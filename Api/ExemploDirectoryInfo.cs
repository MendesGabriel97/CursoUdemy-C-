using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Api {
    class ExemploDirectoryInfo {
        public static void Executar() {
            var dirProjeto = @"~/source/repos/ProjetoCursoUdemy".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivos =========");
            var arquivos = dirInfo.GetFiles();
            foreach (var aquivos in arquivos) {
                Console.WriteLine(arquivos);
            }

            Console.WriteLine("\n== Diretórios ==========");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}
