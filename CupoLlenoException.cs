using System;

namespace TP_Programacion_Objetos;

public class CupoLlenoException : Exception
{
    public CupoLlenoException() : base("El cupo del curso está lleno.")
    {
    }

}