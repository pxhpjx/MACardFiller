using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MACardFiller
{
    public static class ImageTools
    {
        public static bool InitFontPic(string Path)
        {
            try
            {
                List<ImageWithName> listNormal = new List<ImageWithName>();
                List<ImageWithName> listLv = new List<ImageWithName>();
                for (int i = 0; i < 10; i++)
                {
                    Image normal = Image.FromFile(string.Format("{0}\\FontPic\\Normal\\{1}.png", Path, i.ToString()));
                    Image lv = Image.FromFile(string.Format("{0}\\FontPic\\Lv\\{1}.png", Path, i.ToString()));
                    if (normal == null || lv == null)
                        return false;
                    ImageWithName n = new ImageWithName(i.ToString(), normal);
                    ImageWithName l = new ImageWithName(i.ToString(), lv);
                    listNormal.Add(n);
                    listLv.Add(l);
                }
                if (listNormal.Count != 10 || listLv.Count != 10)
                    return false;
                Cache.SetAbsolute("ListNormal", listNormal, 99999);
                Cache.SetAbsolute("ListLv", listLv, 99999);
                return true;
            }
            catch { }
            return false;
        }


        public static Image GetFullView(Image img)
        {
            return img.GetThumbnailImage(img.Width, img.Height, null, System.IntPtr.Zero);
        }

        public static Image GetHalfView(Image img)
        {
            return img.GetThumbnailImage(img.Width / 2, img.Height / 2, null, System.IntPtr.Zero);
        }

        public static Image GetHalfView(Bitmap img)
        {
            return img.GetThumbnailImage(img.Width / 2, img.Height / 2, null, System.IntPtr.Zero);
        }

        public static List<LoactedPic> GetFontPicList(string value, FontType fontType)
        {
            List<LoactedPic> result = null;
            List<ImageWithName> source = null;

            if (fontType == FontType.Lv)
                source = Cache.Get("ListLv") as List<ImageWithName>;
            if (fontType == FontType.HP || fontType == FontType.ATK)
                source = Cache.Get("ListNormal") as List<ImageWithName>;
            if (source == null)
                return result;

            result = new List<LoactedPic>();
            foreach (char c in value)
            {
                Image word = source.Find(item => item.Name == c.ToString()).Img;
                LoactedPic lp = new LoactedPic(word);
                result.Add(lp);
            }

            int firstX = 0, topY = 0;
            switch (fontType)
            {
                case FontType.Lv:
                    firstX = 72 - result.Sum(item => item.Img.Width) / 2;
                    topY = 825;
                    break;
                case FontType.HP:
                    firstX = 610 - result.Sum(item => item.Img.Width);
                    topY = 781;
                    break;
                case FontType.ATK:
                    firstX = 390 - result.Sum(item => item.Img.Width);
                    topY = 838;
                    break;
            }

            int startX;
            for (int i = 0; i < result.Count; i++)
            {
                if (i > 0)
                    startX = result[i - 1].EndX + 1;
                else
                    startX = firstX;
                result[i].StartX = startX;
                result[i].StartY = topY;
            }

            return result;
        }

        public static Image OverlayWords(Image sourceImage, string value, FontType fontType)
        {
            Image result = GetFullView(sourceImage);

            int chk = FormatTools.ParseInt(value);
            if (chk <= 0)
                return result;

            List<LoactedPic> words = GetFontPicList(value, fontType);
            if (words == null)
                return result;

            Graphics g = Graphics.FromImage(result);
            foreach (LoactedPic lp in words)
            {
                g.DrawImage(lp.Img, lp.StartX, lp.StartY, lp.Img.Width, lp.Img.Height);
            }
            return result;
        }

        public static Image OverlayAll(Image sourceImage, string Lv, string HP, string ATK)
        {
            Image result = OverlayWords(sourceImage, Lv, FontType.Lv);
            result = OverlayWords(result, HP, FontType.HP);
            result = OverlayWords(result, ATK, FontType.ATK);
            return result;
        }
    }
}
