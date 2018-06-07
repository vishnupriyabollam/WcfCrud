using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CrudWcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Icrud" in both code and config file together.
    [ServiceContract]
    public interface Icrud
    {
        [OperationContract]
        List<Crud> Getcrud();

        [OperationContract]
        List<Crud> Addcrud(Crud addNewcrud);

        [OperationContract]
        List<Crud> Updatecrud(Crud updatecrud);

        [OperationContract]
        List<Crud> Deletecrud(int deletedcrudId);

    }
    [DataContract]
    public class Crud
    {
        [DataMember]
        public int crudId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public DateTime DOB { get; set; }  
    }

}
