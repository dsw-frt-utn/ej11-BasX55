using Dsw2026Ej11.Domain;
using System.Runtime.CompilerServices;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private static List<Alumno> _alumnos { get; set; } = new List<Alumno>();

    public static void AgregarAlumno(Alumno alumno) => _alumnos.Add(alumno);

    public static void ListarAlumnos()
    {
        Console.WriteLine("\nListando alumnos\n");
        foreach (Alumno alumno in _alumnos)
        {
            Console.WriteLine(alumno);
        }
    }

    public static Alumno BuscarAlumno(string nombre) => _alumnos.Find(p => (p.Nombre == nombre));

    public static void EliminarAlumnoNombre(string nombre) => _alumnos.Remove(_alumnos.Find(p => (p.Nombre == nombre)));

    public static void EliminarAlumnoPosicion(int index) => _alumnos.RemoveAt(index);
}
