using ProductManagement.Models;
using ProductManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class frmProdManagement : Form
    {
        private ProductService _productService;
        private ProductDTO _currentProd;
        private ProductDTO _currentProdSearch;
        public frmProdManagement()
        {
            InitializeComponent();
            _productService = new ProductService();
            _currentProd = new ProductDTO();
        }

        private void btn_AddProd_Click(object sender, System.EventArgs e)
        {
            ResetFormField();
        }

        private void btn_SaveProd_Click(object sender, System.EventArgs e)
        {
            if (!isFormProductValid())
            {
                MessageBox.Show("Có trường thông tin còn trống, vui lòng nhập đủ");
                return;
            }
            _currentProd.ProdID = getStringValue(txt_ProdID.Text);
            _currentProd.ProdName = getStringValue(txt_ProdName.Text);
            _currentProd.Quantity = int.Parse(getStringValue(txt_Quantity.Text));
            _currentProd.Price = decimal.Parse(getStringValue(txt_Price.Text));
            _currentProd.Origin = getStringValue(txt_Origin.Text);
            _currentProd.ExpireDate = dtp_ExpireDate.Value;

            _productService.SaveProduct(_currentProd);
            MessageBox.Show("Lưu thông tin SP thành công");
            loadProductData();
        }

        private void btn_DeleteProd_Click(object sender, System.EventArgs e)
        {
            if (_currentProd.ProdID == string.Empty)
            {
                MessageBox.Show("Trường mã SP chưa có, không thể xóa");
                return;
            }

            if (MessageBox.Show("Có muốn xóa SP này không ?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            _productService.DeleteProduct(p => p.ProdID == _currentProd.ProdID);
            loadProductData();
            ResetFormField();
            MessageBox.Show("Xóa SP thành công!");
        }

        private void btn_MaxPriceProd_Click(object sender, System.EventArgs e)
        {
            var maxPriceProd = _productService.GetMaxPriceProduct();
            var products = new List<ProductDTO>
            {
                maxPriceProd
            };
            setGridDataSource(dt_GridSearch, products);
        }

        private void btn_JPProd_Click(object sender, System.EventArgs e)
        {
            var jpProducts = _productService.GetAllProducts(p => p.Origin == "Nhật Bản");
            setGridDataSource(dt_GridSearch, jpProducts);
        }

        private void btn_ExpProd_Click(object sender, System.EventArgs e)
        {
            var expProducts = _productService.GetAllProducts(p => p.ExpireDate <= DateTime.Now);
            setGridDataSource(dt_GridSearch, expProducts);
        }

        private void btn_RangePriceProd_Click(object sender, System.EventArgs e)
        {
            if (!isRangePriceValid())
            {
                MessageBox.Show("Khoảng giá thiếu giá trị đầu hoặc cuối chưa nhập");
                return;
            }
            var startPrice = decimal.Parse(txt_StartPrice.Text);
            var endPrice = decimal.Parse(txt_EndPrice.Text);
            var rangedProducts = _productService
                .GetAllProducts(
                p => p.Price >= startPrice
                && p.Price <= endPrice);
            setGridDataSource(dt_GridSearch, rangedProducts);
        }

        private void btn_DeleteOrg_Click(object sender, System.EventArgs e)
        {
            string org = txt_DeleteOrg.Text;
            if (string.IsNullOrEmpty(org))
            {
                MessageBox.Show("Chưa nhập thông tin nguồn gốc xóa");
                return;
            }
            _productService.DeleteProduct(p => p.Origin == org);
            loadProductData();
        }

        private void btnCheckExp_Click(object sender, System.EventArgs e)
        {
            bool isExpProductAvail = _productService.GetAllProducts(p => p.ExpireDate <= DateTime.Now).FirstOrDefault() != null;

            if (isExpProductAvail)
            {
                MessageBox.Show("Có sản phẩm hết hạn");
            }
            else MessageBox.Show("Không có sản phẩm hết hạn");
        }

        private void btn_DeleteAllProd_Click(object sender, System.EventArgs e)
        {
            _productService.DeleteAllProduct();
            MessageBox.Show("Đã xóa hết sản phẩm");
            loadProductData();
        }

        private void btn_DeleteAllExp_Click(object sender, System.EventArgs e)
        {
            _productService.DeleteProduct(p => p.ExpireDate <= DateTime.Now);
            MessageBox.Show("Đã xóa hết sản phẩm hết hạn");
            loadProductData();
        }

        private void dt_GridProd_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dt_GridProd.SelectedRows.Count > 0)
            {
                var selectedRow = dt_GridProd.SelectedRows[0];
            }
            else
            {
                return;
            }
            _currentProd.ProdID = (string)dt_GridProd.CurrentRow.Cells[0].Value;

            var selectedProd = _productService.GetAllProducts().FirstOrDefault(
                p => p.ProdID == _currentProd.ProdID);

            if (selectedProd == null || string.IsNullOrEmpty(selectedProd.ProdID))
            {
                return;
            }
            _currentProd.ProdName = selectedProd.ProdName.Trim();
            _currentProd.Quantity = selectedProd.Quantity;
            _currentProd.Price = selectedProd.Price;
            _currentProd.Origin = selectedProd.Origin.Trim();
            _currentProd.ExpireDate = selectedProd.ExpireDate;
            setFormData(_currentProd);

            btn_DeleteProd.Enabled = true;
        }

        private void setFormData(ProductDTO product)
        {
            txt_ProdID.Text = product.ProdID;
            txt_ProdName.Text = product.ProdName;
            txt_Price.Text = product.Price.ToString();
            txt_Quantity.Text = product.Quantity.ToString();
            txt_Origin.Text = product.Origin.ToString();
            dtp_ExpireDate.Value = product.ExpireDate;
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_StartPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_EndPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void frmProdManagement_Load(object sender, EventArgs e)
        {
            loadProductData();
        }

        private bool isFormProductValid()
        {
            if (getStringValue(txt_ProdID.Text) == string.Empty)
            {
                MessageBox.Show("Chưa điền mã SP");
                return false;
            }
            if (getStringValue(txt_ProdName.Text) == string.Empty)
            {
                MessageBox.Show("Chưa điền tên SP");
                return false;
            }
            if (getStringValue(txt_Quantity.Text) == string.Empty)
            {
                MessageBox.Show("Chưa điền số lượng");
                return false;
            }
            if (getStringValue(txt_Price.Text) == string.Empty)
            {
                MessageBox.Show("Chưa điền đơn giá");
                return false;
            }
            if (getStringValue(txt_Origin.Text) == string.Empty)
            {
                MessageBox.Show("Chưa điền xuất xứ");
                return false;
            }
            if (dtp_ExpireDate.Value == null)
            {
                MessageBox.Show("Chưa chọn ngày hết hạn");
                return false;
            }
            return true;
        }

        private bool isRangePriceValid()
        {
            if (getStringValue(txt_StartPrice.Text) == string.Empty)
            {
                MessageBox.Show("Chưa điền giá trị đầu khoảng giá");
                return false;
            }
            if (getStringValue(txt_EndPrice.Text) == string.Empty)
            {
                MessageBox.Show("Chưa điền giá trị cuối khoảng giá");
                return false;
            }
            return true;
        }

        private void ResetFormField()
        {
            // Reset TextBox controls to an empty string
            txt_ProdID.Text = string.Empty;
            txt_ProdName.Text = string.Empty;
            txt_Quantity.Text = string.Empty;
            txt_Price.Text = string.Empty;
            txt_Origin.Text = string.Empty;

            // Reset DateTimePicker control to the current date or a specific default date
            dtp_ExpireDate.Value = DateTime.Now;  // You can also set a specific date if desired
            dt_GridProd.ClearSelection();
            dt_GridProd.CurrentCell = null;
            btn_DeleteProd.Enabled = false;
        }

        private void loadProductData()
        {
            var productGridProds = _productService.GetAllProducts();
            var productGridSearches = _productService.GetAllProducts();
            setGridDataSource(dt_GridProd, productGridProds);
            setGridDataSource(dt_GridSearch, productGridSearches);
        }

        private void setGridDataSource(DataGridView dt, List<ProductDTO> items)
        {
            dt.DataSource = null;
            dt.DataSource = items;
        }

        private string getStringValue(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            return input.Trim();
        }

        private void dt_GridSearch_SelectionChanged(object sender, System.EventArgs e)
        {

        }

        private void txt_startPrice_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txt_EnđPrice_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txt_ProdName_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txt_Quantity_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txt_Price_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txt_Origin_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void dtp_ExpireDate_ValueChanged(object sender, System.EventArgs e)
        {

        }

        private void txt_DeleteOrg_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void layoutProductForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
