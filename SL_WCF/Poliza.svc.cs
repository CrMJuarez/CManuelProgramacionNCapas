using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Mvc;

namespace SL_WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Poliza" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Poliza.svc or Poliza.svc.cs at the Solution Explorer and start debugging.
    public class Poliza : IPoliza
    {
        public SL_WCF.Result Add(ML.Poliza poliza)
        {
            ML.Result result = BL.Poliza.AddEF(poliza);
            return new Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object=result.Object, Objects=result.Objects };
        }
        public SL_WCF.Result Update(ML.Poliza poliza)
        {
            ML.Result result = BL.Poliza.UpdateEF(poliza);
            return new Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };
        }
        public SL_WCF.Result Delete(ML.Poliza poliza)
        {
            ML.Result result = BL.Poliza.DeleteEF(poliza);
            return new Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };
        }
        public SL_WCF.Result GetAll()
        {
            ML.Result result = BL.Poliza.GetAllEF();
            return new Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };
        }
        public SL_WCF.Result GetById(int IdPoliza)
        {
            ML.Result result = BL.Poliza.GetByIdEF(IdPoliza);
            return new Result { Correct = result.Correct, ErrorMessage = result.ErrorMessage, Ex = result.Ex, Object = result.Object, Objects = result.Objects };
        }
    }
}