namespace Kpi.MetaUa.ClientTests.Model.Domain.Login
{
    public interface ILoginContext
    {
        void OpenAndLogin(
            UserInformation user);

        string GetErrorMessage();
    }
}
