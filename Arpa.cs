using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    class Arpa : Instrumentos
    {
        public override void Tocar(string sonido)
        {
            this.sonido = "Tocando el arpa";
        }
        public override void Afinar(string afinado)
        {
            this.afinado = "Afiando el arpa";
        }
        public override void Tipo(string tipo)
        {
            this.tipo = "Instrumento tipo cuerda";
        }
    }
}
