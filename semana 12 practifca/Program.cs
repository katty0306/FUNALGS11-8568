using semana_12_practifca;
using System;
byte opcion;
string regresar;
estudiante f = new estudiante();
do
{
    Console.WriteLine("BIENVENIDOS AL SISTEMA DE REGIISTRO DE EDADES\n");
    Console.WriteLine("************* MENÚ *************");
    Console.WriteLine("*     1. Insertar   *");
    Console.WriteLine("*     2. Mostrar    *");
    Console.WriteLine("*     3. Eliminar   *");
    Console.WriteLine("*     4. Ordenar    *");
    Console.WriteLine("*     0. Salir      *");
    Console.WriteLine("**********************\n");

    Console.WriteLine("Ingrese opcion: ");

    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 4)
    {
        Console.WriteLine("Error: Ingrese opcion");
    }

    switch (opcion)
    {
        case 0: Environment.Exit(0); break;
        case 1: f.insertar(); break;
        case 2: f.mostrar(); break;
        case 3: Console.Write("\nIngrese edad a eliminar: ");
            byte ed = byte.Parse(Console.ReadLine());
            f.eliminar(ed);
            break;
        case 4: break;

    }
    

    Console.Write("\n\nDesea regresar al menú? [si]: ");
    regresar = Console.ReadLine().ToLower();
    Console.Clear();


} while (regresar == "si");