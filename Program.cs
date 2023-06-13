using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OrientacaoAObjetos;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;



namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Váriaveis E Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumeros.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores De Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                // Estruturas De Controle
                {"Estrutura If - Estrutura De Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estrutura De Controle", EstruturaIfElse.Executar},
                {"Estrutura If/ElseIF - Estrutura De Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutura De Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estrutura De Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estrutura De Controle", EstruturaDoWhile.Executar},  
                {"Estrutura For - Estrutura De Controle", EstruturaFor.Executar},  
                {"Estrutura FOREACH - Estrutura De Controle", EstruturaForEach.Executar},  
                {"Usando Break - Estrutura De Controle", UsandoBreak.Executar},  
                {"Usando Continue - Estrutura De Controle", UsandoContinue.Executar},  

                // Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},  
                {"Construtores - Classes e Métodos", Construtores.Executar},  
                {"Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar},  
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar},  
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar},  
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},  
                {"Params - Classes e Métodos", Params.Executar},  
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar},  
                {"Getters & Setters - Classes e Métodos", GetSet.Executar},  
                {"Props / Propriedades - Classes e Métodos", Props.Executar},  
                {"Atributos Readonly - Classes e Métodos", Readonly.Executar}, 
                {"Exemplo Enum - Classes e Métodos", ExemploEnum.Executar}, 
                {"Struct - Classes e Métodos", Struct.Executar}, 
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar}, 
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar}, 
                {"Parâmetro Por Referência - Classes e Métodos", ParametroPorReferencia.Executar}, 
                {"Parâmetro Por Padrão - Classes e Métodos", ParametroPadrao.Executar}, 

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"Array List - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dictionary - Coleções", ColecoesDictionary.Executar},

                // Orientação A Objetos
                {"Heranca - OrientacaoAObjetos", Heranca.Executar},
                {"Construtor This - OrientacaoAObjetos", ConstrutorThis.Executar},
                {"Encapsulamento - OrientacaoAObjetos", OrientacaoAObjetos.Encapsulamento.Executar},
                {"Polimorfismo - OrientacaoAObjetos", Polimorfismo.Executar},
                {"Abstract - OrientacaoAObjetos", Abstract.Executar},
                {"Interface - OrientacaoAObjetos", Interface.Executar},
                {"Sealed - OrientacaoAObjetos", Sealed.Executar},

                // Métodos E Funções
                {"Exemplo Lambda - Métodos e Funções", ExemploLambda.Executar},
                {"Lambda Como Delegates - Métodos e Funções", LambdaDelegate.Executar},
                {"Usando Delegates - Métodos e Funções", UsandoDelegates.Executar},
                {"Delegates Como Função Anonima - Métodos e Funções", DelegateFunAnonima.Executar},
                {"Delegates Como Parâmetros - Métodos e Funções", DelegatesComoParametros.Executar},
                {"Métodos de Extensão - Métodos e Funções", MetodosDeExtensao.Executar},
                
                // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                // Api
                {"Primeiro Arquivo - Api", PrimeiroArquivo.Executar},
                {"Lendo Arquivo - Api", LendoArquivo.Executar},
                {"Exemplo FileInfo - Api", ExemploFileInfo.Executar},
                {"Diretorios - Api", Diretorios.Executar},
                {"Exemplo DirectoryInfo - Api", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Api", ExemploPath.Executar},
                {"Exemplo DateTime - Api", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Api", ExemploTimeSpan.Executar},

                // Tópicos Avançados
                {"LINQ1 - Tópicos Avançados", LINQ1.Executar},
                {"LINQ2 - Tópicos Avançados", LINQ2.Executar},
                {"Nullables - Tópicos Avançados", Nullables.Executar},
                {"Dynamics - Tópicos Avançados", Dynamics.Executar},
                {"Generics - Tópicos Avançados", Genericos.Executar},

            }) ;

            central.SelecionarEExecutar();
        }
    }
}