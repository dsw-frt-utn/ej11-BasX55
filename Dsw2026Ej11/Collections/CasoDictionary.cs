using Dsw2026Ej11.Domain;

using System.Collections.Generic;
namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private static Dictionary<int, Alumno> _alumnos { get; set; } = new Dictionary<int, Alumno>();

    public static void AgregarAlumno(int legajo, Alumno alumno) 
    {
        if(!_alumnos.ContainsKey(legajo))
        {
            _alumnos.Add(legajo, alumno);
        }
        else
        {
            Console.WriteLine("El legajo ya se encuentra en uso");
        }
    }

    public static Alumno BuscarAlumno(int legajo) 
    {
        
        foreach(KeyValuePair<int, Alumno> element in _alumnos)
        {
            if (element.Key.Equals(legajo))
            {
                return element.Value;
            }
        }
        return null;
    }

    public static void RetornarDiccionario()
    {
        Console.WriteLine("Mostrar diccionario");
        foreach(KeyValuePair<int, Alumno> element in _alumnos)
        {
            Console.WriteLine($"Legajo: {element.Key}, Datos del Alumno: {element.Value}");
        }
    }

    public static void EliminarAlumno(int legajo)
    {
        if (_alumnos.ContainsKey(legajo))
        {
            _alumnos.Remove(legajo);
        }
        else
        {
            Console.WriteLine("No se encontró al alumno");
        }
    }
}
