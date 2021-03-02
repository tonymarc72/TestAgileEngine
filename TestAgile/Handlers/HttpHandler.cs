using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;


namespace TestAgile.Utils
{
    public enum AuthorizationType
    {
        Basic,
        Bearer,
        None
    }

    public enum ResultType
    {
        JsonObj,
        JsonArray
    }

    public class HttpHandler
    {
        public dynamic Get(string url, AuthorizationType auth, String authInfo, ResultType resultType)
        {
            dynamic output = null;

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.PreAuthenticate = true;
                request.Accept = "*/*";
                request.KeepAlive = true;

                if (auth == AuthorizationType.Basic)
                    request.Headers["Authorization"] = "Basic " + authInfo;
                else if (auth == AuthorizationType.Bearer)
                    request.Headers["Authorization"] = "Bearer " + authInfo;

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) throw new Exception("Error getting data from url");

                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string jsonString = objReader.ReadToEnd();

                            if(resultType == ResultType.JsonObj)
                            {
                                JObject jsonObject = JObject.Parse(jsonString);
                                output = jsonObject;
                            }
                            else if (resultType == ResultType.JsonArray)
                            {
                                JArray jsonObject = JArray.Parse(jsonString);
                                output = jsonObject;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return output;
        }

        public dynamic Post(string url, string postData)
        {
            dynamic output = null;

            try
            {
                var data = Encoding.ASCII.GetBytes(postData);

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json; charset=utf-8";
                request.Accept = "application/json; charset=utf-8";
                request.ContentLength = data.Length;

               
                using (Stream streamWriter = request.GetRequestStream())
                {
                    streamWriter.Write(data, 0, data.Length);
                    streamWriter.Close();
                }

                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) throw new Exception("Error getting data from url");
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string jsonString = objReader.ReadToEnd();

                            JObject jsonObject = JObject.Parse(jsonString);
                            output = jsonObject;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return output;
        }
    }
}