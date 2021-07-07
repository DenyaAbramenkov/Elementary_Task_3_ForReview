using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Elementary_Task_3
{
    public class Triangle: ITriangle, IComparable<Triangle>
    {
        public string Name { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Area { get; set; }

        private Triangle(string name, double sideA, double sideB, double sideC)
        {
            Name = name;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            AreaCalculating();
        }

        public static Triangle TriangleInitializer(string name, string sideA, string sideB, string sideC)
        {
            name = $"[Triangle {name}]:";
    
            if (!double.TryParse(sideA, out double a) | !double.TryParse(sideB, out double b) | !double.TryParse(sideC, out double c))
            {
                throw new ArgumentException("All Side parametres should be positive numbers");
            }
            if (new Triangle(name, a, b, c).TriangleValidator() == false)
            {
                throw new ArgumentException("There is no triangle with such sides");
            }
            return new Triangle(name, a, b, c);
        }

        public int CompareTo(Triangle triangle)
        {
            if (this.Area > triangle.Area)
            {
                return -1;
            }
            else if (this.Area == triangle.Area)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void AreaCalculating()
        {
            double p = (this.SideA + this.SideB + this.SideC) / 2;
            Area = Math.Sqrt(p * (p- SideA) * (p - SideB) * (p - SideC));
            Area = Math.Round(Area, 3);
        }
        public override string ToString()
        {
            string s = Name + " " + Area.ToString();
            return s;
        }
        public bool TriangleValidator()
        {
            if ((SideA + SideB > SideC) && 
               (SideA + SideC > SideB) &&
               (SideB + SideC > SideA))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
