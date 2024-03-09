using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_InterfaceAbstraction.GeometricShapes
{
    internal class Rectangular : Figure
    {

        private double width;
        private double length;

        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                    width = value;
                else
                    Console.WriteLine("Genslik Menfi ola bilmez xais olunur duzgun deyer (Reqem) daxil edin");
            }

        }



        public double Length
        {
            get { return length; }
            set
            {
                if (value >= 0)
                    length = value;
                else Console.WriteLine("Uzunlugu menfi ola bilmez xais olunur duzgun  deyer (Reqem) daxil edin");
            }

        }

        public Rectangular(double width, double length)
        {

            Width = width;
            Length = length;
        }

        public override double Ca()
        {
            return width * length;
        }

    }
}
