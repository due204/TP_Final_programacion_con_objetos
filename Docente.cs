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
	/// Description of Docente.
	/// </summary>
	public class Docente : Persona
	{
		private List<Curso> cursosDados;
        private double sueldo;
		public Docente()
		{
			cursosDados = new List<Curso>();
            sueldo = 0.0; 
		}
		// Constructor con parametros para crear docentes con datos
        public Docente(string nombre, string apellido, string dni, double sueldo) 
            : base(nombre, apellido, dni) // Pasa los datos comunes al constructor de Persona
        {
            this.cursosDados = new List<Curso>();
            this.sueldo = sueldo;
        }

        // --- Métodos Públicos ---

       
        // Asigna un curso a la lista de cursos que dicta el docente.
       
        public void AsignarCurso(Curso curso)
        {
            this.cursosDados.Add(curso);
        }

        
        // Devuelve el nombre completo del docente.
        
        public string ObtenerNombre()
        {
            return base.ObtenerNombreCompleto();
        }
        public List<Curso> ObtenerCursosDados()
{
    return this.cursosDados;
}
        public void QuitarCurso(Curso curso)
{
    // Usamos el metodo .Remove() que tienen todas las Listas
    this.cursosDados.Remove(curso);
}
    }
}
	
