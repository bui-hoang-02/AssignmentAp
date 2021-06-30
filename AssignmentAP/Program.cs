using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentAP
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Controller controller = new Controller();
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("|-----Chương trình quản lý sản phẩm------|");
                Console.WriteLine("|----------------------------------------|");
                Console.WriteLine("| 1. Thêm hồ sơ sản phẩm.                |");
                Console.WriteLine("| 2. Hiển thị hồ sơ sản phẩm.            |");
                Console.WriteLine("| 3. Xóa sản phẩm theo id.               |");
                Console.WriteLine("| 0. Thoát.                              |");
                Console.WriteLine("|----------------------------------------|");
                Console.WriteLine("| Vui lòng nhập lựa chọn của bạn (0 -> 3)|");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        controller.ThemMoiSanPham();
                        break;
                    case 2:
                        controller.HienThiHoSoSanPham();
                        break;
                    case 3:
                        controller.XoaSanPham();
                        break;
                    case 0:
                        Console.WriteLine("Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi.");
                        break;
                }
            }
        }
    }
}