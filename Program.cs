using System;
using System.IO;
using System.Linq;
using static System.Environment;
using static System.Environment.SpecialFolder;
using static System.IO.Directory;

using static Utils.Text;

namespace MusicFolderCleaner
{
    class Program
    {
        private static readonly string[] paths = GetFiles(
                                                    GetFolderPath(MyMusic));
        private static readonly string[] onlyLettersPaths = (
                                                        from path in paths
                                                        select OnlyLetters(path)
                                                        ).ToArray();


        static void Main(string[] args)
        {
            for (int i = 0; i < paths.Length; i++)
            {
                string path = (string)paths[i];
                if (Array.LastIndexOf(onlyLettersPaths, onlyLettersPaths[i]) != i
                    || path.EndsWith(".mp3.mp3"))
                {
                    File.Delete(path);
                }
            }
        }
    }
}
