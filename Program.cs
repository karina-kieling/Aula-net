using aula_dotnet.Classe;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();



novaPf.nome = "Odirlei";
novaPf.cpf = "12345678412";
novaPf.rendimento = 3590.5f;
novaPf.dataNasc = new DateTime(2001, 01, 01);

novoEndPf.logradouro = "Rua Niteroi";
novoEndPf.numero = 180;
novoEndPf.complemento = "senai informatica";
novoEndPf.endComercial = true;

novaPf.endereco = novoEndPf;


//Console.WriteLine(novaPf.nome);
//Console.WriteLine("Nome: " + novaPf.nome + " CPF: " + novaPf.cpf);
//Console.WriteLine($"Nome: {novaPf.nome} CPF: {novaPf.cpf}");
Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novoEndPf.logradouro}, Num: {novoEndPf.numero}
Maior de idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
");



//pessoa fisica
float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine(impostoPagar.ToString("C"));


//pessoa juridica
PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto(3590.5f));


//validar data nascimento para ser maior de 18 anos
DateTime temp = new DateTime(2001, 01, 01);
Console.WriteLine(novaPf.ValidarDataNasc("2005-02-01"));
