using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba_6
{
    public class Cat : IMeow
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Cat(string name) 
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"кот: {name}";
        }
        public void Meow(int n = 1)
        {
            Console.Write($"{name}: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("meow");
                if (i < n - 1)
                    Console.Write("-");
            }
            Console.WriteLine();
        }
    }    
}
