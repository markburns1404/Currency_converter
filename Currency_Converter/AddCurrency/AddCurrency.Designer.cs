namespace Currency_Converter
{
    partial class AddCurrency
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_add_currency = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.txt_currency_value = new System.Windows.Forms.TextBox();
            this.txt_currency_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_title.Location = new System.Drawing.Point(21, 20);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(303, 39);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add New Currency";
            // 
            // btn_add_currency
            // 
            this.btn_add_currency.Location = new System.Drawing.Point(125, 196);
            this.btn_add_currency.Name = "btn_add_currency";
            this.btn_add_currency.Size = new System.Drawing.Size(75, 23);
            this.btn_add_currency.TabIndex = 1;
            this.btn_add_currency.Text = "Add";
            this.btn_add_currency.UseVisualStyleBackColor = true;
            this.btn_add_currency.Click += new System.EventHandler(this.btn_add_currency_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(59, 80);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(80, 13);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Currency Name";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(60, 132);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(99, 13);
            this.lbl_amount.TabIndex = 3;
            this.lbl_amount.Text = "Amount equal to £1";
            // 
            // txt_currency_value
            // 
            this.txt_currency_value.Location = new System.Drawing.Point(60, 149);
            this.txt_currency_value.Name = "txt_currency_value";
            this.txt_currency_value.Size = new System.Drawing.Size(100, 20);
            this.txt_currency_value.TabIndex = 4;
            // 
            // txt_currency_name
            // 
            this.txt_currency_name.Location = new System.Drawing.Point(59, 97);
            this.txt_currency_name.Name = "txt_currency_name";
            this.txt_currency_name.Size = new System.Drawing.Size(100, 20);
            this.txt_currency_name.TabIndex = 5;
            // 
            // AddCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 234);
            this.Controls.Add(this.txt_currency_name);
            this.Controls.Add(this.txt_currency_value);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_add_currency);
            this.Controls.Add(this.lbl_title);
            this.Name = "AddCurrency";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_add_currency;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.TextBox txt_currency_value;
        private System.Windows.Forms.TextBox txt_currency_name;
    }
}

