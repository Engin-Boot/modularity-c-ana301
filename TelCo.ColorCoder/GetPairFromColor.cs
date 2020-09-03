using System;
using System.Diagnostics;
using System.Drawing;
 
namespace TelCo.ColorCoder 
{
    class GetPairFromColor
    {       
        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <returns></returns>
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = GetIndex(ColorDataMember.colorMapMajor, pair.majorColor);
            int minorIndex = GetIndex(ColorDataMember.colorMapMinor, pair.minorColor);
            // Find the minor color in the array and get the index
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            // Compute pair number and Return  
            // (Note: +1 in compute is because pair number is 1 based, not zero)
            return (majorIndex * ColorDataMember.colorMapMinor.Length) + (minorIndex + 1);
        }
        private static int GetIndex(Color[] array,Color pairColor){
            int index = -1;
            for (int i = 0; i < array[i].Length; i++)
            {
                if (array[i] == pairColor)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
