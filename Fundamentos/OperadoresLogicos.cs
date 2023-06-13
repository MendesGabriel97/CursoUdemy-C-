using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true; // Verdadeiro
            var executouTrabalho2 = false; // Falso

            bool comprouTv50 = executouTrabalho1 && executouTrabalho2; // Ambos verdadeiro (&&)
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // Um ou ambos verdadeiro (||)
            Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // Exclusivamente um verdadeiro (^)
            Console.WriteLine("Comprou a Tv 32? {0}", comprouTv32);

            Console.WriteLine("Mais Saudável? {0}", !comprouSorvete); // Negação (!)
        }
    }
}
