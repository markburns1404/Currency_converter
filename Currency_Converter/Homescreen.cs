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
    public partial class Homescreen : Form
    {
        public Homescreen()
        {
            InitializeComponent();
        }

        private void btn_add_currency_Click(object sender, EventArgs e)
        {
            AddCurrency addCurrency = new AddCurrency();
            AddCurrencyPresenter addCurrencyPresenter = new AddCurrencyPresenter(addCurrency);
            this.Hide();
            addCurrency.ShowDialog();
            this.Show();
        }

        private void btn_convert_currency_Click(object sender, EventArgs e)
        {
            Converter converter = new Converter();
            ConverterPresenter converterPresenter = new ConverterPresenter(converter);
            this.Hide();
            converter.ShowDialog();
            this.Show();
        }

        private void btn_audit_Click(object sender, EventArgs e)
        {
            Audit audit = new Audit();
            AuditPresenter auditPresenter = new AuditPresenter(audit);
            this.Hide();
            audit.ShowDialog();
            this.Show();
        }
    }
}
