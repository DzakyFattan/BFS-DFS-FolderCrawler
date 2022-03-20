using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes2Stima_DeathFromStima_FolderCrawler
{
    internal class Implementation
    {
        private DirectoryInfo root;

        public DirectoryInfo Root
        {
            get { return root; }
            set { root = value; }
        }

        public Implementation(DirectoryInfo dir)
        {
            root = dir;
        }

        public bool DFS(string input, out string fpath)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;
            fpath = null;
            // Find all the subdirectories under this directory.
            try
            {
                subDirs = root.GetDirectories();
            }
            // Do nothing if error
            catch (Exception) { }
            // Recursive for every subDirectory (DFS)
            if (subDirs != null)
            {
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    Implementation imp = new Implementation(dirInfo);
                    if (imp.DFS(input, out fpath))
                    {
                        return true;
                    }
                }
            }
            // If there's no more subdir then process through files
            try
            {
                files = root.GetFiles("*.*");
            }
            // Skip error
            catch (Exception){}

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    // Matching with the input file
                    string matchpath = fi.FullName;
                    string matchname = Path.GetFileNameWithoutExtension(matchpath);
                    if (matchname.Equals(input))
                    {
                        fpath = matchpath;
                        return true;
                    }
                }
            }
            return false;
        }

        public void MultipleDFS(string input, ref string[] fpath)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;
            // Find all the subdirectories under this directory.
            try
            {
                subDirs = root.GetDirectories();
            }
            // Do nothing if error
            catch (Exception) { }
            // Recursive for every subDirectory (DFS)
            if (subDirs != null)
            {
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    Implementation imp = new Implementation(dirInfo);
                    imp.MultipleDFS(input, ref fpath);
                }
            }
            // If there's no more subdir then process through files
            try
            {
                files = root.GetFiles("*.*");
            }
            // Skip error
            catch (Exception){}

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    // Matching with the input file
                    string matchpath = fi.FullName;
                    string matchname = Path.GetFileNameWithoutExtension(matchpath);
                    if (matchname.Equals(input))
                    {
                        if (fpath == null){
                            fpath = new string[] {matchpath};
                        }
                        else {
                            fpath = fpath.Concat(new string[] {matchpath}).ToArray();
                        }
                    }
                }
            }
        }
        //TODO : public BFS(string input) { } // Similar to DFS, different process
        
        //Testing Main
        static void Main(string[] args)
        {
            /* Test DFS 
            string fpath;
            Console.WriteLine("Masukkan nama file: ");
            string input = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(@"D:");
            if (di.Exists)
            {
                Implementation imp = new Implementation(di);
                if(imp.DFS(input, out fpath))
                {
                    Console.WriteLine(fpath);
                    Console.WriteLine(Path.GetFileNameWithoutExtension(fpath));
                }
                else
                {
                    Console.WriteLine("File not found");
                }
            } */
            
            /* Test MultipleDFS
            string[] fpath = null;
            Console.WriteLine("Masukkan nama file: ");
            string input = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(@"D:");
            if (di.Exists)
            {
                Implementation imp = new Implementation(di);
                imp.MultipleDFS(input, ref fpath);
                if(fpath != null){
                    foreach (string outPath in fpath)
                    {
                        Console.WriteLine(outPath);
                    }
                }
                else
                {
                    Console.WriteLine("File not found");
                }
            }
            */
        }
    }
}
