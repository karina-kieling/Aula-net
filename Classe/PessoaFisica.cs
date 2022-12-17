using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula_dotnet.Interface;

namespace aula_dotnet.Classe
{
    public class PessoaFisica : Pessoa, IpessoaFisica
    {
        public string cpf { get; set; }

        public DateTime dataNasc { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}