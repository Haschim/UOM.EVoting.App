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

        public List<Common.clsCandidate> ReadResults(Common.clsConstituency objConstituency)
        {
            Data.clsCandidateDA objCandidateDA = new Data.clsCandidateDA();
            return objCandidateDA.Read(objConstituency.Id);
        }

    }
}
