using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    class Piano : Instrumentos
    {
        public override void Tocar(string sonido)
        {
            this.sonido = "Tocando el piano";
        }
        public override void Afinar(string afinado)
        {
             this.afinado = "Afiando el piano";
        }
        public override void Tipo(string tipo)
        {
             this.tipo = "Instrumento tipo cuerda";
        }
    }
}
