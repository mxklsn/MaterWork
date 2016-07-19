using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
//using System.Runtime.Serialization.Json;
using Newtonsoft.Json;


namespace OpenGlTemplateApp
{
    internal class ModelData
    {
        private readonly string _filePath;

        public List<double> PointsDll { get; set; }

        public ModelData(string filePath)
        {
            _filePath = filePath;
        }

        public InputData LoadJson() // чтение файла .json
        {
            using (StreamReader reader = new StreamReader(_filePath))
            {
                var json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<InputData>(json);
            }
        }

        public void SaveJson(List<Element> elements, string filePath)
        {
            string json = JsonConvert.SerializeObject(elements);
            System.IO.File.WriteAllText(filePath, json);
            //throw new NotImplementedException();
        }

        public void SaveArray(List<Element> elements, double dxCoefficient)
        {
            var array = new List<double>();
            for (int element = 0; element < elements.Count; element++)
            {
                for (int point = 0; point < elements[element].Points.Count; point++)
                {
                    array.Add(dxCoefficient * elements[element].Points[point].X);
                    array.Add(dxCoefficient * elements[element].Points[point].Y);
                    array.Add(dxCoefficient * elements[element].Points[point].Z);
                }
            }
            PointsDll = array;
        }
    }
}
