Console.WriteLine("calcular el promedio");
Console.WriteLine("ingrese la cantidad de notas");
int cantidad = int.Parse(Console.ReadLine());
double promedio;
double suma = 0;

for (int i = 1; i <= cantidad; i++)
{
    Console.Write($"ingrese la nota numero {i}: ");
    double nota = double.Parse(Console.ReadLine());
    suma += nota;
}
promedio = suma / cantidad;
Console.WriteLine($"el promedio es: {promedio}");
