using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
  class ColorPair
        {
            Color majorColor;
            Color minorColor;
           
            public override string ToString()
            {
                return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
            }
        }
}
