using System;
using System.Collections;
using System.Text;
using System.DirectoryServices.AccountManagement;
using System.Data;
using System.Configuration;


namespace WebApplication7.Models
{
    public class ActiveDir
    {
        private string sDomain = "jncb.com";
        private string sDefaultOU = "OU=Test Users,OU=Test,DC=test,DC=com";
        private string sDefaultRootOU = "DC=test,DC=com";
        private string sServiceUser = @"ServiceUser";
        private string sServicePassword = "ServicePassword";
        public bool ValidateCredentials(string sUserName, string sPassword)
        {
            PrincipalContext oPrincipalContext = GetPrincipalContext();
            return oPrincipalContext.ValidateCredentials(sUserName, sPassword);
        }

        public PrincipalContext GetPrincipalContext()
        {
            PrincipalContext oPrincipalContext = new PrincipalContext
               (ContextType.Domain, sDomain, sDefaultOU, ContextOptions.SimpleBind,
               sServiceUser, sServicePassword);
            return oPrincipalContext;

        }
    }
}