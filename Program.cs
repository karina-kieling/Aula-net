using aula_dotnet.Classe;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();

//-------------

PessoaJuridica novoPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();


//dados pessoa juridica----------------------------------

//duas formas validadas cnpj:
//Console.WriteLine(novoPj.ValidarCnpj("76773415000160"));
//Console.WriteLine(novoPj.ValidarCnpj("76.773.415/0001-60"));

novoPj.nome = "EMPRESA Odirlei Me";
novoPj.cnpj = "76773415000160";
novoPj.rendimento = 22600.5f;


novoEndPj.logradouro = "Rua Niteroi";
novoEndPj.numero = 180;
novoEndPj.complemento = "Odirlei informatica";
novoEndPj.endComercial = false;

novoPj.endereco = novoEndPj;

//interpolação
Console.WriteLine(@$"
Nome: {novoPj.nome}
Endereço: {novoEndPj.logradouro}, Num: {novoEndPf.numero}
Cnpj: {novoPj.cnpj} - Valido: {novoPj.ValidarCnpj(novoPj.cnpj)}
");




//dados pessoa fisica--------------------------------

novaPf.nome = "Odirlei";
novaPf.cpf = "12345678412";
novaPf.rendimento = 3590.5f;
novaPf.dataNasc = new DateTime(2001, 01, 01);

novoEndPf.logradouro = "Rua Niteroi";
novoEndPf.numero = 180;
novoEndPf.complemento = "senai informatica";
novoEndPf.endComercial = true;

novaPf.endereco = novoEndPf;

//interpolação
//Console.WriteLine(novaPf.nome);
//Console.WriteLine("Nome: " + novaPf.nome + " CPF: " + novaPf.cpf);
//Console.WriteLine($"Nome: {novaPf.nome} CPF: {novaPf.cpf}");
Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novoEndPf.logradouro}, Num: {novoEndPf.numero}
Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
");


//calcular imposto:--------------------------------------------

//pessoa fisica
float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine(impostoPagar.ToString("C"));


//pessoa juridica
PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto(22600.5f));


//------------------------------------------------------------

//validar data nascimento para ser maior de 18 anos
DateTime temp = new DateTime(2001, 01, 01);
Console.WriteLine(novaPf.ValidarDataNasc("2005-02-01"));
