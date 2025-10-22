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
    private int dni;

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
        set
        {
            if (value <= 0)
            {
                throw new NumeroNegativoException("El legajo debe ser un numero positivo.");
            }
            legajo = value;
        }
    }
    
    public int Dni
    {
        get { return dni; }
        set
        {
            if (value <= 0)
            {
                throw new NumeroNegativoException("El dni debe ser un numero positivo.");
            }
            dni = value;
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
