using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class SinhVien
    {
        private List<SinhVien> ListSinhVien = null;
        public int MASO { get; set; }
        public string HOVATEN { get; set; }
        public int TUOI { get; set; }
        public string GIOITINH { get; set; }
        public string DIACHI { get; set; }
        public int SDT { get; set; }
        public string NGANH { get; set; }
        public string KHOA { get; set; }
        struct DIEM
        {

        }
        struct TKB
        {

        }
        public int DRl { get; set; }
        public int DCTXH { get; set; }

        private int THEMMSSV()
        {
            int max = 1;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                max = ListSinhVien[0].MASO;
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (max < sv.MASO)
                    {
                        max = sv.MASO;
                    }
                }
                max++;
            }
            return max;
        }
        public void THEMSV()
        {
            SinhVien sv = new SinhVien();
            // NHAP MSSV
            Console.Write("Nhap MSSV cua sinh vien: ");
            sv.MASO = Convert.ToInt32(Console.ReadLine());
            // NHAP HO VA TEN
            Console.Write("Nhap ten cua sinh vien: ");
            sv.HOVATEN = Convert.ToString(Console.ReadLine());
            // NHAP TUOI
            Console.Write("Nhap tuoi cua sinh vien: ");
            sv.TUOI = Convert.ToInt32(Console.ReadLine());
            // NHAP GIOI TINH
            Console.Write("Nhap gioi tinh cua sinh vien: ");
            sv.GIOITINH = Convert.ToString(Console.ReadLine());
            // NHAP DIA CHI
            Console.Write("Nhap dia chi cua sinh vien: ");
            sv.DIACHI = Convert.ToString(Console.ReadLine());
            // NHAP SDT
            Console.Write("Nhap sdt cua sinh vien: ");
            sv.SDT = Convert.ToInt32(Console.ReadLine());
            // NHAP NGANH HOC
            Console.Write("Nhap nganh hoc cua sinh vien: ");
            sv.NGANH = Convert.ToString(Console.ReadLine());
            // NHAP KHOA HỌC
            Console.Write("Nhap khoa hoc cua sinh vien: ");
            sv.KHOA = Convert.ToString(Console.ReadLine());


            ListSinhVien.Add(sv);
        }
        public void DANGKIHOC()
        {
            throw new NotImplementedException();
        }
        public void DANGKIDOAN()
        {
            throw new NotImplementedException();
        }
        public void TTHOCPHI()
        {
            throw new NotImplementedException();
        }
    }
}
