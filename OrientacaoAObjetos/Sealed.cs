using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OrientacaoAObjetos {

    sealed class SemFilho { // Quando aplicado a uma classe, o modificador sealed impede que outras classes herdem dela.
        public double ValorDaFortuna() {
            return 1_407_033.65;
        }
    }

    // class SouFilho : SemFilho {

    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public sealed override bool HonrarNomeFamilia() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
       // public override bool HonrarNomeFamilia() {
       //     return false;
       // }
    }

    class Sealed {
        public static void Executar() {
            SemFilho semFilho  = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}


// Você também pode usar o modificador sealed em um método ou propriedade que substitui um método
// ou propriedade virtual em uma classe base.
// Com isso, você pode permitir que classes sejam derivadas de sua classe
// e impedir que substituam métodos ou propriedades virtuais.
