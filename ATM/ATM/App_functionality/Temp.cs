namespace ATM.App_functionality
{
    public class Temp
    {
        private string _folderPath = $@"C:\Users\{Environment.UserName}\Documents\Temp";

        public string FolderPath { get => _folderPath; }

        public void CreateFile(string file, string content) => File.WriteAllText($@"C:\Users\{Environment.UserName}\Documents\Temp\{file}", content);
        public void AppendFile(string file, string content) => File.AppendAllText($@"C:\Users\{Environment.UserName}\Documents\Temp\{file}", content);
        public string ReadFile(string file) => File.ReadAllText($@"C:\Users\{Environment.UserName}\Documents\Temp\{file}");
        public void DisposeFile(string path) => File.Delete($@"{FolderPath}\{path}");


    }
}
