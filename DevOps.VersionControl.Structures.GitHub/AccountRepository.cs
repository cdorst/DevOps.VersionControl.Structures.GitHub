namespace DevOps.VersionControl.Structures.GitHub
{
    public struct AccountRepository
    {
        private const string GitHub = "https://github.com";

        public AccountRepository(string account, string repository)
        {
            Account = account;
            Repository = repository;
        }

        public string Account { get; set; }
        public string Repository { get; set; }

        public string Uri => $"{GitHub}/{Account}/{Repository}";
    }
}
