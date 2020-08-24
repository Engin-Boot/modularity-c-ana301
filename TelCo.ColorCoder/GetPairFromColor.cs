﻿using System;
using System.Diagnostics;
using System.Drawing;
using TelCo.ColorCoder.ColorDataMember;
using TelCo.ColorCoder.ColorPair;

namespace TelCo.ColorCoder
{
    class GetPairFromColor
    {       
       private static ColorDataMember  colorDataMembers;

       static GetColorFromPair(){
           ColorDataMember();
       }
       
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < colorDataMembers.colorMapMajor.Length; i++)
            {
                if (colorDataMembers.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < colorDataMembers.colorMapMinor.Length; i++)
            {
                if (colorDataMembers.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * colorDataMembers.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}