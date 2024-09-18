using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapClass
{
    internal class SinhVien
    {
        // block 1 - Định nghĩa "thuộc tính" kiểu Java
        /*
        private String maSinhVien;

        public String getMaSinhVien() { return maSinhVien; }

        public void setMaSinhVien(String value) { maSinhVien = value; }
        */

        // block 2 - Định nghĩa thuộc tính trong C# theo kiểu tường minh
        /*
        private String maSinhVien; // back var

        public String MaSinhVien
        {
            get { return maSinhVien; }
            set { maSinhVien = value; }
        }
        */

        // block 3 - Nếu code getter, setter tường minh đơn giản -> có thể viết tắt
        public String MaSinhVien { get; set; }

        // block 4 - Nếu getter, setter phức tạp -> phải định nghĩa tường minh
        private String hoVaTen;
        public String HoVaTen
        {
            get { return hoVaTen; }

            set
            {
                if (value == null || "" == value)
                    value = "KHONG BIET";

                hoVaTen = value;
            }
        }

        //public String getInfo()
        //{
        //    return $"Sinh vien {this.HoVaTen} - Ma sinh vien {this.MaSinhVien}";
        //}

        /// <summary>
        /// Sinh viên có giới tính Nam?
        /// </summary>
        public bool GioiTinhNam { get; set; }

        public DateTime NgaySinh { get; set; }


        /// <summary>
        /// Thông tin tóm tắt của sinh viên
        /// </summary>
        public String ThongTin
        {
            get
            {
                return $"Sinh vien {this.HoVaTen} - Ma sinh vien {this.MaSinhVien}";
            }
        }

        public SinhVien() { }

        /// <summary>
        /// khởi tạo sinh viên
        /// </summary>
        /// <param name="maSV"></param>
        /// <param name="hoVaTen"></param>
        public SinhVien(String maSV, String hoVaTen)
        {
            //this.setMaSinhVien(maSV);
            this.MaSinhVien = maSV;
            this.HoVaTen = hoVaTen;
        }
    }
}
