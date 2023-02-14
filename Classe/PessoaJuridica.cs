using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using aula_dotnet.Interface;

namespace aula_dotnet.Classe
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string cnpj { get; set; }    

        public string razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
           if (rendimento <= 3000)
           {
                return rendimento * .03f;

           }else if (rendimento <= 6000)
           {
                return rendimento * .05f;

           }else if (rendimento <= 10000)
           {
                return rendimento * .07f;

           }else
           {
                return rendimento * .09f;

           }
        }

        public bool ValidarCnpj(string cnpj)
        {
          //comparando atraves do metodo regex o valor info do cnpj com o padrao "regex"
          bool retornoCnpjValido = Regex.IsMatch(cnpj, @"^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2}) $");

            if (retornoCnpjValido)
            {
                string subStringCnpj14 = cnpj.Substring(8, 4);

                if (subStringCnpj14 == "0001")
                {
                    return true;
                } else

                return false;

            }

            string subStringCnpj18 = cnpj.Substring(11, 4);

                if (subStringCnpj18 == "0001")
                {
                    return true;
                }

        return false;
        }
    }
}