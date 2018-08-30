using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    class Marimba : Instrumentos
    {
        public override void Tocar(string sonido)
        {
            this.sonido = "Tocando Marimba";
        }
        public override void Afinar(string afinado)
        {
            this.afinado = "Afiando la marimba";
        }
        public override void Tipo(string tipo)
        {
            this.tipo = "Instrumento tipo percusión";
        }
    }
}
