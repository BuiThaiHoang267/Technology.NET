using BaiTap3___Net.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3___Net.BLL
{
    public class ProductManager
    {
        private readonly ProductDbContext _context;

        public ProductManager()
        {
            _context = new ProductDbContext();
        }
        // check exist product
        public bool CheckExistProduct(int id)
        {
            return _context.Products.Any(p => p.MaSP == id);
        }
        // get all
        public List<Product> GetAllProduct()
        {
            return _context.Products.ToList();
        }
        // add
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        // update
        public void UpdateProduct(Product product)
        {
            var productUpdate = _context.Products.Find(product.MaSP);
            if (productUpdate != null)
            {
                productUpdate.TenSP = product.TenSP;
                productUpdate.SoLuong = product.SoLuong;
                productUpdate.DonGia = product.DonGia;
                productUpdate.XuatXu = product.XuatXu;
                productUpdate.NgayHetHan = product.NgayHetHan;
                _context.SaveChanges();
            }
        }
        // delete
        public void DeleteProduct(int id) 
        {
            var productDelete = _context.Products.Find(id);
            if (productDelete != null)
            {
                _context.Products.Remove(productDelete);
                _context.SaveChanges();
            }
        }
        // check expired date product
        public bool CheckExpiredDateProduct()
        {
            return _context.Products.Any(p => p.NgayHetHan < DateTime.Now);
        }
        // find 1 product have price highest
        public Product FindProductHavePriceHighest()
        {
            return _context.Products.OrderByDescending(p => p.DonGia).FirstOrDefault()!;
        }
        // find product is producted in Japan
        public List<Product> FindProductFromJapan()
        {
            return _context.Products.Where(p => p.XuatXu == "Nhật Bản").ToList();
        }
        // Get all product have expired date
        public List<Product> GetAllProductHaveExpiredDate()
        {
            return _context.Products.Where(p => p.NgayHetHan < DateTime.Now).ToList();
        }
        // Get all product have price between A and B (A<=B)
        public List<Product> GetAllProductHavePriceBetween(decimal a, decimal b)
        {
            if(a > b)
            {
                return new List<Product>();
            }
            return _context.Products.Where(p => p.DonGia >= a && p.DonGia <= b).ToList();
        }
        // Delete product by origin
        public void DeleteProductByOrigin(string origin)
        {
            var products = _context.Products.Where(p => p.XuatXu == origin).ToList();
            foreach (var product in products)
            {
                _context.Products.Remove(product);
            }
            _context.SaveChanges();
        }
        // DeleteAll
        public void DeleteAllProduct()
        {
            _context.Products.RemoveRange(_context.Products);
            _context.SaveChanges();
        }
        // Check product is exist by origin
        public bool CheckProductExistByOrigin(string origin)
        {
            return _context.Products.Any(p => p.XuatXu == origin);
        }
        // Delete all product have expired date
        public void DeleteAllProductHaveExpiredDate()
        {
            var products = _context.Products.Where(p => p.NgayHetHan < DateTime.Now).ToList();
            foreach (var product in products)
            {
                _context.Products.Remove(product);
            }
            _context.SaveChanges();
        }
    }
}
