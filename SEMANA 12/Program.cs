void imprime(int[] lis)
{
    foreach (int f in lis)
    {
        Console.WriteLine(f);
    }
}


int[] lista = new int[5];



Random rand = new Random();
for (int f = 0; f < lista.Length; f++)
{
    lista[f] = rand.Next(1, 10 + 1);
}
imprime(lista);

foreach (int f in lista)
{
    Console.WriteLine(f);
}
Console.WriteLine("Ingrese nuevo numero");

int c = Convert.ToInt32(Console.ReadLine());
Array.Resize(ref lista, lista.Length + 1);
lista[lista.Length - 1] = c;

imprime(lista);