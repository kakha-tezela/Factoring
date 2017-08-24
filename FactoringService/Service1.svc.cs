using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using FactoringService.Core.Domain;
using FactoringService.Persistence;

namespace FactoringService
{
    public class Service1 : IService1
    {
        public string GetData()
        {
            return "ok";
        }
    }
}
