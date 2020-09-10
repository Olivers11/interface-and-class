using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro
{


    public interface CirculoBase
    {
        double PI
        {
            get;
            set;
        }

        double CalcularAreaCirculo(double radio);
        double CalcularPerimetroCirculo(double radio);

    }

    public class Circulo : CirculoBase
    {
        public Circulo(double p)
        {
            PI = p;
        }

        public double PI { get; set; }
        public double CalcularAreaCirculo(double radio)
        {
            radio *= radio;
            return PI * radio;
        }

        public double CalcularPerimetroCirculo(double radio)
        {
            return 2 * (PI * radio);
        }

    }

    public class Cilindro:Circulo
    {
        private double altura;
        public Cilindro(double h)
            :base(3.1416)
        {
            this.altura = h;
        }

        public double CalcularAreaCilindro(double radio)
        {
            double resultado = 2*(radio)*this.altura*PI+2*(CalcularAreaCirculo(radio));
            return resultado;
        }

        public double CalcularVolumenCilindro(double radio)
        {
            double resultado = CalcularAreaCirculo(radio) * this.altura;
            return resultado;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro(20);
            Console.WriteLine(cilindro.CalcularAreaCilindro(5));
            Console.WriteLine(cilindro.CalcularPerimetroCirculo(5));


        }
    }
}
