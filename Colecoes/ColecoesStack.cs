using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3); // Insere um objeto na parte superior do Stack.
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.Write($"{item}");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}"); // Remove e retorna o objeto na parte superior do Stack.

            foreach (var item in pilha) {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}"); // Retorna o objeto na parte superior do Stack sem removê-lo.
            Console.WriteLine(pilha.Count); // Contagem de linhas.
        }
    }
}
