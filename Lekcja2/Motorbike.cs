using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademia
{
    public class Motorbike : IEnginable, IJednoslad
    {
        public void JazdaMaJednymKole()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            Console.WriteLine("MOTOR ENGINE STARTS");
        }
    }
}
