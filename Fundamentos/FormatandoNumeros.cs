using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // 1 casa decimal
            Console.WriteLine(valor.ToString("C")); // Moeda do Sistema
            Console.WriteLine(valor.ToString("P")); // Percentual
            Console.WriteLine(valor.ToString("#.##")); // = F2

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10")); // Até o número ficar com 10 digitos

        }
    }
}
