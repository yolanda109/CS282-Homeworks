using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string sql =
                @"select * fron Table
                    where id > 10
                ";
            Console.WriteLine(sql);

            string path =
                @"D:\\CS282-Homeworks";
            Console.WriteLine(path);
        }
    }
}