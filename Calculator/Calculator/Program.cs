// EXTREMELY BAD CODED CALCULATOR

Console.WriteLine("Super bad-coded Calculator v0.1");

Console.WriteLine("Qual operação deseja realizar?");
Console.WriteLine("1. Somar");
Console.WriteLine("2. Diminuir");
Console.WriteLine("3. Multiplicar");
Console.WriteLine("4. Dividir");

string option = Console.ReadLine();
int number1;
int number2;



if (option == "1")
{
    Console.WriteLine("Insira o primeiro valor:");
    number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira o segundo valor:");
    number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
    Console.ReadKey();
}
else if (option == "2")
{
    Console.WriteLine("Insira o primeiro valor:");
    number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira o segundo valor:");
    number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
    Console.ReadKey();
}
else if (option == "3")
{
    Console.WriteLine("Insira o primeiro valor:");
    number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira o segundo valor:");
    number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
    Console.ReadKey();
}
else if (option == "4")
{
    Console.WriteLine("Insira o primeiro valor:");
    number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insira o segundo valor:");
    number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Opção Inválida");
    Console.ReadKey();
}