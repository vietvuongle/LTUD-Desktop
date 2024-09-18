using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopKeThua
{
    public class Hinh
    {
        virtual public double GetChuVi()
        {
            return -1;
        }
        virtual public String GetThongTin()
        {
            return "";
        }

        virtual public double GetDienTich()
        {
            return -1;
        }

        virtual public String LoaiHinh()
        {
            return "";
        }
    }

    public class HinhChuNhat : Hinh
    {
        public double ChieuDai { get; set; }

        public double ChieuRong { get; set; }

        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
        }

        public override double GetChuVi()
        {
            return (ChieuDai + ChieuRong) * 2.0f;
        }

        public override double GetDienTich()
        {
            return ChieuDai * ChieuRong;
        }

        public override string GetThongTin()
        {
            return $"Hinh chu nhat {ChieuDai} x {ChieuRong}";
        }

        public override String LoaiHinh()
        {
            return "Hinh chu nhat";
        }
    }

    public class HinhTron : Hinh
    {
        public double BanKinh { get; set; }

        public override double GetChuVi()
        {
            return 3.14158235897f * 2 * BanKinh;
        }

        public override double GetDienTich()
        {
            return 3.14158235897f * BanKinh * BanKinh;
        }

        public override string GetThongTin()
        {
            return $"Hinh tron ban kinh {BanKinh}";
        }

        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
        }

        public override String LoaiHinh()
        {
            return "Hinh tron";
        }
    }
}
