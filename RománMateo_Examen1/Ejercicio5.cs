using System;

class Estudiante
{
    // Propiedades de la clase Estudiante
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }

    // M�todo para mostrar la informaci�n del estudiante
    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: {0}, Edad: {1}, Calificaci�n: {2}", Nombre, Edad, Calificacion);
    }
}

class EstudianteGraduado : Estudiante
{
    // Nueva propiedad para la clase EstudianteGraduado
    public string Titulo { get; set; }
}

class Program
{
    static void Main()
    {
        // Crear un objeto de tipo EstudianteGraduado
        EstudianteGraduado graduado1 = new EstudianteGraduado
        {
            Nombre = "Ana",
            Edad = 25,
            Calificacion = 92.0,
            Titulo = "Licenciatura en Inform�tica"
        };

        // Utilizar el m�todo MostrarInformacion de la clase base para mostrar la informaci�n del estudiante graduado
        graduado1.MostrarInformacion();
        Console.WriteLine("T�tulo obtenido: {0}", graduado1.Titulo);
    }
}