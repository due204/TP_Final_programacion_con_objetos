/*
 * Creado por SharpDevelop.
 * Usuario: nuevo2
 * Fecha: 16/10/2025
 * Hora: 09:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
namespace TP_final_obejetos_de_programación
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno: Persona
	{
		// Atributos privados específicos de Alumno
		private List<Curso> cursosInscritos;
		private Dictionary<Curso, double> notas;
		private int legajo;

		// Constructor por defecto
		public Alumno() : base() // Llama explícitamente al constructor por defecto de Persona
		{
			// Inicializa las colecciones y atributos propios de Alumno
			this.cursosInscritos = new List<Curso>();
			this.notas = new Dictionary<Curso, double>();
			this.legajo = 0;
		}
		
		// Constructor con parámetros para crear alumnos con todos sus datos
		public Alumno(string nombre, string apellido, string dni, int legajo)
			: base(nombre, apellido, dni) // Pasa los datos comunes al constructor de Persona
		{
			// Inicializa los atributos propios de Alumno
			this.cursosInscritos = new List<Curso>();
			this.notas = new Dictionary<Curso, double>();
			this.legajo = legajo;
		}
		public int ObtenerLegajo()
		{
			return this.legajo;
		}
		public void InscribirACurso(Curso curso)
		{
			// Aquí se podría validar para no inscribir dos veces al mismo curso, si fuera necesario.
			this.cursosInscritos.Add(curso);
		}
			// Devuelve la lista de cursos a los que está inscrito.
			public List<Curso> ObtenerCursosInscritos()
			{
				return this.cursosInscritos;
			}

			// Elimina un curso de la lista de cursos del alumno.
			public void QuitarCurso(Curso curso)
			{
				this.cursosInscritos.Remove(curso);
			}
			
			
			public void AsignarNota(Curso curso, double nota)
			{
				if (cursosInscritos.Contains(curso))
				{
					// 1. Verificamos si ya existe
					if (notas.ContainsKey(curso))
					{
						// 2. Si existe, la MODIFICAMOS (usando diccionario[clave])
						notas[curso] = nota;
					}
					else
					{
						// 3. Si no existe, la AÑADIMOS (usando Add(clave, valor))
						notas.Add(curso, nota);
					}
				}
				else
				{
					Console.WriteLine("Error: El alumno no está inscripto en el curso seleccionado.");
				}
			}
			public void EliminarNota(Curso curso)
			{
				// Verificamos si la clave (curso) existe
				if (notas.ContainsKey(curso))
				{
					// Si existe, la eliminamos
					notas.Remove(curso);
				}
				// Si no existe, no hacemos nada.
			}
			public double ObtenerNota(Curso curso)
{
    // 1. Verificamos si la clave existe (usando el método de tu lista)
    if (notas.ContainsKey(curso))
    {
        // 2. Si existe, accedemos al valor (usando el método de tu lista)
        return notas[curso]; 
    }
    else
    {
        // Si la clave no existe, devolvemos -1 (para "Sin nota")
        return -1; 
    }
}
		}
	}


