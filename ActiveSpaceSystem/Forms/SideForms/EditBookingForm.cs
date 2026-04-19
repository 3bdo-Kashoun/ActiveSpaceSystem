using ActiveSpaceSystem.Forms.Views;
using System;
using System.Windows.Forms;

namespace ActiveSpaceSystem.Forms.SideForms
{
    public partial class EditBookingForm : Form
    {
        private BookingViewModel model;

        public EditBookingForm(BookingViewModel model)
        {
            InitializeComponent();
            this.model = model;
            LoadModel();
        }

        private void LoadModel()
        {
            txtCustomer.Text = model.CustomerName;
            txtPhone.Text = model.Phone;
            txtCourt.Text = model.Court;
            txtDate.Text = model.Date;
            txtTime.Text = model.Time;
            numAmount.Value = model.Amount;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            model.CustomerName = txtCustomer.Text;
            model.Phone = txtPhone.Text;
            model.Court = txtCourt.Text;
            model.Date = txtDate.Text;
            model.Time = txtTime.Text;
            model.Amount = numAmount.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}