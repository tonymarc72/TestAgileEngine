using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAgile.Model
{
    public class PictureModel
    {
        string id;
        string author;
        string cropped_picture;
        string full_picture;
        string camera;
        string tags;

        public string Author { get => author; set => author = value; }
        public string Cropped_picture { get => cropped_picture; set => cropped_picture = value; }
        public string Id { get => id; set => id = value; }
        public string Camera { get => camera; set => camera = value; }
        public string Full_picture { get => full_picture; set => full_picture = value; }
        public string Tags { get => tags; set => tags = value; }
    }
}
