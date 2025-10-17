using System;
using System.Collections.Generic;


namespace TP_Programacion_Objetos;


public class Docente : Persona
{
    // Atributos
    private List<Curso> cursosDado;
    private double sueldo;

    // Getters y Setters de los atributos
    public List<Curso> CursosDado
    {
        get { return cursosDado; }
        set { cursosDado = value; }
    }

    public double Sueldo
    {
        get { return sueldo; }
        set { sueldo = value; }
    }

    // Metodos de la clase docente
    public void CursosDados()
    {
        // codigo para mostrar los cursos dados por el docente
    }

    // Constructor parametrizado
    public Docente(string nombre, string apellido, int edad, double sueldo) : base(nombre, apellido, edad)
    {
        this.sueldo = sueldo;
        this.cursosDado = new List<Curso>();
    }
}