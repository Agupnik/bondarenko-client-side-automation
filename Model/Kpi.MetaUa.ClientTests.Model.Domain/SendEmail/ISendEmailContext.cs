namespace Kpi.MetaUa.ClientTests.Model.Domain.SendEmail
{
    public interface ISendEmailContext
    {
        string GetErrorMessage();

        void SendEmail(string receiver, EmailInformation email);
    }
}
