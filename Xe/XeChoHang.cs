using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xe
{
    internal class XeChoHang:Xe
    {
        double sotan;
        public new void nhap()
        {
            base.nhap();
            Console.Write("Nhap vao sotan :");
            sotan = double.Parse(Console.ReadLine());   
        }
        public new void xuat()
        {
            base.xuat();
        }
       
    }
}
