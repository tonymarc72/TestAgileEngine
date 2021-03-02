using TestAgile.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAgile.Model;


namespace TestAgile.Handlers
{
    public class ImagesHandler
    {
        internal List<PictureModel> GetImages()
        {
            List<PictureModel> imgList = null;

            try
            {
                CacheManager cache = new CacheManager();
                PictureList pictures = cache.GetCache();

                imgList = pictures.Pictures;
            }
            catch (Exception)
            {
                
            }

            return imgList;
        }
       
        internal List<PictureModel> Search(string search)
        {
            List<PictureModel> imgList = null;

            try
            {
                CacheManager cache = new CacheManager();
                PictureList pictures = cache.GetCache();

                imgList = new List<PictureModel>();

                foreach (var item in pictures.Pictures)
                {
                    if (!string.IsNullOrEmpty(item.Author))
                    {
                        if (item.Author.ToLower() == search.ToLower())
                        {
                            imgList.Add(item);
                        }
                    }

                    if (!string.IsNullOrEmpty(item.Camera))
                    {
                        if (item.Camera.ToLower() == search.ToLower())
                        {
                            imgList.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return imgList;
        }

        internal async Task GetCache()
        {
            try
            {
                await Task.Run(() =>
                {
                    HttpHandler http = new HttpHandler();
                    var postData = "{\"apiKey\":\"23567b218376f79d9415\"}";

                    dynamic resp = http.Post(Config.Url + "/auth", postData);

                    if (resp == null || resp.token == null)
                    {
                        throw new Exception("Error getting token data");
                    }

                    string token = Convert.ToString(resp.token);
                    int page = 1;
                    int imagesByPage = 10;
                    int maxIteration = 100;

                    List<PictureModel> imgList = new List<PictureModel>();

                    while (page < maxIteration)
                    {
                        dynamic respImages = http.Get(Config.Url + "/images?page=" + page, AuthorizationType.Bearer, token, ResultType.JsonObj);

                        if (respImages == null || respImages.pictures == null)
                        {
                            throw new Exception("Error getting image data");
                        }

                        if (respImages.pictures.Count < imagesByPage)
                        {
                            break;
                        }

                        page++;

                        foreach (var item in respImages.pictures)
                        {
                            if (item.id != null && item.cropped_picture != null)
                            {
                                PictureModel img = new PictureModel();
                                img.Id = Convert.ToString(item.id);
                                img.Cropped_picture = Convert.ToString(item.cropped_picture);

                                PictureModel m = this.GetImageDetail(token, img);

                                imgList.Add(m);
                            }
                        }
                    }

                    CacheManager cache = new CacheManager();
                    PictureList pictures = new PictureList();
                    pictures.Pictures = imgList;

                    cache.SetCache(pictures);
                });
            }
            catch (Exception)
            {
            }
        }


        internal PictureModel GetImageDetail(string token, PictureModel input)
        {
            PictureModel output = null;

            try
            {
                HttpHandler http = new HttpHandler();
                output = new PictureModel();
                output.Id = input.Id;
                output.Cropped_picture = input.Cropped_picture;

                dynamic respImage = http.Get(Config.Url + "/images/" + input.Id, AuthorizationType.Bearer, token, ResultType.JsonObj);

                if (respImage == null || respImage.id == null)
                {
                    throw new Exception("Error getting image data");
                }

                if (respImage.author != null) output.Author = Convert.ToString(respImage.author);
                if (respImage.camera != null) output.Camera = Convert.ToString(respImage.camera);
                if (respImage.tags != null) output.Tags = Convert.ToString(respImage.tags);
            }
            catch (Exception)
            {
            }

            return output;
        }
    }
}
