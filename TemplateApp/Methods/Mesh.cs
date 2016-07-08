using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Newtonsoft.Json.Bson;

namespace OpenGlTemplateApp.Methods
{
    internal class Mesh
    {
        public DataPoints GlobalPoints { set; get; }

        public double MeshParam { set; get; }

        public List<GetIntervals.NewIntervalProperty> PropertyX { set; get; }

        public List<GetIntervals.NewIntervalProperty> PropertyY { set; get; }

        public List<GetIntervals.NewIntervalProperty> PropertyZ { set; get; }

        public List<Element> ElementsGrid { get; set; }

        public Mesh(double meshParam, GetIntervals newProperty)
        {
            MeshParam = meshParam;
            GlobalPoints = newProperty.Input.Points;
            PropertyX = newProperty.IntervalPropertyX;
            PropertyY = newProperty.IntervalPropertyY;
            PropertyZ = newProperty.IntervalPropertyZ;
            _getMesh();

        }

        public void _getMesh()
        {
            var tmpX = new List<List<Point>>();
            for (int i = 0; i < PropertyX.Count; i++)
            {
                tmpX.Add(_getPointsByLine(
                    GlobalPoints.PointsByX[PropertyX[i].PointsNumbers[0]],
                    GlobalPoints.PointsByX[PropertyX[i].PointsNumbers[1]],
                    PropertyX[i].N,
                    PropertyX[i].Q));
            }

            var tmpY = new List<List<Point>>();
            for (int i = 0; i < PropertyY.Count; i++)
            {
                tmpY.Add(_getPointsByLine(
                    GlobalPoints.PointsByY[PropertyY[i].PointsNumbers[0]],
                    GlobalPoints.PointsByY[PropertyY[i].PointsNumbers[1]],
                    PropertyY[i].N,
                    PropertyY[i].Q));
            }

            var tmpZ = new List<List<Point>>();
            for (int i = 0; i < PropertyY.Count; i++)
            {
                tmpZ.Add(_getPointsByLine(
                    GlobalPoints.PointsByZ[PropertyZ[i].PointsNumbers[0]],
                    GlobalPoints.PointsByZ[PropertyZ[i].PointsNumbers[1]],
                    PropertyZ[i].N,
                    PropertyZ[i].Q));
            }


            // Точки по осям
            var arrX = new List<Point>();
            for (int i = 0; i < tmpX.Count; i++)
            {
                for (int j = 0; j < tmpX[i].Count; j++)
                {
                    if (j != tmpX[i].Count - 1)
                    {
                        arrX.Add(tmpX[i][j]);                        
                    }
                }
            }
            arrX.Add(tmpX[tmpX.Count - 1][tmpX[tmpX.Count - 1].Count - 1]);

            var arrY = new List<Point>();
            for (int i = 0; i < tmpY.Count; i++)
            {
                for (int j = 0; j < tmpY[i].Count; j++)
                {
                    arrY.Add(tmpY[i][j]);
                }
            }

            var arrZ = new List<Point>();
            for (int i = 0; i < tmpZ.Count; i++)
            {
                for (int j = 0; j < tmpZ[i].Count; j++)
                {
                    arrZ.Add(tmpZ[i][j]);
                }
            }

            // Точки на плоскостях
            var elem = _getAllPoints(arrX, arrY, arrZ);

            // Создаем массив с точками КЭ
            var list = new List<Element>();
            for (int z = 0; z < arrZ.Count - 1; z++)
            {
                for (int y = 0; y < arrY.Count - 1; y++)
                {
                    for (int x = 0; x < arrX.Count - 1; x++)
                    {
                        var listPoint= new List<Point>();
                        listPoint.Add(elem[x + arrX.Count * y + arrX.Count * arrY.Count * z]);
                        listPoint.Add(elem[x + arrX.Count * y + arrX.Count * arrY.Count * z + 1]);
                        listPoint.Add(elem[x + arrX.Count * y + arrX.Count * arrY.Count * z + arrX.Count]);
                        listPoint.Add(elem[x + arrX.Count * y + arrX.Count * arrY.Count * z + arrX.Count + 1]);
                        listPoint.Add(elem[x + arrX.Count * y + arrX.Count * arrY.Count * z + arrX.Count * arrY.Count]);
                        listPoint.Add(elem[x + arrX.Count * y + arrX.Count * arrY.Count * z + arrX.Count * arrY.Count + 1]);
                        listPoint.Add(elem[x + arrX.Count * y + arrX.Count * arrY.Count * z + arrX.Count * arrY.Count + arrX.Count]);
                        listPoint.Add(elem[x + arrX.Count * y + arrX.Count * arrY.Count * z + arrX.Count * arrY.Count + arrX.Count + 1]);
                        var element = new Element(listPoint);
                        list.Add(element);
                    }
                }
            }
            ElementsGrid = list;
        }

        // Возвращает все точки
        private List<Point> _getAllPoints(List<Point> oX, List<Point> oY, List<Point> oZ)
        {
            var list = new List<Point>();
            for (int z = 0; z < oZ.Count; z++)
            {
                for (int y = 0; y < oY.Count; y++)
                {
                    for (int x = 0; x < oX.Count; x++)
                    {
                        list.Add(new Point(oX[x].X, oY[y].Y, oZ[z].Z));
                    }
                }
            }
            return list;
        }

        /* Возвращает длину всех интервалов числу
         */
        private double[] _getIntevlsByCurve(double length, int count, double coef)
        {
            var h = -1.0;
            var lengthIntervals = new double[count];
            for (int i = 0; i < count; i++)
            {
                if (coef == 1.0) // если коэф. раст¤жени¤ = 1
                {
                    h = length / count;
                }
                else if (h != -1.0 && coef != 1.0)
                {
                    if (coef < 0)
                    {
                        double coefExp1 = 1 / Math.Abs(coef);
                        h = h * coefExp1;
                    }
                    else h = h * coef;
                }
                else
                {
                    if (coef < 0)
                    {
                        double coefExp1 = 1 / Math.Abs(coef);
                        h = length * (1 - coefExp1) / (1 - Math.Pow(coefExp1, count));  //считаем первый шаг
                    }
                    else
                        h = length * (1 - coef) / (1 - Math.Pow(coef, count));  //считаем первый шаг
                }

                lengthIntervals[i] = h;
            }
            return lengthIntervals;
        }

        /* Возвращает массив точек на линии
         */
        private List<Point> _getPointsByLine(Point p1, Point p2, int count, double coef)
        {
            var result = new List<Point>();
            var changeX = _getIntevlsByCurve(Math.Abs(p2.X - p1.X), count, coef);
            var changeY = _getIntevlsByCurve(Math.Abs(p2.Y - p1.Y), count, coef);
            var changeZ = _getIntevlsByCurve(Math.Abs(p2.Z - p1.Z), count, coef);

            result.Add(p1);
            for (int i = 0; i < changeX.Length; i++)
            {
                if (i == 0)
                {
                    result.Add(new Point(
                        p1.X + changeX[i],
                        p1.Y + changeY[i],
                        p1.Z + changeZ[i]));
                }
                else
                {
                    var previosPoint = result[result.Count - 1];
                    result.Add(new Point(
                        previosPoint.X + changeX[i],
                        previosPoint.Y + changeY[i],
                        previosPoint.Z + changeZ[i]));
                }
            }
            return result;
        }
    }
}
