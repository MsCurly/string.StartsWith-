using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string.StartsWith__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Z ketegorisnde arama yapmaktasınız. \n Lütfen aramak istediğiniz kelimeyi giriniz:");
            string kelime = Console.ReadLine();
            bool kelimetarstWithZ = kelime.StartsWith("Z");
            bool kelimetarstWithz = kelime.StartsWith("z");

            if (kelimetarstWithZ == true  || kelimetarstWithz == true)

                Console.WriteLine("Arama birazdan sonuçlanır, lütfen bekleyiniz."); // herhangi bi sözlükten arama yapmak için kullanılabilir
            else
                Console.WriteLine("Girdiğiniz kelime 'Z' harfi ile başlamamktadır! \nLütfen 'Z' harfi ile başlayan bir kelime giriniz!");

            Console.ReadLine();
        }
    }
    
}
