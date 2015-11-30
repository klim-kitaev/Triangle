using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    /// <summary>
    /// Прямоугольный треугольник
    /// </summary>
    public class RightTriangle
    {
        //первый катет
        private double a;
        //второй катет
        private double b;
        //третий катет
        private double c;

        public RightTriangle(double s1, double s2, double s3)
        {
            //определим что является гипотенузой, а что катетами
            double[] tmp=new double[]{s1,s2,s3}.OrderByDescending(p=>p).ToArray();
            c = tmp[0];
            a = tmp[1];
            b = tmp[2];

            //проверим на корркетность веденных данных
            if (Math.Pow(a, 2) + Math.Pow(b, 2) != Math.Pow(c, 2))
            {
                throw new ArgumentException("Некорректные параметры сторон");
            }
        }
        /// <summary>
        /// Площадь прямоугольного треугольника
        /// </summary>
        public double Area
        {
            get { return a*b/2; }
        }
    }
}
