namespace BaiTapClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TestSinhVien01();
        }

        static void TestList()
        {
            // Danh sách các đối tượng
            var lst = new List<SinhVien>();

            #region Khởi tạo một đối tượng SinhVien và add vào lst
            var sv = new SinhVien();
            sv.MaSinhVien = "T1";
            sv.HoVaTen = "Nguyen Van";
            sv.GioiTinhNam = true;
            sv.NgaySinh = DateTime.Now; // Now là thuộc tính static của class DateTime

            lst.Add(sv);
            #endregion

            #region Add vào lst một đối tượng, sau đó thay đổi thuộc tính của đt đó
            lst.Add(new SinhVien("T2", "Tran Nguyen Phong"));

            lst[1].HoVaTen = "Nguyen Hoang Ha";
            lst[1].NgaySinh = new DateTime(1976, 11, 22);
            #endregion

            #region Xoá bớt 1 phần tử trong lst
            //lst.RemoveAt(1);
            //lst.RemoveAt(0);
            #endregion

            #region Duyệt qua các phần tử trong lst
            //// Duyệt qua các phần tử trong danh sách
            //for (int i = 0; i < lst.Count; i++)
            //{
            //    Console.WriteLine((i+1).ToString() + "\t" + lst[i].ThongTin);
            //}

            //// Duyệt qua các phần tử sử dụng foreach
            //int stt = 1;
            //foreach (SinhVien x in lst)
            //{
            //    Console.WriteLine(stt + " " + x.ThongTin);
            //    stt++;
            //}

            // Duyệt qua danh sách sử dụng cấu trúc lambda
            lst.ForEach(x =>
            {
                Console.Write("[[[[ ");
                Console.Write(x.ThongTin);
                Console.WriteLine(" ]]]");
            });

            // Lấy ra ngày sinh nhỏ nhất trong lst
            var minNgaySinh = lst.Min(x => x.NgaySinh);
            Console.WriteLine("Ngay sinh nho nhat = " + minNgaySinh.ToString("dd/MM/yyyy"));

            var minNgaySinh2 = lst[0].NgaySinh;
            foreach (var x in lst)
                if (x.NgaySinh < minNgaySinh2)
                    minNgaySinh2 = x.NgaySinh;
            Console.WriteLine("Ngay sinh nho nhat = " + minNgaySinh2.ToString("dd/MM/yyyy"));
            #endregion
        }

        static void TestSinhVien01()
        {
            SinhVien sv = new SinhVien();

            /*sv.setMaSinhVien("T1029385");*/
            sv.MaSinhVien = "T1029385";
            Console.WriteLine("Ma sinh vien = " + sv.MaSinhVien);

            sv.HoVaTen = ""; // thiết lập giá trị cho thuộc tính HoVaTen, sử dụng setter

            Console.WriteLine($"Ho va ten = {sv.HoVaTen}");
            Console.WriteLine("Ho va ten = " + sv.HoVaTen); // lấy giá trị, sử dụng getter
        }
    }
}