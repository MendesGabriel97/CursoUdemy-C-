using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class ParametroPadrao {

        public static int Somar (int a = 1, int b = 1) {
            return a + b;
        }

        public static void Executar() {
            Console.WriteLine(Somar(10, 55));
            Console.WriteLine(Somar(10));
            Console.WriteLine(Somar(b: 15));
            Console.WriteLine(Somar(0, 0));
            Console.Write(Somar());
        }
    }
}
