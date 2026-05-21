using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private readonly List<Alumno> alumnos = [];//Campo de una lista de Alumnos, agrego el readonly para que sea solo lectura
    public void AgregarAlumnos (Alumno alumno) => alumnos.Add(alumno);//Metodo para agregra un alumno a la lista 
    public List<Alumno> ObtenerAlumnos() => alumnos;//Metodo que retorna una lista
    public Alumno? BuscarPorNombre(string? nombre) => alumnos.Find(a => a.Nombre == nombre);//Metodo para buscar un alumno por el nombre
    public void EliminarAlumno (Alumno alumno) => alumnos.Remove(alumno);//Metodo para eliminar un alumno (recibe un alumno)
    public void EliminarPosicion (int posicion) => alumnos.RemoveAt(posicion);//Metodo para eliminar de una determinada posicion
}
