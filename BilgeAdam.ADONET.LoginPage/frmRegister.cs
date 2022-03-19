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
    public partial class frmRegister : Form
    {
        private readonly IAuthenticationService service;

        public frmRegister(IAuthenticationService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            var result = service.GetSercurityQuestions();
            cmbQuestions.DataSource = result;
            cmbQuestions.DisplayMember = nameof(SecurityQuestionOptionDto.Question);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            erp.Clear();
            if (!IsPasswordsMatched(txtPassword.Text, txtPasswordAgain.Text))
            {
                erp.SetError(txtPassword, "girilen parolalar eşleşmiyor!");
                erp.SetError(txtPasswordAgain, "girilen parolalar eşleşmiyor!");
                return;
            }


            var selectedQuestion = cmbQuestions.SelectedItem as SecurityQuestionOptionDto;
            var dto = new NewUserDto
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Answer = txtAnswer.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                SecurityQuestionId = selectedQuestion.Id
            };

            var result = service.AddNewUser(dto);
            if (result)
            {
                MessageBox.Show("Hesabınız Oluşturuldu", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Beklenmedik bir hata ile karşılaşıldı! Lütfen destek alınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }


        }



        //helper
        private bool IsPasswordsMatched(string password, string passwordAgain)
        {
            return password == passwordAgain;
        }
    }
}
