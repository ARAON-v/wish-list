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
    public partial class MaimForm : Form
    {
        public MaimForm()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            ItemFromSheet.GetMainForm(this);
            DbCommunicator.Communicator.OpenConnection();
            var itemsList = await DbCommunicator.Communicator.ReadAllItems();
            foreach (var item in itemsList)
            {
                ItemFromSheet itemFromSheet = new ItemFromSheet(item);
            }
            ResizeForm(itemsList.Count);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {

            DataEntryForm formForDataEntry = new DataEntryForm();
            this.Enabled = false;
            DataEntryForm.GetMainForm(this);
            formForDataEntry.Show();
        }

        public void ResizeForm(int ItemsCount)
        {
            int FormHeightSize = Size.Height + (ItemFromSheet.buttonAndLabelHeight * ItemsCount);
            if (FormHeightSize < 900)
            {
                MaximumSize = new Size(Size.Width, FormHeightSize);
                AutoScroll = false;
            }
            else
            {
                MaximumSize = new Size(Size.Width, 900);
                AutoScroll = true;
            }
            MinimumSize = MaximumSize;
            Size = MaximumSize;
        }
    }
}
