namespace Kpi.MetaUa.ClientTests.Model.Platform.WebElements.Dropdowns
{
    public interface IMethodDropdown
    {
        void OpenDropdown();

        void Select(string option);

        string[] GetOptions();
    }
}
