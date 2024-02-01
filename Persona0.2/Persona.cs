using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona0._2
{
    internal class Persona
    {
        public string Nome { get; set; }
        public int Eta { get; set; }

        public Persona(string Nome,int Eta ) 
        {
            this.Nome = Nome;
            this.Eta = Eta;

        }

        public override string ToString()
        {
            return $"{Nome},{Eta}";
        }
    }
}
