using BaiTap3___Net.BLL;
using BaiTap3___Net.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap3___Net
{
    public partial class ProductManagement : Form
    {
        public int inputMaSP;
        public string inputTenSP = String.Empty;
        public int inputSoLuong;
        public decimal inputDonGia;
        public string inputXuatXu = String.Empty;
        public DateTime inputNgayHetHan;
        private readonly ProductManager _productManager = new ProductManager();
        public decimal inputMinPrice;
        public decimal inputMaxPrice;
        public string inputXXuatXu = String.Empty;

        public ProductManagement()
        {
            InitializeComponent();
            LoadDataGetAll();
        }

        private void ClearInputs()
        {
            InputTextMaSP.Text = String.Empty;
            InputTextTenSP.Text = String.Empty;
            InputTextSoLuong.Text = String.Empty;
            InputTextDonGia.Text = String.Empty;
            InputTextXuatXu.Text = String.Empty;
            InputTextNgayHetHan.Value = DateTime.Now;
        }

        public Product ParseProduct()
        {
            Debug.WriteLine(inputMaSP);
            Debug.WriteLine(inputTenSP);
            Debug.WriteLine(inputSoLuong);
            Debug.WriteLine(inputDonGia);
            Debug.WriteLine(inputXuatXu);
            Debug.WriteLine(inputNgayHetHan);
            return new Product
            {
                MaSP = inputMaSP,
                TenSP = inputTenSP,
                SoLuong = inputSoLuong,
                DonGia = inputDonGia,
                XuatXu = inputXuatXu,
                NgayHetHan = inputNgayHetHan
            };
        }
        private void LoadDataGetAll()
        {
            List<Product> products = _productManager.GetAllProduct();
            dataGVGetAll.DataSource = products;
        }

        private void btnLuuSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputTextMaSP.Text) || !int.TryParse(InputTextMaSP.Text, out inputMaSP))
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            inputTenSP = InputTextTenSP.Text;
            if (string.IsNullOrEmpty(inputTenSP))
            {
                MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(InputTextSoLuong.Text) || !int.TryParse(InputTextSoLuong.Text, out inputSoLuong) || inputSoLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(InputTextDonGia.Text) || !decimal.TryParse(InputTextDonGia.Text, out inputDonGia) || inputDonGia <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            inputXuatXu = InputTextXuatXu.Text;
            if (string.IsNullOrEmpty(inputXuatXu))
            {
                MessageBox.Show("Xuất xứ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (InputTextNgayHetHan.Value <= DateTime.Now)
            {
                MessageBox.Show("Ngày hết hạn phải là ngày tương lai!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            inputNgayHetHan = InputTextNgayHetHan.Value;
            ParseProduct();
            // Save product
            if (_productManager.CheckExistProduct(inputMaSP))
            {
                Product productUpdate = ParseProduct();
                _productManager.UpdateProduct(productUpdate);
                MessageBox.Show("Sản phẩm đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                Product product = ParseProduct();
                _productManager.AddProduct(product);
                MessageBox.Show("Sản phẩm đã được thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDataGetAll();
            ClearInputs();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            // Kiểm tra mã sản phẩm
            if (string.IsNullOrEmpty(InputTextMaSP.Text) || !int.TryParse(InputTextMaSP.Text, out inputMaSP) || inputMaSP <= 0)
            {
                MessageBox.Show("Mã sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_productManager.CheckExistProduct(inputMaSP))
            {
                _productManager.DeleteProduct(inputMaSP);
                MessageBox.Show($"Sản phẩm có mã {inputMaSP} đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Sản phẩm có mã {inputMaSP} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadDataGetAll();
            inputMaSP = 0;
            ClearInputs();
        }

        private void btnSPCDGCN_Click(object sender, EventArgs e)
        {
            Product product = _productManager.FindProductHavePriceHighest();
            List<Product> products = new List<Product>();
            products.Add(product);
            dataGVTimKiem.DataSource = products;
        }

        private void btnSPTNB_Click(object sender, EventArgs e)
        {
            List<Product> products = _productManager.FindProductFromJapan();
            dataGVTimKiem.DataSource = products;
        }

        private void btnXTBSPQH_Click(object sender, EventArgs e)
        {
            List<Product> products = _productManager.GetAllProductHaveExpiredDate();
            dataGVTimKiem.DataSource = products;
        }

        private void btnXCSPCDGAB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InputTextMinPrice.Text) || !decimal.TryParse(InputTextMinPrice.Text, out inputMinPrice))
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(InputTextMaxPrice.Text) || !decimal.TryParse(InputTextMaxPrice.Text, out inputMaxPrice))
            {
                MessageBox.Show("Giá sản phẩm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (inputMinPrice > inputMaxPrice)
            {
                MessageBox.Show("Giá trước phải nhỏ hơn hoặc bằng giá sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Product> products = _productManager.GetAllProductHavePriceBetween(inputMinPrice, inputMaxPrice);
            dataGVTimKiem.DataSource = products;
        }

        private void btnXSPTXXBK_Click(object sender, EventArgs e)
        {
            inputXXuatXu = InputTextXXuatXu.Text;
            if (string.IsNullOrEmpty(inputXXuatXu))
            {
                MessageBox.Show("Tên xuất xứ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_productManager.CheckProductExistByOrigin(inputXXuatXu))
            {
                _productManager.DeleteProductByOrigin(inputXXuatXu);
                MessageBox.Show($"Sản phẩm có xuất xứ {inputXXuatXu} đã được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGetAll();
            }
            else
            {
                MessageBox.Show($"Sản phẩm có xuất xứ {inputXXuatXu} không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnXTBSPTK_Click(object sender, EventArgs e)
        {
            // Delete all product
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả các sản phẩm?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                _productManager.DeleteAllProduct();
                LoadDataGetAll();
                MessageBox.Show("Tất cả sản phẩm đã được xóa.");
            }
        }

        private void btnXXTBSPQH_Click(object sender, EventArgs e)
        {
            // Delete all product
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả các sản phẩm hết hạn?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                _productManager.DeleteAllProductHaveExpiredDate();
                LoadDataGetAll();
                MessageBox.Show("Tất cả sản phẩm hết hạn đã được xóa.");
            }
        }
    }
}
