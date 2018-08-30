using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    class Fagot : Instrumentos
    {
        public override void Tocar(string sonido)
        {
            this.sonido = "Tocando el fagot";
        }
        public override void Afinar(string afinado)
        {
            this.afinado = "Afiando el fagot";
        }
        public override void Tipo(string tipo)
        {
            this.tipo = "Instrumento tipo viento";
        }
    }
}
