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
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private static Form mainForm;

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            ItemFromSheet.RemoveItem();

            this.Close();
        }

        private void FormForConfirmation_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }

        public static void GetMainForm(Form form)
        {
            mainForm = form;
        }
    }
}
