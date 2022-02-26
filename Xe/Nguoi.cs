abstract class Nguoi
{
    long soChungMinh;
    string hoTen;
    string diaChi;
    string dienThoai;

    public long SoChungMinh { get => soChungMinh; set => soChungMinh = value; }
    public string HoTen { get => hoTen; set => hoTen = value; }
    public string DiaChi { get => diaChi; set => diaChi = value; }



    public string DienThoai { get => dienThoai; set => dienThoai = value; }

    public abstract void nhap();
    public abstract void xuat();
}