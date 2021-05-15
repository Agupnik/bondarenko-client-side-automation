using System;
using Kpi.MetaUa.ClientTests.Model.Domain.Login;
using Kpi.MetaUa.ClientTests.Model.Domain.SendEmail;

namespace Kpi.MetaUa.ClientTests.Domain.SendEmail
{
    public class SendEmailContext : ISendEmailContext
    {
        private readonly ISendEmailSteps _sendEmailSteps;

        public SendEmailContext(
            ISendEmailSteps sendEmailSteps)
        {
            _sendEmailSteps = sendEmailSteps;
        }

        public string GetErrorMessage()
        {
            var result = _sendEmailSteps.GetErrorMessage();
            return result.Split("\r\n")[0];
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
    }
}
