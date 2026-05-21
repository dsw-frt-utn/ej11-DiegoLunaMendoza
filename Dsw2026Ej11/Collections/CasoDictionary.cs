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
    public void AgregarAlumno(int legajo, Alumno alumno) => dic.Add(legajo, alumno);//Metodo para agregar alumno 
    public Alumno? BuscarPorClave(int legajo)//Metodo para buscar alumno por clave
    {
        dic.TryGetValue(legajo, out Alumno? alumno);
        return alumno;
    }
    public Dictionary<int, Alumno> ObtenerDiccionario() => dic;//Metodo para retornar el diccionario
    public void EliminarAlumnoClave(int legajo) => dic.Remove(legajo);//Metodo para eliminar utilizando una clave 
}
