using System;
using System.IO;


namespace CursoCSharp.Api {
    class LendoArquivo {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preco;Quatidade");
                    sw.WriteLine("Caneta;3.59;89");
                    sw.WriteLine("Borracha;2.89;27");
                }
            }
            try {
                using (StreamReader sr = new StreamReader(path)) {
                    var texto = sr.ReadToEnd(); // Lê todos os caracteres da posição atual até o final do fluxo.
                    Console.WriteLine(texto);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
