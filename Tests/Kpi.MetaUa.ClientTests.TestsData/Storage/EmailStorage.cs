using System.Collections.Generic;
using Bogus;
using Kpi.MetaUa.ClientTests.Model.Domain.SendEmail;

namespace Kpi.MetaUa.ClientTests.TestsData.Storage
{
    public static class EmailStorage
    {
        public static Dictionary<string, EmailInformation> Emails =>
            new Dictionary<string, EmailInformation>
            {
                { "ValidMail", ValidMail }
            };

        private static EmailInformation ValidMail =>
            new Faker<EmailInformation>()
                .RuleFor(u => u.Subject, "Test Subject")
                .RuleFor(u => u.Body, "Test Body");
    }
}
