namespace Kpi.MetaUa.ClientTests.Model.Domain.SendEmail
{
    public interface ISendEmailSteps
    {
        void OpenEmailForm();

        void SetReceiver(string receiver);

        void SetSubject(string subject);

        void SetBody(string body);

        string GetLastEmailTitle();

        void SendEmail();

        string GetErrorMessage();
    }
}
