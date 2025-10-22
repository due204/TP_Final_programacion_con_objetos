using System;

/*

En esta parte se definen las excepciones personalizadas que se utilizaran en el proyecto.
Originalmente se pidio la excepcion CupoLlenoException pero se agrego otra para manejar legajos negativos.

*/

namespace TP_Programacion_Objetos;

public class CupoLlenoException : Exception
{
    public CupoLlenoException(string message) : base(message)
    {
    }

}

public class LegajoNegativoException : Exception
{
    public LegajoNegativoException(string message) : base(message)
    {
    }

}