using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //LinQ查詢
            //var query = from num in numbers
            //            select num + 1;
            var query = numbers.Select(num => num + 1);         // Linq to Lambda

            foreach (int num in query)
            {
                Console.WriteLine(num);
            }

            List<string> country = new List<string>() { "Taiwan", "Japan", "China" };

            //LinQ查詢
            //var CountryQuery = from coun in country
            //                   select new { Upper = coun.ToUpper() };
            var CountryQuery = country.Select(coun => new { Upper = coun.ToUpper() });          // Linq to Lambda

            foreach (var coun in CountryQuery)
            {
                Console.WriteLine(coun.Upper);
            }

            List<int> indexs = new List<int>() { 0, 1, 2, 3, 4 };
            List<string> digits = new List<string>() { "One", "Two", "Three", "Four", "Five" };

            //LinQ查詢
            //var IndexQuery = from index in indexs
            //                 select digits[index];
            var IndexQuery = indexs.Select(index => digits[index]);         // Linq to Lambda

            foreach (var index in IndexQuery)
            {
                Console.WriteLine("Number=" + index);
            }

            List<int> scores = new List<int>() { 67, 75, 85, 90, 70, 56 };

            //LinQ查詢
            //var ScoreQuery = from score in scores
            //                 where score > 70
            //                 select score;
            var ScoreQuery = scores.Where(score => score > 70);         // Linq to Lambda

            foreach (var score in ScoreQuery)
            {
                Console.WriteLine("分數：" + score);
            }

            List<int> MathScore = new List<int>() { 54, 60, 75, 94, 45, 68, 82 };

            //LinQ查詢
            //var MathQuery = from mathscore in MathScore
            //                where mathscore >= 60 && mathscore <= 90
            //                select mathscore;
            //var MathQuery = from mathscore in MathScore
            //                where mathscore >= 60
            //                where mathscore <= 90
            //                select mathscore;
            var MathQuery = MathScore.Where(mathscore => mathscore >= 60 && mathscore <= 90);           // Linq to Lambda

            foreach (var mathscore in MathQuery)
            {
                Console.WriteLine("分數：" + mathscore);
            }

            List<int> EnglishScore = new List<int>() { 82, 89, 75, 67, 95, 84, 99 };

            //LinQ查詢
            //var EnglishQuery = from englishscore in EnglishScore
            //                   where englishscore > 70
            //                   orderby englishscore ascending
            //                   select englishscore;
            var EnglishQuery = EnglishScore.OrderBy(englishscore =>  englishscore)           // Linq to Lambda
                               .Where(englishscore => englishscore > 70);

            Console.WriteLine("從小到大：");
            foreach (var englishscore in EnglishQuery)
            {
                Console.Write(englishscore + " ");
            }

            List<int> ChineseScore = new List<int>() { 82, 89, 75, 67, 95, 84, 99 };

            //LinQ查詢
            //var ChineseQuery = from chinesescore in ChineseScore
            //                   where chinesescore > 70
            //                   orderby chinesescore descending
            //                   select chinesescore;


            var ChineseQuery = ChineseScore.OrderByDescending(chinesescore => chinesescore)         // Linq to Lambda
                               .Where(chinesescore => chinesescore > 70);

            Console.WriteLine("從大到小：");
            foreach (var chinesescore in ChineseQuery)
            {
                Console.Write(chinesescore + " ");
            }

            List<string> Names = new List<string>() { "Jack", "Merry", "Allen", "Jason", "Alice" };

            //LinQ查詢
            //var NameQuery = from name in Names
            //                group name by name.Substring(0, 1);

            var NameQuery = Names.GroupBy(name => name.Substring(0, 1));            // Linq to Lambda

            foreach (var namegroup in NameQuery)
            {
                Console.WriteLine(namegroup.Key);
                foreach (var name in namegroup)
                {
                    Console.WriteLine("名字：" + name);
                }
            }

            Console.ReadLine();
        }
    }
}
