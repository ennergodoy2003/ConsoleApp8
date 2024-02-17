using System;

class Program
{
    static void Main(string[] args)
    {
        /***** CONVERSION DE TIPOS *****/
        int entero = 4;
        decimal numdec = Convert.ToDecimal(entero);
        Console.WriteLine($"Entero a Decimal: {numdec}");

        decimal deci= 10.5m;
        float floatValue = Convert.ToSingle(deci);
        Console.WriteLine($"Decimal a Float: {floatValue}");

        float floatnu = 15.2f;
        int intNum = Convert.ToInt32(floatnu);
        Console.WriteLine($"Float a Entero: {floatnu}");

        char charval = 'D';
        int charToInt = Convert.ToInt32(charval);
        Console.WriteLine($"Caracter a Entero: {charToInt}");

        int intChar = 25;
        char intToChar = Convert.ToChar(intChar);
        Console.WriteLine($"Entero a caracter: {intToChar}");

        Console.WriteLine();


        /***** OPERACIONES CON TIPOS DE DATOS *****/
        int N1 = 8, N2 = 4;
        Console.WriteLine($"Suma en enteros: {N1 + N2}");

        decimal R1 = 11.5m, R2 = 3.4m;
        Console.WriteLine($"Resta en decimales: {R1 - R2}");

        float M1 = 5.1f, M2 = 4.6f;
        Console.WriteLine($"MultiplicacioLn en flotantes: {M1 * M2}");

        int D1 = 100, D2 = 5;
        Console.WriteLine($"Division en enteros: {D1 / D2}");

        int MO1 = 50, MO2 = 2;
        Console.WriteLine($"Modulo en enteros: {MO1 % MO2}");

        Console.WriteLine();


        /***** USO DE CHAR Y STRING *****/
        string texto = "Hola Mundo";
        Console.WriteLine($"Texto en mayusculas: {texto.ToUpper()}");

        Console.WriteLine($"Texto en minusculas: {texto.ToLower()}");

        char[] chars = texto.ToCharArray();
        Array.Reverse(chars);
        string reversedText = new string(chars);
        Console.WriteLine($"Texto al reves: {reversedText}");

        Console.WriteLine($"Buscar 'Mundo' en el texto: {texto.Contains("Mundo")}");

       
        int contarvocales = 0;
        foreach (char c in texto.ToLower())
        {
            if ("aeiou".Contains(c))
                contarvocales++;
        }
        Console.WriteLine($"Numero de vocales en el texto: {contarvocales}");

        Console.WriteLine();


        /***** USO DE TIPOS DE DATOS NUMERICOS ****/

        double baset = 8, altura = 4;
        double area = (baset * altura) / 2;
        Console.WriteLine($"Area del triangulo: {area}");

        double radioEsfera = 3.0;
        double volumenEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);
        Console.WriteLine($"Volumen de la esfera: {volumenEsfera}");

        double x1 = 1, y1 = 2, x2 = 4, y2 = 6;
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"Distancia entre dos puntos: {distancia}");

        double celsius = 30;
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Temperatura en Fahrenheit: {fahrenheit}");

        double fahrenheitTemp = 86.0;
        double celsiusTemp = (fahrenheitTemp - 32) * 5 / 9;
        Console.WriteLine($"Temperatura en Celsius: {celsiusTemp}");
    }
}
