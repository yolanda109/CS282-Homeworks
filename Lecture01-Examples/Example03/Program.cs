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
            Student someone = new Student();
            someone.name = "陳雅姿";
            Console.WriteLine("學生的名字:{0}", someone.name);

            someone.birthday = "1009";
            Console.WriteLine("學生的生日:{0}", someone.birthday);

            someone.email = "abc@email.com";
            Console.WriteLine("學生的信箱:{0}", someone.email);

            someone.phone = "0123456789";
            Console.WriteLine("學生的電話:{0}", someone.phone);

            someone.age = 5;
            Console.WriteLine("學生的年齡:{0}", someone.age);
        }
    }
}