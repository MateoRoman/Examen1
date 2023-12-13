using System;

class Estudiante
{
    // Propiedades de la clase Estudiante
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }
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

        // Imprimir en la consola la información del estudiante
        Console.WriteLine("Nombre: {0}, Edad: {1}, Calificación: {2}", estudiante1.Nombre, estudiante1.Edad, estudiante1.Calificacion);
    }
}