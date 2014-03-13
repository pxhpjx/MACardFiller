using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MACardFiller
{
    public class LoactedPic
    {
        public LoactedPic(Image img)
        {
            Img = img;
        }

        public LoactedPic(Image img,int startX,int startY)
        {
            Img = img;
            StartX = startX;
            StartY = startY;
        }

        public int StartX { get; set; }

        public int StartY { get; set; }

        public Image Img { get; set; }

        public int EndX
        {
            get { return StartX + (Img == null ? 0 : Img.Width - 1); }
        }

        public int EndY
        {
            get { return StartY + (Img == null ? 0 : Img.Height - 1); }
        }
    }

    public class ImageWithName
    {
        public ImageWithName(string name, Image img)
        {
            Name = name;
            Img = img;
        }

        public string Name { get; set; }
        public Image Img { get; set; }
    }

    public enum FontType
    {
        Lv = 0,
        HP = 1,
        ATK = 2
    }
}
