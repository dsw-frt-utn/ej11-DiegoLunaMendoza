using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private readonly Dictionary<int, Alumno> dic = [];

    //Metodo para agregar alumno 
    public void AgregarAlumno(int legajo, Alumno alumno) => dic.Add(legajo, alumno);

    //Metodo para buscar alumno por clave
    public Alumno? BuscarPorClave(int legajo)
    {
        dic.TryGetValue(legajo, out Alumno? alumno);
        return alumno;
    }

    //Metodo para retornar el diccionario
    public Dictionary<int, Alumno> ObtenerDiccionario() => dic;

    //Metodo para eliminar utilizando una clave 
    public void EliminarAlumnoClave(int legajo) => dic.Remove(legajo);
}
