using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentAP
{
    internal class Program
    {
        
        private static List<Product> _listProduct = new List<Product>();
        public static void Main(string[] args)
        {
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
                        ThemMoiSanPham();
                        break;
                    case 2:
                        HienThiHoSoSanPham();
                        break;
                    case 3:
                        XoaSanPham();
                        break;
                    case 0:
                        Console.WriteLine("Cảm ơn bạn đã sử dụng dịch vụ của chúng tôi.");
                        break;
                }
            }
        }
        private static void ThemMoiSanPham()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Product product = new Product();
            Console.WriteLine("Nhập id sản phẩm.");
            product.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tên sản phẩm.");
            product.Ten = Console.ReadLine();
            Console.WriteLine("Nhập giá sản phẩm.");
            product.Gia = int.Parse(Console.ReadLine());
            Console.WriteLine("Thông tin sản phẩm vừa nhập là:");
            Console.WriteLine($"Product Id: {product.Id}, Product Name: {product.Ten}, Price: {product.Gia}");
            _listProduct.Add(product);
        }
        
        private static void HienThiHoSoSanPham()
        {
            
            Console.WriteLine("Danh sách sản phẩm gồm:");
            Console.WriteLine("Product Id \t||\t Product Name \t||\t Price \t||");
            for (int i = 0; i < _listProduct.Count; i++)
            {
                var product01 = _listProduct[i];
                Console.WriteLine($"{product01.Id} \t\t||\t {product01.Ten} \t\t||\t {product01.Gia}  ||");
            }
        }
        
        private static void XoaSanPham()
        {
            Console.WriteLine("Nhập id cần xóa:");
            int IdSanPham = int.Parse(Console.ReadLine());
            for (int i = 0; i < _listProduct.Count; i++)
            {
                _listProduct.RemoveAt(IdSanPham);
            }
        }
    }
}