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
                // Si el archivo no existe devuelvo un instituto nuevo
                if (!File.Exists(rutaArchivo))
                {
                    return new Instituto("Aprender+");
                }

                string json = File.ReadAllText(rutaArchivo);
                // En caso de que falle la deserializacion devuelvo un instituto nuevo
                Instituto instituto = JsonSerializer.Deserialize<Instituto>(json, opciones) ?? new Instituto("Aprender+");
                // Devuelvo el instituto cargado y en caso de ser nullo un instituto nuevo
                return instituto ?? new Instituto("Aprender+");
            }

            catch (Exception)
            {
                // En caso de que algo falle devuelvo un instituto nuevo
                return new Instituto("Aprender+");
            }
        }
    }
}
