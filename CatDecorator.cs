using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    public class CatDecorator : IMeow
    {
        private IMeow meow_object;
        private int meow_count;

        public int MeowCount
        {
            get { return meow_count; }
        }
        public CatDecorator(IMeow meow_object)
        {
            this.meow_object = meow_object;
            meow_count = 0;
        }
        public void Meow(int n = 1)
        {
            meow_object.Meow(n);
            meow_count += n;
        }
    }
}
