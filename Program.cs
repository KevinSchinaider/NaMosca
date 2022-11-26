const double linhaVermelha = 1;
const double linhaAzul = 3;
const double linhaAmarela = 5;

double x, y, distanciaX, distanciaY, distanciaDardo;

Console.WriteLine("--- Dardos ---\n");

Console.ForegroundColor = (ConsoleColor)12;
Console.WriteLine("Coordenada X..: ");
Console.ResetColor();
x = Convert.ToDouble(Console.ReadLine());

Console.ForegroundColor = (ConsoleColor)13;
Console.WriteLine("Coordenada Y..: ");
Console.ResetColor();
y = Convert.ToDouble(Console.ReadLine());

distanciaX = Math.Abs(x);
distanciaY = Math.Abs(y);

distanciaDardo = Math.Sqrt(Math.Pow(distanciaX, 2) + Math.Pow(distanciaY, 2));

Console.WriteLine($"\nDistancia do Centro: {distanciaDardo:N2}\n");

if (distanciaDardo <= linhaVermelha)
{
        Console.ForegroundColor = (ConsoleColor)10;
    Console.WriteLine(" ----------- ");
    Console.WriteLine("| Perfeito! |");
    Console.WriteLine(" ----------- ");
}
else if (distanciaDardo <= linhaAzul)
{
   Console.ForegroundColor = (ConsoleColor)9;
    Console.WriteLine(" ----- ");
    Console.WriteLine("| Bom |");
    Console.WriteLine(" ----- ");
}
else if (distanciaDardo <= linhaAmarela)
{
   Console.ForegroundColor = (ConsoleColor)14;
    Console.WriteLine(" ------ ");
    Console.WriteLine("| Ruim |");
    Console.WriteLine(" ------ ");
}
else 
{
   Console.ForegroundColor = (ConsoleColor)12;
    Console.WriteLine(" ------- ");
    Console.WriteLine("| Errou |");
    Console.WriteLine(" ------- ");
    Console.Beep();
    Console.ResetColor();
    Console.WriteLine("Tente novamente.");
}

Console.ResetColor();