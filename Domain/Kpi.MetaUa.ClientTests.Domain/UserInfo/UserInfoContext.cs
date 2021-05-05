using Kpi.MetaUa.ClientTests.Model.Domain.UserInfo;

namespace Kpi.MetaUa.ClientTests.Domain.UserInfo
{
    public class UserInfoContext : IUserInfoContext
    {
        private readonly IUserInfoSteps _userInfoSteps;

        public UserInfoContext(
            IUserInfoSteps userInfoSteps)
        {
            _userInfoSteps = userInfoSteps;
        }

        public string GetUserLogin()
        {
            return _userInfoSteps.GetUserLogin();
        }
    }
}
