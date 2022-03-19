using BilgeAdam.ADONET.LoginPage.Extensions;
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
                this.Switch(new frmProductManagement());
            }
            else
            {
                MessageBox.Show("Bu bilgilerle oturum açýlamadý :(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEmail.Text = string.Empty;
                this.txtPassword.Text = string.Empty;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var frmRegister = new frmRegister(service);
            this.Switch(frmRegister);
            //if (reuslt == DialogResult.OK)
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmForgotPassword = new frmForgotPassword(service);
            this.Switch(frmForgotPassword);
            this.Show();
        }

        // SecurityQuestions adýnda bir tablo oluþturun. (Id, Questions(nvarchar(500)))
        // User tablosunda SecurityQuestionId adýnda bir kolon (FK)
        // User tablosunda Answer kolon (güvenlik sorusunun cevabý)(nvarchar(64))




        // Register formu oluþturun. Kullanýcý bilgilerini alýn ve yeni bir kullanýcý insert edin
        // Güvenlik sorularýný bir combobox'ta listeleyin, kullanýcýnýn seçtiði sorunun cevabýný alýn. ve insert edin.



        // baseClass{ public string myProp {get; set;}}
        // childClass : baseClass{biþeyler}
        // var instance = new childClass()
        // private void MyMethod(baseClass instance){..statements}
        //MyMethod(instance)





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



        // Parolamý unuttum süreci, ayrý bir formda olacak
        // Kullanýcýya önce Maili sorulacak. eðer böyle bir mail varsa,
        // db den SecurityQuestions getirilecek
        // Aldýðýnýz cevap dbden doðrulanacak
        // parolayý sýfýrlamak için ayrý bir form açýlacak,
        // kullanýcý yeni parolasýný girecek (passwordAgain olmalý)
        // kullanýcýnýn parolasý update edilecek (Hash ile)
    }
}








/*TODO: ÖDEVLER 19.03.2022-------SON TESLÝM 23.03.2022 22:00 Çarþamba


Ödev1 (kullanýcýnýn doðru cevabý vermesi için 3 hakký olsun yoksa hesabý bloke olsun);
Hesabýn bloke olmasý demek User tablosunda isActive kolonunun false olmasý demektir.
Bunun için User tablosuna boolean bir isActive kolonu ekleyin(Dbeaver ile yapabilirsiniz).
Default olarak hepsi aktif yani isActive = 1 olamalý
Bu implementasyondan sonra kullanýcýnýn giriþ yapma senaryosunu deðiþtirin 
ve sadece aktif kullanýcýlar giriþ yapabilir hale getirin.

Ödev2 (Ürünleri listelediðimiz sayfayý düzenleyin)
Düzenlemeler þunlarý içermelidir;
  1) Paginating olmalý (sayfanýn altýnda sað sol ok tuþlarý olmalý ve veri parça parça gelmeli)(Bunu daha önce yaptýnýz.)
  2) Sayfanýn üst kýsmýnda bulunan Product Search text boxýný çalýþýr hale getirin.
  3) Ekle, Sil, Güncelle butonlarý Aktif hale getirin (Herbiri farklý bir formda olmalý);


ÖNEMLÝ: Ödevlerinizi ba-boost-2022 hesabýndaki bu projenin repository'sini Fork layýp kendi hesabýnýzda yapýnýz.
Ödevler sizlerin kiþisel hesaplarýnýzdaki repositorylerden kontrol edilecek. (Fork Nedir?)
*/