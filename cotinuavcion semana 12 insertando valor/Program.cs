void imprime(int[] lis)
{
    foreach (int fk in lis)
    {
        Console.WriteLine(fk);
    }
}


int[] lista = {5,6,8,9}; 

imprime(lista);



Console.WriteLine("Ingrese numero a insertar: ");
int f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese posicion donde insertar:");
int c = Convert.ToInt32(Console.ReadLine()) - 1;

Array.Resize(ref lista, lista.Length + 1);
for (int fk = lista.Length - 1; fk > c; fk--)
{
    lista[fk] = lista[fk - 1];
}

lista[c] = f;

imprime(lista);