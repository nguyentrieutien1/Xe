using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xe
{
    internal class QuanLyXe
    {
        Dictionary<string, Xe> List = new Dictionary<string, Xe>();

       public void nhap()
        {
            int number;
            Console.Write("Nhap vao loai xe :");
            string loaiXe = Console.ReadLine(); 
            Console.Write("Nhap vao so xe ");
             number = int.Parse(Console.ReadLine()); 
            for (int i = 0; i < number; i++)
            {
                if (loaiXe == "H")
                {
                    XeChoHang xech = new XeChoHang();
                    xech.nhap();
                    List.Add(xech.Bienso, xech);

                }
                else if (loaiXe == "D")
                {
                    XeDuLich xedl = new XeDuLich();
                    xedl.nhap();
                    List.Add(xedl.Bienso, xedl);
                }
            }
            
        }

        
        public void xoa(string bienso)  
        {
            if(this.List.ContainsKey(bienso))
            {

                Console.Write("Da xoa xe co bien so {0}", bienso);
                this.List.Remove(bienso);
            }
            else
            {
                Console.Write("Co dau ma xoa :)");
            }
        }
        public string timBienSo(string bienso)
        {
            if (this.List.ContainsKey(bienso))
            {
                return bienso;

            }
            else
            {
                return null;
            }
        }
        static void Main(string[] args)
        {
            QuanLyXe ql = new QuanLyXe();   
            ql.nhap();
            Console.Write("Nhap bien so can tim :");
            string bienSo = Console.ReadLine();
             string result = ql.timBienSo(bienSo);
            if(result != null)
            {
                Console.WriteLine("1 xe co bien so {0}", result);
            }
            else
            {
                Console.Write("Khong co :) \n");
            }
            ql.xoa(bienSo);
        }

        
    }
    
}
