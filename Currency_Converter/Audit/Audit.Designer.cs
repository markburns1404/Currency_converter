namespace Currency_Converter
{
    partial class Audit
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
            this.dgv_audit = new System.Windows.Forms.DataGridView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.dt_start_date = new System.Windows.Forms.DateTimePicker();
            this.dt_end_date = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_audit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_audit
            // 
            this.dgv_audit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_audit.Location = new System.Drawing.Point(12, 125);
            this.dgv_audit.Name = "dgv_audit";
            this.dgv_audit.Size = new System.Drawing.Size(593, 313);
            this.dgv_audit.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_title.Location = new System.Drawing.Point(251, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(95, 39);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Audit";
            // 
            // dt_start_date
            // 
            this.dt_start_date.Location = new System.Drawing.Point(14, 96);
            this.dt_start_date.Name = "dt_start_date";
            this.dt_start_date.Size = new System.Drawing.Size(200, 20);
            this.dt_start_date.TabIndex = 2;
            this.dt_start_date.ValueChanged += new System.EventHandler(this.dt_start_date_ValueChanged);
            // 
            // dt_end_date
            // 
            this.dt_end_date.Location = new System.Drawing.Point(246, 95);
            this.dt_end_date.Name = "dt_end_date";
            this.dt_end_date.Size = new System.Drawing.Size(200, 20);
            this.dt_end_date.TabIndex = 3;
            this.dt_end_date.ValueChanged += new System.EventHandler(this.dt_end_date_ValueChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(530, 96);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(14, 77);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(55, 13);
            this.lbl_start.TabIndex = 5;
            this.lbl_start.Text = "Start Date";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(243, 79);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(52, 13);
            this.lbl_end.TabIndex = 6;
            this.lbl_end.Text = "End Date";
            // 
            // Audit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dt_end_date);
            this.Controls.Add(this.dt_start_date);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.dgv_audit);
            this.Name = "Audit";
            this.Text = "Audit";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_audit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_audit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DateTimePicker dt_start_date;
        private System.Windows.Forms.DateTimePicker dt_end_date;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_end;
    }
}