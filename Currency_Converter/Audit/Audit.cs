using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_Converter
{
    public partial class Audit : Form, IAudit
    {
        private AuditPresenter presenter;
        public Audit()
        {
            InitializeComponent();
        }

        public DateTime getEndDate()
        {
            return dt_end_date.Value.Date;
        }

        public DateTime getStartDate()
        {
            return dt_start_date.Value.Date;
        }

        public void Register(AuditPresenter auditPresenter)
        {
            this.presenter = auditPresenter;
        }

        public void setGridView(DataTable dt)
        {
            dgv_audit.DataSource = dt;
            dgv_audit.AllowUserToAddRows = false;
            dgv_audit.AllowUserToDeleteRows = false;
            int cols = dgv_audit.ColumnCount;
            for (int x = 0; x < cols; x++)
            {
                dgv_audit.Columns[x].ReadOnly = true;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            presenter.setDataGridView();
        }

        private void dt_start_date_ValueChanged(object sender, EventArgs e)
        {
            if (dt_start_date.Value > dt_end_date.Value)
            {
                MessageBox.Show("Start date cannot be after end date");
                dt_start_date.Value = dt_end_date.Value;
            }
        }

        private void dt_end_date_ValueChanged(object sender, EventArgs e)
        {
            if (dt_end_date.Value < dt_start_date.Value)
            {
                MessageBox.Show("End date cannot be before start date");
                dt_end_date.Value = dt_start_date.Value;
            }
        }

        public void noDataMessage()
        {
            MessageBox.Show("No data available between this date range");
        }
    }
}
