using System;
using System.Collections.Generic;

namespace TP_Programacion_Objetos;

public class Curso
{
    // Atributos
    private string nombre;
    private Docente docente;
    private int maxAlumnos;
    private List<Alumno> alumnos;

    // Getters y Setters de los atributos

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public Docente Docente
    {
        get { return docente; }
        set { docente = value; }
    }

    public int MaxAlumnos
    {
        get { return maxAlumnos; }
        set { maxAlumnos = value; }
    }

    public List<Alumno> Alumnos
    {
        get { return alumnos; }
    }

    // Metodos de la clase curso
    public bool AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno);
        return true;

    }

    // Eliminr un alumno del curso por el legajo
    public void EliminarAlumno(Alumno alumno)
    {
        foreach (Alumno a in alumnos)
        {
            if (a.Legajo == alumno.Legajo)
            {
                alumnos.Remove(a);
                break;
            }
        }

    }

    public void RegistrarNota(Alumno alumno, double nota)
    {

    }
    
    public void CalcularPromedio()
    {

    }

    // Constructor
    public Curso(string nombre, Docente docente, int maxAlumnos)
    {
        this.nombre = nombre;
        this.docente = docente;
        this.maxAlumnos = maxAlumnos;
        this.alumnos = new List<Alumno>();
    }  

}