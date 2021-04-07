using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace WishList
{
    class ItemFromSheet
    {
        public const byte buttonAndLabelHeight = 30;
        private const byte labelWidth = 240;
        private const byte buttonWidth = 30;
        private const byte indent = 10;

        private static int buttonAndLabelLocationY = indent;
        private static int lblLocationX = indent;
        private static int btnLocationX = lblLocationX + labelWidth + (indent / 5);

        private readonly DataItem dataItem;

        private static MaimForm mainForm;

        private readonly Button newButton = new Button();
        private readonly Label newLabel = new Label();
        private static Button removableButton = new Button();

        private static Dictionary<string, ItemFromSheet> itemsList = new Dictionary<string, ItemFromSheet>();

        public ItemFromSheet(DataItem actualItem)
        {
            dataItem = actualItem;

            if (mainForm == null)
            {
                return;
            }

            createLabel();
            createButton();
            mainForm.Controls.Add(newLabel);
            mainForm.Controls.Add(newButton);
            newLabel.ForeColor = dataItem.Realization ? Color.Green : Color.Red;
            buttonAndLabelLocationY += buttonAndLabelHeight;

            itemsList.Add(dataItem.Id.ToString(), this);
        }

        private void createLabel()
        {
            newLabel.Name = dataItem.Id.ToString();
            newLabel.Text = dataItem.Name;
            newLabel.Location = new Point(lblLocationX, buttonAndLabelLocationY);
            newLabel.Size = new Size(labelWidth, buttonAndLabelHeight);
            newLabel.ForeColor = Color.Red;
            newLabel.MouseClick += Right_Click_My_Label;
            newLabel.MouseDoubleClick += Left_DoubleClick_My_Label;
        }

        private void createButton()
        {
            newButton.Name = dataItem.Id.ToString();
            newButton.Text = "X";
            newButton.Location = new Point(btnLocationX, buttonAndLabelLocationY);
            newButton.Size = new Size(buttonWidth, buttonAndLabelHeight);
            newButton.Click += Click_My_Button;
        }

        public static void GetMainForm(MaimForm form)
        {
            mainForm = form;
        }

        private void Click_My_Button(object sender, EventArgs e) 
        {
            ConfirmationForm formForConfirmation = new ConfirmationForm();
            mainForm.Enabled = false;
            ConfirmationForm.GetMainForm(mainForm);
            removableButton = (Button)(sender);
            formForConfirmation.Show();
        }

        private void Right_Click_My_Label(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var label = (Label)sender;
                ItemFromSheet selectedItem = itemsList[label.Name];

                MessageBox.Show($"{selectedItem?.dataItem.Name}   {selectedItem?.dataItem.MinPrice} - {selectedItem?.dataItem.MaxPrice}");
            }
        }

        private void Left_DoubleClick_My_Label(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var label = (Label)sender;
                
                DbCommunicator.Communicator.ChangeItemRealization(Int32.Parse(label.Name));

                if (label.ForeColor == Color.Red)
                {
                    label.ForeColor = Color.Green;
                }
                else if (label.ForeColor == Color.Green)
                {
                    label.ForeColor = Color.Red;
                }
            }
        }

        public static async void RemoveItem() 
        {
            if (removableButton != null)
            {
                DbCommunicator.Communicator.SubtractItem(Int32.Parse(removableButton.Name));

                mainForm.Controls.Clear();
                itemsList.Clear();

                mainForm.MaximumSize = new Size(320, 70);
                mainForm.MinimumSize = mainForm.MaximumSize;
                mainForm.Size = mainForm.MaximumSize;
                buttonAndLabelLocationY = indent;

                var list = await DbCommunicator.Communicator.ReadAllItems();
                foreach (var item in list)
                {
                    ItemFromSheet itemFromSheet = new ItemFromSheet(item);
                }
                mainForm.ResizeForm(list.Count);
            }
        }
    }
}
