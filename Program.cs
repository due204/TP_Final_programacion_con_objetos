/*
 * Creado por SharpDevelop.
 * Usuario: nuevo2
 * Fecha: 16/10/2025
 * Hora: 09:27
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
            Instituto miInstituto = new Instituto();
            int opcion = 0;//variable de opcion fuera del bucle

            do
            {
                MostrarMenu();//se llama a la funcion mostrar menu
                
                int opcionSeleccionada = 0;//variable de opcion dentro del bucle
                bool entradaValida = false;//variable booleana para determinar si el ingreso es correcto

                
                for (int intento = 1; intento <= 3; intento++)//bucle para limitar los intentos de ingreso a 3
                {
                    string entrada = Console.ReadLine();//variable de ingreso de menu
                    
                    if (int.TryParse(entrada, out opcionSeleccionada))//verifica si entrada es es int
                    {
                        
                        if (opcionSeleccionada >= 1 && opcionSeleccionada <= 10)//si es un número, verifica si esta en el rango valido
                        {
                            entradaValida = true; //la entrada es válida
                            break; // Salimos del bucle for
                        }
                    }                    
                    if (intento < 3)//si la entrada no era un numero o estaba fuera de rango, utiliza este condicional
                    {
                         Console.WriteLine("Error: Opción no válida. Por favor, ingrese un número entre 1 y 10.");//muetra mensaje en pantalla
                         Console.Write("Seleccione una opción: ");//muetra mensaje en pantalla
                    }
                }

                
                if (!entradaValida)//si despues de 3 intentos la entrada sigue sin ser válida muestra mensaje y cierra el programa
                {
                    Console.WriteLine("\nSe superó el número de intentos. El programa se cerrará.");
                    opcion = 10; //se asigna la opcion de salida para terminar el programa
                }
                else
                {
                     opcion = opcionSeleccionada; //si fue valida la variable opcion toma se ese valor para ejecutar el menu
                }

               
                if (entradaValida)//si la variable entradaValida es true salio del bucle y ejecuta el switch
                {
                    switch (opcion)//opcion tomo el valor de ingreso valido
                    {
                        case 1:
                            if (ConfirmarEleccion("Inscribir alumno en un curso"))//se llama a la funcion confirmarEleccion
                            {
                                miInstituto.InscribirAlumnoEnCurso();
                                Console.WriteLine("\nPresione una tecla para continuar...");
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            if (ConfirmarEleccion("Eliminar alumno de un curso"))//se llama a la funcion confirmarEleccion
                            {
                                miInstituto.EliminarAlumnoDeCurso();
                                Console.WriteLine("\nPresione una tecla para continuar...");
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            if (ConfirmarEleccion("Asignar Docente a un curso"))//se llama a la funcion confirmarEleccion
                            {
                                miInstituto.AsignarDocenteACurso();
                                Console.WriteLine("\nPresione una tecla para continuar...");
                                Console.ReadKey();
                            }
                            break;
                        case 4:
                            if (ConfirmarEleccion("Registrar nota"))//se llama a la funcion confirmarEleccion
                            {
                                miInstituto.RegistrarNota();
                                Console.WriteLine("\nPresione una tecla para continuar...");
                                Console.ReadKey();
                            }
                            break;
                        case 5:
                            if (ConfirmarEleccion("Mostrar alumnos por curso"))//se llama a la funcion confirmarEleccion
                            {
                                miInstituto.ListarAlumnosPorCurso();
                                Console.WriteLine("\nPresione una tecla para continuar...");
                                Console.ReadKey();
                            }
                            break;
                        case 6:
                            if (ConfirmarEleccion("Lista de cursos"))//se llama a la funcion confirmarEleccion
                            {
                                miInstituto.ListarCursos();
                                Console.WriteLine("\nPresione una tecla para continuar...");
                                Console.ReadKey();
                            }
                            break;
                        case 7:
                            if (ConfirmarEleccion("Lista de alumnos inscriptos en más de un curso"))//se llama a la funcion confirmarEleccion
                            {
                                miInstituto.ListarAlumnosMultiplesCursos();
                                Console.WriteLine("\nPresione una tecla para continuar...");
                                Console.ReadKey();
                            }
                            break;
                        case 8:
                            if (ConfirmarEleccion("Transferir un alumno de un curso a otro"))//se llama a la funcion confirmarEleccion
                            {
                                miInstituto.TransferirAlumnoDeCurso();
                                Console.WriteLine("\nPresione una tecla para continuar...");
                                Console.ReadKey();
                            }
                            break;
                        case 9:
                            if (ConfirmarEleccion("Mostrar el promedio general de notas de cada curso"))//se llama a la funcion confirmarEleccion
                            {
                                miInstituto.MostrarPromedioGeneralPorCurso();
                                Console.WriteLine("\nPresione una tecla para continuar...");
                                Console.ReadKey();
                            }
                            break;
                        case 10:
                            if (ConfirmarEleccion("Salir"))//se llama a la funcion confirmarEleccion
                            	{
                            	Console.WriteLine("\nGracias por usar el sistema.");
                            	}
                            else
                            	{
                            	opcion=0;//asigna valor de 0 a opcion para que no se cierre por while
                            	}                                       	
                            break;
                       
                    }
                }

            } while (opcion != 10);//mientras opcion sea distinto de 10 sigue en el menu

            Console.WriteLine("\nEl programa ha finalizado. Presione cualquier tecla para cerrar la ventana.");
            Console.ReadKey();
        }

        static void MostrarMenu()//funcion mostrar menu
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
        
        static bool ConfirmarEleccion(string eleccion)//funcion para confirmar eleccion
        {
            for (int intento = 1; intento <= 3; intento++)//bucle para permitir hasta 3 intentos
            {
                Console.WriteLine("\nUsted eligió: "+eleccion);
                Console.WriteLine("¿Desea continuar? (Y/N)");
                string confirmacion = Console.ReadLine().ToUpper();//convierte en mayuscula para no romper

                if (confirmacion == "Y")
                {
                    return true;
                }
                if (confirmacion == "N")
                {
                    Console.WriteLine("Acción cancelada. Volviendo al Menú Principal...");
                    return false;
                }
                
                Console.WriteLine("Opción no válida. Intente nuevamente.");
            }

            Console.WriteLine("Se superó el número de intentos. Volviendo al Menú Principal...");
            return false;
        }
    }
}