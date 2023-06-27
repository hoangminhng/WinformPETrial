using LibraryRepo.Models;
using LibraryRepo.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElectricStore_NguyenVanHoangMinh
{
    public partial class ProductManagement : Form
    {
        private ProductRepo productRepo;
        private CategoryRepo categoryRepo;
        public ProductManagement()
        {
            InitializeComponent();
            loadProduct();

            categoryRepo = new CategoryRepo();
            cbCate.DisplayMember = "CategoryName";
            cbCate.ValueMember = "Id";
            cbCate.DataSource = categoryRepo.GetAll();
            cbCate.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public void loadProduct()
        {
            List<Product> product = new List<Product>();
            productRepo = new ProductRepo();
            categoryRepo = new CategoryRepo();
            var listProduct = productRepo.GetAll();
            for (int i = 0; i < listProduct.Count; i++)
            {
                var productItem = new Product();
                productItem.Id = listProduct[i].Id;
                productItem.ProductName = listProduct[i].ProductName;
                productItem.ProductCode = listProduct[i].ProductCode;
                productItem.Price = listProduct[i].Price;
                productItem.DateCreate = listProduct[i].DateCreate;
                productItem.CategoryId = listProduct[i].CategoryId;
                var cateName = categoryRepo.GetAll().Where(x => x.Id == listProduct[i].CategoryId).FirstOrDefault();
                productItem.Category = cateName;
                product.Add(productItem);
            }
            dataGridView1.DataSource = new BindingSource { DataSource = product };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtProductCodeSearch.Text;
            loadBankAccountByName(search);
        }

        private void loadBankAccountByName(string search)
        {
            List<Product> product = new List<Product>();
            categoryRepo = new CategoryRepo();
            productRepo = new ProductRepo();
            var listProduct = productRepo.GetAll().Where(x => x.ProductCode.ToLower().Contains(search.ToLower())).ToList();
            for (int i = 0; i < listProduct.Count; i++)
            {
                var productItem = new Product();
                productItem.Id = listProduct[i].Id;
                productItem.ProductName = listProduct[i].ProductName;
                productItem.ProductCode = listProduct[i].ProductCode;
                productItem.Price = listProduct[i].Price;
                productItem.DateCreate = listProduct[i].DateCreate;
                productItem.CategoryId = listProduct[i].CategoryId;
                var cateName = categoryRepo.GetAll().Where(x => x.Id == listProduct[i].CategoryId).FirstOrDefault();
                productItem.Category = cateName;
                product.Add(productItem);
            }
            dataGridView1.DataSource = new BindingSource() { DataSource = product };
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryRepo = new CategoryRepo();
            productRepo = new ProductRepo();
            txtProductDate.Enabled = false;
            var product = productRepo.GetAll().ToList()[e.RowIndex];
            txtProductID.Text = product.Id.ToString();
            txtProductName.Text = product.ProductName;
            txtProductCode.Text = product.ProductCode;
            txtProductPrice.Value = product.Price.Value;
            txtProductDate.Text = product.DateCreate.ToString();
            cbCate.Text = categoryRepo.GetAll().FirstOrDefault(x => x.Id == product.CategoryId).CategoryName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            productRepo = new ProductRepo();
            try
            {
                var account = productRepo.GetAll().ToList()[dataGridView1.CurrentRow.Index];
                DialogResult result = MessageBox.Show("Are you sure want to delete", "Notice", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    productRepo.Remove(account);
                    loadProduct();
                }
                resetTextBox();
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose account to delete", "Error", MessageBoxButtons.OK);
                throw;
            }
        }



        private void resetTextBox()
        {
            //txtProductName.Text = "";
            //txtAccountName.Text = "";
            //dtpOpenDate.Text = "";
            //comboBox1.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            categoryRepo = new CategoryRepo();
            productRepo = new ProductRepo();
            try
            {
                if (string.IsNullOrEmpty(txtProductName.Text) ||
                string.IsNullOrEmpty(txtProductCode.Text) ||
                cbCate.SelectedItem == null ||
                txtProductPrice == null ||
                txtProductDate == null)
                {
                    MessageBox.Show("Please fill in all required fields", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    string productName = txtProductName.Text;
                    string productCode = txtProductCode.Text;
                    DateTime productCreateDate = DateTime.UtcNow.Date;
                    string typeName = cbCate.SelectedItem.ToString();
                    int typeID = categoryRepo.GetAll().FirstOrDefault(x => x.CategoryName == typeName).Id;
                    bool isValidProductCode = Regex.IsMatch(productCode, @"^[A-Z]{4}$");
                    if (isValidProductCode)
                    {
                        Product bankAccount = new Product
                        {
                            ProductName = txtProductName.Text,
                            DateCreate = DateTime.Now,
                            ProductCode = txtProductCode.Text,
                            Price = txtProductPrice.Value,
                            CategoryId = typeID,
                        };
                        bool result = productRepo.Create(bankAccount);
                        if (result)
                        {
                            DialogResult res = MessageBox.Show("Create new product successfully", "Notice", MessageBoxButtons.OK);
                            if (res == DialogResult.OK)
                            {
                                loadProduct();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product code must be 4 character and capital", "Error", MessageBoxButtons.OK);
                    }
                    resetTextBox();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            categoryRepo = new CategoryRepo();
            productRepo = new ProductRepo();
            try
            {
                if (string.IsNullOrEmpty(txtProductName.Text) ||
                    string.IsNullOrEmpty(txtProductCode.Text) ||
                    cbCate.SelectedItem == null ||
                    txtProductPrice == null)
                {
                    MessageBox.Show("Please fill in all required fields", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    string productName = txtProductName.Text;
                    string productCode = txtProductCode.Text;
                    DateTime productCreateDate = DateTime.UtcNow.Date;
                    string typeName = cbCate.SelectedItem.ToString();
                    int typeID = categoryRepo.GetAll().FirstOrDefault(x => x.CategoryName == typeName).Id;
                    bool isValidProductCode = Regex.IsMatch(productCode, @"^[A-Z]{4}$");
                    if (isValidProductCode)
                    {
                        Product bankAccount = new Product
                        {
                            Id = Convert.ToInt32(txtProductID.Value),
                            ProductName = txtProductName.Text,
                            DateCreate = DateTime.Now,
                            ProductCode = txtProductCode.Text,
                            Price = txtProductPrice.Value,
                            CategoryId = typeID,
                        };
                        bool result = productRepo.Update(bankAccount);
                        if (result)
                        {
                            DialogResult res = MessageBox.Show("Update product successfully", "Notice", MessageBoxButtons.OK);
                            if (res == DialogResult.OK)
                            {
                                loadProduct();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product code must be 4 character and capital", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
