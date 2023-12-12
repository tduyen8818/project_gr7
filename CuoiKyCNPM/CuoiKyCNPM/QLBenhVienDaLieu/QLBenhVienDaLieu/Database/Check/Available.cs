using System;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLBenhVienDaLieu.Database.Check
{
    internal class Available
    {
        /// <summary>
        /// Kiểm tra xem ngày sinh có hợp lệ hay không.
        /// </summary>
        /// <param name="ngaySinh">Thông tin ngày sinh cần kiểm tra.</param>
        /// <returns>
        /// true nếu ngày sinh hợp lệ, 
        /// false nếu ngược lại.
        /// </returns>
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

        /// <summary>
        /// Kiểm tra xem số điện thoại có hợp lệ hay không.
        /// </summary>
        /// <remarks>
        /// Số điện thoại hợp lệ phải có 10 số và phải bắt đầu bằng số 0.
        /// </remarks>
        /// <param name="soDienThoai">Thông tin số điện thoại cần kiểm tra.</param>
        /// <returns>
        /// true nếu số điện thoại hợp lệ, 
        /// false nếu ngược lại.
        /// </returns>
        public static bool CheckSoDienThoai(string soDienThoai)
        {
            if (soDienThoai.Length == 10 && Regex.Match(soDienThoai, @"0\d{9}").Success)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Kiểm tra xem căn cước công dân có hợp lệ hay không.
        /// </summary>
        /// <remarks>
        /// Căn cước công dân hợp lệ phải có 12 số và chúng phải có định dạng sau:<br/><br/>
        /// - 3 số đầu căn cước công dân là mã tỉnh hoặc thành phố chúng phải nằm trong các mã sau:<br/>
        /// "001", "002", "004", "006", "008", "010", "011", "012", "014", "015",<br/>
        /// "017", "019", "020", "022", "024", "025", "026", "027", "030", "031",<br/>
        /// "033", "034", "035", "036", "037", "038", "040", "042", "044", "045",<br/>
        /// "046", "048", "049", "051", "052", "054", "056", "058", "060", "062",<br/> 
        /// "064", "066", "067", "068", "070", "072", "074", "075", "077", "079",<br/>
        /// "080", "082", "083","084", "086", "087", "089", "091", "092", "093",<br/>
        /// "094", "095", "096".<br/><br/>
        /// - 1 số tiếp theo là mã giới tính, chúng tuân theo quy tắc sau:<br/>
        /// + 0: là giới tính nam có năm sinh &lt; 2000.<br/>
        /// + 1: là giới tính nữ có năm sinh &lt; 2000.<br/>
        /// + 2: là giới tính nam có năm sinh &lt; 2100.<br/>
        /// + 3: là giới tính nữ có năm sinh &lt; 2100.<br/>
        /// + 4: là giới tính nam có năm sinh &lt; 2200.<br/>
        /// + 5: là giới tính nữ có năm sinh &lt; 2200.<br/>
        /// + 6: là giới tính nam có năm sinh &lt; 2300.<br/>
        /// + 7: là giới tính nữ có năm sinh &lt; 2300.<br/>
        /// + 8: là giới tính nam có năm sinh &lt; 2400.<br/>
        /// + 9: là giới tính nữ có năm sinh &lt; 2400.<br/><br/>
        /// - 2 số tiếp theo là mã năm sinh tương ứng với 2 số cuối năm sinh, ví dụ: 1984 là 84.<br/><br/>
        /// - 6 số cuối là số ngẫu nhiên.
        /// </remarks>
        /// <param name="CCCD">Thông tin căn cước công dân cần kiểm tra.</param>
        /// <param name="ngaySinh">Thông tin về ngày sinh để hỗ trợ kiểm tra căn cước công dân.</param>
        /// <param name="gioiTinh">Thông tin về giới tính để hỗ trợ kiểm tra căn cước công dân.</param>
        /// <returns>
        /// true nếu căn cước công dân hợp lệ, 
        /// false nếu ngược lại.
        /// </returns>
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

        /// <summary>
        /// Kiểm tra xem giới tính có hợp lệ hay không.
        /// </summary>
        /// <remarks>
        /// Giới tính hợp lệ thuộc một trong các giới tính: nam, nữ, male, female.
        /// </remarks>
        /// <param name="gioiTinh">Thông tin giới tính cần kiểm tra.</param>
        /// <returns>
        /// true nếu giới tính hợp lệ, 
        /// false nếu ngược lại.
        /// </returns>
        public static bool CheckGioiTinh(string gioiTinh)
        {
            if (gioiTinh.ToLower().Equals("nam") || gioiTinh.ToLower().Equals("nữ") || gioiTinh.ToLower().Equals("male") || gioiTinh.ToLower().Equals("female"))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Kiểm tra xem họ và tên có hợp lệ hay không. 
        /// </summary>
        /// <remarks>
        /// Họ tên hợp lệ là họ tên không chứa số.
        /// </remarks>
        /// <param name="name">Thông tin họ và tên cần kiểm tra.</param>
        /// <returns>
        /// true nếu họ và tên hợp lệ, 
        /// false nếu ngược lại.
        /// </returns>
        public static bool CheckHoVaTen(string name)
        {
            if (!Regex.Match(name, @"\d").Success && !name.Equals(""))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Kiểm tra xem mã bảo hiểm y tế có hợp lệ hay không.
        /// </summary>
        /// <remarks>
        /// Thẻ bảo hiểm y tế hợp lệ phải có 15 chữ số và chúng phải định dạng sau:<br/><br/>
        /// - 2 số đầu căn cước công dân thể hiện mã đối tượng,chúng phải nằm trong các từ sau:<br/>
        /// "DN", "HX", "CH", "NN", "TK", "HC", "XK", "HT", "TB", "NO", "CT", "XB",<br/>
        /// "TN", "CS", "QN", "CA", "CY", "XN", "MS", "CC", "CK", "CB", "KC", "HD",<br/>
        /// "TE", "BT", "HN", "DT", "DK", "XD", "TS", "TC", "TQ", "TA", "TY", "HG",<br/>
        /// "LS", "PV", "CN", "HS", "SV", "GB", "GD".<br/><br/>
        /// - 1 số tiếp theo phải tương ứng với mã mức thưởng của 2 số đầu, tương ứng với ở trên là:<br/>
        /// 4, 4, 4, 4, 4, 4, 4, 3, 4, 4, 4, 4<br/>
        /// 4, 4, 5, 5, 5, 4, 4, 1, 2, 4, 2, 4<br/>
        /// 1, 2, 2, 2, 2, 2, 2, 3, 4, 4, 4, 4<br/>
        /// 4, 4, 3, 4, 4, 4, 4.<br/><br/>
        /// - 2 số tiếp theo thể hiện mã tỉnh hoặc thành phố, chúng nằm trong khoảng 0-99.<br/><br/>
        /// - 10 số còn lại là số ngẫu nhiên.
        /// </remarks>
        /// <param name="maBHYT">thông tin mã bảo hiểm y tế cần kiểm tra.</param>
        /// <returns>
        /// true nếu mã bảo hiểm y tế hợp lệ, 
        /// false nếu ngược lại.
        /// </returns>
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

        /// <summary>
        /// Kiểm tra xem nghề nghiệp có hợp lệ hay không.
        /// </summary>
        /// <remarks>
        /// Nghề nghiệp hợp lệ là nghề nghiệp không chứa số.
        /// </remarks>
        /// <param name="ngheNghiep">thông tin về nghề nghiệp cần kiểm tra.</param>
        /// <returns>
        /// true nếu nghề nghiệp hợp lệ, 
        /// false nếu ngược lại.
        /// </returns>
        public static bool CheckNgheNghiep(string ngheNghiep)
        {
            return CheckHoVaTen(ngheNghiep);
        }

        /// <summary>
        /// Kiểm tra xem email có hợp lệ hay không.
        /// </summary>
        /// <remarks>
        /// Email hợp lệ là email có định dạnh example@gmail.com hoặc example123@gmail.com.
        /// </remarks>
        /// <param name="email">Thông tin về email cần kiểm tra.</param>
        /// <returns>
        /// true nếu email hợp lệ, 
        /// false nếu ngược lại.
        /// </returns>
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
