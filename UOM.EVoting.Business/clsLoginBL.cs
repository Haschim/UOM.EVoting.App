using System;

namespace UOM.EVoting.Business
{
    public class clsLoginBL
    {
        // Login
        public Common.clsVoter Login(Common.clsLoginData objLogin)
        {
            // Read voter
            Data.clsVoterDA objvoterDA = new Data.clsVoterDA();
            var objvoter = objvoterDA.Read(objLogin);

            // Check if voter is valid
            if (objvoter.Id == 0)
                throw new Exception("Invalid login");
            // Check if voter has already voted
            if (objvoter.HasVoted)
                throw new Exception("Voter already voted");

            return objvoter;
        }
    }
}
