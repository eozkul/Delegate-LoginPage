using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frmRefreshPassword : Form
    {
        private readonly IAuthenticationService service;
        private readonly int userId;

        public frmRefreshPassword(IAuthenticationService service, int userId)
        {
            InitializeComponent();
            this.service = service;
            this.userId = userId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            erp.Clear();
            if(txtPassword.Text != txtPasswordAgain.Text)
            {
                erp.SetError(txtPassword, "Eşleşmedi");
                erp.SetError(txtPasswordAgain, "Eşleşmedi");
                return;
            }
            var dto = new UpdateUserPasswordDto() { Password = txtPassword.Text, UserId = userId };
            var result = service.UpdateUserPassword(dto);

            if (result)
            {
                MessageBox.Show("işlem Başarılı");
            }
            else
            {
                MessageBox.Show("işlem Başarısız");
            }
            this.Close();
        }
    }
}
