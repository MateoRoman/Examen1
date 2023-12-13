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

class Program
{
    static void Main()
    {
        // Crear un objeto de tipo Estudiante
        Estudiante estudiante1 = new Estudiante
        {
            Nombre = "Juan",
            Edad = 20,
            Calificacion = 85.5
        };

        // Llamar al m�todo MostrarInformacion para el objeto estudiante1
        estudiante1.MostrarInformacion();
    }
}