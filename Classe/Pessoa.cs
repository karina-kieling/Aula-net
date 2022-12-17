using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_dotnet.Interface;

namespace aula_dotnet.Classe
{
    public abstract class Pessoa : IPessoa
    {
        public string nome { get; set; }

        public float rendimento { get; set; }


        public Endereco end { get; set; }


        public abstract float CalcularImposto(float rendimento);
        
    }
}