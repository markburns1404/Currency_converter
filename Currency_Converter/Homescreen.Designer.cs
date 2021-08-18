namespace Currency_Converter
{
    partial class Homescreen
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
            this.btn_add_currency = new System.Windows.Forms.Button();
            this.btn_convert_currency = new System.Windows.Forms.Button();
            this.btn_audit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_add_currency
            // 
            this.btn_add_currency.Location = new System.Drawing.Point(64, 89);
            this.btn_add_currency.Name = "btn_add_currency";
            this.btn_add_currency.Size = new System.Drawing.Size(131, 23);
            this.btn_add_currency.TabIndex = 0;
            this.btn_add_currency.Text = "Add Currency";
            this.btn_add_currency.UseVisualStyleBackColor = true;
            this.btn_add_currency.Click += new System.EventHandler(this.btn_add_currency_Click);
            // 
            // btn_convert_currency
            // 
            this.btn_convert_currency.Location = new System.Drawing.Point(64, 149);
            this.btn_convert_currency.Name = "btn_convert_currency";
            this.btn_convert_currency.Size = new System.Drawing.Size(131, 23);
            this.btn_convert_currency.TabIndex = 1;
            this.btn_convert_currency.Text = "Convert Currency";
            this.btn_convert_currency.UseVisualStyleBackColor = true;
            this.btn_convert_currency.Click += new System.EventHandler(this.btn_convert_currency_Click);
            // 
            // btn_audit
            // 
            this.btn_audit.Location = new System.Drawing.Point(64, 206);
            this.btn_audit.Name = "btn_audit";
            this.btn_audit.Size = new System.Drawing.Size(131, 23);
            this.btn_audit.TabIndex = 2;
            this.btn_audit.Text = "Audit";
            this.btn_audit.UseVisualStyleBackColor = true;
            this.btn_audit.Click += new System.EventHandler(this.btn_audit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Homescreen";
            // 
            // Homescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_audit);
            this.Controls.Add(this.btn_convert_currency);
            this.Controls.Add(this.btn_add_currency);
            this.Name = "Homescreen";
            this.Text = "Homescreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_currency;
        private System.Windows.Forms.Button btn_convert_currency;
        private System.Windows.Forms.Button btn_audit;
        private System.Windows.Forms.Label label1;
    }
}