using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {
    class Params {

        public static void Recepcionar(params string[] pessoas) { //[ ] Array
            foreach (var pessoa in pessoas) { // Foreach = Percorrer por todas as casas
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar() {
            Recepcionar("Gabriel", "Mendes", "Arlete", "José");

        }
    }
}
 