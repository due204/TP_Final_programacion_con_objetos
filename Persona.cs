/*
 * Creado por SharpDevelop.
 * Usuario: nuevo2
 * Fecha: 16/10/2025
 * Hora: 11:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace TP_final_obejetos_de_programación
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		private string nombre;
        private string apellido;
        private string dni;

		public Persona()
		{
			nombre = "";
            apellido = "";
            dni = "";
		}
		// Constructor con parametros para crear personas con datos iniciales
        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

       

        // Método para obtener el nombre
        public string ObtenerNombre()
        {
            return nombre;
        }

        // Método para obtener el apellido
        public string ObtenerApellido()
        {
            return apellido;
        }

        // Método para obtener el DNI
        public string ObtenerDni()
        {
            return dni;
        }
        
        // Método para obtener el nombre completo
        public string ObtenerNombreCompleto()
        {
        	return nombre + " " + apellido;
        }
	}
}
