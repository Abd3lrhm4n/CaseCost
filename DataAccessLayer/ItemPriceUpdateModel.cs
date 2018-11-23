using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ItemPriceUpdateModel
    {
        //insert
        public string InsertUpdatedPrice(ItemPriceUpdateT itemPriceUpdateT)
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                try
                {
                    db.SP_InsertItemPriceUpdate(itemPriceUpdateT.ItemID, itemPriceUpdateT.OldUnitPrice, itemPriceUpdateT.NewUnitPrice, itemPriceUpdateT.ModifyDate, itemPriceUpdateT.Note);
                    return "The Item's Price Updated Successfully!";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}
