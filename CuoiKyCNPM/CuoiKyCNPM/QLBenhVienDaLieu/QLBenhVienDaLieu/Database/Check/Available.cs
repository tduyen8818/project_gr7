using System;
using System.Text.RegularExpressions;

namespace QLBenhVienDaLieu.Database.Check
{
    internal class Available
    {
        public static bool CheckNgaySinh(DateTime ngaySinh)
        {
            int[] thang = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if ((ngaySinh.Year > 1900 && ngaySinh.Year <= DateTime.Now.Year) && (ngaySinh.Day <= thang[ngaySinh.Month - 1]))
            {
                return true;
            }

            return false;
        }

        public static bool CheckSoDienThoai(string soDienThoai)
        {
            if (soDienThoai.Length == 10 && Regex.Match(soDienThoai, @"0\d{9}").Success)
            {
                return true;
            }

            return false;
        }

        public static bool CheckCCCD(string CCCD)
        {
            if (CCCD.Length == 12 && Regex.Match(CCCD, @"0\d{11}").Success)
            {
                return true;
            }

            return false;
        }

        public static bool CheckGioiTinh(string gioiTinh)
        {
            if (gioiTinh.ToLower().Equals("nam") || gioiTinh.ToLower().Equals("nữ") || gioiTinh.ToLower().Equals("male") || gioiTinh.ToLower().Equals("female"))
            {
                return true;
            }

            return false;
        }

        public static bool CheckHoVaTen(string name)
        {
            if (!Regex.Match(name, @"\d").Success)
            {
                return true;
            }

            return false;
        }

        public static bool CheckMaBHYT(string maBHYT)
        {
            if (maBHYT.Length == 15 && Regex.Match(maBHYT, @"[a-zA-Z]{2}\d{13}").Success)
            {
                return true;
            }
            return false;
        }

        public static bool CheckNgheNghiep(string ngheNghiep)
        {
            return CheckHoVaTen(ngheNghiep);
        }

        public static bool CheckEmail(string email)
        {
            if (Regex.Match(email, @"^[a-zA-Z]+\@gmail.com\z").Success)
            {
                return true;
            }

            return false;
        }
    }
}
