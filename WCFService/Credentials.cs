using System;
using System.ServiceModel;
using System.IdentityModel.Selectors;

namespace WCFService
{
    public class Credentials : UserNamePasswordValidator
    {
        public Credentials() { }

        public override void Validate(string userName, string password)
        {
            if (userName == null || password == null)
            {
                throw new ArgumentNullException();
            }

            if (!(userName == "Raj" && password == "Shelar"))
            {
                throw new FaultException("Incorrect Username or Password");
            }
        }
    }
}