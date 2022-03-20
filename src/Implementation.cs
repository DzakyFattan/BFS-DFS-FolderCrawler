using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Msagl;
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

        public bool DFS(string input, out string fpath, ref Microsoft.Msagl.Drawing.Graph graphResult)
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
                List<string> TempDirInfo = new List<string>();
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    Implementation imp = new Implementation(dirInfo);
                    if (imp.DFS(input, out fpath, ref graphResult))
                    {
                        // create tree with the root dir as root and all iterated subDir up to subDir with found file as subTree
                        graphResult.AddEdge(root.Name, dirInfo.Name).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        graphResult.FindNode(root.Name).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        for (int i = TempDirInfo.Count - 1; i >= 0; i--)
                        {
                            graphResult.AddEdge(root.Name, TempDirInfo[i]).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            graphResult.FindNode(TempDirInfo[i]).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        }
                        return true;
                    }
                    TempDirInfo.Add(dirInfo.Name);
                }
                // create tree with the root dir as root and all subDir as subTree, if not found
                for (int i = TempDirInfo.Count - 1; i >= 0; i--)
                {
                    graphResult.AddEdge(root.Name, TempDirInfo[i]).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    graphResult.FindNode(TempDirInfo[i]).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
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
                // create temporary list to store filename before the result
                List<string> tempFileList = new List<string>();
                foreach (FileInfo fi in files)
                {
                    // Matching with the input file
                    string matchname = fi.Name;
                    Console.WriteLine(matchname + " " + input);
                    if (matchname.Equals(input))
                    {
                        fpath = fi.FullName;
                        // create tree with the root dir as root and all iterated files up to found file as leaves
                        graphResult.AddEdge(root.Name, matchname).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        graphResult.FindNode(matchname).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        for (int i = tempFileList.Count - 1; i >= 0; i--)
                        {
                            graphResult.AddEdge(root.Name, tempFileList[i]).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            graphResult.FindNode(tempFileList[i]).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        }
                        graphResult.FindNode(root.Name).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        return true;
                    }
                    else
                    {
                        tempFileList.Add(matchname);
                    }
                }
                // create tree with the root dir as root and all files as leaves, if not found
                for (int i = tempFileList.Count - 1; i >= 0; i--)
                {
                    graphResult.AddEdge(root.Name, tempFileList[i]).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    graphResult.FindNode(tempFileList[i]).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
                graphResult.FindNode(root.Name).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
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
        /* static void Main(string[] args)
        {
            Test DFS 
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
        } */
    }
}
