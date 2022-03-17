using BilgeAdam.Data.Abstractions;
using BilgeAdam.Data.Concretes;
using BilgeAdam.Data.Dtos;

namespace BilgeAdam.ADONET.LoginPage
{
    public partial class frm_Login : Form
    {
        private IAuthenticationService service;

        public frm_Login()
        {
            InitializeComponent();
            service = new AuthenticationService();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var dto = new CheckUserDto { Email = txtEmail.Text, Password = txtPassword.Text };
            var result = service.CheckUser(dto);

            if (result)
            {
                MessageBox.Show("Giriþ baþarýlý :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu bilgilerle oturum açýlamadý :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEmail.Text = String.Empty;
                this.txtPassword.Text = String.Empty;
            }
        }

        // Bir login sayfasý dizayný oluþturun.
        // Kullanýcý email ve password bilgilerini girsin
        // Eðer db varsa böyle bir kayýt(User Tablosu) giriþ baþarýlý uyarýsý
        // yoksa Bu bilgilerle oturum açýlamadý uyarýsý versin
        /*
         @"CREATE TABLE Users(
                            Id INT PRIMARY KEY IDENTITY(1,1),
                            FirstName NVARCHAR(64) NOT NULL,
                            LastName NVARCHAR(64) NOT NULL,
                            Email NVARCHAR(64) NOT NULL,
                            Password NVARCHAR(128) NOT NULL,
                            CreatedAt DATETIME NOT NULL,
                            CreatedBy NVARCHAR(64) NULL
                    )"
         */
    }
}