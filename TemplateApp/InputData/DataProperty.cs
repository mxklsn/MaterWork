using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace OpenGlTemplateApp
{
    [DataContract]
    internal class DataProperty
    {
        /// <summary>
        /// Содержится просто весь массив интервалов и коэф.
        /// </summary>
        public DataProperty(double[] oX, double[] oY, double[] oZ, double h)
        {
            Ox = oX;
            Oy = oY;
            Oz = oZ;
            Step = h;
        }

        public double[] Ox { set; get; }

        public double[] Oy { set; get; }

        public double[] Oz { set; get; }

        public double Step { set; get; }
    }
}
