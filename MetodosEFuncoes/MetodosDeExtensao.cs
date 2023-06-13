using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Os métodos de extensão permitem que você "adicione" tipos existentes sem criar um novo tipo derivado,
// recompilar ou, caso contrário, modificar o tipo original. 

namespace CursoCSharp.MetodosEFuncoes {

    public static class ExtensoesInteiros {
        public static int Soma(this int num, int num2) {
            return num + num2;
        }

        public static int Subtracao(this int num, int num2) {
            return num - num2;
        }
    }
    class MetodosDeExtensao {
        public static void Executar() {
            int numero = 5;
            // Fórmula 1
            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Subtracao(10));
            // Fórmula 2
            Console.WriteLine(8.Soma(3));
            Console.WriteLine(2.Subtracao(4));
        }
    }
}
