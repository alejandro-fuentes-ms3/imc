namespace imc.Models
{
    public static class Calculadoraimc
    {
        public static decimal IndiceDeMasaCorporal( decimal peso, decimal estatura)
        {
            return peso / (estatura * estatura);
        }
        public static string SituacionNutricional (decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Peso bajo";
            }
            if (imc < 25.0m)
            {
                return "Peso normal";
            }
            if (imc < 30.0m)
            {
                return "Peso sobrepeso";
            }
            if (imc < 40.0m)
            {
                return "Obisidad";
            }
            return "Obesidad extrema";
        }
    }
}
