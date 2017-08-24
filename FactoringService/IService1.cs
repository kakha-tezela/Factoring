using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using FactoringService.Core.Domain;

namespace FactoringService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method ="GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "/users")]
        string GetData();
    }
}
