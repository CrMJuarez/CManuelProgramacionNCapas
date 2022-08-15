using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPoliza" in both code and config file together.
    [ServiceContract]
    public interface IPoliza
    {
        [OperationContract]
        SL_WCF.Result Add(ML.Poliza poliza);
        [OperationContract]
        SL_WCF.Result Update(ML.Poliza poliza);
        [OperationContract]
        SL_WCF.Result Delete(ML.Poliza poliza);

        [OperationContract]
        [ServiceKnownType(typeof(ML.Poliza))]
        SL_WCF.Result GetAll();

        [OperationContract]
        [ServiceKnownType(typeof(ML.Poliza))]
        SL_WCF.Result GetById(int IdPoliza);
    }
}
