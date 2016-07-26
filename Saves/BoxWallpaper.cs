﻿using System.Drawing;

namespace PKHeX
{
    public static class BoxWallpaper
    {
        public static Bitmap getWallpaper(SaveFile SAV, int index)
        {
            index++;
            string s = "box_wp" + index.ToString("00");
            switch (SAV.Generation)
            {
                case 6: s += SAV.ORAS && index > 16 ? "ao" : "xy";
                    break;
                case 5: s += SAV.Version == GameVersion.B2W2 && index > 16 ? "b2w2" : "bw";
                    break;
                case 4:
                    if (SAV.Version == GameVersion.Pt && index > 16)
                        s += "pt";
                    else if (SAV.Version == GameVersion.HGSS && index > 16)
                        s += "hgss";
                    else
                        s += "dp";
                    break;
                case 3:
                    if (SAV.Version == GameVersion.E)
                        s += "e";
                    else if (SAV.Version == GameVersion.FRLG && index > 12)
                        s += "frlg";
                    else
                        s += "rs";
                    break;
            }
            return (Bitmap)(Properties.Resources.ResourceManager.GetObject(s) ?? Properties.Resources.box_wp16xy);
        }
    }
}