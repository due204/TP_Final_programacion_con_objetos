using System;

namespace TP_Programacion_Objetos;

public class Instituto
{

    // Atributos
    private string nombreDeLaInstitucion;
    private List<Docente> listaDocente;
    private List<Alumno> listaAlumnos;
    private List<Curso> listaCursos;

    // Propiedades

    public string NombreDeLaInstitucion
    {
        get { return nombreDeLaInstitucion; }
    }

    // Metodos
    public bool InscribirAlumnoEnCurso()
    {
        Console.WriteLine("Ingrese el legajo del alumno a inscribir:");
        // ?? Es el operador de fusion nula
        // Si el valor de la izquierda es null asigna el valor de la derecha
        int legajo = int.Parse(Console.ReadLine() ?? "0");

        if (legajo <= 0)
        {
            throw new LegajoNegativoException("El legajo debe ser un numero mayor a 0.");
        }

        // Busco el alumno en la lista de alumnos
        foreach (Alumno alumno in listaAlumnos)
        {
            if (alumno.Legajo == legajo)
            {
                Console.WriteLine("Ingrese el nombre del curso al que desea inscribirse:");
                string nombreCurso = Console.ReadLine() ?? "";

                // Busco el curso en la lista de cursos
                foreach (Curso curso in listaCursos)
                {
                    if (curso.Nombre == nombreCurso)
                    {
                        try
                        {
                            curso.AgregarAlumno(alumno);
                            Console.WriteLine("Alumno inscripto correctamente en el curso");
                            return true;
                        }
                        catch (CupoLlenoException ex)
                        {
                            Console.WriteLine("No se pudo inscribir al alumno: " + ex.Message);
                            return false;
                        }
                    }
                }
                Console.WriteLine("Curso no encontrado.");
                return false;
            }
        }




        return false;




    }

    public bool EliminarAlumnoDeCurso()
    {
        // Solicito legajo
        Console.WriteLine("Ingrese el legajo del alumno a eliminar:");
        int legajo = int.Parse(Console.ReadLine() ?? "0");

        if (legajo <= 0)
        {
            throw new LegajoNegativoException("El legajo debe ser un numero mayor a 0.");
        }

        // Falta toda la logica para eliminar el alumno del curso
        

        return false;
    }

    // Constructor
    public Instituto(string nombreInstitucion)
    {
        nombreDeLaInstitucion = nombreInstitucion;

        listaDocente = new List<Docente>();//inicializa lista
        listaAlumnos = new List<Alumno>();//inicializa lista
        listaCursos = new List<Curso>();//inicializa lista

        // Creo los docentes
        Docente docente1 = new Docente("Flavia", "Choren", 36, 1000);
        Docente docente2 = new Docente("Juan", "Garcia", 39, 1000);
        Docente docente3 = new Docente("Pedro", "Paso", 30, 1000);
        Docente docente4 = new Docente("Carolina", "Carrazco", 36, 1000);
        Docente docente5 = new Docente("Emiliano", "Segura", 35, 1000);
        Docente docente6 = new Docente("Vicente", "Arroyo", 49, 1000);
        Docente docente7 = new Docente("Daminan", "Pugliese", 28, 1000);
        Docente docente8 = new Docente("Patricia", "Garay", 60, 1000);
        Docente docente9 = new Docente("Noelia", "Basan", 36, 1000);
        Docente docente10 = new Docente("Sergio", "Besares", 37, 1000);

        // Creo los cursos
        Curso ProgramacionconObejetos = new Curso("Programacion con Objetos", docente1, 5);
        Curso Algebra = new Curso("Algebra I", docente2, 3);
        Curso MatematicaDiscreta = new Curso("Matematica discreta", docente3, 10);
        Curso BaseDatos = new Curso("Base de datos I", docente4, 7);
        Curso Historia = new Curso("Problematica de la hitoria argentina", docente5, 4);
        Curso TallerIngenieria = new Curso("Taller de ingeniaria", docente6, 11);
        Curso Ingles = new Curso("Ingles tecnico I", docente7, 9);
        Curso Electronica = new Curso("Electronica digital y microcontroladores", docente8, 2);
        Curso Calculo = new Curso("Calculo I", docente9, 10);
        Curso SistemasOperativos = new Curso("Sistemas operativos I", docente10, 9);

        // Agrego los cursos a la lista
        listaCursos.Add(ProgramacionconObejetos);
        listaCursos.Add(Algebra);
        listaCursos.Add(MatematicaDiscreta);
        listaCursos.Add(BaseDatos);
        listaCursos.Add(Historia);
        listaCursos.Add(TallerIngenieria);
        listaCursos.Add(Ingles);
        listaCursos.Add(Electronica);
        listaCursos.Add(Calculo);
        listaCursos.Add(SistemasOperativos);

        // Agrego los docentes a la lista
        listaDocente.Add(docente1);
        listaDocente.Add(docente2);
        listaDocente.Add(docente3);
        listaDocente.Add(docente4);
        listaDocente.Add(docente5);
        listaDocente.Add(docente6);
        listaDocente.Add(docente7);
        listaDocente.Add(docente8);
        listaDocente.Add(docente9);
        listaDocente.Add(docente10);

    }

}
        
