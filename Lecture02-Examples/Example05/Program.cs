using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "陳雅姿",
                Birthday = "1009",
                Email = "abc@email.com",
                Orientation = 0.0,
                Pos = new Position()
                {
                    X = 10,
                    Y = 20
                }
            };

            person.ShowPosition();
            person.MoveForward(100);
            person.ShowPosition();
            person.TurnRight(90);
            person.ShowPosition();
        }
    }
}