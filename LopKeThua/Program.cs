namespace LopKeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //TestKeThua01();
            TestKeThua02();
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
