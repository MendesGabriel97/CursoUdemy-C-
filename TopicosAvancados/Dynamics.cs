using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados {
    class Dynamics {
        public static void Executar() {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Gabriel Mendes";
            aluno.nota = 8.9;
            aluno.idade = 26;

            Console.WriteLine($"{aluno.nome} , {aluno.nota} , {aluno.idade}");
        }
    }
}
