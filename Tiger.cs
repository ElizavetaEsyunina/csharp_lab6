using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    public class Tiger : IMeow
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Tiger(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"собака: {name}";
        }
        public void Meow(int n = 1)
        {
            Console.Write($"{name}: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("rrrr");
                if (i < n - 1)
                    Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
