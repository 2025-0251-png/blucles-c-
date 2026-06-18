Console.WriteLine("contador");

    Console.WriteLine("cuantos numeros son ?");
    int n = int.Parse(Console.ReadLine());
    int[] numeros = new int[n];

    for (int i = 0; i < n; i++)
{
    Console.WriteLine($"ingrese los numeros {i + 1} ");
    numeros[i] = int.Parse(Console.ReadLine());

}
int positivos = 0;
int negativos = 0;
int ceros = 0;
for (int i = 0; i < n; i++)
{
    if (numeros[i] > 0)
    {
        positivos++;
    }
    else if (numeros[i] < 0)
    {
        negativos++;
    }
    else
    {
        ceros++;
    }
}

Console.WriteLine("cantidad de numeros positivos: " + positivos);
Console.WriteLine("cantidad de numeros negativos: " + negativos);
Console.WriteLine("cantidad de ceros: " + ceros);