using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {
            // double nota = 6.0;
            Console.Write("Digite a nota: "); // Mesma linha
            double.TryParse(Console.ReadLine(), out double nota); // tenta fazer, se não vai o valor padrão {0}
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota inválida? {0}", nota > 10.0); // Maior
            Console.WriteLine("Nota inválida? {0}", nota < 0.0); // Menor
            Console.WriteLine("Perfeito? {0}", nota == 10.0); // Igualdade
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0); // Diferente
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte); // Maior Igual
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte); // Menor
            Console.WriteLine("Reprovado? {0}", nota <= 3.0); // Menor Igual
        }
    }
}
