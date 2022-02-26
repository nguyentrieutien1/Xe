using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    class KhachHang : Nguoi
    {
        string maKhachHang;
        DateTime hangBangLai;
        public override void nhap()
        {

            Console.Write("Nhap so chung minh :");
            SoChungMinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap ho ten :");
            HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi :");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap so dien thoai :");
            DienThoai = Console.ReadLine();
            Console.Write("Nhap ma nhan vien");
            maKhachHang = Console.ReadLine();
            Console.Write("Nhap ngay vao co quan :");
            hangBangLai = DateTime.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            Console.Write("So chung minh la {0} \n ho va ten la {1} \n dia chi la {2} \n so dien thoai la {3} \n ma khach hang la {4} \n hang bang lai la {5}", SoChungMinh, HoTen, DiaChi, DienThoai, maKhachHang, hangBangLai);
        }

    }
}
