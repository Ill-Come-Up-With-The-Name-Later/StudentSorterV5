﻿using Newtonsoft.Json;
using StudentSorter.Debug;

namespace StudentSorter.FileHandling
{
    public static class Importer
    {
        /// <summary>
        /// Deserializes a JSON file into a specified type
        /// </summary>
        /// <typeparam name="T">
        /// The type to deserialize the JSON into
        /// </typeparam>
        /// <param name="filePath">
        /// The path of the JSON file to deserialize
        /// </param>
        public static void Import<T>(string filePath)
        {
            string file = filePath;
            string lines = File.ReadAllText(file);

            var jsonReader = new JsonTextReader(new StringReader(lines))
            {
                SupportMultipleContent = true
            };
            try
            {
                while (jsonReader.Read())
                {
                    JsonSerializer serializer = new();
                    T? obj = serializer.Deserialize<T>(jsonReader);
                }
            }
            catch (Exception) { Debugger.Log("Import error!"); }
        }
    }
}
