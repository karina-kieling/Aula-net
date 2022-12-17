using aula_dotnet.Classe;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Odirlei";
novaPf.cpf = "12345678412";

Console.WriteLine(novaPf.nome);

Console.WriteLine("Nome: " + novaPf.nome + " CPF: " + novaPf.cpf);
Console.WriteLine($"Nome: {novaPf.nome} CPF: {novaPf.cpf}");