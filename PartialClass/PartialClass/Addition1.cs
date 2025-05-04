using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Addition
    {
        private int a;
        private int b;

        public void SetValue(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
}
