using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Security.Cryptography.X509Certificates;

namespace Dsw2026Ej11.Tests;


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
        CasoList lista = new();
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("Agregar 3 Alumnos");
        lista.AgregarAlumnos(new Alumno(1, "Diego", 8.5));
        lista.AgregarAlumnos(new Alumno(2, "Ana", 7.0));
        lista.AgregarAlumnos(new Alumno(3, "Carlos", 9.0));

        foreach (Alumno a in lista.ObtenerAlumnos())
        Console.WriteLine(a);
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("Buscar Alumno Nombre Ana");
        Alumno encontrado = lista.BuscarPorNombre("Ana");
        Console.WriteLine($"Alumno encontado {encontrado}");
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("Buscar un alumno que no existe");
        Alumno? noExiste = lista.BuscarPorNombre("Juan");
        Console.WriteLine(noExiste?.ToString() ?? "No existe");
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("Eliminar un alumno");
        lista.EliminarAlumno(encontrado!);
        foreach (Alumno a in lista.ObtenerAlumnos())
            Console.WriteLine(a);
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("Eliminar el primer elemento de la lista");
        lista.EliminarPosicion(0);
        foreach (Alumno a in lista.ObtenerAlumnos())
            Console.WriteLine(a);

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary dic = new();
        dic.AgregarAlumno(56142,new Alumno (1,"Diego",8.5));
        dic.AgregarAlumno(56450, new Alumno(1, "Fabrizzio", 8.5));
        dic.AgregarAlumno(56600, new Alumno(1, "Pablo", 8.5));
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("Buscar por clave");
        Alumno? encontrado = dic.BuscarPorClave(56142);
        Console.WriteLine($"Alumno encontrado {encontrado}");
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("Buscar por clave un legajo que no existe");
        Alumno noExiste = dic.BuscarPorClave(56182);
        Console.WriteLine(noExiste?.ToString() ?? "No existe");
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("Eliminar alumno por clave, 56600");
        dic.EliminarAlumnoClave(56600);
        foreach (var a in dic.ObtenerDiccionario())
            Console.WriteLine($"Legajo: {a.Key} - {a.Value}");
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linq = new();
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine($"El primer libro es: {linq.GetPrimero()}");
        Console.WriteLine($"El ultimo libro es: {linq.GetUltimo()}");
        Console.WriteLine($"Precio Total: {linq.GetTotalPrecios()}");
        Console.WriteLine($"Precio Promedio: {linq.GetPromedioPrecios()}");

        Console.WriteLine("Los ID mayores a 15 son:");
        foreach (Libro l in linq.GetListByID())
        {
            Console.WriteLine(l);
        }
        Console.WriteLine("lista de cada libro con su título y precio en formato moneda");
        foreach (String l in linq.GetLibros())
        {
            Console.WriteLine(l);
        }
        Console.WriteLine($"El precio mayor es: {linq.GetMayorPrecio()}");
        Console.WriteLine($"El menor precio es: {linq.GetMenorPrecio()}");
        Console.WriteLine("los libros cuyo precio sea mayor al promedio");
        foreach (Libro l in linq.GetMayorPromedio()) //l es de libro
        {
            Console.WriteLine(l);
        }
        Console.WriteLine("los libros ordenados por título de forma descendente");
        foreach (Libro l in linq.OrdenadosDescendente())
        {
            Console.WriteLine(l);
        }

    }
}
