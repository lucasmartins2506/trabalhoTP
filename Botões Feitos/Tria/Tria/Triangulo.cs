using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tria
{
    class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        public double LadoA { get => ladoA; set => ladoA = value; }
        public double LadoB { get => ladoB; set => ladoB = value; }
        public double LadoC { get => ladoC; set => ladoC = value; }

        public double CalculaArea()
        {
            return(0);    
        }

        public double CalculaPerimetro()
        {
            double perimetro = this.ladoA + this.ladoB + this.ladoC;
            return (perimetro);
        }

    }
}
