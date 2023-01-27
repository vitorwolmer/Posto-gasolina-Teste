// See https://aka.ms/new-console-template for more information


Console.WriteLine("Bem vind@ ao Posto Gasosa!!");

double Litros;
double gasolina;
double alcool;
double valorcompra;
double valorfinal;
string nomecliente;
int item;



Console.WriteLine("Por favor, digite seu nome:");
nomecliente= Console.ReadLine();

gasolina= 4.22;
alcool = 3.25;

Console.WriteLine($"Car@ {nomecliente}, temos [1] gasolina R${gasolina} e [2] álcool R${alcool}");

Console.WriteLine("Deseja o item 1 ou 2?");
item= int.Parse( Console.ReadLine() );

//GASOLINA!!
if (item == 1)
{
    Console.WriteLine("Quantos Litros deseja?");
    Litros = Convert.ToDouble(Console.ReadLine());

    valorcompra = Litros * gasolina;

    //Console.WriteLine($"O valor total é de R$ {valorcompra}");
    if (valorcompra >= 100)
    {
        valorfinal = valorcompra * 0.95;

        Console.WriteLine($"A quantidade de litros abestecido é {Litros} e o valor da compra é {valorfinal} Reais;");
    }
    else
    {
        Console.WriteLine($"A quantidade de litros abestecido é {Litros} e o valor da compra é {valorcompra} Reais;");
    }

    //ALCOOL!!
}
else
{ Console.WriteLine("Quantos Litros deseja?");
    Litros = Convert.ToDouble(Console.ReadLine());

    valorcompra = Litros * alcool;

    //Console.WriteLine($"O valor total é de R$ {valorcompra}");
    if (valorcompra >= 100)
    {
        valorfinal = valorcompra * 0.95;

        Console.WriteLine($"A quantidade de litros abestecido é {Litros} e o valor da compra é {valorfinal} Reais;");
    }
    else
    {
        Console.WriteLine($"A quantidade de litros abestecido é {Litros} e o valor da compra é {valorcompra} Reais;");
    }
}






