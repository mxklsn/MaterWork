using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGlTemplateApp.Methods
{
    internal class GetIntervals
    {
        public InputData Input { get; set; }

        public struct NewIntervalProperty
        {
            public List<int> PointsNumbers { set; get; }

            public double Q { set; get; }

            public int N { get; set; }

            public NewIntervalProperty(int a, int b, double newQ, int n)
                : this()
            {
                var p = new List<int>(2);
                p.Add(a);
                p.Add(b);
                Q = newQ;
                N = n;
                PointsNumbers = p;
            }
        }

        public List<NewIntervalProperty> IntervalPropertyX { get; set; }

        public List<NewIntervalProperty> IntervalPropertyY { get; set; }

        public List<NewIntervalProperty> IntervalPropertyZ { get; set; }

        public GetIntervals(InputData input)
        {
            Input = input;
            var property = Input.Property;

            // для X
            var compressionX = _findCompressionPoint(property.Ox);  // точка сгущения
            var tmp = new List<NewIntervalProperty>();
            tmp.Add( // первый интервал в зависимости от точки сгущения
                _calcNewIntervalProperty(
                    compressionX, 
                    compressionX - 1, 
                    property.Ox[compressionX - 1],
                    property.Step, 
                    Input.Points.PointsByX[compressionX - 1].X, 
                    Input.Points.PointsByX[compressionX].X));

            for (int i = 0; i < property.Ox.Length - 1; i++)
            {
                var newIn = tmp[tmp.Count - 1]; // new Interval
                tmp.Add(
                    _calcNewIntervalProperty(
                        newIn.PointsNumbers[1] + 1, 
                        newIn.PointsNumbers[1], 
                        property.Ox[newIn.PointsNumbers[1]],
                        newIn.Q, 
                        Input.Points.PointsByX[newIn.PointsNumbers[1]].X,
                        Input.Points.PointsByX[newIn.PointsNumbers[1] + 1].X));
            }

            IntervalPropertyX = tmp;

            // для Y
            var compressionY = _findCompressionPoint(property.Oy);  // точка сгущения
            tmp = new List<NewIntervalProperty>();
            var prev = 0;
            if (compressionY != 0)
            {
                prev = compressionY - 1;
            }
            else
            {
                prev = compressionY;
                compressionY = compressionY + 1;
            }

            tmp.Add( // первый интервал в зависимости от точки сгущения
                _calcNewIntervalProperty(
                compressionY, 
                prev, 
                property.Oy[prev], 
                property.Step, 
                Input.Points.PointsByY[prev].Y, 
                Input.Points.PointsByY[compressionY].Y));

            for (int i = 0; i < property.Oy.Length - 1; i++)
            {
                var newIn = tmp[tmp.Count - 1]; // new Interval
                tmp.Add(
                    _calcNewIntervalProperty(
                        newIn.PointsNumbers[1] + 1, 
                        newIn.PointsNumbers[1], 
                        property.Oy[newIn.PointsNumbers[1]],
                        newIn.Q, Input.Points.PointsByY[newIn.PointsNumbers[1]].Y, 
                        Input.Points.PointsByY[newIn.PointsNumbers[1] + 1].Y));
            }
            IntervalPropertyY = tmp;

            // для Z
            var compressionZ = _findCompressionPoint(property.Oz);  // точка сгущения
            tmp = new List<NewIntervalProperty>();
            prev = 0;
            if (compressionZ != 0)
            {
                prev = compressionZ - 1;
            }
            else
            {
                prev = compressionZ;
                compressionZ = compressionZ + 1;
            }

            tmp.Add( // первый интервал в зависимости от точки сгущения
                _calcNewIntervalProperty(
                compressionZ,
                prev,
                property.Oz[prev],
                property.Step,
                Input.Points.PointsByZ[prev].Z,
                Input.Points.PointsByZ[compressionY].Z));

            for (int i = 0; i < property.Oz.Length - 1; i++)
            {
                var newIn = tmp[tmp.Count - 1]; // new Interval
                tmp.Add(
                    _calcNewIntervalProperty(
                        newIn.PointsNumbers[1] + 1,
                        newIn.PointsNumbers[1],
                        property.Oz[newIn.PointsNumbers[1]],
                        newIn.Q, Input.Points.PointsByZ[newIn.PointsNumbers[1]].Z,
                        Input.Points.PointsByZ[newIn.PointsNumbers[1] + 1].Z));
            }
            IntervalPropertyZ = tmp;
        }


        /// <summary>
        /// Возвращает точки интервала, его новое q и h по Х
        /// </summary>
        /// <param name="compression">номер точки сгущения в глобальном массива</param>
        /// <param name="previous">номер предыдущей точки в глобальном массиве</param>
        /// <param name="inputQ">коэф. растяжки из файла</param>
        /// <param name="inputH">навальный шаг h0 из файла</param>
        /// <param name="previousPt">чисто в точке которое характеризует интервал</param>
        /// <param name="compressionPt">чисто в точке которое характеризует интервал</param>
        /// <returns>номера точек интервала, новый коэй. растяж и кол-во интервалов</returns>
        private NewIntervalProperty _calcNewIntervalProperty(
            int compression, int previous, double inputQ, double inputH, double previousPt, double compressionPt)
        {
            var count = _calcCountIntervals(
                previousPt,
                compressionPt,
                inputQ,
                inputH);

            var newQ = _reCalc_q(
                previousPt,
                compressionPt,
                inputQ,
                inputH,
                count);

            return new NewIntervalProperty(previous, compression, newQ, count);
        }

        /* Возвращает номер точки сгущение пока только по X
         */
        private int _findCompressionPoint(double[] coef)
        {
            var pNumber1 = _getIndexFromPropertyX(coef.Max(), coef);
            var pNumber2 = _getIndexFromPropertyX(coef.Min(), coef);
            return Math.Abs(pNumber1 - pNumber2);
        }

        /* Возвращает индекс коэф растяжения по Х из массива
         */
        private int _getIndexFromPropertyX(double x, double[] arrayIntervals)
        {
            for (int i = 0; i < arrayIntervals.Length; i++)
            {
                if (arrayIntervals[i] == x)
                {
                    return i;
                }
            }
            return 05072016; // костыль
        }

        /* Возвращает точное кол-во интервало на промежутке от A до B
         */
        private int _calcCountIntervals(double a, double b, double q, double h0)
        {
            //var ax = a.paramO;  // 0
            //var bx = b.paramO;  // 5
            var ax = a;  // 0
            var bx = b;  // 5
            var arrayX = new List<double>();
            double x;
            int n = 0;
            double bL = 0;
            double bR = 0; 

            if (q < -1)
            {
                //bx = a.paramO;
                //ax = b.paramO;
                bx = a;
                ax = b;
                x = ax;
                arrayX.Add(x);
                var hx = h0;
                var qx = -(q);

                while (x >= bx)
                {
                    x -= hx;
                    hx *= qx;
                    arrayX.Add(x);
                }
                n = arrayX.Count;
                bL = arrayX[n - 1];
                bR = arrayX[n - 2];
            }
            else
            {
                x = ax;
                arrayX.Add(x);
                var hx = h0;
                var qx = q;

                while (x <= bx)
                {
                    x += hx;
                    hx *= qx;
                    arrayX.Add(x);
                }
                n = arrayX.Count;
                bL = arrayX[n - 1];
                bR = arrayX[n - 2];
            }
            if (Math.Abs(bx - bL) > Math.Abs(bx - bR) && Math.Abs(bx - bR) < 0.0001)
            {
                n = arrayX.Count - 2;
            }
            else if (Math.Abs(bx - bL) > Math.Abs(bx - bR))
            {
                n = arrayX.Count - 1;
            }

            else
            {
                n = arrayX.Count;
            }
            return n;
        }

        /* Рассчет нового Q
         */
        private double _reCalc_q(double a, double b, double q, double h, int n)
        {
            //var sN = b.X - a.X;  // эталонная сумма
            var sN = b - a;  // эталонная сумма
            var eps = sN / 10000000000000;
            double qMin = 1;
            double qMax = 100;

            q = Math.Abs(q);
            var s = _calsSn(h, q, n);
            while (Math.Abs(s - sN) > eps)
            {
                if (s < sN)
                {
                    qMin = q;
                }
                else
                {
                    qMax = q;
                }
                q = (qMax + qMin) / 2;
                s = _calsSn(h, q, n);
            }
            return q;
        }

        /* Считает сумму всех шагов
         */
        private double _calsSn(double h, double q, int n)
        {
            return h * (1 - Math.Pow(q, n)) / (1 - q);
        }

        /* Получаем последний шаг на первом интевале
         */
        private double[] _getIntervalSteps(double length, double q, int n)
        {
            var h = -1.0;
            var lengthIntervals = new double[n];
            for (int i = 0; i < n; i++)
            {
                if (q == 1.0) // если коэф. раст¤жени¤ = 1
                {
                    h = length / n;
                }
                else if (h != -1.0 && q != 1.0)
                {
                    if (q < 0)
                    {
                        double coefExp1 = 1 / Math.Abs(q);
                        h = h * coefExp1;
                    }
                    else h = h * q;
                }
                else
                {
                    if (q < 0)
                    {
                        double coefExp1 = 1 / Math.Abs(q);
                        h = length * (1 - coefExp1) / (1 - Math.Pow(coefExp1, q));  //считаем первый шаг
                    }
                    else
                        h = length * (1 - q) / (1 - Math.Pow(q, n));  //считаем первый шаг
                }

                lengthIntervals[i] = h;
            }
            return lengthIntervals;
        }
    }
}
