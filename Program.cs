bool condicao01 = true;
bool condicao02 = true;
bool condicao03 = true;
bool condicao04 = true;

Console.WriteLine("A Condição Foi atendida?");
Console.WriteLine("01 - Sim");
Console.WriteLine("02 - Não");
double resposta01 = Convert.ToDouble(Console.ReadLine());

if(resposta01 == 1)
{
    condicao01 = true;
}
else
{
    condicao01 = false;
}

if(condicao01 == false)
{
    Console.WriteLine("Não é possível prosseguir");
}
else
{
    Console.WriteLine("A Condição Foi atendida?");
    Console.WriteLine("01 - Sim");
    Console.WriteLine("02 - Não");
    double resposta02 = Convert.ToDouble(Console.ReadLine());

    if (resposta02 == 1)
    {
        condicao02 = true;
    }
    else
    {
        condicao02 = false;
    }

    if (condicao02 == false)
    {
        Console.WriteLine("Não é possível prosseguir");
    }
    else
    {
        Console.WriteLine("A Condição Foi atendida?");
        Console.WriteLine("01 - Sim");
        Console.WriteLine("02 - Não");
        double resposta03 = Convert.ToDouble(Console.ReadLine());

        if (resposta03 == 1)
        {
            condicao03 = true;
        }
        else
        {
            condicao03 = false;
        }

        if (condicao03 == false)
        {
            Console.WriteLine("Não é possível prosseguir");
        }
        else
        {
            Console.WriteLine("A Condição Foi atendida?");
            Console.WriteLine("01 - Sim");
            Console.WriteLine("02 - Não");
            double resposta04 = Convert.ToDouble(Console.ReadLine());

            if (resposta04 == 1)
            {
                condicao04 = true;
            }
            else
            {
                condicao04 = false;
            }

            if (condicao04 == false)
            {
                Console.WriteLine("Não é possível prosseguir");
            }
            else
            {
                Console.WriteLine("Operação Finalizada com Sucesso!");
            }
        }
    }
}