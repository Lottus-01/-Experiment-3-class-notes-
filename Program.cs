
using System;

Console.Clear();

//----SUB ROTINA----
string Resposta;

Console.WriteLine("----SUB ROTINA----");
Console.WriteLine(@"Modelos:
I- inicial
II-subrotina
III- Pular
Teste-III");

    Console.WriteLine();

Console.WriteLine("digite qual exibir:");
Resposta = Console.ReadLine();

    Console.WriteLine();

if (Resposta == "I")
{
    Console.WriteLine("Exibição I-");

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(DateTime.Now.ToLongTimeString());
    Console.ResetColor();

    Console.WriteLine("pressione uma tecla para atualizar o horario-");
    Console.ReadKey();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(DateTime.Now.ToLongTimeString());
    Console.ResetColor();

}

else if (Resposta == "II")
{
    void exibirhora()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.ResetColor();
    }

    Console.WriteLine("Exibição II-");
    exibirhora();

    Console.WriteLine("pressione uma tecla para atualizar o horario-");
    Console.ReadKey();

    exibirhora();
}


else if (Resposta == "III")
{
    //----LAÇOS----

    Console.WriteLine("----LAÇOS----");

    int Max = 10, Num = 0;

    while (Num <= Max)
    {
        Num = Num + 1;
        Console.WriteLine($"Sensação termica é de {Num}, o maximo já registrado é de {Max}");
    }
    Console.WriteLine("Novo record!!!");
}

//teste-I
else if (Resposta == "Teste-III")
{
    int NI, NII;

    Console.WriteLine("Determinação");
    Console.WriteLine("digite dois numeros aleatorios:");

    Console.WriteLine("Numero I:");
    NI = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Numero II:");
    NII = Convert.ToInt32(Console.ReadLine());

    while (NII < NI)
    {
        Console.WriteLine("Erro, porfavor, Digita um numero maior que o primeiro");
        Console.WriteLine("Numero II:");
        NII = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine();

    Console.WriteLine($"{NI}");
    while (NI < NII - 1)
    {
        NI = NI + 1;
        Console.WriteLine($"{NI};");
    }
    Console.WriteLine($"{NII}");
}