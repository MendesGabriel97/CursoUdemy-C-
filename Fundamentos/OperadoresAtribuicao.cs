using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1; Incremento
            b--; // b = b - 1; Descremento
            
            Console.WriteLine($"{a} {b}");

            // Não se preocupe com o código
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Gabriel";

            dynamic d = c;
            d.nome = "Mendes";

            Console.WriteLine(c.nome);
        }
    }
}
