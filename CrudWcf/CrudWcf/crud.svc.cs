using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CrudWcf
{
    public class crud : Icrud
    {
        private static List<Crud> cruds = new List<Crud>()
        {
            new Crud {crudId=1,Name="vishnu",Age=20,DOB=new DateTime(2018,4,5)},
            new Crud {crudId=2,Name="priya",Age=20,DOB=new DateTime(2018,6,30)}
        };
        public List<Crud> Addcrud(Crud addNewcrud)
        {
            cruds.Add(addNewcrud);
            return cruds;
        }
        public List<Crud> Deletecrud(int deletedcrudId)
        {
            var deletingcrud = cruds.Find(t => t.crudId == deletedcrudId);
            cruds.Remove(deletingcrud);
            return cruds;
        }

        public List<Crud> Getcrud()
        {
            return cruds;
        }

        
        

        public List<Crud> Updatecrud(Crud updatedcrud)
        {
            var deletingcrud = cruds.Find(t => t.crudId == updatedcrud.crudId);
            if (deletingcrud == null)
                cruds.Add(updatedcrud);
            else
            {
                cruds.Remove(deletingcrud);
                cruds.Add(updatedcrud);
            }
            return cruds;
        }
    }
}
