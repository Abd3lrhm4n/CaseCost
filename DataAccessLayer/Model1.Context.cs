﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CaseCostEntities : DbContext
    {
        public CaseCostEntities()
            : base("name=CaseCostEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CostT> CostTs { get; set; }
        public virtual DbSet<ItemPriceUpdateT> ItemPriceUpdateTs { get; set; }
        public virtual DbSet<ItemsT> ItemsTs { get; set; }
        public virtual DbSet<ProceduresT> ProceduresTs { get; set; }
        public virtual DbSet<CostDetailsT> CostDetailsTs { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<PremissionsT> PremissionsTs { get; set; }
        public virtual DbSet<UsersT> UsersTs { get; set; }
    
        public virtual int SP_DeleteCost(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DeleteCost", idParameter);
        }
    
        public virtual int SP_DeleteItem(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DeleteItem", iDParameter);
        }
    
        public virtual int SP_DeleteItemPriceUpdate(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DeleteItemPriceUpdate", idParameter);
        }
    
        public virtual int SP_DeleteProcedures(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DeleteProcedures", idParameter);
        }
    
        public virtual int SP_InsertCost(Nullable<int> procId, Nullable<System.DateTime> date)
        {
            var procIdParameter = procId.HasValue ?
                new ObjectParameter("procId", procId) :
                new ObjectParameter("procId", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertCost", procIdParameter, dateParameter);
        }
    
        public virtual int SP_InsertCostDetails(Nullable<int> costId, Nullable<decimal> quantity, Nullable<int> itemid)
        {
            var costIdParameter = costId.HasValue ?
                new ObjectParameter("costId", costId) :
                new ObjectParameter("costId", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(decimal));
    
            var itemidParameter = itemid.HasValue ?
                new ObjectParameter("itemid", itemid) :
                new ObjectParameter("itemid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertCostDetails", costIdParameter, quantityParameter, itemidParameter);
        }
    
        public virtual int SP_InsertItemPriceUpdate(Nullable<int> itemID, Nullable<decimal> oldprice, Nullable<decimal> newprice, Nullable<System.DateTime> modifyDate, string note)
        {
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("itemID", itemID) :
                new ObjectParameter("itemID", typeof(int));
    
            var oldpriceParameter = oldprice.HasValue ?
                new ObjectParameter("oldprice", oldprice) :
                new ObjectParameter("oldprice", typeof(decimal));
    
            var newpriceParameter = newprice.HasValue ?
                new ObjectParameter("newprice", newprice) :
                new ObjectParameter("newprice", typeof(decimal));
    
            var modifyDateParameter = modifyDate.HasValue ?
                new ObjectParameter("modifyDate", modifyDate) :
                new ObjectParameter("modifyDate", typeof(System.DateTime));
    
            var noteParameter = note != null ?
                new ObjectParameter("note", note) :
                new ObjectParameter("note", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertItemPriceUpdate", itemIDParameter, oldpriceParameter, newpriceParameter, modifyDateParameter, noteParameter);
        }
    
        public virtual int SP_InsertItems(string name, string decription, Nullable<System.DateTime> date, Nullable<decimal> unitprice, Nullable<decimal> quantity)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var decriptionParameter = decription != null ?
                new ObjectParameter("decription", decription) :
                new ObjectParameter("decription", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var unitpriceParameter = unitprice.HasValue ?
                new ObjectParameter("unitprice", unitprice) :
                new ObjectParameter("unitprice", typeof(decimal));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertItems", nameParameter, decriptionParameter, dateParameter, unitpriceParameter, quantityParameter);
        }
    
        public virtual int SP_InsertProcedures(string procName, string note)
        {
            var procNameParameter = procName != null ?
                new ObjectParameter("procName", procName) :
                new ObjectParameter("procName", typeof(string));
    
            var noteParameter = note != null ?
                new ObjectParameter("note", note) :
                new ObjectParameter("note", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertProcedures", procNameParameter, noteParameter);
        }
    
        public virtual int SP_UpdateCost(Nullable<int> id, Nullable<int> procId, Nullable<System.DateTime> date)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var procIdParameter = procId.HasValue ?
                new ObjectParameter("procId", procId) :
                new ObjectParameter("procId", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateCost", idParameter, procIdParameter, dateParameter);
        }
    
        public virtual int SP_UpdateItem(Nullable<int> iD, string name, string description, Nullable<System.DateTime> date, Nullable<decimal> unitprice, Nullable<decimal> quantity)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var unitpriceParameter = unitprice.HasValue ?
                new ObjectParameter("unitprice", unitprice) :
                new ObjectParameter("unitprice", typeof(decimal));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateItem", iDParameter, nameParameter, descriptionParameter, dateParameter, unitpriceParameter, quantityParameter);
        }
    
        public virtual int SP_UpdateItemPrice(Nullable<int> iD, Nullable<System.DateTime> modifyDate, string note, Nullable<System.DateTime> date, Nullable<decimal> newUnitPrice)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var modifyDateParameter = modifyDate.HasValue ?
                new ObjectParameter("ModifyDate", modifyDate) :
                new ObjectParameter("ModifyDate", typeof(System.DateTime));
    
            var noteParameter = note != null ?
                new ObjectParameter("Note", note) :
                new ObjectParameter("Note", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var newUnitPriceParameter = newUnitPrice.HasValue ?
                new ObjectParameter("NewUnitPrice", newUnitPrice) :
                new ObjectParameter("NewUnitPrice", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateItemPrice", iDParameter, modifyDateParameter, noteParameter, dateParameter, newUnitPriceParameter);
        }
    
        public virtual int SP_UpdateProcedures(Nullable<int> id, string procName, string note)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var procNameParameter = procName != null ?
                new ObjectParameter("procName", procName) :
                new ObjectParameter("procName", typeof(string));
    
            var noteParameter = note != null ?
                new ObjectParameter("note", note) :
                new ObjectParameter("note", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateProcedures", idParameter, procNameParameter, noteParameter);
        }
    
        public virtual int sp_InsertInvoice(Nullable<int> procID, Nullable<System.DateTime> date, Nullable<int> itemID, Nullable<decimal> quantity)
        {
            var procIDParameter = procID.HasValue ?
                new ObjectParameter("procID", procID) :
                new ObjectParameter("procID", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var itemIDParameter = itemID.HasValue ?
                new ObjectParameter("itemID", itemID) :
                new ObjectParameter("itemID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertInvoice", procIDParameter, dateParameter, itemIDParameter, quantityParameter);
        }
    }
}
