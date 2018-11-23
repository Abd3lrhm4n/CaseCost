using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UsersModel
    {
        //insert
        public string InsertUser(UsersT user)
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                try
                {
                    db.UsersTs.Add(user);
                    db.SaveChanges();
                    return $"{user.Name} Has been Created Succesfully";
                }
                catch (Exception ex)
                {
                   return ex.Message;
                }
            }
        }

        //Update
        public string UpdateUser(UsersT user)
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                try
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return $"{user.Name} Has been Updated Succesfully";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        //Delete
        public string DeleteUser(UsersT user)
        {
            using (CaseCostEntities db = new CaseCostEntities())
            {
                try
                {
                    db.Entry(user).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                    return $"{user.Name} Has been Deleted";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }
    }
}
