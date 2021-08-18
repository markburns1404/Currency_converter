namespace Currency_Converter
{
    partial class Converter
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_converted_from = new System.Windows.Forms.ComboBox();
            this.cmb_converted_to = new System.Windows.Forms.ComboBox();
            this.txt_convert_to = new System.Windows.Forms.TextBox();
            this.txt_convert_from = new System.Windows.Forms.TextBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.btn_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert";
            // 
            // cmb_converted_from
            // 
            this.cmb_converted_from.FormattingEnabled = true;
            this.cmb_converted_from.Location = new System.Drawing.Point(44, 108);
            this.cmb_converted_from.Name = "cmb_converted_from";
            this.cmb_converted_from.Size = new System.Drawing.Size(62, 21);
            this.cmb_converted_from.TabIndex = 1;
            // 
            // cmb_converted_to
            // 
            this.cmb_converted_to.FormattingEnabled = true;
            this.cmb_converted_to.Location = new System.Drawing.Point(44, 186);
            this.cmb_converted_to.Name = "cmb_converted_to";
            this.cmb_converted_to.Size = new System.Drawing.Size(62, 21);
            this.cmb_converted_to.TabIndex = 2;
            // 
            // txt_convert_to
            // 
            this.txt_convert_to.Location = new System.Drawing.Point(132, 186);
            this.txt_convert_to.Name = "txt_convert_to";
            this.txt_convert_to.ReadOnly = true;
            this.txt_convert_to.Size = new System.Drawing.Size(100, 20);
            this.txt_convert_to.TabIndex = 3;
            // 
            // txt_convert_from
            // 
            this.txt_convert_from.Location = new System.Drawing.Point(132, 108);
            this.txt_convert_from.Name = "txt_convert_from";
            this.txt_convert_from.Size = new System.Drawing.Size(100, 20);
            this.txt_convert_from.TabIndex = 4;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Location = new System.Drawing.Point(44, 89);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(75, 13);
            this.lbl_from.TabIndex = 5;
            this.lbl_from.Text = "Currency From";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Location = new System.Drawing.Point(44, 170);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(65, 13);
            this.lbl_to.TabIndex = 6;
            this.lbl_to.Text = "Currency To";
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(44, 237);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(188, 23);
            this.btn_convert.TabIndex = 7;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 281);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.txt_convert_from);
            this.Controls.Add(this.txt_convert_to);
            this.Controls.Add(this.cmb_converted_to);
            this.Controls.Add(this.cmb_converted_from);
            this.Controls.Add(this.label1);
            this.Name = "Converter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_converted_from;
        private System.Windows.Forms.ComboBox cmb_converted_to;
        private System.Windows.Forms.TextBox txt_convert_to;
        private System.Windows.Forms.TextBox txt_convert_from;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Button btn_convert;
    }
}