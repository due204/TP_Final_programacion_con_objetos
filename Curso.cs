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
        // Verifico que alumno no sea nulo
        if (alumno == null)
        {
            return false;
        }

        // Verifico si ya está inscrito por legajo
        for (int i = 0; i < alumnos.Count; i++)
        {
            if (alumnos[i].Legajo == alumno.Legajo)
            {
                return false;
            }
        }

        // Verificar cupo
        if (alumnos.Count >= maxAlumnos)
        {
            // Si el cupo está lleno lanzo la excepcion
            throw new CupoLlenoException("El cupo del curso está lleno.");
        }
        // Si pasa todas las verificaciones lo agrego
        alumnos.Add(alumno);
        return true;
    }

    // Eliminr un alumno del curso por el legajo
    public bool EliminarAlumno(Alumno alumno)
    {
        // Verifico que alumno no sea nulo
        if (alumno == null)
        {
            return false;
        }

        for (int i = alumnos.Count - 1; i >= 0; i--)
        {
            if (alumnos[i].Legajo == alumno.Legajo)
            {
                alumnos.RemoveAt(i);
                return true;
            }
        }
        return false;
    }

    public bool RegistrarNota(Alumno alumno, double nota)
    {
        // Verifico que alumno no sea nulo
        if (alumno == null)
        {
            return false;
        }

        // Verifico que el alumno este inscripto en este curso por por legajo
        bool encontrado = false;
        for (int i = 0; i < alumnos.Count; i++)
        {
            if (alumnos[i].Legajo == alumno.Legajo)
            {
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            return false;
        }

        // Me aseguro que la colección de notas exista
        if (alumno.Notas == null)
        {
            alumno.Notas = new Dictionary<string, double>();
        }

        // Valido rango de notas
        alumno.Notas[nombre] = nota;
        return true;
    }

    public double CalcularPromedio()
    {
        double suma = 0.0;
        int cuenta = 0;

        for (int i = 0; i < alumnos.Count; i++)
        {
            Alumno a = alumnos[i];
            // ContainsKey comprueba si un Dictionary contiene una clave dada y devuelve true o false
            if (a.Notas != null && a.Notas.ContainsKey(nombre))
            {
                suma += a.Notas[nombre];
                cuenta++;
            }
        }
        double promedio = suma / cuenta;
        return promedio;
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