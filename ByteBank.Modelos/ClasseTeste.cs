using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ByteBank.Modelos.ClasseDerivada;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public  ClasseTeste()
        {
            ModificadoresTeste testeMetodoPublico = new ModificadoresTeste();
            testeMetodoPublico.MetodoPublico();
            testeMetodoPublico.MetodoInterno();
            /*
            testeMetodoPublico.MetodoPrivado(); não permite pois é visivel apenas no "ModificadoresTeste"
            testeMetodoPublico.MetodoProtegido(); não permite pois é visivel apenas no "ModificadoresTeste" e dentro das
            derivadas como mostra a class abaixo
            */
        }
    }

    class ClasseDerivada : ModificadoresTeste
    {
        public ClasseDerivada()
        {
            MetodoProtegido();
        }
    }

    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {
            //Visível fora da class "ModificadoresTeste"
        }
        private void MetodoPrivado()
        {
            //Visível apenas na class "ModificadoresTeste"
        }
        protected void MetodoProtegido()
        {
            //Visível apenas na class "ModificadoresTeste" e derivados
        }

        internal void MetodoInterno()
        {
            //Visível apenas dentro do projeto  "ByteBank.Modelos"
        }
    }
}
