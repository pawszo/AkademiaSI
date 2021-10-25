using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akademia
{
    class Car : IEnginable
    {
        public string Make { get; set; }
        public decimal Price;
        private Color _color;

        public Car(string make)
        {
            Make = make;
            _color = Color.Black;
        }

        public void SetColor(Color color)
        {
            
        }

        public Color GetColor()
        {
            return _color;
        }

        

        public static void DoSomething()
        {

        }

        private void Ignition()
        {
            Console.WriteLine("IGNITION");
        }

        public void StartEngine()
        {
            Ignition();

            Console.WriteLine($"{Make}: Engine starts");
        }
    }
}
