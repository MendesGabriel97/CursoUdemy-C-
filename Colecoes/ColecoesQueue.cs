using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {

    class ColecoesQueue {
        public static void Executar() {
            var fila = new Queue<string>();

            fila.Enqueue("Gabriel"); // Enfileirar.
            fila.Enqueue("Mendes");
            fila.Enqueue("Arlete");

            Console.WriteLine(fila.Peek()); // Retorna o objeto ao início da Queue sem removê-lo.
            Console.WriteLine(fila.Count); // Retorna o número de elementos em uma sequência.

            Console.WriteLine(fila.Dequeue()); // Remove e retorna o objeto no início do Queue.
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila) { // Mostrar o que restou da fila.
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(5);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("item"));
            Console.WriteLine(salada.Contains("Item"));
            // Retorna um valor que indica se um caractere especificado ocorre nessa cadeia de caracteres.
        }
    }
}
