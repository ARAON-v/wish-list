
namespace WishList
{
    partial class DataEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEntryForm));
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtBoxProduct = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblMinPrice = new System.Windows.Forms.Label();
            this.lblMaxPrice = new System.Windows.Forms.Label();
            this.txtBoxMinPrice = new System.Windows.Forms.TextBox();
            this.txtBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAccept.Location = new System.Drawing.Point(95, 126);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(130, 26);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Add product";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtBoxProduct
            // 
            this.txtBoxProduct.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxProduct.Location = new System.Drawing.Point(148, 9);
            this.txtBoxProduct.MaxLength = 22;
            this.txtBoxProduct.Name = "txtBoxProduct";
            this.txtBoxProduct.Size = new System.Drawing.Size(160, 30);
            this.txtBoxProduct.TabIndex = 1;
            this.txtBoxProduct.TextChanged += new System.EventHandler(this.txtBoxProduct_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProduct.Location = new System.Drawing.Point(12, 14);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(57, 19);
            this.lblProduct.TabIndex = 4;
            this.lblProduct.Text = "Product";
            // 
            // lblMinPrice
            // 
            this.lblMinPrice.AutoSize = true;
            this.lblMinPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinPrice.Location = new System.Drawing.Point(12, 50);
            this.lblMinPrice.Name = "lblMinPrice";
            this.lblMinPrice.Size = new System.Drawing.Size(100, 19);
            this.lblMinPrice.TabIndex = 5;
            this.lblMinPrice.Text = "Minimum Price";
            // 
            // lblMaxPrice
            // 
            this.lblMaxPrice.AutoSize = true;
            this.lblMaxPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxPrice.Location = new System.Drawing.Point(12, 86);
            this.lblMaxPrice.Name = "lblMaxPrice";
            this.lblMaxPrice.Size = new System.Drawing.Size(104, 19);
            this.lblMaxPrice.TabIndex = 6;
            this.lblMaxPrice.Text = "Maximum Price";
            // 
            // txtBoxMinPrice
            // 
            this.txtBoxMinPrice.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxMinPrice.Location = new System.Drawing.Point(148, 45);
            this.txtBoxMinPrice.MaxLength = 9;
            this.txtBoxMinPrice.Name = "txtBoxMinPrice";
            this.txtBoxMinPrice.Size = new System.Drawing.Size(160, 30);
            this.txtBoxMinPrice.TabIndex = 7;
            this.txtBoxMinPrice.TextChanged += new System.EventHandler(this.txtBoxMinPrice_TextChanged);
            // 
            // txtBoxMaxPrice
            // 
            this.txtBoxMaxPrice.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxMaxPrice.Location = new System.Drawing.Point(148, 81);
            this.txtBoxMaxPrice.MaxLength = 9;
            this.txtBoxMaxPrice.Name = "txtBoxMaxPrice";
            this.txtBoxMaxPrice.Size = new System.Drawing.Size(160, 30);
            this.txtBoxMaxPrice.TabIndex = 8;
            this.txtBoxMaxPrice.TextChanged += new System.EventHandler(this.txtBoxMaxPrice_TextChanged);
            // 
            // FormForDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 164);
            this.Controls.Add(this.txtBoxMaxPrice);
            this.Controls.Add(this.txtBoxMinPrice);
            this.Controls.Add(this.lblMaxPrice);
            this.Controls.Add(this.lblMinPrice);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.txtBoxProduct);
            this.Controls.Add(this.btnAccept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 203);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(336, 203);
            this.Name = "FormForDataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormForDataEntry_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtBoxProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblMinPrice;
        private System.Windows.Forms.Label lblMaxPrice;
        private System.Windows.Forms.TextBox txtBoxMinPrice;
        private System.Windows.Forms.TextBox txtBoxMaxPrice;
    }
}