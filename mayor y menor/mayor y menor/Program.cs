using System.Runtime.CompilerServices;

Console.WriteLine("mayor y menor");

int[] numeros = new int[10];
for (int i = 0; i <= 9; i++)
{
    Console.Write($"ingresa los numeros {i} ");
    numeros[i] = int.Parse(Console.ReadLine());
}
for (int num = 0; num <= 9; num++)
{
    Console.WriteLine(numeros[num]);
}
 int mayor = numeros[0];
 int menor = numeros[0];
for (int i = 1; i <= 9; i++)
{
    if (numeros[i] > mayor) 
    {
        mayor = numeros[i];
    }
    if (numeros[i] < menor) 
    {
        menor = numeros[i];
    }
}
Console.WriteLine($"el numero mayor es {mayor}");
Console.WriteLine($"el numero menor es {menor}");