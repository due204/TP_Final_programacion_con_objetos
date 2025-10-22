using System;
using System.Collections.Generic;
using System.Linq;


namespace TP_Programacion_Objetos;

public class Alumno : Persona
{
    // Atributos
    private List<Curso> cursos;
    private Dictionary<string, double> notas;
    private int legajo;

    // Getters y Setters de los atributos
    public List<Curso> Cursos
    {
        get { return cursos; }
        set { cursos = value; }
    }
    public Dictionary<string, double> Notas
    {
        get { return notas; }
        set { notas = value; }
    }
    public int Legajo
    {
        get { return legajo; }
        set { 
            if (value <= 0)
            {
                throw new LegajoNegativoException("El legajo debe ser un numero positivo.");
            }
            legajo = value;
         }
    }

    // Metodos de la clase alumno
    // Calcular el promedio de las notas del alumno
    public double Promedio()
    {
        // Si no tiene notas o notas es null el promedio es 0
        if (notas == null || notas.Count == 0)
        {
            return 0;
        }
        else
        {
            // Average es un metodo que calcula el promedio
            return notas.Values.Average();
        }
    }


    // Constructor parametrizado
    public Alumno(string nombre, string apellido, int edad, int legajo) : base(nombre, apellido, edad)
    {
        this.Legajo = legajo;
        this.cursos = new List<Curso>();
        this.notas = new Dictionary<string, double>();
    }


}