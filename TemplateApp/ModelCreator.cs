

using System;
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

        public ModelCreator(ModelData curveFile, double meshParam)
        {
            _curveData = curveFile;
            _meshParam = meshParam;
        }

        public void Create()
        {
            var inputData = _curveData.LoadJson();  // входные данные
            var initGetIntervals = new GetIntervals(inputData);  // согласование q, n, h0
            var mesh = new Mesh(_meshParam, initGetIntervals);  // все КЭ
            var values = inputData.Points.Values;
            var dxCoefficient = new СoordinateСonverter(
                values.X.Min(), values.X.Max(), 
                values.Y.Min(), values.Y.Max(),
                values.Z.Min(), values.Z.Max());

            _curveData.SaveJson(mesh.ElementsGrid, "../OutputData/gridPoints.json");  // в формате JSON
            _curveData.SaveArray(mesh.ElementsGrid, dxCoefficient.DxCoefficient, "../OutputData/gridArray.json");  // сплошной массив для DirectX



            /*var elementsModel = new MoldelElements(inputData);
            var gridElements = new ModelGrid(inputData, elementsModel);*/
        }
    }
}
