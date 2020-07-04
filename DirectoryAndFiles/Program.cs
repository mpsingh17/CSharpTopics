using System;
using System.IO;

namespace DirectoryAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "D:\\Codebase\\VegaStore\\VegaStore.UI\\wwwroot\\uploads/2020/7/3\\1babc126-beaf-43d7-aa09-206ed89029c2_637293930461319149.jpg";
            var uploadFolder = "uploads\\2020\\7\\3";
            var fileName = "1babc126-beaf-43d7-aa09-206ed89029c2_637293930461319149.jpg";

            //var directorySeparator = Path.DirectorySeparatorChar;
            //Console.WriteLine("Direcotry separator is: ", directorySeparator.ToString());

            //var fullPath = Path.GetFullPath(path);
            //Console.WriteLine(fullPath); // Returns the path variable value.

            //var rootPath = Path.GetPathRoot(path);
            //Console.WriteLine(rootPath); // Returns D:\

            var filePathToStore = Path.Join(uploadFolder, fileName);
            Console.WriteLine(filePathToStore);
            
            
            //Console.WriteLine(path);

        }
    }
}
