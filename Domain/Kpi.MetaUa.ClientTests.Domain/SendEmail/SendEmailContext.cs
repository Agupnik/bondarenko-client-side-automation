using Kpi.MetaUa.ClientTests.Model.Domain.Login;
using Kpi.MetaUa.ClientTests.Model.Domain.SendEmail;

namespace Kpi.MetaUa.ClientTests.Domain.SendEmail
{
    public class SendEmailContext : ISendEmailContext
    {
        private readonly ISendEmailSteps _sendEmailSteps;
        private readonly ILoginContext _loginContext;

        public SendEmailContext(
            ISendEmailSteps sendEmailSteps,
            ILoginContext loginContext)
        {
            _sendEmailSteps = sendEmailSteps;
            _loginContext = loginContext;
        }

        public string GetErrorMessage()
        {
            var result = _sendEmailSteps.GetErrorMessage();
            var index = result.LastIndexOf(
                "\r\n");
            return index >= 0 ? result.Substring(
                0, 
                index) : 
                _sendEmailSteps.GetErrorMessage();
        }

        public void OpenAndLogin(
            UserInformation user)
        {
            _loginContext.OpenAndLogin(
                user);
        }

        public void OpenEmailForm()
        {
            _sendEmailSteps.OpenEmailForm();
        }

        public void SendEmail(
            string receiver, 
            EmailInformation email)
        {
            _sendEmailSteps.SetReceiver(
                receiver);
            _sendEmailSteps.SetSubject(
                email.Subject);
            _sendEmailSteps.SetBody(
                email.Body);
            _sendEmailSteps.SendEmail();
        }

        public string GetLastEmailTitle()
        {
            return _sendEmailSteps.GetLastEmailTitle();
        }
    }
}
