using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestAgile.Handlers;
using TestAgile.Model;

namespace TestAgile.Pages
{
    public class ImagesModel : PageModel
    {
        List<PictureModel> imgList;
        ImagesHandler ImgHandler;

        public List<PictureModel> ImgList { get => imgList; set => imgList = value; }


        public ImagesModel()
        {
            this.ImgList = new List<PictureModel>();
            this.ImgHandler = new ImagesHandler();
        }

        public void OnGet()
        {
            this.ImgList = this.ImgHandler.GetImages();

            Task.Run(() => this.ImgHandler.GetCache());
        }


        public void OnPostSearch(string searchtext)
        {
            if (!string.IsNullOrEmpty(searchtext))
            {
                this.ImgList = this.ImgHandler.Search(searchtext);
            }
            else
            {
                this.ImgList = this.ImgHandler.GetImages();
            }
        }
    }
}