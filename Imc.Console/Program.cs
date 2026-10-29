using imc.Models;

Console.WriteLine("Caulculadora de Indice de Masa Corporal");
Console.WriteLine();

decimal peso = ReadDecimal("proporcione el peso de la persona en kilogramos");
decimal estatura = ReadDecimal("proporcione la esatatura de la persona en metros ");

// realizar calculos
var imc = Calculadoraimc.IndiceDeMasaCorporal(peso, estatura);
Console.WriteLine($"el indice de la masa corporal de la persona es {imc:F4}");
var situacionnutricional =Calculadoraimc.SituacionNutricional(imc);
Console.WriteLine($"el estado nutricional de la persona es {situacionnutricional}");
return 0;

static decimal ReadDecimal(string indicacion)
{
    bool valorEsvalido = false;
    decimal valor;
    do
    {
        Console.Write($"{indicacion}");
        var entrada = Console.ReadLine();
        valorEsvalido = decimal.TryParse(entrada, out valor);
        if (!valorEsvalido)
        {
            Console.WriteLine("el dato proporcionada debe ser numerico");
        }

    } while (!valorEsvalido);
    return valor;
}