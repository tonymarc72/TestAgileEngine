using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAgile.Model
{
    public class PictureList
    {
        List<PictureModel> pictures;

        public List<PictureModel> Pictures { get => pictures; set => pictures = value; }
    }
}
