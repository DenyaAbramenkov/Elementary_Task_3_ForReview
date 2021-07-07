using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Task_3
{
    interface ITriangle
    {
        string Name { get; set; }
        double SideA { get; set; }
        double SideB { get; set; }
        double SideC { get; set; }
        bool TriangleValidator();
        void AreaCalculating();
    }
}
