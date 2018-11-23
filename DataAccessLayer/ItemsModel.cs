using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class ItemsModel
    {
        //insert
        public string InsertItem(ItemsT item)
        {
             using (CaseCostEntities db = new CaseCostEntities())
            {
                try
                {
                    db.SP_InsertItems(item.Name, item.Description, item.Date, item.UnitPrice, item.Quantity);
                    return $"{item.Name} IS ADDED";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        //get the last updated price 
        public void UpdateItemPrice(ItemsT items)
        {
            using(CaseCostEntities db = new CaseCostEntities())
            {
                //db.ItemsTs.Attach(items);
                //db.Entry(items).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();
                //db.ItemsTs.Attach(items);
                //db.Entry(items).Property(x => x.UnitPrice).IsModified = true;
                //db.SaveChanges();
                var contxt = db.ItemsTs.Find(items.ItemID);
                contxt.UnitPrice = items.UnitPrice;
                db.SaveChanges();
            }
        }

        //update
        public string UpdateItem(ItemsT item)
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                try
                {
                    db.SP_UpdateItem(item.ItemID, item.Name, item.Description, item.Date, item.UnitPrice, item.Quantity);
                    return $"{item.Name} IS UPDATED";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        //delete
        public string DeleteItem(ItemsT item)
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                try
                {
                    db.SP_DeleteItem(item.ItemID);
                    return $"{item.Name} IS DELETED";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}
