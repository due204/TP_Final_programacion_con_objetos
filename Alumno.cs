using System;
using System.Collections.Generic;


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
        set { legajo = value; }
    }

    // Metodos de la clase alumno
    public void Inscribirse()
    {
        // codigo para inscribirse en un curso
    }

    public void Promedio()
    {
        // codigo para el promedio del alumno
    }



    // Constructor parametrizado
    public Alumno(string nombre, string apellido, int edad, int legajo) : base(nombre, apellido, edad)
    {
        this.legajo = legajo;
        this.cursos = new List<Curso>();
        this.notas = new Dictionary<string, double>();
    }


}