using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public class AuditPresenter
    {
        private IAudit screen;
        private AuditModel model;

        public AuditPresenter(IAudit screen)
        {
            this.screen = screen;
            screen.Register(this);
            model = new AuditModel();
        }
        public void setDataGridView()
        {
            DataTable dt = model.getData(screen.getStartDate(), screen.getEndDate());
            if (dt.Rows.Count != 0)
            {
                screen.setGridView(dt);
            }
            else screen.noDataMessage();
        }
    }
}
