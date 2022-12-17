using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_dotnet.Interface
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj(string cnpj);
    }
}