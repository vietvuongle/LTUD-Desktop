namespace LopKeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //TestKeThua01();
            //TestKeThua02();
            List<Hinh> danhSachHinhHoc = DocFile("D:\\C#\\Day02\\LTUD-Desktop\\Hinh.txt");
            InDanhSachHinhHoc(danhSachHinhHoc);
        }

        static List<Hinh> DocFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            List<Hinh> danhSachHinh = new List<Hinh>();

            foreach (var h in lines)
            {
                string[] parts = h.Split('|');

                if (parts.Length == 3 && parts[0] == "CN")
                {
                    Double chieuDai = Double.Parse(parts[1].Trim());
                    Double chieuRong = Double.Parse(parts[2].Trim());

                    danhSachHinh.Add(new HinhChuNhat(chieuDai, chieuRong));
                }
                else if (parts.Length == 2 && parts[0] == "T") {
                    Double banKinh = Double.Parse(parts[1].Trim());

                    danhSachHinh.Add(new HinhTron(banKinh));
                }
            }
            return danhSachHinh;
        }

        static void InDanhSachHinhHoc(List<Hinh> danhSachHinhHoc)
        {
            Console.WriteLine("STT    Loai hinh        Thong tin           Chu vi       Dien tich");

            for (int i = 0; i < danhSachHinhHoc.Count; i++)
            {
                var hinh = danhSachHinhHoc[i];
                Console.WriteLine($"{i + 1}     {hinh.LoaiHinh(),-15} {hinh.GetThongTin(),-20} {hinh.GetChuVi(),-12:F2} {hinh.GetDienTich(),-12:F2}");
            }
        }

        static void TestKeThua01()
        {
            Hinh x;

            x = new HinhChuNhat(10, 5);

            Console.WriteLine("Chu vi HCN = " + x.GetChuVi()); // 30
            Console.WriteLine("Dien tich HCN = " + x.GetDienTich()); // 50 <--- -1???
            Console.WriteLine("Dien tich HCN = " + ((HinhChuNhat)x).GetDienTich()); // 50 
        }

        static void TestKeThua02()
        {
            var lst = new List<Hinh>();
            lst.Add(new HinhChuNhat(6, 2));
            lst.Add(new HinhChuNhat(16, 12));
            lst.Add(new HinhTron(6));
            lst.Add(new HinhChuNhat(11, 3));
            lst.Add(new HinhTron(16));

            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i].GetThongTin()
                        + " CV = " + lst[i].GetChuVi()
                        + " DT = " + lst[i].GetDienTich());
                //if (lst[i] is HinhTron)
                //    Console.Write(((HinhTron)lst[i]).GetDienTich());
                //else if (lst[i] is HinhChuNhat)
                //    Console.Write(((HinhChuNhat)lst[i]).GetDienTich());
            }
        }
    }
}
