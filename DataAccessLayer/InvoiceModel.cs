using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class InvoiceModel
    {

        public int InsertCost(CostT cost, out int id)
        {
            try
            {
                using (CaseCostEntities db = new CaseCostEntities())
                {
                    db.CostTs.Add(cost);
                    db.SaveChanges();
                    id = cost.CostID;
                    return 1;
                }
            }
            catch (Exception)
            {
                id = 0;
                return 0;
            }
        }

        public int InsertCostDetails(List<CostDetailsT> detailsTs)
        {
            try
            {
                using (CaseCostEntities db = new CaseCostEntities())
                {
                    foreach (var item in detailsTs)
                    {
                        db.CostDetailsTs.Add(item);
                    }
                    db.SaveChanges();
                    return 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

    }
}
