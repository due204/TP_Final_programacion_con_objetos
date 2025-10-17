using System;

namespace TP_Programacion_Objetos;

public class Persona
{
    // Atributos
    protected string nombre;
    protected string apellido;
    protected int edad;

    // Getters y Setters de los atributos
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public string Apellido
    {
        get { return apellido; }
        set { apellido = value; }
    }

    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }

    // La clase persona no tiene metodos especificos

    // Constructor parametrizado
    public Persona(string nombre, string apellido, int edad)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
    }
}