Console.WriteLine(" Búsqueda en un arreglo");

Console.Write("Ingrese un número a buscar: ");
int buscar = int.Parse(Console.ReadLine());
bool encontrado = false;
int posicion = 0;
Random random = new Random();
int[] numero = new int[20];

for (int i = 0; i < numero.Length; i++) 
{
    numero[i] = random.Next(1, 101);
}
for (int i = 0; i < numero.Length; i++)
{
    if (numero[i] == buscar)
    {
        posicion = i;
        encontrado = true;
    }
        break;

}
if (encontrado)
{
    Console.WriteLine($"El número {buscar} se encuentra en la posición {posicion}");
}
else
{
    Console.WriteLine($"El número {buscar} no se encuentra en el arreglo");
}
