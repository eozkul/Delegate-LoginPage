﻿using BilgeAdam.ADONET.LoginPage.Extensions;
using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Dtos;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frmForgotPassword : Form
    {
        private readonly IAuthenticationService service;
        private UserQuestionDto user;
        public frmForgotPassword(IAuthenticationService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            erp.Clear();
            var result = service.GetUserByEmail(txtEmail.Text);
            if (result == null)
            {
                erp.SetError(txtEmail, "Böyle bir mail bulunamadı!");
                return;
            }
            grpSecurityQuestionArea.Visible = true;
            lbl_Question.Text = result.Question;
            user = result;
        }

        private void btnSendAnswer_Click(object sender, EventArgs e)
        {
            if (user.Answer != txtAnswer.Text)
            {
                erp.SetError(txtAnswer, "Cevabınız doğru değildir.");
                return;
            }
            this.Switch(new frmRefreshPassword(service, user.Id));
        }
    }


}