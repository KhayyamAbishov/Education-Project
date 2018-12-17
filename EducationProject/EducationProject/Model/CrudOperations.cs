using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationProject.Model
{
   static class CrudOperations
    {
      static  public void  Update( object source)
        {
            using (EducationProjectDbEntities1 db=new EducationProjectDbEntities1())
            {
                var entitystate = db.Entry(source);
                entitystate.State = EntityState.Modified;

                db.SaveChanges();
            }
        }
    }
}
