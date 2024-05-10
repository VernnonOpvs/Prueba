using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indicedemasacorporal
{
    internal class CalculoPeso
    {
        public double pesoLbs, pesoKg, altura, indiceMasa;
        public double IMC() 
        {
            pesoKg = pesoLbs * 0.453592;

            indiceMasa = pesoKg / (Math.Pow(altura,2));

            return indiceMasa;
        }
    }
}
