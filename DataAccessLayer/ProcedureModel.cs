using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProcedureModel
    {
        //insert 
        public string InsertProcedure(ProceduresT proceduresT)
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                try
                {
                    db.SP_InsertProcedures(proceduresT.ProcedureName, proceduresT.Note);
                    return $"{proceduresT.ProcedureName} IS INSERTED";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        //update
        public string UpdateProcedure(ProceduresT proceduresT)
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                try
                {
                    db.SP_UpdateProcedures(proceduresT.ID, proceduresT.ProcedureName, proceduresT.Note);
                    return $"{proceduresT.ProcedureName} IS UPDATED";
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
               
            }
        }

        //delete
        public string DeleteProcedure(ProceduresT proceduresT)
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                try
                {
                    db.SP_DeleteProcedures(proceduresT.ID);
                    return $"{proceduresT.ProcedureName} IS DElETED";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}
