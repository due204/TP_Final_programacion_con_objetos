/*
 * Creado por SharpDevelop.
 * Usuario: nuevo2
 * Fecha: 16/10/2025
 * Hora: 09:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace TP_final_obejetos_de_programación
{
	/// <summary>
	/// Description of Instituto.
	/// </summary>
	public class Instituto
	{
		
		// Atributos
		private List<Docente> listaDocente;
		private List<Alumno> listaAlumnos;
		private List<Curso> listaCursos;

		// Constructor
		public Instituto()
		{
			this.listaDocente = new List<Docente>();//inicializa lista
			this.listaAlumnos = new List<Alumno>();//inicializa lista
			this.listaCursos = new List<Curso>();//inicializa lista
			
			//constructores parametrizados
			Curso ProgramacionconObejetos = new Curso("Programacion con Objetos", "Nazareno Figueroa", 5); //cupo para 5, ejemplos de prueba
			Curso AlgebraI = new Curso("Algebra I", "Juan Pérez", 3); //cupo para 3, ejemplos de prueba
			this.listaCursos.Add(ProgramacionconObejetos);//se agrega a la lista
			this.listaCursos.Add(AlgebraI);//se agrega a la lista
			Docente docente1= new Docente("Diego","Luparello","3333333",500000);//ejemplos de prueba
			Docente docente2= new Docente("Fulanito","Cosme","11111111",500000);//ejemplos de prueba
			this.listaDocente.Add(docente1);//se agrega a la lista
			this.listaDocente.Add(docente2);//se agrega a la lista
			docente1.AsignarCurso(ProgramacionconObejetos);//se utilza metodo para asignar curso
			docente2.AsignarCurso(AlgebraI);//se utilza metodo para asignar curso
		}

				//aca empiezan los metodos del menu

						// opcion 1 -inscribir alumno en un curso- 3 pasos .buscar,seleccionar curso, realizar inscripcion
		
		public void InscribirAlumnoEnCurso()//1. Inscribir alumno en un curso. Si el alumno no está registrado en el instituto, se debe dar de alta. Si el curso ya se encuentra lleno, se debe lanzar una excepción(CupoLlenoException).
		{
			Console.WriteLine("\t--- Inscribir Alumno en Curso ---");
			
				//para buscar al alumno
			Console.Write("Ingrese el DNI del alumno: ");
			string dniBuscado = Console.ReadLine();//variable local
			
			Alumno alumnoAInscribir = null; //se inicializa la variable de la clase Alumno en null
			foreach (Alumno alumno in listaAlumnos) //recorre la lista de alumnos
			{
				if (alumno.ObtenerDni() == dniBuscado) //compara el dni, llamando al metodo obtener dni si coincide con el dni ingresado no hace falta inscribirlo 
				{
					alumnoAInscribir = alumno; //si coincide se guarda en la variable
					break; //sale del bucle ya no necesita seguir buscando
				}
			}
			
			if (alumnoAInscribir == null)//si no encuetra el dni en la lista inicia la inscripcion 
			{
				Console.WriteLine("El alumno no esta registrado. Vamos a darle de alta.");
				Console.Write("Nombre: ");
				string nombre = Console.ReadLine();
				Console.Write("Apellido: ");
				string apellido = Console.ReadLine();
				Console.Write("Legajo: ");
				int legajo = int.Parse(Console.ReadLine());

				alumnoAInscribir = new Alumno(nombre, apellido, dniBuscado, legajo);//crea un nuevo elemento
				this.listaAlumnos.Add(alumnoAInscribir);//lo agrega a la lista
				
				
				Console.WriteLine("Alumno " + alumnoAInscribir.ObtenerNombreCompleto() + " registrado con exito");//mensaje en pantalla
			}
			else//sino muestra en pantalla los datos con el metodo obtenernombrecompleto de la clase persona
			{
				
				Console.WriteLine("Alumno encontrado: " + alumnoAInscribir.ObtenerNombreCompleto());
			}

					//seleccionar curso
			if (listaCursos.Count == 0)//si la lista de cursos esta vacia 
			{
				Console.WriteLine("No hay cursos disponibles para inscribir.");
				return;
			}

			Console.WriteLine("\nCursos disponibles:");//si la lista tiene cursos los muestra
			for (int i = 0; i < listaCursos.Count; i++)//recorre la lista 
			{
				
				Console.WriteLine((i + 1) + ". " + listaCursos[i].ObtenerNombre());//muetra en pantalla el nombre de los cursos por medio del metodo
			}

			Console.Write("Seleccione el numero del curso: ");
			int opcionCurso = int.Parse(Console.ReadLine());//define el ingreso de pantalla como variable y verifica que sea numero entero

			if (opcionCurso < 1 || opcionCurso > listaCursos.Count)//condiciones para el ingreso
			{
				Console.WriteLine("Opcion no valida. Por favor, seleccione un numero de la lista.");
				return;
			}

			Curso cursoSeleccionado = listaCursos[opcionCurso - 1];//le asigana el valor seleccionado -1 porque el conteo inicia en 0

			//realiza la inscripcion
			cursoSeleccionado.AgregarAlumno(alumnoAInscribir);//toma el curso con el metodo agregarAlumno y los datos
			alumnoAInscribir.InscribirACurso(cursoSeleccionado);// toma los datos e inscribe con el metodo de la clase curso

			
			Console.WriteLine("\n✅Inscripción exitosa El alumno " + alumnoAInscribir.ObtenerNombreCompleto() + " fue inscripto en el curso de " + cursoSeleccionado.ObtenerNombre() + ".");
			
			
		}

		
									// opcion 2 Eliminar alumno de un curso- 5 pasos
									// buscar alumno, mostrar cursos actuales, seleccionar curso, eliminar curso, verificar si hay que dar de baja
		
		public void EliminarAlumnoDeCurso()//metodo
		{
			Console.WriteLine("\n--- Eliminar Alumno de Curso ---");
			//buscar alumno
			Console.Write("Ingrese el DNI del alumno: ");
			string dniBuscado = Console.ReadLine();

			
			Alumno alumnoEncontrado = null;//se crea una variable dentro del tipo Alumno y se le da valor nulo
			foreach (Alumno alumno in listaAlumnos)//usamos foreach para buscar al alumno en la lista de alumnos
			{
				if (alumno.ObtenerDni() == dniBuscado)//condicion si encuentra con el metodo de la clase persona
				{
					alumnoEncontrado = alumno;
					break;
				}
			}

			
			if (alumnoEncontrado == null)//verifica si encontra al alumno
			{
				Console.WriteLine("❎Error: No se encontró ningun alumno con ese DNI.");
				return; //sale del metodo
			}

			Console.WriteLine("✅Alumno encontrado: " + alumnoEncontrado.ObtenerNombreCompleto());

			//mostrar cursos acutuales
			
			
			List<Curso> cursosDelAlumno = alumnoEncontrado.ObtenerCursosInscritos();//se crea la variable cursosDeAlumno obtenemos la lista de cursos del alumno usando el metodo de la clase Alumno

			if (cursosDelAlumno.Count == 0)//cuenta la lista si es =0 muestra mensaje
			{
				Console.WriteLine("El alumno no está inscripto en ningún curso actualmente.");
				return;
			}

			Console.WriteLine("\nCursos en los que está inscripto:");//muestra los cursos inscriptos por medio de un for
			for (int i = 0; i < cursosDelAlumno.Count; i++)
			{
				Console.WriteLine((i + 1) + " " + cursosDelAlumno[i].ObtenerNombre());//usa el metodo de la clase curso para mostrar los cursos,asignado el valor +1
			}

			//seleccion del curso a eliminar
			Console.Write("Seleccione el numero del curso del que desea eliminarlo: ");
			int opcionCurso = int.Parse(Console.ReadLine());//verifica que sea entero

			if (opcionCurso < 1 || opcionCurso > cursosDelAlumno.Count)//condiciones para seleccion correcta
			{
				Console.WriteLine("Error: Opción no válida.");
				return;
			}

			Curso cursoAEliminar = cursosDelAlumno[opcionCurso - 1];//obtenemos el curso a eliminar

			//realizar la eliminacion
			
			cursoAEliminar.EliminarAlumno(alumnoEncontrado);//quita al alumno del curso
			alumnoEncontrado.QuitarCurso(cursoAEliminar);//quita el curso del alumno

			Console.WriteLine("\t✅Eliminación exitosa El alumno fue quitado del curso " + cursoAEliminar.ObtenerNombre() + ".");

			//verifica si hay que darlo de baja en el instituto
			
			if (alumnoEncontrado.ObtenerCursosInscritos().Count == 0)//cuenta la cantidad si es =0 borra de la lista de alumnos
			{
					this.listaAlumnos.Remove(alumnoEncontrado);
				
				Console.WriteLine("El alumno ya no estaba inscripto en ningun otro curso y ha sido dado de baja del instituto.");
				
			}
		}

		
						//opcion 3. Asignar Docente a un curso (Opcion 3 del menú)
						//4 pasos: seleccionar curso
		
		
		public void AsignarDocenteACurso()
		{
			Console.WriteLine("\n--- Asignar Docente a Curso ---");
			// paso 1 seleccionar curso
			if (listaCursos.Count == 0)//condicon por si no hay cursos registrados
			{
				Console.WriteLine("Error: No hay cursos registrados en el instituto.");
				return;
			}

			Console.WriteLine("Cursos disponibles:");
			for (int i = 0; i < listaCursos.Count; i++)//recorre la lista y muestra en pantalla los nombres de los cursos muestra con su docente actual con el metodo de la clase curso
			{
				Console.WriteLine((i + 1) + ". " + listaCursos[i].ObtenerNombre() + " (Docente actual: " + listaCursos[i].ObtenerDocenteNombre() + ")");
			}
			
			Console.Write("Seleccione el numero del curso: ");
			int opcionCurso = int.Parse(Console.ReadLine());//verifica que sea un entero y que sea valido
			if (opcionCurso < 1 || opcionCurso > listaCursos.Count)
			{
				Console.WriteLine("Error: Opcion no valida.");
				return;
			}
			Curso cursoSeleccionado = listaCursos[opcionCurso - 1];

			//paso 2 seleccionar docente 
			
			Docente docenteNuevo = null; //variable para guardar el docente
			
			Console.WriteLine("\nDocentes disponibles:");
			if (listaDocente.Count == 0)//cuenta la lista de docentes=0 mensaje
			{
				Console.WriteLine("No hay docentes registrados.");
			}
			else//sino 
			{
				for (int i = 0; i < listaDocente.Count; i++)//muestra la lista numerada a partir del 1
				{
					
					Console.WriteLine((i + 1) + ". " + listaDocente[i].ObtenerNombre());//utiliza el metodo obtener nombre de la clase docente
				}
			}
			
			Console.WriteLine("0. Crear un nuevo docente");//como muestra la lista numerada con los docentes existentes agregamos una linea con la opcion 0 para que permita crear un nuevo docente
			Console.Write("Seleccione el docente que desea asignar (o 0 para crear uno): ");
			int opcionDocente = int.Parse(Console.ReadLine());//verifica que el numero sea entero creando la variable

			if (opcionDocente == 0)//si la opcion que elije es crear llama al metodo de la clase instituto
			{
				docenteNuevo = CrearNuevoDocente();
			}
			else if (opcionDocente > 0 && opcionDocente <= listaDocente.Count)//el usuario eligio un docente existente de la lista.
			{
				docenteNuevo = listaDocente[opcionDocente - 1];//restamos 1 para que el indice coincida con la eleccion
			}
			else
			{
				Console.WriteLine("Error: Opción no válida.");
				return;
			}
			
			//paso 3 quitar el docente anterior 
			
			Docente docenteViejo = null;//se crea la variable y se le da valor nulo
			foreach (Docente d in listaDocente)//se busca dentro de la lista de docente
			{
				if (d.ObtenerCursosDados().Contains(cursoSeleccionado))//si encuentra dentro de la lista al curso seleccionado quiebra
				{
					docenteViejo = d;
					break;
				}
			}

			if (docenteViejo != null)//si es distinto de nullo llama al metodo de la clase curso y lo borra del curso
			{
				docenteViejo.QuitarCurso(cursoSeleccionado);
			}

			//paso 4 asignar docente al curso
			
			docenteNuevo.AsignarCurso(cursoSeleccionado);//hace que el docente sea asignado al curso
			cursoSeleccionado.AsignarDocente(docenteNuevo);//hace que el curso se entere del nuevo docente

			Console.WriteLine("\t✅Asignacion exitosa");
			Console.WriteLine("El curso " + cursoSeleccionado.ObtenerNombre() + " ahora es dictado por " + docenteNuevo.ObtenerNombre() + ".");
		}
		
		

							// opcion 4. Registrar nota (Opción 4 del menú)
							//4 pasos buscar alumnos, seleccionar cursos,ingresar nota,asignar nota
		
		public void RegistrarNota()
		{
			Console.WriteLine("\n--- Registrar Nota ---");
			//paso 1 buscar alumno
			Console.Write("Ingrese el DNI del alumno: ");
			string dniBuscado = Console.ReadLine();//se crea variable
			Alumno alumnoEncontrado = null;
			foreach (Alumno alumno in listaAlumnos)//usamos foreach para buscar al alumno
			{
				if (alumno.ObtenerDni() == dniBuscado)
				{
					alumnoEncontrado = alumno;//si lo encuentra en la lista quiebra
					break;
				}
			}

			if (alumnoEncontrado == null)//si no lo encuentra mensaje de no encontrado
			{
				Console.WriteLine("❎No se encontró ningún alumno con ese DNI.");
				return;
			}

			Console.WriteLine("✅Alumno encontrado: " + alumnoEncontrado.ObtenerNombreCompleto());//si lo encuentra obtiene nombre completo con el metodo de la clase persona

			//paso 2 seleccionar curso
			List<Curso> cursosDelAlumno = alumnoEncontrado.ObtenerCursosInscritos();//utiliza el metodo de la clase alumno

			if (cursosDelAlumno.Count == 0)//si el conteo es 0 mesaje 
			{
				Console.WriteLine("El alumno no esta inscripto en el Instituto.");
				return;
			}

			Console.WriteLine("\nCursos en los que está inscripto:");
			for (int i = 0; i < cursosDelAlumno.Count; i++)//arama la lista de cursos por la iteracion 
			{
				Console.WriteLine((i + 1) + ". " + cursosDelAlumno[i].ObtenerNombre());//arma la lista empezando en 1 
			}

			Console.Write("Seleccione el número del curso para registrar la nota: ");
			int opcionCurso = int.Parse(Console.ReadLine());//crea al variable por medio de la eleccion del usuario

			if (opcionCurso < 1 || opcionCurso > cursosDelAlumno.Count)//condiciones para elegir la opcion correcta
			{
				Console.WriteLine("Error: Opción no válida.");
				return;
			}
			Curso cursoSeleccionado = cursosDelAlumno[opcionCurso - 1];//obtiene el curso seleccionado

			//paso 3 ingresar nota
			Console.Write("Ingrese la nota para " + cursoSeleccionado.ObtenerNombre());//utiliza metodo de la clase curso
			
			double notaIngresada = double.Parse(Console.ReadLine());//usamos double.Parse para convertir el texto a numero
			

			// paso 4 asignar nota
			alumnoEncontrado.AsignarNota(cursoSeleccionado, notaIngresada);//metodo de la calse alumno
			
			Console.WriteLine("✅Nota registrada con éxito para " + alumnoEncontrado.ObtenerNombreCompleto());
		}

							// opcion 5. Listar alumnos de un curso
							// 3 pasos:seleccion de curso,obtener la lista de alumnos, mostrar datos
		public void ListarAlumnosPorCurso()
		{
			Console.WriteLine("\n--- Listado de Alumnos por Curso ---");
			//paso 1 seleccion de curso
			if (listaCursos.Count == 0)// primero  verifica que haya cursos creados
			{
				Console.WriteLine("Error: No hay cursos registrados en el instituto.");
				return;
			}

			Console.WriteLine("Cursos disponibles:");//muestra los cursos disponibles con for
			for (int i = 0; i < listaCursos.Count; i++)
			{
				Console.WriteLine((i + 1) + ". " + listaCursos[i].ObtenerNombre());//utiliza el metodo de clase curso
			}
			
			Console.Write("Seleccione el número del curso: ");
			int opcionCurso = int.Parse(Console.ReadLine());//crea variable por medio de la seleccion del usuario,estableciendo condiciones
			if (opcionCurso < 1 || opcionCurso > listaCursos.Count)
			{
				Console.WriteLine("Error: Opción no válida.");
				return;
			}
			Curso cursoSeleccionado = listaCursos[opcionCurso - 1];//obtenemos el curso que el usuario eligio

			// paso 2 obtener la lista de alumnos
			List<Alumno> alumnosDelCurso = cursoSeleccionado.ObtenerAlumnosInscritos();//usamos el metodo de la clase alumno

			if (alumnosDelCurso.Count == 0)//por si no tiene alumnos incriptos
			{
				Console.WriteLine("Este curso no tiene alumnos inscriptos actualmente.");
				return;
			}

			//paso 3 mostrar datos
			Console.WriteLine("\nAlumnos inscriptos en " + cursoSeleccionado.ObtenerNombre() + ":");
			Console.WriteLine("-------------------------------------------------");

			foreach (Alumno alumno in alumnosDelCurso)//recorremos la lista de alumnos que nos dio el curso
			{
				double nota = alumno.ObtenerNota(cursoSeleccionado);//usa metodo de la clase alumno
				
				string notaParaMostrar;//se crea variable
				if (nota == -1)// Verificamos si tiene nota -1 significaba "Sin nota" porque segun se definio en el metodo si la clave notiene valor arroja ese dato
				{
					notaParaMostrar = "Sin nota";
				}
				else
				{
					notaParaMostrar = nota.ToString();//converte el numero (double) a texto (string)
				}
				Console.WriteLine("DNI: " + alumno.ObtenerDni() + " - Nombre: " + alumno.ObtenerNombreCompleto() + " - Nota: " + notaParaMostrar);//muestra la linea completa con los datos del alumno
			}
		}
									// opcion 6. Listar cursos
									
		public void ListarCursos()
		{
			Console.WriteLine("\n--- Listado de Cursos ---");

			if (listaCursos.Count == 0)//por si  no hay cursos registrados,mensaje
			{
				Console.WriteLine("No hay cursos registrados en el instituto.");
				return; // Salimos del método
			}

			Console.WriteLine("Cursos disponibles en el instituto:");
			Console.WriteLine("-------------------------------------------------");

			
			foreach (Curso curso in listaCursos)//recorre la lista de cursos del instituto
			{
				//para cada curso obtiene sus datos
				string nombreCurso = curso.ObtenerNombre();
				string nombreDocente = curso.ObtenerDocenteNombre();
				int cantidadInscritos = curso.ObtenerCantidadInscritos();//utiliza metodo de la clase curso

				// Imprimimos la línea (usando 'ToString' para asegurar que la cantidad sea texto clase 7 de teoria)
				Console.WriteLine("\tCurso: " + nombreCurso +"\t Docente: " + nombreDocente +"\t Inscriptos: " + cantidadInscritos.ToString());
			}

		}

								// opcion 7. Listar alumnos inscriptos en más de un curso
		
		public void ListarAlumnosMultiplesCursos()
		{
			Console.WriteLine("\n--- Alumnos en Multiples Cursos ---");

			if (listaAlumnos.Count == 0)//verfica que haya alunmos inscriptos
			{
				Console.WriteLine("No hay alumnos registrados en el instituto.");
				return;
			}
			bool seEncontraronAlumnos = false;//usa variable booleana para saber si encontramos a alguien.

			Console.WriteLine("Listado de alumnos inscriptos en más de un curso:");
			Console.WriteLine("-------------------------------------------------");

			foreach (Alumno alumno in listaAlumnos)//recorremos la lista COMPLETA de alumnos del instituto
			{
				
				int cantidadCursos = alumno.ObtenerCursosInscritos().Count;//le preguntamos al alumno su lista de cursos y contamos cuántos son

				
				if (cantidadCursos > 1)//si esta en mas de uno se muestra
				{
					Console.WriteLine("Alumno: " + alumno.ObtenerNombreCompleto() +"\t(DNI: " + alumno.ObtenerDni() + ") - \tInscripto en " + cantidadCursos.ToString() + " cursos.");
					
					
					seEncontraronAlumnos = true;//encuentra al menos uno
				}
			}

			if (!seEncontraronAlumnos)//si despues de revisar a todos la variable seEncontraronAlumnos sigue en false significa que no encontramos a nadie.
			{
				Console.WriteLine("No se encontraron alumnos inscriptos en más de un curso.");
			}
		}

								//opcion  8. Transferir un alumno de un curso a otro
								//5 pasos: buscar alumno, seleccionar curso de origen, seleccinar curso de destino, validacion de mismo curso, validacion de cupo,tranferencia
		public void TransferirAlumnoDeCurso()
		{
			Console.WriteLine("\n--- Transferir Alumno de Curso ---");
			//paso 1 buscar alumno
			Console.Write("Ingrese el DNI del alumno a transferir: ");
			string dniBuscado = Console.ReadLine();//crea variable 

			Alumno alumnoEncontrado = null;//variable local con valor nulo
			foreach (Alumno al in listaAlumnos)// busca en la lista
			{
				if (al.ObtenerDni() == dniBuscado)//si encuntra valor quiebra
				{
					alumnoEncontrado = al;
					break;
				}
			}

			if (alumnoEncontrado == null)//sino encuentra valor mensaje
			{
				Console.WriteLine("❎No se encontro ningun alumno con ese DNI.");
				return;
			}
			Console.WriteLine("Alumno encontrado: " + alumnoEncontrado.ObtenerNombreCompleto());//si encuentra valor entrega datos

			//paso 2 seleccionar curso de origen
			List<Curso> cursosDelAlumno = alumnoEncontrado.ObtenerCursosInscritos();//en la lista de cursos de alumnos implementa el metodo y cuenta
			if (cursosDelAlumno.Count == 0)//si la cuenta es 0 envia mensaje
			{
				Console.WriteLine("❎El alumno no esta inscripto en ningun curso para transferir.");
				return;
			}

			Console.WriteLine("\nCursos actuales del alumno (Curso Origen):");
			for (int i = 0; i < cursosDelAlumno.Count; i++)//hace un listado de los cursos actuales y los muestra en pantalla
			{
				Console.WriteLine((i + 1) + ". " + cursosDelAlumno[i].ObtenerNombre());
			}
			
			Console.Write("Seleccione el curso de ORIGEN: ");
			int opcionOrigen = int.Parse(Console.ReadLine());//crea variable por medio de ingreso de datos y valida que sean enteros
			if (opcionOrigen < 1 || opcionOrigen > cursosDelAlumno.Count)
			{
				Console.WriteLine("Error: Opcion no valida.");
				return;
			}
			Curso cursoOrigen = cursosDelAlumno[opcionOrigen - 1];//-1 para que coincida con el indice

			//seleccionar cueso de destino
			if (listaCursos.Count <= 1)//tiene que haber mas de 1 curso para transferir
			{
				Console.WriteLine("❎No hay otros cursos disponibles para transferir.");
				return;
			}
			
			Console.WriteLine("\nCursos disponibles (Curso Destino):");
			for (int i = 0; i < listaCursos.Count; i++)//imprime una lista de cursos disponibles
			{
				Console.WriteLine((i + 1) + ". " + listaCursos[i].ObtenerNombre());//+1 para que la lista se muestre desde el 1
			}
			
			Console.Write("Seleccione el curso de DESTINO: ");
			int opcionDestino = int.Parse(Console.ReadLine());//crea variable por ingreso de consola y valida que sea correcto
			if (opcionDestino < 1 || opcionDestino > listaCursos.Count)
			{
				Console.WriteLine("Error: Opción no válida.");
				return;
			}
			Curso cursoDestino = listaCursos[opcionDestino - 1];//-1 para que coincida la eleccion con el indice

			//paso 4 validacion de no transferir al minmo curso
			
			// Validación 1: No transferir al mismo curso
			if (cursoOrigen == cursoDestino)//
			{
				Console.WriteLine("❎ No se puede transferir un alumno al mismo curso.");
				return;
			}

			cursoDestino.AgregarAlumno(alumnoEncontrado);//ver validacion de cupo 

			// paso 5 transferencia
			
			
			alumnoEncontrado.InscribirACurso(cursoDestino);//lo agrega al curso destino clase alumno
			cursoOrigen.EliminarAlumno(alumnoEncontrado);//lo quita del curso origen clase curso
			alumnoEncontrado.QuitarCurso(cursoOrigen);//lo quita del curso origen clase alumno
			alumnoEncontrado.EliminarNota(cursoOrigen);//eliminamos su nota del curso origen clase alumno

			Console.WriteLine("\t✅Transferencia exitosa");
			Console.WriteLine(alumnoEncontrado.ObtenerNombreCompleto() + " ha sido movido de " + cursoOrigen.ObtenerNombre() + " a " + cursoDestino.ObtenerNombre() + ".");
		}

							// opcion 9. Mostrar el promedio general de notas de cada curso
							// 5 pasos:
							
		public void MostrarPromedioGeneralPorCurso()
		{
			Console.WriteLine("\n--- Promedio General por Curso ---");

			if (listaCursos.Count == 0)//valida que haya registrados
			{
				Console.WriteLine("No hay cursos registrados en el instituto.");
				return;
			}

			Console.WriteLine("Promedio de notas por curso:");
			Console.WriteLine("-------------------------------------------------");

			//paso 1 recorre la lista de todos los cursos
			foreach (Curso curso in listaCursos)
			{
				// paso 2 obtenemos los alumnos del curso
				List<Alumno> alumnosDelCurso = curso.ObtenerAlumnosInscritos();

				if (alumnosDelCurso.Count == 0)//el curso no tiene alumnos
				{
					
					Console.WriteLine("Curso: " + curso.ObtenerNombre() + " - (Sin alumnos inscriptos)");
				}
				else
				{
					//el curso si tiene alumnos. Calculamos el promedio.
					double sumaDeNotas = 0;
					int cantidadDeNotas = 0;

					//paso 3 recorremos los alumnos de ese curso
					foreach (Alumno alumno in alumnosDelCurso)
					{
						// paso 4 pedimos la nota del alumno
						double nota = alumno.ObtenerNota(curso);

						if (nota != -1)//-1 significa "Sin nota"
						{
							sumaDeNotas = sumaDeNotas + nota;
							cantidadDeNotas = cantidadDeNotas + 1;
						}
					}

					// 5. Mostramos el resultado del promedio
					if (cantidadDeNotas == 0)
					{
						// Si hubo alumnos, pero ninguno tenía nota
						Console.WriteLine("Curso: " + curso.ObtenerNombre() + " - (Sin notas registradas)");
					}
					else
					{
						// Calculamos el promedio final
						double promedio = sumaDeNotas / cantidadDeNotas;
						
						Console.WriteLine("Curso: " + curso.ObtenerNombre() + " - Promedio: " + promedio);
					}
				}
			}
		}
		
		// Metodo privado para crear y registrar un nuevo docente
		//mover a clase curso
		private Docente CrearNuevoDocente()
		{
			Console.WriteLine("\n--- Registrar Nuevo Docente ---");
			
			
			Console.Write("Ingrese Nombre: ");
			string nombre = Console.ReadLine();
			
			Console.Write("Ingrese Apellido: ");
			string apellido = Console.ReadLine();
			
			Console.Write("Ingrese DNI: ");
			string dni = Console.ReadLine();
			

			Console.Write("Ingrese Sueldo: ");
			double sueldo = double.Parse(Console.ReadLine()); // Esto puede lanzar FormatException

			// Creamos el docente
			Docente nuevoDocente = new Docente(nombre, apellido, dni, sueldo);
			
			// Lo agregamos a la lista principal del instituto
			this.listaDocente.Add(nuevoDocente);

			Console.WriteLine("¡Docente " + nuevoDocente.ObtenerNombre() + " registrado con éxito!");
			
			// Devolvemos el docente recién creado
			return nuevoDocente;
		}
	}
}