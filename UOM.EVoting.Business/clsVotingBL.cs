using System.Collections.Generic;

namespace UOM.EVoting.Business
{
    public class clsVotingBL
    {
        public bool ReadConstituency(int ConstituencyId, out Common.clsConstituency objConstituency)
        {
            // Declarations
            bool fOk;
            Data.clsConstituencyDA objConstituencyDA = new Data.clsConstituencyDA();


            // Initialisations
            objConstituency = new Common.clsConstituency();

            // Read constituency
            objConstituency = objConstituencyDA.Read(ConstituencyId);

            // Indicate if constituency is valid
            fOk = (objConstituency.Id != 0);

            return fOk;
        }

        public bool ReadCandidates(int ConstituencyId, out List<Common.clsCandidate> lstCandidates)
        {
            // Declarations
            bool fOk;
            Data.clsCandidateDA objCandidatesDA = new Data.clsCandidateDA();

            // Initialisations
            lstCandidates = new List<Common.clsCandidate>();

            // Read candidates
            lstCandidates = objCandidatesDA.Read(ConstituencyId);

            // Indicate if candidates exist
            fOk = (lstCandidates.Count != 0);

            return fOk;
        }

        public void Vote(Common.clsVoter objVoter, List<Common.clsCandidate> lstCandidates)
        {
            // Declarations
            Data.clsCandidateDA objCandidatesDA = new Data.clsCandidateDA();
            Data.clsVoterDA objVoterDA = new Data.clsVoterDA();

            // Increment one vote for each candidate
            foreach  (Common.clsCandidate objCandidate in lstCandidates)
            {
                objCandidate.Votes += 1;
                objCandidatesDA.Update(objCandidate);
            }

            // Indicate that a voter has completed voting
            objVoterDA.Update(objVoter);
        }

    }
}
