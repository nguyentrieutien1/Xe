using Homework_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xe
{
    class HopDongChoThue
    {
        string soHopDong;
        Xe xe;
        Nguoi nhanVien;
        Nguoi khachHang;
        int soNgayThue;
        double donGia;
        DateTime ngayThue;
        List<QuanLyXe> nguoiList;
        public int thanhTien()
        {

            Console.Write("Nhap vao so cho ngoi 5 or 7 :");
            int choNgoi = int.Parse(Console.ReadLine());
            if (new QuanLyXe().LoaiXe == "CH")
            {
                donGia = 500;
            }
            else if (new QuanLyXe().LoaiXe == "DL")
            {
                if (choNgoi <= 5)
                {
                    donGia = 500;
                }
                else if (choNgoi <= 7)
                {
                    donGia = 700;
                }
                else
                {
                    donGia = 1000;
                }
            }

            return (int)(donGia) * soNgayThue;
        }
        public void nhap()
        {
            string ketQuaTimXe;
            QuanLyXe quanLyXe = new QuanLyXe();

            quanLyXe.nhap();
            Console.Write("Nhap vao bien so xe can thue :");
            string bienSo = Console.ReadLine();
            ketQuaTimXe = quanLyXe.timBienSo(bienSo);
            if (ketQuaTimXe != "")
            {
                NhanVien nv = new NhanVien();
                KhachHang kh = new KhachHang();
                nv.nhap();
                kh.nhap();
            }
        }

    }
}
