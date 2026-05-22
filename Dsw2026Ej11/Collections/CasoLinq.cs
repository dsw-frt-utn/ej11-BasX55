using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private static IEnumerable<Libro> _libros { get; set; } = Libro.CrearLista();

    public static Libro GetPrimero() => _libros.First();

    public static Libro GetUltimo() => _libros.Last();

    public static decimal GetTotalPrecios() => _libros.Sum(p => p.Precio);

    public static decimal GetPromedioPrecios() => _libros.Average(p => p.Precio);

    public static List<Libro> GetListById() => _libros.Where(p => (p.Id > 15)).ToList();

    public static List<string> GetLibros() => _libros.Select(p => $"Titulo del libro: {p.Titulo} - Precio: {p.Precio:C}").ToList();

    public static Libro GetMayorPrecio() => _libros.MaxBy(p => p.Precio);

    public static Libro GetMenorPrecio() => _libros.MinBy(p => p.Precio);

    public static List<Libro> GetMayorPromedio() => _libros.Where(p => (p.Precio > _libros.Average(w => w.Precio))).ToList();

    public static List<Libro> GetOrden() => _libros.OrderByDescending(p => p.Titulo).ToList();
}
