using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class Settings : Form
    {
        Form StadSett = new StaduimSteting();
        Form UserSett = new UsersSettings();

        Form AbuotSett= new AbuotSettings();

        public Settings()
        {
            InitializeComponent();
            tabButton1.IsActive = true;
            ShowFormInPanel(StadSett);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       
        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void tabButton1_Click(object sender, EventArgs e)
        {
            tabButton1.IsActive = true;
            tabButton2.IsActive = false;
            tabButton3.IsActive = false;
            ShowFormInPanel(StadSett);
        }

        private void tabButton3_Click(object sender, EventArgs e)
        {
            tabButton1.IsActive = false;
            tabButton2.IsActive = false;
            tabButton3.IsActive = true;
            
            ShowFormInPanel(UserSett);
        }
        private void tabButton2_Click(object sender, EventArgs e)
        {
            tabButton2.IsActive = true;
            tabButton1.IsActive = false;
            tabButton3.IsActive = false;
            ShowFormInPanel(AbuotSett);
        }
        private void ShowFormInPanel(Form form)
        {
            mainContainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.RightToLeftLayout = true;
            form.RightToLeft = RightToLeft.Yes;
            mainContainer.Controls.Add(form);
            form.Show();
        }

        private void mainContainer_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
