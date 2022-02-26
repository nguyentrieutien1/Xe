using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xe
{
    internal class SoHopDong
    {
        Dictionary<string, HopDongChoThue> soCai = new Dictionary<string, HopDongChoThue>();
        public void luu()
        {
            int soHopDong = int.Parse(Console.ReadLine());
            for (int i = 0; i < soHopDong; i++)
            {
                Console.Write("Nhap vao hop dong thu {0}", i + 1);
                string hopDong = Console.ReadLine();
                soCai.Add(hopDong, new HopDongChoThue());

            }
        }
        public void tim(string soHopDong)
        {
            Boolean timSoHopDong = soCai.ContainsKey(soHopDong);
            if (timSoHopDong)
            {
                Console.Write("Hop dong cua ban la : {0}", soCai[soHopDong]);
            }
        }
        public void xoa(string soHopDong)
        {
            Boolean timSoHopDong = soCai.ContainsKey((soHopDong));
            if (timSoHopDong)
            {
                soCai.Remove(soHopDong);
                Console.Write("Da xoa hop dong co ten :", soHopDong);
            }
            else
            {
                Console.Write("Hop dong khong tim thay !!!");
            }
        }
    }
}
