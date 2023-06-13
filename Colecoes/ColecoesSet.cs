using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto("O segredo", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa",28.7),
                new Produto("8 temporada O segredo", 87.9),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo); // União com
            Console.WriteLine(carrinho.Count);
          //carrinho.RemoveAt(3);

            foreach (var item in carrinho) {
            //  Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            // Console.WriteLine(carrinho.LastIndexOf(livro)); // Ultimo elemento da lista

        }
    }
}
