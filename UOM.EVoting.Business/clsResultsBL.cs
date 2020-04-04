using System.Collections.Generic;

namespace UOM.EVoting.Business
{
    public class clsResultsBL
    {
        public List<Common.clsConstituency> ReadConstituencies()
        {
            Data.clsConstituencyDA objConstituencyDA = new Data.clsConstituencyDA();
            return objConstituencyDA.Read();
        }
    }
}
