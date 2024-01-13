namespace NugetUtility
{
    public class LibraryInfo
    {
        public string PackageName { get; set; }
        public string PackageVersion { get; set; }
        public string PackageUrl { get; set; }
        public string Copyright { get; set; }
        public string [] Authors { get; set; }
        public string Description { get; set; }
        public string LicenseUrl { get; set; }
        public string LicenseType { get; set; }
        public string Projects { get; set; }
        public LibraryRepositoryInfo Repository { get; set; }

        //https://www.nuget.org/packages/Grpc.AspNetCore/2.59.0
        public string NugetUrl => $"https://www.nuget.org/packages/{PackageName}/{PackageVersion}";
    }

    public class LibraryRepositoryInfo
    {
        public string Type { get; set; }
        public string Url { get; set; }
        public string Commit { get; set; }
    }
}