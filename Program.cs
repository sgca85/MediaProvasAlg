Console.Clear();
double P1, P2, P3, L1, L2, L3, L4, L5, L6, 
       mediaFinal, mediaListas, mediaProvas;
const double MEDIA_APROVACAO = 6.0;

Console.Write("Informe a nota da Lista 01:");
L1 = Convert.ToDouble(Console.ReadLine());

if (L1 < 0 || L1 > 10)
{
    Console.WriteLine("Nota da lista 01 inválida!");
    return;
}

Console.Write("Informe a nota da Lista 02:");
L2 = Convert.ToDouble(Console.ReadLine());

/*
-inf             0          10          +inf
|----------------|-----------|------------|
*/

if (!(L2 >= 0 && L2 <= 10))
{
    Console.WriteLine("Nota da lista 02 inválida!");
    return;  
}

Console.Write("Informe a nota da Lista 03:");
L3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da Lista 04:");
L4 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da Lista 05:");
L5 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da Lista 06:");
L6 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da P1:");
P1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota da P2:");
P2 = Convert.ToDouble(Console.ReadLine());

mediaListas = (L1 + L2 + L3 + L4 + L5 + L6) / 6 * 0.2;
mediaProvas = (P1 + P2) / 2 * 0.8;

mediaFinal = mediaListas + mediaProvas;
bool aprovado = mediaFinal >= MEDIA_APROVACAO;

if (aprovado)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Aprovado com média {mediaFinal:N1}");
}
else
{
    Console.Write("Informe a nota da P3:");
    P3 = Convert.ToDouble(Console.ReadLine());
    
    mediaProvas = (Math.Max(P1, P2) + P3) / 2 * 0.8;
    mediaFinal = mediaListas + mediaProvas;

    if (mediaFinal >= MEDIA_APROVACAO)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Aprovado com média {mediaFinal:N1}");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Reprovado com média {mediaFinal:N1}");    
    }
}

Console.ResetColor();