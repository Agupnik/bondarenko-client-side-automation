using FluentAssertions;
using Kpi.MetaUa.ClientTests.Model.Domain.Login;
using Kpi.MetaUa.ClientTests.Model.Domain.UserInfo;
using Kpi.MetaUa.ClientTests.TestsData.Storage;
using TechTalk.SpecFlow;

namespace Kpi.MetaUa.ClientTests.Tests.Features
{
    [Binding, Scope(Feature = "Login")]
    public class LoginDefinition
    {
        private readonly ILoginContext _loginContext;
        private readonly IUserInfoContext _userInfoContext;
        private UserInformation _userInformation;

        public LoginDefinition(
            ILoginContext loginContext,
            IUserInfoContext userInfoContext)
        {
            _loginContext = loginContext;
            _userInfoContext = userInfoContext;
        }

        [Given(@"I have (.*) user")]
        public void GivenIHaveExistingUserUser(
            string entityName)
        {
            _userInformation = UsersStorage.Users[entityName];
        }

        [When(@"I login to application")]
        public void WhenILoginToApplication()
        {
            _loginContext.OpenAndLogin(
                _userInformation);
        }

        [Then(@"I see user login in header")]
        public void ThenISeeUserLoginInHeader()
        {
            _userInfoContext.GetUserLogin().Should().BeEquivalentTo(
                _userInformation.Login);
        }

        [Then(@"I see '(.*)' message")]
        public void ThenISeeMessageInForm(string message)
        {
            _loginContext.GetErrorMessage().Should().BeEquivalentTo(
                message);
        }
    }
}