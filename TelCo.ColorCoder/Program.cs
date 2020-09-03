using System;
using System.Diagnostics;
using System.Drawing;
namespace TelCo.ColorCoder
{
    class Program
    {   private static String ConvertToString(Color[] mapMajor,Color[] mapMinor){
        String ans="";
        for(int i=0;i<mapMajor.Length;i++){
            for(int j=0;j<mapMinor.Length;j++){
                int code=(i+1)*(j+1);
                ans+="The color pair"+Convert.ToString(mapMajor[i])+Convert.ToString(mapMinor[j])+"has the code: "+Convert.ToString(code)+"@";}}
        return ans;}
        private static void Main(string[] args)
        {   
           
            String text=ConvertToString(ColorDataMember.colorMapMajor,ColorDataMember.colorMapMinor);
            text = text.Replace("@", System.Environment.NewLine);
            Console.WriteLine("The color-code manual is as follows:\n{0}",text);
            
            int pairNumber = 4;
            ColorPair testPair1 = GetColorFromPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.Brown);

            pairNumber = 5;
            testPair1 =GetColorFromPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.White);
            Debug.Assert(testPair1.minorColor == Color.SlateGray);

            pairNumber = 23;
            testPair1 = GetColorFromPair.GetColorFromPairNumber(pairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            Debug.Assert(testPair1.majorColor == Color.Violet);
            Debug.Assert(testPair1.minorColor == Color.Green);

            ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            pairNumber = GetPairFromColor.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            Debug.Assert(pairNumber == 18);

            testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            pairNumber = GetPairFromColor.GetPairNumberFromColor(testPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            Debug.Assert(pairNumber == 6);
        }
    }
}
