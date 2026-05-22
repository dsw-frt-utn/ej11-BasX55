namespace Dsw2026Ej11.Tests;

using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        
        CasoList.AgregarAlumno(new Alumno(1, "Ezequiel", 5.0D));
        CasoList.AgregarAlumno(new Alumno(2, "Pedro", 7.8D));
        CasoList.AgregarAlumno(new Alumno(3, "Andres", 6.0D));

        
        CasoList.ListarAlumnos();

        Console.WriteLine("\nBuscando al alumno Ezequiel");
        Console.WriteLine(CasoList.BuscarAlumno("Ezequiel"));
        Console.WriteLine("Alumno encontrado");

        Console.WriteLine("\nBuscando al alumno Emanuel");
        if (CasoList.BuscarAlumno("Emanuel") is null)
        {
            Console.WriteLine("No existe el alumno ingresado");
        }

        Console.WriteLine("\nEliminando al alumno Andres");
        CasoList.EliminarAlumnoNombre("Andres");
        CasoList.ListarAlumnos();

        Console.WriteLine("\nEliminar al primero de la lista");
        CasoList.EliminarAlumnoPosicion(0);
        CasoList.ListarAlumnos();
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary.AgregarAlumno(45789, new Alumno(1, "Ezequiel", 5.0D));
        CasoDictionary.AgregarAlumno(46777, new Alumno(2, "Pedro", 7.8D));
        CasoDictionary.AgregarAlumno(43511, new Alumno(3, "Andres", 6.0D));


        CasoDictionary.RetornarDiccionario();

        Console.WriteLine("\nBuscando el alumno de legajo: 46777");
        Console.WriteLine(CasoDictionary.BuscarAlumno(46777));
        Console.WriteLine("Alumno encontrado");

        Console.WriteLine("\nBuscando al alumno de legajo: 45888");
        if (CasoDictionary.BuscarAlumno(45888) is null)
        {
            Console.WriteLine("No existe el alumno ingresado");
        }

        Console.WriteLine("\nEliminando al alumno de legajo: 45789");
        CasoDictionary.EliminarAlumno(45789);
        CasoDictionary.RetornarDiccionario();

        
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        Console.WriteLine("Mostrando el primer libro");
        Libro priLibro = CasoLinq.GetPrimero();
        Console.WriteLine($"Id: {priLibro.Id} - Nombre: {priLibro.Titulo} - Precio: {priLibro.Precio:C}");

        Console.WriteLine("\nMostrando el ultimo libro");
        Libro ultLibro = CasoLinq.GetUltimo();
        Console.WriteLine($"Id: {ultLibro.Id} - Nombre: {ultLibro.Titulo} - Precio: {ultLibro.Precio:C}");

        Console.WriteLine($"\nEl total de precios de los libros es: {CasoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"\nEl promedio de los precios es: {CasoLinq.GetPromedioPrecios():C}");

        Console.WriteLine("\nMostrar lista de libros con id mayor a 15");
        foreach(Libro libro in CasoLinq.GetListById())
        {
            Console.WriteLine($"Id: {libro.Id} - Nombre: {libro.Titulo} - Precio: {libro.Precio:C}");
        }

        Console.WriteLine("\nMostrando lista de libros");
        foreach(string libro in CasoLinq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nMostrando al libro mas caro");
        Libro libCaro = CasoLinq.GetMayorPrecio();
        Console.WriteLine($"Id: {libCaro.Id} - Nombre: {libCaro.Titulo} - Precio: {libCaro.Precio:C}");

        Console.WriteLine("\nMostrando al libro mas barato");
        Libro libBar = CasoLinq.GetMenorPrecio();
        Console.WriteLine($"Id: {libBar.Id} - Nombre: {libBar.Titulo} - Precio: {libBar.Precio:C}");

        Console.WriteLine("\nMostrando libros con precio mayor al promedio");
        foreach(Libro l in CasoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"Id: {l.Id} - Nombre: {l.Titulo} - Precio: {l.Precio:C}");
        }

        Console.WriteLine("\nMostrando libros de manera descendente");
        foreach (Libro l in CasoLinq.GetOrden())
        {
            Console.WriteLine($"Id: {l.Id} - Nombre: {l.Titulo} - Precio: {l.Precio:C}");
        }
    }


}
