namespace Kpi.MetaUa.ClientTests.UI.MailBox
{
    public interface IEmailFormElement
    {
        void SetReceiver(
            string receiver);

        void SetSubject(
            string subject);

        void SetBody(
            string emailBody);

        void SendEmail();

        string GetErrorMessage();
    }
}
