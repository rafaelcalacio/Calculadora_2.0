using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Calculo c1 = new Calculo();
            c1.IniciarCalculo();
            c1.Calcular();            
        }
    }
}
