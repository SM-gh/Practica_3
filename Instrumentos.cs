using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    class Instrumentos
    {
        public string tipo, sonido, afinado;

        public virtual void Tocar(string sonido)
        {
            sonido = this.sonido;
        }
        public virtual void Afinar(string afinado)
        {
            afinado = this.afinado;
        }
        public virtual void Tipo(string tipo)
        {
            tipo = this.tipo;
        }
    }
}
