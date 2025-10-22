using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TP_Programacion_Objetos
{
    // Clase estatica para guardar y cargar datos del instituto
    public static class Dato
    {
        // Ruta del archivo donde se guardaran los datos
        private static string rutaArchivo = "instituto_datos.json";


        // Configuracion de json
        private static JsonSerializerOptions opciones = new JsonSerializerOptions
        {
            // WriteIndented guarda el json con sangria y saltos de linea
            WriteIndented = true,
            // evita bucles entre objetos
            ReferenceHandler = ReferenceHandler.Preserve
        };

        // Metodo estatico para guardar los datos
        public static bool Guardar(Instituto instituto)
        {
            try
            {
                string json = JsonSerializer.Serialize(instituto, opciones);
                File.WriteAllText(rutaArchivo, json);
                // Si guarda corectamente devuelvo true
                return true;
            }
            catch (Exception)
            {
                // Si no se guarda correctamente devuelvo false
                return false;
            }
        }

        public static Instituto Cargar()
        {
            try
            {
                if (!File.Exists(rutaArchivo))
                {
                    return new Instituto("Aprender+");
                }

                string json = File.ReadAllText(rutaArchivo);
                Instituto instituto = JsonSerializer.Deserialize<Instituto>(json, opciones) ?? new Instituto("Aprender+");

                return instituto ?? new Instituto("Aprender+");
            }

            catch (Exception)
            {
                return new Instituto("Aprender+");
            }
        }
    }
}
