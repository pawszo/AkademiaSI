using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class MyClass
    {
        private MyClass2 _internalObject;

        public MyClass(MyClass2 internalObject)
        {
            _internalObject = internalObject;
        }

        void DOSmeth()
        {

        }
    }
}
