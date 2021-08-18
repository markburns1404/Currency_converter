using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Currency_Converter
{
    public interface IAudit
    {
        void Register(AuditPresenter auditPresenter);
        DateTime getStartDate();
        DateTime getEndDate();
        void setGridView(DataTable dt);
        void noDataMessage();
    }
}
