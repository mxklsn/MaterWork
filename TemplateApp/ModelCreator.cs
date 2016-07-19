using System;
using System.Collections.Generic;
using System.Linq;
using OpenGlTemplateApp.Methods;

namespace OpenGlTemplateApp
{
     /* Создание модели отображения объекта
     */
    internal class ModelCreator
    {
        private readonly ModelData _curveData;
        private readonly double _meshParam;

        public int CountFe { get; set; }

        public double[] Points { get; set; }

        public int[] CountO { get; set; }

        public ModelCreator(ModelData curveFile, double meshParam)
        {
            _curveData = curveFile;
            _meshParam = meshParam;
        }

        public void Create()
        {
            var inputData = _curveData.LoadJson();  // входные данные
            var initGetIntervals = new GetIntervals(inputData);  // согласование q, n, h0
            var mesh = new Mesh(Convert.ToInt32(_meshParam), initGetIntervals);  // все КЭ

            // коэф. для DX
            var values = inputData.Points.Values;
            var dxCoefficient = new СoordinateСonverter(
                values.X.Min(), values.X.Max(), 
                values.Y.Min(), values.Y.Max(),
                values.Z.Min(), values.Z.Max());

            //_curveData.SaveJson(mesh.ElementsGrid, "../OutputData/gridPoints.json");  // в формате JSON

            // массив всех чисел (точек) для DLL
            _curveData.SaveArray(mesh.ElementsGrid, dxCoefficient.DxCoefficient);
            Points = _curveData.PointsDll.ToArray();

            // кол-во точек на оХ и т.д.
            var arrayCountO = new int[3];
            for (int i = 0; i < mesh.PropertyX.Count; i++)
                arrayCountO[0] += mesh.PropertyX[i].N;
            arrayCountO[0] = arrayCountO[0] * Convert.ToInt32(_meshParam + 1);
            arrayCountO[0]++;
            for (int i = 0; i < mesh.PropertyY.Count; i++)
                arrayCountO[1] += mesh.PropertyY[i].N;
            arrayCountO[1] = arrayCountO[1] * Convert.ToInt32(_meshParam + 1);
            arrayCountO[1]++;
            for (int i = 0; i < mesh.PropertyZ.Count; i++)
                arrayCountO[2] += mesh.PropertyZ[i].N;
            arrayCountO[2] = arrayCountO[2] * Convert.ToInt32(_meshParam + 1);
            arrayCountO[2]++;


            CountO = arrayCountO;

            // кол-во ке
            CountFe = mesh.ElementsGrid.Count;
        }
    }
}
