using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_InterfaceAbstraction.GeometricShapes
{

  
    internal class Square : Figure
    {
       
        private double side;

        public double _side{


            get { return side; }
            set
            {
                if (value>=0)
                    side = value;
                else
                    Console.WriteLine("Yan uzunlug menfi ola bilmez zehmet olmasa menfi olman deyer daxil edin");
            }
        }

        public Square(double side)
        {
            side = _side;
        }


        public override double Ca()
        {
            return side * side;
        }

    }

   

  
}
