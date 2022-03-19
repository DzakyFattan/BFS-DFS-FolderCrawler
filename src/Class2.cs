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
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;
            fpath = "default";
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
                foreach (System.IO.FileInfo fi in files)
                {
                    // Matching with the input file
                    fpath = fi.FullName;
                    string fname = Path.GetFileNameWithoutExtension(fpath);
                    if (fname.Equals(input))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //TODO : public BFS(string input) { } // Similar to DFS, different process
        
        //Testing Main
        static void Main(string[] args)
        {
            string fpath = "default";
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
            }
        }
    }
}
