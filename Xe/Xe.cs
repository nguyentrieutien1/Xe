using System;

namespace Xe;
 class Xe
    {
    string bienso, tenxe;
    int trongtai;
    DateTime ngaydangkiem;
    int tieuchuanbang;

    public string Bienso { get => bienso; set => bienso = value; }
    public string Tenxe { get => tenxe; set => tenxe = value; }
    public int Trongtai { get => trongtai; set => trongtai = value; }
    public DateTime Ngaydangkiem { get => ngaydangkiem; set => ngaydangkiem = value; }
    public int Tieuchuanbang { get => tieuchuanbang; set => tieuchuanbang = value; }

    public void nhap()
    {
        Console.Write("Nhap vao bien so:");
        bienso = Console.ReadLine();

    }
    public void xuat()
    {
        Console.Write("{0}, {1}, {2}, {3}, {4}", bienso, tenxe, trongtai, ngaydangkiem, tieuchuanbang);
    }

    public static implicit operator string(Xe v)
    {
        throw new NotImplementedException();
    }
}
