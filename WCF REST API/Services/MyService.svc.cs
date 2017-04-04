using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace WCF_REST_API.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MyService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MyService.svc or MyService.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class MyService : IMyService
    {
        public int DoAddValues(AddValues addValues)
        {
            return addValues.Value1 + addValues.Value2;
        }

        public int DoSquare(int value)
        {
            return value * value;
        }

        public String DoWork()
        {
            return "Hello WCF Rest Service!";
        }
    }

    [DataContract]
    public class AddValues
    {
        [DataMember]
        public int Value1 { get; set; }
        [DataMember]
        public int Value2 { get; set; }

        public AddValues()
        {
            Value1 = 0;
            Value2 = 0;
        }
    }
}
