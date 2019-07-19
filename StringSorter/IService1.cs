using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StringSorter
{
  
    [ServiceContract]
    public interface IService1                      // service to sort comma-separeted integers in a string
    {

        [OperationContract]
        string sort(string s);                      // function for sorting comma-separated integers in a string
    }

}
