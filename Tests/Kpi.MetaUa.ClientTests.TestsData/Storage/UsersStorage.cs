using System.Collections.Generic;
using Bogus;
using Kpi.MetaUa.ClientTests.Model.Domain.Login;

namespace Kpi.MetaUa.ClientTests.TestsData.Storage
{
    public static class UsersStorage
    {
        public static Dictionary<string, UserInformation> Users =>
            new Dictionary<string, UserInformation>
            {
                { "ExistingUser", ExistingUser },
                { "InvalidUser", InvalidUser }
            };

        private static UserInformation ExistingUser =>
            new Faker<UserInformation>()
                .RuleFor(u => u.Login, "test.automation@meta.ua")
                .RuleFor(u => u.Password, "Qwertyuiop12");

        private static UserInformation InvalidUser =>
            new Faker<UserInformation>()
                .RuleFor(u => u.Login, "InvalidLoginInfo")
                .RuleFor(u => u.Password, "InvalidPassword");
    }
}
