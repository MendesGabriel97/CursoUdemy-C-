using System;
using System.IO;

namespace CursoCSharp.Api {
    class ExemploFileInfo {

        public static void ExcluirSeExistir(params string[] caminhos) { // Params, lista separada por vírgulas de argumentos do tipo dos elementos da matriz.
            foreach (var caminho in caminhos) {
                FileInfo arquivo = new FileInfo(caminho);  

                if (arquivo.Exists) {
                    arquivo.Delete(); // Se o arquivo existir, o mesmo será deletado.
                }
            }
        }

        public static void Executar() {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia); 

            using(StreamWriter sw = File.CreateText(caminhoOrigem)) {
                sw.WriteLine("Arqivo original!!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
