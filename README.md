# TP_Final_programacion_con_objetos
Trabajo final de la materia Programacion con objetos. Lenguaje usado C#
/*
 * Creado por SharpDevelop.
 * Usuario: nuevo2
 * Fecha: 16/10/2025
 * Hora: 17:38
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace TP_final_obejetos_de_programación
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Instituto miInstituto = new Instituto();

            int opcion = 0;
            do
            {
                MostrarMenu();
                string entrada = Console.ReadLine();
                
                
                int opcionSeleccionada = 0; //Inicializamos la variable para evitar errores de compilación
                
                while (!int.TryParse(entrada, out opcionSeleccionada))
                {
                    Console.WriteLine("Error: Por favor, ingrese un número válido.");
                    Console.Write("Seleccione una opción: ");
                    entrada = Console.ReadLine();
                }
                
                opcion = opcionSeleccionada;
                
                switch (opcion)
                {
                    case 1:
                        string confirmacion1 = "";
                        for (int intento = 1; intento <= 3; intento++)
                        {
                            Console.WriteLine("\nUsted eligió: Inscribir alumno en un curso");
                            Console.WriteLine("¿Desea continuar? (Y/N)");
                            confirmacion1 = Console.ReadLine().ToUpper();
                            if (confirmacion1 == "Y" || confirmacion1 == "N")
                            {
                                break;
                            }
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                        }

                        if (confirmacion1 == "Y")
                        {
                        	Console.WriteLine(" faltan los metodos"); // miInstituto.InscribirAlumnoEnCurso(); El método todavía no está creado
                        }
                        else if (confirmacion1 == "N")
                        {
                            Console.WriteLine("Acción cancelada. Volviendo al Menú Principal...");
                        }
                        else
                        {
                            Console.WriteLine("Se superó el número de intentos. Volviendo al Menú Principal...");
                        }

                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    
                    case 2:
                        string confirmacion2 = "";
                        for (int intento = 1; intento <= 3; intento++)
                        {
                            Console.WriteLine("\nUsted eligió: Eliminar alumno de un curso");
                            Console.WriteLine("¿Desea continuar? (Y/N)");
                            confirmacion2 = Console.ReadLine().ToUpper();
                            if (confirmacion2 == "Y" || confirmacion2 == "N")
                            {
                                break;
                            }
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                        }

                        if (confirmacion2 == "Y")
                        {
                            Console.WriteLine(" faltan los metodos");//miInstituto.EliminarAlumnoDeCurso(); El método todavía no está creado
                        }
                        else if (confirmacion2 == "N")
                        {
                            Console.WriteLine("Acción cancelada. Volviendo al menú...");
                        }
                        else
                        {
                            Console.WriteLine("Se superó el número de intentos. Volviendo al menú...");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    
                    case 3:
                        string confirmacion3 = "";
                        for (int intento = 1; intento <= 3; intento++)
                        {
                            Console.WriteLine("\nUsted eligió: Asignar Docente a un curso");
                            Console.WriteLine("¿Desea continuar? (Y/N)");
                            confirmacion3 = Console.ReadLine().ToUpper();
                            if (confirmacion3 == "Y" || confirmacion3 == "N")
                            {
                                break;
                            }
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                        }

                        if (confirmacion3 == "Y")
                        {
                            Console.WriteLine(" faltan los metodos");//miInstituto.AsignarDocenteACurso();El método todavía no está creado
                        }
                        else if (confirmacion3 == "N")
                        {
                            Console.WriteLine("Acción cancelada. Volviendo al menú...");
                        }
                        else
                        {
                            Console.WriteLine("Se superó el número de intentos. Volviendo al menú...");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                        
                    case 4:
                        string confirmacion4 = "";
                        for (int intento = 1; intento <= 3; intento++)
                        {
                            Console.WriteLine("\nUsted eligió: Registrar nota");
                            Console.WriteLine("¿Desea continuar? (Y/N)");
                            confirmacion4 = Console.ReadLine().ToUpper();
                            if (confirmacion4 == "Y" || confirmacion4 == "N")
                            {
                                break;
                            }
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                        }

                        if (confirmacion4 == "Y")
                        {
                            Console.WriteLine(" faltan los metodos");//miInstituto.RegistrarNota();El método todavía no está creado
                        }
                        else if (confirmacion4 == "N")
                        {
                            Console.WriteLine("Acción cancelada. Volviendo al menú...");
                        }
                        else
                        {
                            Console.WriteLine("Se superó el número de intentos. Volviendo al menú...");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                        
                    case 5:
                        string confirmacion5 = "";
                        for (int intento = 1; intento <= 3; intento++)
                        {
                            Console.WriteLine("\nUsted eligió: Lista de alumnos por curso");
                            Console.WriteLine("¿Desea continuar? (Y/N)");
                            confirmacion5 = Console.ReadLine().ToUpper();
                            if (confirmacion5 == "Y" || confirmacion5 == "N")
                            {
                                break;
                            }
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                        }

                        if (confirmacion5 == "Y")
                        {
                            Console.WriteLine(" faltan los metodos");//miInstituto.ListarAlumnosPorCurso();El método todavía no está creado
                        }
                        else if (confirmacion5 == "N")
                        {
                            Console.WriteLine("Acción cancelada. Volviendo al menú...");
                        }
                        else
                        {
                            Console.WriteLine("Se superó el número de intentos. Volviendo al menú...");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                        
                    case 6:
                        string confirmacion6 = "";
                        for (int intento = 1; intento <= 3; intento++)
                        {
                            Console.WriteLine("\nUsted eligió: Lista de cursos");
                            Console.WriteLine("¿Desea continuar? (Y/N)");
                            confirmacion6 = Console.ReadLine().ToUpper();
                            if (confirmacion6 == "Y" || confirmacion6 == "N")
                            {
                                break;
                            }
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                        }

                        if (confirmacion6 == "Y")
                        {
                            Console.WriteLine(" faltan los metodos");//miInstituto.ListarCursos();El método todavía no está creado
                        }
                        else if (confirmacion6 == "N")
                        {
                            Console.WriteLine("Acción cancelada. Volviendo al menú...");
                        }
                        else
                        {
                            Console.WriteLine("Se superó el número de intentos. Volviendo al menú...");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                        
                    case 7:
                        string confirmacion7 = "";
                        for (int intento = 1; intento <= 3; intento++)
                        {
                            Console.WriteLine("\nUsted eligió: Lista de alumnos inscriptos en más de un curso");
                            Console.WriteLine("¿Desea continuar? (Y/N)");
                            confirmacion7 = Console.ReadLine().ToUpper();
                            if (confirmacion7 == "Y" || confirmacion7 == "N")
                            {
                                break;
                            }
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                        }

                        if (confirmacion7 == "Y")
                        {
                            Console.WriteLine(" faltan los metodos");//miInstituto.ListarAlumnosMultiplesCursos();El método todavía no está creado
                        }
                        else if (confirmacion7 == "N")
                        {
                            Console.WriteLine("Acción cancelada. Volviendo al menú...");
                        }
                        else
                        {
                            Console.WriteLine("Se superó el número de intentos. Volviendo al menú...");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                        
                    case 8:
                        string confirmacion8 = "";
                        for (int intento = 1; intento <= 3; intento++)
                        {
                            Console.WriteLine("\nUsted eligió: Transferir un alumno de un curso a otro");
                            Console.WriteLine("¿Desea continuar? (Y/N)");
                            confirmacion8 = Console.ReadLine().ToUpper();
                            if (confirmacion8 == "Y" || confirmacion8 == "N")
                            {
                                break;
                            }
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                        }

                        if (confirmacion8 == "Y")
                        {
                        	Console.WriteLine(" faltan los metodos");//miInstituto.TransferirAlumnoDeCurso();El método todavía no está creado
                        }
                        else if (confirmacion8 == "N")
                        {
                            Console.WriteLine("Acción cancelada. Volviendo al menú...");
                        }
                        else
                        {
                            Console.WriteLine("Se superó el número de intentos. Volviendo al menú...");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                        
                    case 9:
                        string confirmacion9 = "";
                        for (int intento = 1; intento <= 3; intento++)
                        {
                            Console.WriteLine("\nUsted eligió: Mostrar el promedio general de notas de cada curso");
                            Console.WriteLine("¿Desea continuar? (Y/N)");
                            confirmacion9 = Console.ReadLine().ToUpper();
                            if (confirmacion9 == "Y" || confirmacion9 == "N")
                            {
                                break;
                            }
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                        }

                        if (confirmacion9 == "Y")
                        {
                            Console.WriteLine(" faltan los metodos");// miInstituto.MostrarPromedioGeneralPorCurso();El método todavía no está creado
                        }
                        else if (confirmacion9 == "N")
                        {
                            Console.WriteLine("Acción cancelada. Volviendo al menú...");
                        }
                        else
                        {
                            Console.WriteLine("Se superó el número de intentos. Volviendo al menú...");
                        }
                        Console.WriteLine("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                        
                    case 10:
                        Console.WriteLine("\nGracias por usar el sistema.");
                        break;
                        
                    default:
                        Console.WriteLine("\nOpción no válida. Por favor, intente de nuevo.");
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } 
            while (opcion != 10);

            Console.WriteLine("\nEl programa ha finalizado. Presione cualquier tecla para cerrar la ventana.");
            Console.ReadKey();
        }

        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("\n \t\tMENÚ DE OPCIONES ");
            Console.WriteLine("\t1- Inscribir alumno en un curso");
            Console.WriteLine("\t2- Eliminar alumno de un curso.");
            Console.WriteLine("\t3- Asignar Docente a un curso");
            Console.WriteLine("\t4- Registrar nota");
            Console.WriteLine("\t5- Mostrar alumnos por curso,");
            Console.WriteLine("\t6- Lista de cursos");
            Console.WriteLine("\t7- Lista de alumnos inscriptos en más de un curso.");
            Console.WriteLine("\t8- Transferir un alumno de un curso a otro");
            Console.WriteLine("\t9- Mostrar el promedio general de notas de cada curso.");
            Console.WriteLine("\t10- Salir");
            Console.Write("Seleccione una opción: ");
        }
    }
}

