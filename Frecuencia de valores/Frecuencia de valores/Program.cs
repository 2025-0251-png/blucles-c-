Console.WriteLine(" Frecuencia de valores");

Console.Write("¿Cuántos números deseas ingresar? ");
int cantidad = int.Parse(Console.ReadLine());

int[] numeros = new int[cantidad];
bool[] Contado = new bool[cantidad];

for (int i = 0; i < cantidad; i++)
{
    Console.Write($"Ingresa el número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
    Contado[i] = false; 
}

Console.WriteLine("\nFrecuencia de los números:");


for (int i = 0; i < numeros.Length; i++)
{
    if (Contado[i] == true)
    {
        continue;
    }

    int contador = 1;
    for (int n = i + 1; n < numeros.Length; n++)
    {
        if (numeros[i] == numeros[n])
        {
            contador++;
            Contado[n] = true;
        }
    }
    Console.WriteLine($"El número {numeros[i]} se repite {contador} vez/veces.");
}