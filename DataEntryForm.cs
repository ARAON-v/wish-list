using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WishList
{
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }
        private static MaimForm mainForm;

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            string name = txtBoxProduct.Text;
            double minPrise = double.Parse(txtBoxMinPrice.Text);
            double maxPrise = double.Parse(txtBoxMaxPrice.Text);

            DataItem newItem = new DataItem() { Name = name, MinPrice = minPrise, MaxPrice = maxPrise };
            if (await DbCommunicator.Communicator.AddItem(newItem))
            {
                ItemFromSheet newItemFromSheet = new ItemFromSheet(newItem);
                mainForm.ResizeForm(1);
            }
            this.Close();
        }

        private void txtBoxProduct_TextChanged(object sender, EventArgs e)
        {
            MyTextChanged();
        }

        private void txtBoxMinPrice_TextChanged(object sender, EventArgs e)
        {
            MyTextChanged();

            if (txtBoxMinPrice.Text != null && txtBoxMinPrice.Text != "")
            {
                txtBoxMinPrice.Text = NumberDetection.FilterNumbers(txtBoxMinPrice.Text);
                txtBoxMinPrice.Text = NumberDetection.CommaCheck(txtBoxMinPrice.Text);
            }

            if (txtBoxMinPrice.SelectionStart == 0)
            {
                txtBoxMinPrice.SelectionStart = Text.Length;
            }
        }

        private void txtBoxMaxPrice_TextChanged(object sender, EventArgs e)
        {
            MyTextChanged();

            if (txtBoxMaxPrice.Text != null && txtBoxMaxPrice.Text != "")
            {
                txtBoxMaxPrice.Text = NumberDetection.FilterNumbers(txtBoxMaxPrice.Text);
                txtBoxMaxPrice.Text = NumberDetection.CommaCheck(txtBoxMaxPrice.Text);
            }

            if (txtBoxMaxPrice.SelectionStart == 0)
            {
                txtBoxMaxPrice.SelectionStart = Text.Length;
            }
        }

        private void MyTextChanged()
        {
            if (txtBoxProduct.Text.Length >= 2 && txtBoxMinPrice.Text.Length >= 1 && txtBoxMaxPrice.Text.Length >= 1)
            {
                btnAccept.Enabled = true;
            }
            else
            {
                btnAccept.Enabled = false;
            }
        }

        private void FormForDataEntry_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }

        public static void GetMainForm(MaimForm form) 
        {
            mainForm = form;
        }
    }
}
