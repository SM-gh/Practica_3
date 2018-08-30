using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    class Violin : Instrumentos
    {
        public override void Tocar(string sonido)
        {
            this.sonido = "Tocando el violin";
        }
        public override void Afinar(string afinado)
        {
            this.afinado = "Afiando el violin";
        }
        public override void Tipo(string tipo)
        {
            this.tipo = "Instrumento tipo cuerda";
        }
    }
}
