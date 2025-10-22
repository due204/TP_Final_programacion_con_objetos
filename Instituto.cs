/*
Este archivo es de solo puebas y puede contener varios errores
OJO
*/



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

    public List<Curso> ListaCursos
    {
        get { return listaCursos; }
    }

    // Metodos
    public bool InscribirAlumnoEnCurso()
    {
        Console.Write("Ingrese el legajo del alumno a inscribir: ");
        int legajo;
        if (!int.TryParse(Console.ReadLine(), out legajo) || legajo <= 0)
        {
            Console.WriteLine("El legajo debe ser un nUmero mayor a 0.");
            return false;
        }

        // Buscamos el alumno
        Alumno alumnoEncontrado = null;
        foreach (Alumno alumno in listaAlumnos)
        {
            if (alumno.Legajo == legajo)
            {
                alumnoEncontrado = alumno;
                break;
            }
        }

        if (alumnoEncontrado == null)
        {
            Console.WriteLine("No se encontrO un alumno con ese legajo.");
            Console.Write("¿Desea registrar un nuevo alumno? (s/n): ");
            string respuesta = Console.ReadLine() ?? "n";
            if (respuesta.ToLower() == "s")
            {
                Console.Write("Ingrese el nombre del alumno: ");
                string nombre = Console.ReadLine() ?? "";
                Console.Write("Ingrese el apellido del alumno: ");
                string apellido = Console.ReadLine() ?? "";
                Console.Write("Ingrese la edad del alumno: ");
                int edad;
                if (!int.TryParse(Console.ReadLine(), out edad) || edad <= 0 || nombre == "" || apellido == "")
                {
                    Console.WriteLine("Datos invalidos. No se pudo registrar el alumno.");
                    return false;
                }
                return false;
            }
        }

        // Mostrar cursos disponibles
        Console.WriteLine("\nCursos disponibles:");
        for (int i = 0; i < listaCursos.Count; i++)
        {
            Console.WriteLine($"{(i + 1):D2} {listaCursos[i].Nombre}");
        }

        Console.Write("\nIngrese el nUmero del curso al que desea inscribirse: ");
        int numeroCurso;
        if (!int.TryParse(Console.ReadLine(), out numeroCurso) ||
            numeroCurso < 1 || numeroCurso > listaCursos.Count)
        {
            Console.WriteLine("Número de curso inválido.");
            return false;
        }

        // Seleccionar curso
        Curso cursoSeleccionado = listaCursos[numeroCurso - 1];

        try
        {
            cursoSeleccionado.AgregarAlumnoCurso(alumnoEncontrado);
            Console.WriteLine("Alumno inscripto correctamente en el curso '" + cursoSeleccionado.Nombre + "'.");
            return true;
        }
        catch (CupoLlenoException ex)
        {
            Console.WriteLine("No se pudo inscribir al alumno: " + ex.Message);
            return false;
        }
    }


    public bool EliminarAlumnoDeCurso()
    {
        // Solicito legajo
        Console.WriteLine("Ingrese el legajo del alumno a eliminar:");
        int legajo = int.Parse(Console.ReadLine() ?? "0");

        if (legajo <= 0)
        {
            throw new NumeroNegativoException("El legajo debe ser un numero mayor a 0.");
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

        // Creo los alumnos
        Alumno alumno1 = new Alumno("Juan", "Perez", 20, 1001);
        Alumno alumno2 = new Alumno("Maria", "Gomez", 22, 1002);
        Alumno alumno3 = new Alumno("Luis", "Lopez", 19, 1003);

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

        // Agrego los alumnos a la lista
        listaAlumnos.Add(alumno1);
        listaAlumnos.Add(alumno2);
        listaAlumnos.Add(alumno3);

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
    }

}
        
