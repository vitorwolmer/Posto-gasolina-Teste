
string nome = "";

//Console.WriteLine("Cálculo de média");

Console.WriteLine("Olá, digite seu nome:");
nome = Console.ReadLine();

Console.WriteLine(nome + ", digite a sua primeira nota : ");

double nota1 = int.Parse(Console.ReadLine());



Console.WriteLine(nome + ", digite a sua segunda nota : ");
double nota2 = int.Parse(Console.ReadLine());

double media = (nota1 + nota2) / 2;

//verificação se aprovado ou não

if (media >= 7)
{
    Console.WriteLine($"{nome}, sua media é: {media}! Você foi aprovad@ por média.");
}
else
{
    if (media <= 3)
    {
        Console.WriteLine($"{nome}, sua media é: {media}! Você está reprovado por média.");
    }


    else
    {
        Console.WriteLine($"{nome}, sua media é: {media}! Você terá que fazer a prova final.");
    }
}

