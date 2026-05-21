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
    //Campo de una lista de Alumnos
    private List<Alumno> alumnos = new List<Alumno>();

    //Metodo para agregra un alumno a la lista 
    public void AgregarAlumnos (Alumno alumno) => alumnos.Add(alumno);

    //Metodo que retorna una lista
    public List<Alumno> ObtenerAlumnos() => alumnos;

    //Metodo para buscar un alumno por el nombre
    public Alumno? BuscarPorNombre(string? nombre) => alumnos.Find(a => a.Nombre == nombre);

    //Metodo para eliminar un alumno (recibe un alumno)
    public void EliminarAlumno (Alumno alumno) => alumnos.Remove(alumno);

    //Metodo para eliminar de una determinada posicion
    public void EliminarPosicion (int posicion) => alumnos.RemoveAt(posicion);

}
