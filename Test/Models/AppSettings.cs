namespace Test.Models
{
    public struct AppSettings
    {
        public string PathStorage { get; set; }
        public bool Encryption { get; set; }
        public bool DeleteInsert { get; set; }
        public bool DeleteExtract { get; set; }
        public bool ReplaceInsertCloud { get; set; }
        public bool ReplaceInsertLocal { get; set; }
    }
}