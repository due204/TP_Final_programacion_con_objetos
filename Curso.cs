using System;
using System.Collections.Generic;

namespace TP_Programacion_Objetos;

public class Curso
{
    // Atributos
    private string nombreCurso;
    private Docente docenteACargo;
    private int cupoMaximoAlumnos;
    private List<Alumno> alumnos;

    // Getters y Setters de los atributos

    public string Nombre
    {
        get { return nombreCurso; }
        set { nombreCurso = value; }
    }

    public Docente Docente
    {
        get { return docenteACargo; }
        set { docenteACargo = value; }
    }

    public int CupoMaximoAlumnos
    {
        get { return cupoMaximoAlumnos; }
        set { cupoMaximoAlumnos = value; }
    }

    public List<Alumno> Alumnos
    {
        get { return alumnos; }
    }

    // Metodos de la clase curso
    public bool AgregarAlumnoCurso(Alumno alumno)
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
        if (alumnos.Count >= cupoMaximoAlumnos)
        {
            // Si el cupo está lleno lanzo la excepcion
            throw new CupoLlenoException("El cupo del curso está lleno.");
        }
        // Si pasa todas las verificaciones lo agrego
        alumnos.Add(alumno);
        return true;
    }

    // Eliminr un alumno del curso por el legajo
    public bool EliminarAlumnoCurso(Alumno alumno)
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

    public bool RegistrarNotaCurso(Alumno alumno, double nota)
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
        alumno.Notas[nombreCurso] = nota;
        return true;
    }

    public double CalcularPromedioCurso(Alumno alumno)
    {
        // Verifico que alumno no sea nulo
        if (alumno == null)
        {
            // Si el alumno es nulo retorno -1.0 para avisar que es nulo
            return -1.0;
        }

        double suma = 0.0;
        int cuenta = 0;

        for (int i = 0; i < alumnos.Count; i++)
        {
            Alumno a = alumnos[i];
            // ContainsKey comprueba si un Dictionary contiene una clave dada y devuelve true o false
            if (a.Notas != null && a.Notas.ContainsKey(nombreCurso))
            {
                suma += a.Notas[nombreCurso];
                cuenta++;
            }
        }
        double promedio = suma / cuenta;
        return promedio;
    }

    public List<Curso> CursosDadosPorUnDocente(List<Curso> listaCursos, Docente docente)
    {
        List<Curso> cursosDelDocente = new List<Curso>();

        for (int i = 0; i < listaCursos.Count; i++)
        {
            if (listaCursos[i].Docente == docente)
            {
                cursosDelDocente.Add(listaCursos[i]);
            }
        }

        return cursosDelDocente;
    }


    // Constructor
    public Curso(string nombre, Docente docente, int maxAlumnos)
    {
        this.nombreCurso = nombre;
        this.docenteACargo = docente;
        this.cupoMaximoAlumnos = maxAlumnos;
        this.alumnos = new List<Alumno>();
    }  

}
