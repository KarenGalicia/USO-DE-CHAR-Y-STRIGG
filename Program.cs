using System;

// *USO DE CHAR Y STRING*
Console.WriteLine("*USO DE CHAR Y STRING*");
Console.WriteLine("--------------------------");

// *1. Convertir una cadena de texto y la imprima en mayúsculas*
Console.WriteLine("1. Convertir una cadena de texto y la imprima en mayúsculas");
Console.WriteLine("Introduzca una cadena de texto: ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
string cadena = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
string cadenaMayusculas = cadena.ToUpper();
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
Console.WriteLine("La cadena en mayúsculas es: " + cadenaMayusculas);

// *2. Convertir una cadena de texto y la imprima en minúsculas.*
Console.WriteLine("2. Convertir una cadena de texto y la imprima en minúsculas.");
Console.WriteLine("Introduzca una cadena de texto: ");
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
string cadenaMinusculas = Console.ReadLine().ToLower();
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
Console.WriteLine("La cadena en minúsculas es: " + cadenaMinusculas);

// *3. Convertir una cadena de texto y la imprima al revés.*
Console.WriteLine("3. Convertir una cadena de texto y la imprima al revés.");
Console.WriteLine("Introduzca una cadena de texto: ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
cadena = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
char[] cadenaAlReves = new char[cadena.Length];
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
for (int i = cadena.Length - 1; i >= 0; i--)
{
    cadenaAlReves[cadena.Length - 1 - i] = cadena[i];
}

string cadenaInvertida = new string(cadenaAlReves);
Console.WriteLine("La cadena al revés es: " + cadenaInvertida);

// *4. Convertir una cadena de texto y busque una palabra en ella.*
Console.WriteLine("4. Convertir una cadena de texto y busque una palabra en ella.");
Console.WriteLine("Introduzca una cadena de texto: ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
string cadenaA = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
Console.WriteLine("Introduzca la palabra que desea buscar: ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
string palabra = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

#pragma warning disable CS8604 // Posible argumento de referencia nulo
int indice = cadena.IndexOf(palabra);
#pragma warning restore CS8604 // Posible argumento de referencia nulo

if (indice == -1)
{
    Console.WriteLine("La palabra no se encuentra en la cadena.");
}
else
{
    Console.WriteLine("La palabra se encuentra en la cadena en el índice {0}.", indice);
}

// *5. Convertir una cadena de texto y cuente el número de vocales que contiene*
Console.WriteLine("5. Convertir una cadena de texto y cuente el número de vocales que contiene");
Console.WriteLine("Introduzca una cadena de texto: ");
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
string texto = Console.ReadLine();
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

int numeroVocales = 0;
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
foreach (char caracter in texto.ToLower())
{
    if ("aeiou".Contains(caracter))
    {
        numeroVocales++;
    }
}
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.

Console.WriteLine("El número de vocales en la cadena es: " + numeroVocales);
