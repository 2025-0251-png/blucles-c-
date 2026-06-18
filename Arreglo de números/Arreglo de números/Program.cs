Console.WriteLine("arreglo de numeros");

int[] numeros = new int[5];
for (int i = 0; i <= 4; i++)
{
    Console.Write($"ingresa el numero {i} ");
    numeros[i] = int.Parse(Console.ReadLine());
}
for (int num = 0; num <= 4; num++) 
{
    Console.WriteLine(numeros[num]);
}
