using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaForEach {
        public static void Executar() {
            var palavra = "Gato!";

            foreach (var letra in palavra) {
                Console.WriteLine(letra);

            }

            var alunos = new string[] { "Gabriel", "Arlete", "José" };

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
