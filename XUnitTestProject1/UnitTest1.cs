using Moq;
using Test.Service;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1 
    {
       

        [Theory]
        [JsonFileData("testcase.json", "email")]
        public void EmailVerify(dynamic email)
        {
            
            Mock<TestService> mockTestService = new Mock<TestService>();
            var result=mockTestService.Object.TestEmail(email.ToString());
            Xunit.Assert.True(result);
        }

      
    }
}
