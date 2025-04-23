using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
  sealed class MyClass
    {
        private static MyClass instance;
        private static object instanceLock = new object();
        private MyClass() { }

        public static MyClass GetInstance()
        {
            if(instance == null)
            {
                lock(instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new MyClass();
                    }
                } 
            }
            return instance;

        }
    }

}
