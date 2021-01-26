using System;
using System.Net.Mail;
using Test.Service.Interface;

namespace Test.Service
{
    public class TestService : ITestService
    {
        public bool TestEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
          
        }
    }
}
