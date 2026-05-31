using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace URLtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string url = "https://i.imgur.com/MU9BfK1.jpeg  Mlem!"; // 0~71

            string pattern = @"(https?://\S+\.(jpg|png|gif|jpeg))";
            Regex regex = new Regex(pattern);

            
            List<TextURL> URLdata = new List<TextURL>();
            

            int lastEnd = 0;
            foreach (Match match in regex.Matches(url))
            {
                
                int start = match.Index;
                int end = start + match.Length;

                // 取得動態文字部分
                string dynamicText = url.Substring(lastEnd, start - lastEnd).Trim();
                TextURL textURL = new TextURL(dynamicText, match.Value);               
                URLdata.Add(textURL);
                
                lastEnd = end;
            }

            // 檢查是否還有剩餘的動態文字部分
            string remainingText = url.Substring(lastEnd).Trim();
            TextURL textURL1 = new TextURL(remainingText, "");
            if (!string.IsNullOrEmpty(remainingText))
            {
                URLdata.Add(textURL1);
            }

            // 輸出結果
            
            foreach (TextURL data in URLdata)
            {
                if(!string.IsNullOrEmpty(data.text))
                    Console.WriteLine(data.text);
                if (!string.IsNullOrEmpty(data.url))
                    Console.WriteLine(data.url);
            }
            Console.ReadKey();             
        }
    }
}
