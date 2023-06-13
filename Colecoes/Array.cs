using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Gabriel";
            alunos[1] = "Arlete";
            alunos[2] = "Mendes";
            alunos[3] = "Jose";
            alunos[4] = "Quadra";

            foreach (var aluno in alunos) { 
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach (var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length; // Length = Tamanho do Array.
            Console.WriteLine(media);

            char[] letras = { 'A', 'g', 'b', 'u', 'o' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
// Homogênia e estatica.