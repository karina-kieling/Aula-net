using aula_dotnet.Classe;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Odirlei";
novaPf.cpf = "12345678412";
novaPf.rendimento = 3590.5f;

Console.WriteLine(novaPf.nome);

Console.WriteLine("Nome: " + novaPf.nome + " CPF: " + novaPf.cpf);
Console.WriteLine($"Nome: {novaPf.nome} CPF: {novaPf.cpf}");

float impostoPagar = novaPf.CalcularImposto(novaPf.rendimento);

Console.WriteLine(impostoPagar);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine(impostoPagar.ToString("C"));