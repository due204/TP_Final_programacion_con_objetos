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
	/// Description of Curso.
	/// </summary>
	public class Curso
	{
		private string nombre;
		private string docente;
		private int maxAlumnos;
		private List<Alumno> alumnos;
		
		// borrar
		
		public Curso()
		{
			nombre = "";
			docente = "";
			maxAlumnos = 0;
			alumnos = new List<Alumno>();
		}
		
		public string ObtenerNombre()
		{
			return this.nombre;
		}
		public bool AgregarAlumno(Alumno alumno)
		{
			//verificamos si la cantidad de alumnos inscritos es menor que el maximo permitido
			if (alumnos.Count < maxAlumnos)
			{
				alumnos.Add(alumno);
				return true; // Éxito
			}
			else
			{
				//si no hay cupo informamos y devolvemos false
				Console.WriteLine("El curso '" + this.nombre + "' ya no tiene cupos disponibles.");
				return false; // Fracaso
			}
		}
		// Dentro de public class Curso

		public Curso(string nombre, string docente, int maxAlumnos)
		{
			this.nombre = nombre;
			this.docente = docente;
			this.maxAlumnos = maxAlumnos;
			this.alumnos = new List<Alumno>();
		}
		// Elimina un alumno de la lista de inscriptos del curso.
		public void EliminarAlumno(Alumno alumno)
		{
			this.alumnos.Remove(alumno);
		}
		public List<Alumno> ObtenerAlumnosInscritos()
		{
			return this.alumnos;
		}
		public int ObtenerCantidadInscritos()
		{
			// Simplemente devolvemos el .Count de la lista interna
			return this.alumnos.Count;
		}
		public string ObtenerDocenteNombre()
{
    return this.docente;
}
		// Método para cambiar o asignar el docente (actualiza el atributo string)
public void AsignarDocente(Docente nuevoDocente)
{
    // Usamos el método .ObtenerNombre() de la clase Docente
    this.docente = nuevoDocente.ObtenerNombre();
}
	}
	
}
