using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentAP
{
    public class Controller
    {
        private Product _product = new Product();
        private List<Product> _listProduct = new List<Product>();

        public void ThemMoiSanPham()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập id sản phẩm.");
            _product.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tên sản phẩm.");
            _product.Ten = Console.ReadLine();
            Console.WriteLine("Nhập giá sản phẩm.");
            _product.Gia = int.Parse(Console.ReadLine());
            Console.WriteLine("Thông tin sản phẩm vừa nhập là:");
            Console.WriteLine($"Product Id: {_product.Id}, Product Name: {_product.Ten}, Price: {_product.Gia}");
            _listProduct.Add(_product);
        }

        public void HienThiHoSoSanPham()
        {
            Console.WriteLine("Danh sách sản phẩm gồm:");
            Console.WriteLine("Product Id \t||\t Product Name \t||\t Price \t||");
            for (int i = 0; i < _listProduct.Count; i++)
            {
                var product01 = _listProduct[i];
                Console.WriteLine($"{product01.Id} \t\t||\t {product01.Ten} \t\t||\t {product01.Gia}  ||");
            }
        }

        public void XoaSanPham()
        {
            Console.WriteLine("Nhập id cần xóa:");
            _product.Id = int.Parse(Console.ReadLine());
            for (int i = 0; i < _listProduct.Count; i++)
            {
                var products = _listProduct[i].Id;
                if (_product.Id == products)
                {
                    _listProduct.Remove(_product);
                    Console.WriteLine("Xóa thành công.");
                }
                else
                {
                    Console.WriteLine("Id không tồn tại.");
                }
            }
        }
    }
}