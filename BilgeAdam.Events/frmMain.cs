using BilgeAdam.Events.Models;
using System.ComponentModel;

namespace BilgeAdam.Events
{
    public partial class frmMain : Form
    {
        private BindingList<Parent> parents;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadSeedData();
            var now = DateTime.Now;
            dtpBirthDate.MinDate = new DateTime(now.Year, now.Month, now.Day).AddYears(-70);
            dtpBirthDate.MaxDate = new DateTime(now.Year, now.Month, now.Day).AddYears(-18);
            grbMatch.Visible = false;
            lstParents.SelectedIndex = -1;
        }

        private void LoadSeedData()
        {
            parents = new BindingList<Parent>(new List<Parent>()
            {
                new Parent { FullName = "Rüstem Yýldýz", BirthDate = new DateTime(1987, 12, 17), Gender = Gender.Male },
                new Parent { FullName = "Aysun Þenocak", BirthDate = new DateTime(1990, 2, 18), Gender = Gender.Female },
                new Parent { FullName = "Kadir Cündübey", BirthDate = new DateTime(1994, 6, 20), Gender = Gender.Male },
                new Parent { FullName = "Cavit Usta", BirthDate = new DateTime(1992, 8, 30), Gender = Gender.Male },
                new Parent { FullName = "Nihal Tekin", BirthDate = new DateTime(1999, 10, 20), Gender = Gender.Female },
                new Parent { FullName = "Figen Uluca", BirthDate = new DateTime(2000, 3, 27), Gender = Gender.Female },
                new Parent { FullName = "Yaðmur Yanýk", BirthDate = new DateTime(1988, 8, 3), Gender = Gender.Female },
                new Parent { FullName = "Yasemin Boca", BirthDate = new DateTime(1995, 2, 10), Gender = Gender.Female },
                new Parent { FullName = "Hamit Ayrýk", BirthDate = new DateTime(1996, 8, 17), Gender = Gender.Male },
                new Parent { FullName = "Selçuk Kaya", BirthDate = new DateTime(1997, 5, 13), Gender = Gender.Male },
                new Parent { FullName = "Ahmet Yüksek", BirthDate = new DateTime(1991, 2, 26), Gender = Gender.Male },
                new Parent { FullName = "Gülsüm Ceylan", BirthDate = new DateTime(2001, 11, 10), Gender = Gender.Female },
                new Parent { FullName = "Orhan Aydýn", BirthDate = new DateTime(1993, 5, 1), Gender = Gender.Male }
            });
            lstParents.DataSource = parents;
            foreach (var parent in parents)
            {
                parent.onMatched += Parent_onMatched;
                parent.onDisruptMatching += Parent_onDisruptMatching;
            }
        }

        private void Parent_onDisruptMatching(Parent self)
        {
            self.Spouse = null;
            lstParents.SelectedIndex = -1;
        }

        private void Parent_onMatched(Parent self, Parent spouse)
        {
            self.Spouse = spouse;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
            var newParent = new Parent()
            {
                FullName = txtName.Text,
                BirthDate = dtpBirthDate.Value,
                Gender = rdbFemale.Checked ? Gender.Female : Gender.Male,

            };
            newParent.onMatched += Parent_onMatched;
            parents.Add(newParent);
            txtName.Clear();
        }

        private void lstParents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstParents.SelectedIndex == -1)
            {
                grbMatch.Visible = false;
                return;
            }
            grbMatch.Visible = true;

            var selected = lstParents.SelectedItem as Parent;
            txtDisplayName.Text = selected.FullName;
            txtDisplayBirthDate.Text = selected.BirthDate.ToShortDateString();
            if (selected.Spouse is not null)
            {
                cmbParents.DataSource = new object[] { selected.Spouse };
                cmbParents.Enabled = false;
                btnMatch.Text = "Kaldýr";
                return;
            }
            btnMatch.Text = "Eþleþtir";
            cmbParents.Enabled = true;
            cmbParents.DataSource = GetParent(selected).ToList();
        }

        private IEnumerable<Parent> GetParent(Parent selected)
        {
            yield return new Parent { FullName = "Seçiniz" };
            foreach (var parent in parents)
            {
                if (parent.Spouse is not null)
                {
                    continue;
                }
                if (parent.Gender == selected.Gender)
                {
                    continue;
                }
                yield return parent;
            }
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            var self = lstParents.SelectedItem as Parent;
            var spouse = cmbParents.SelectedItem as Parent;
            if (btnMatch.Text == "Kaldýr")
            {
                self.DisruptMatching(spouse);
                return;
            }

            if (spouse.FullName == "Seçiniz")
            {
                MessageBox.Show("Lütfen bir eþ seçiniz");
                return;
            }
            self.SetSpouse(spouse);
            lstParents.SelectedIndex = -1;
        }
    }
}