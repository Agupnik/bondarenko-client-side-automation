using Kpi.MetaUa.ClientTests.Model.Domain.Login;

namespace Kpi.MetaUa.ClientTests.Model.Domain.SendEmail
{
    public interface ISendEmailContext
    {
        string GetErrorMessage();

        void OpenAndLogin(UserInformation user);

        void OpenEmailForm();

        void SendEmail(string receiver, EmailInformation email);

        string GetLastEmailTitle();
    }
}
