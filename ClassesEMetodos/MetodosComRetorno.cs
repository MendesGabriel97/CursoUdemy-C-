using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraComum {
        //Publico | Tipo de retorno | Nome do Método | Tipos de Parâmetro 
        public int Somar(int a, int b) {
            return a + b; // Return para cumprir o combinado *existem váriações
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public int Dividir(int a, int b) {
            return a / b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Subtrair(int a) {
            memoria -= a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Dividir(int a) {
            memoria /= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {  // Sequência se encerra, pois não tem o this.
            return memoria;

        }

    }
    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(10, 10));
            Console.WriteLine(calculadoraComum.Multiplicar(10, 10));
            Console.WriteLine(calculadoraComum.Dividir(10, 2));

            var calculadoraCadeia = new CalculadoraCadeia();

            calculadoraCadeia.Somar(80).Dividir(4).Multiplicar(5).Imprimir();

        }
    }
}
