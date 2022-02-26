using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xe
{
    internal class XeDuLich:Xe
    {

        int sochongoi;
        public new void nhap()
        {
            base.nhap();
            sochongoi = int.Parse(Console.ReadLine());
        }
        public new void xuat()
        {
            base.xuat();
            Console.Write("{0}", sochongoi);
        }
    }
}
