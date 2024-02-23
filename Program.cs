// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string workingDir = ""; // Replace with the dir to remove empty dirs from

var dirs = Directory.GetDirectories(workingDir);

foreach (var dir in dirs)
{
    if(!Directory.EnumerateFileSystemEntries(dir).Any())
    {
        Directory.Delete(dir, true);
    }
}
