using System;
using System.Text.RegularExpressions;

namespace QLBenhVienDaLieu.Database.Check
{
    internal class Available
    {
        public static bool CheckNgaySinh(DateTime ngaySinh)
        {
            bool isNamNhuan = ngaySinh.Year % 400 == 0;

            if (isNamNhuan && ngaySinh.Day == 29 && ngaySinh.Month == 2) {
                return false;
            }

            if (ngaySinh.Year < 1900 || ngaySinh.Year > DateTime.Now.Year)
            {
                return false;
            }

            return true;
        }

        public static bool CheckSoDienThoai(string soDienThoai)
        {
            if (soDienThoai.Length == 10 && Regex.Match(soDienThoai, @"0\d{9}").Success)
            {
                return true;
            }

            return false;
        }

        public static bool CheckCCCD(string CCCD, DateTime ngaySinh, string gioiTinh)
        {
            if (CCCD.Length == 12 && CheckNgaySinh(ngaySinh) && CheckGioiTinh(gioiTinh))
            {
                string[] maTinhOrThanhPho = { "001", "002", "004", "006", "008", "010", "011",
                    "012", "014", "015", "017", "019", "020", "022", "024", "025", "026", "027",
                    "030", "031", "033", "034", "035", "036", "037", "038", "040", "042", "044",
                    "045", "046", "048", "049", "051", "052", "054", "056", "058", "060", "062",
                    "064", "066", "067", "068", "070", "072", "074", "075", "077", "079", "080",
                    "082", "083", "084", "086", "087", "089", "091", "092", "093", "094", "095", "096"};

                string xacThucMaNamOrNu = "";

                if (gioiTinh.ToLower().Equals("nam") || gioiTinh.ToLower().Equals("male"))
                {
                    if (ngaySinh.Year < 2000)
                    {
                        xacThucMaNamOrNu = "0";
                    }

                    else if (ngaySinh.Year < 2100)
                    {
                        xacThucMaNamOrNu = "2";
                    }
                    else if (ngaySinh.Year < 2200)
                    {
                        xacThucMaNamOrNu = "4";
                    }
                    else if (ngaySinh.Year < 2300)
                    {
                        xacThucMaNamOrNu = "6";
                    }
                    else if (ngaySinh.Year < 2400)
                    {
                        xacThucMaNamOrNu = "8";
                    }
                    else
                    {
                        xacThucMaNamOrNu = "";
                    }
                }
                else
                {
                    if (ngaySinh.Year < 2000)
                    {
                        xacThucMaNamOrNu = "1";
                    }

                    else if (ngaySinh.Year < 2100)
                    {
                        xacThucMaNamOrNu = "3";
                    }
                    else if (ngaySinh.Year < 2200)
                    {
                        xacThucMaNamOrNu = "5";
                    }
                    else if (ngaySinh.Year < 2300)
                    {
                        xacThucMaNamOrNu = "7";
                    }
                    else if (ngaySinh.Year < 2400)
                    {
                        xacThucMaNamOrNu = "9";
                    }
                    else
                    {
                        xacThucMaNamOrNu = "";
                    }
                }

                string maGioiTinh = CCCD.Substring(3, 1);
                
                if (!maGioiTinh.Equals(xacThucMaNamOrNu))
                {
                    return false;
                }

                string maNgaySinh = CCCD.Substring(4, 2);

                string xacThucNgaySinh = ngaySinh.Year.ToString().Substring(2,2);

                if (!maNgaySinh.Equals(xacThucNgaySinh))
                {
                    return false;
                }
                

                string baSoDau = CCCD.Substring(0, 3);

                foreach (string value in maTinhOrThanhPho)
                {
                    if (baSoDau.Equals(value))
                    {
                        string randomNumber = CCCD.Substring(6,6);

                        try
                        {
                            int.Parse(randomNumber);

                            return true;
                        } catch(FormatException e)
                        {
                            return false;
                        }
                        
                    }
                }


                return false;
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
            if (!Regex.Match(name, @"\d").Success && !name.Equals(""))
            {
                return true;
            }

            return false;
        }

        public static bool CheckMaBHYT(string maBHYT)
        {
            if (maBHYT.Length == 15)
            {
                (string MaDoiTuong, string MaMucThuong)[] xacThucMaDoiTuongAndMaMucThuong = {("DN", "4"), ("HX", "4"), ("CH", "4"), ("NN", "4"), ("TK", "4"), ("HC", "4"), ("XK", "4"),
                    ("HT", "3"), ("TB", "4"), ("NO", "4"), ("CT", "4"), ("XB", "4"), ("TN", "4"), ("CS", "4"), ("QN", "5"), ("CA", "5"), ("CY", "5"), ("XN", "4"), ("MS","4"),
                    ("CC", "1"), ("CK", "2"), ("CB", "4"), ("KC", "2"), ("HD", "4"), ("TE", "1"), ("BT", "2"), ("HN", "2"), ("DT", "2"), ("DK", "2"), ("XD", "2"), ("TS", "2"), ("TC", "3"),
                    ("TQ", "4"), ("TA", "4"), ("TY", "4"), ("HG", "4"), ("LS", "4"), ("PV", "4"), ("CN", "3"), ("HS", "4"), ("SV", "4"), ("GB", "4"), ("GD", "4")};

                string haiSoDauCCCD = maBHYT.Substring(0, 2);
                
                foreach((string MaDoiTuong, string MaMucThuong) value in xacThucMaDoiTuongAndMaMucThuong)
                {
                    if (haiSoDauCCCD.Equals(value.MaDoiTuong))
                    {
                        string soThuBaCCCD = maBHYT.Substring(2, 1);

                        if (soThuBaCCCD.Equals(value.MaMucThuong))
                        {
                            try
                            {
                                int maTinhOrThanhPho = int.Parse(maBHYT.Substring(3, 2));

                                if (maTinhOrThanhPho >= 1 && maTinhOrThanhPho <= 99) {
                                    
                                    try
                                    {
                                        int.Parse(maBHYT.Substring(5, 10));

                                        return true;
                                    } catch(FormatException)
                                    {
                                        return false;
                                    }

                                } else
                                {
                                    return false;
                                }

                            } catch(FormatException)
                            {
                                return false;
                            }
                        }

                        return false;
                    }
                }


                return false;
            }

            return false;
        }

        public static bool CheckNgheNghiep(string ngheNghiep)
        {
            return CheckHoVaTen(ngheNghiep);
        }

        public static bool CheckEmail(string email)
        {
            if (Regex.Match(email, @"^[a-zA-Z]+\d*\@gmail.com\z").Success)
            {
                return true;
            }

            return false;
        }
    }
}
