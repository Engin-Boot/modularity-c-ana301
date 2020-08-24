using System;
using System.Diagnostics;
using System.Drawing;
using TelCo.ColorCoder.ColorPair;

namespace TelCo.ColorCoder
{

   class ColorDataMember
   {
        /// <summary>
        /// Array of Major colors
        /// </summary>
        private static Color[] colorMapMajor;
        /// <summary>
        /// Array of minor colors
        /// </summary>
        private static Color[] colorMapMinor;
        /// <summary>
        /// Static constructor required to initialize static variable
        /// </summary>
        static ColorDataMember()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
   }
 }
