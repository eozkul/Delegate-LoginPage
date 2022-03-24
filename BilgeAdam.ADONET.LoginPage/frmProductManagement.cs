using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Concretes;
using BilgeAdam.Data.Entities;
using System.ComponentModel;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frmProductManagement : Form
    {
        private IProductService service;

        public frmProductManagement()
        {
            InitializeComponent();
            service = new ProductService();
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            var result = service.GetAllProducts();
            dgvProducts.DataSource = new BindingList<Product>(result);
        }
    }
}