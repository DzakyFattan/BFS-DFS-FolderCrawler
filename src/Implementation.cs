using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Msagl.Drawing;
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

        public void DFS(string input, out string fpath, ref Graph graphResult)
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
                    imp.DFS(input, out fpath, ref graphResult);
                    if (fpath != null)
                    {
                        // create tree with the root dir as root and all iterated subDir up to subDir with found file as subTree
                        graphResult.AddEdge(root.Name, dirInfo.Name).Attr.Color = Color.Blue;
                        graphResult.FindNode(root.Name).Attr.Color = Color.Blue;
                        subDirs = subDirs.Skip(1).ToArray();
                        foreach (DirectoryInfo restdir in subDirs)
                        {
                            graphResult.AddEdge(root.Name, restdir.Name);
                        }
                        return;
                    }
                    else
                    {
                        graphResult.AddEdge(root.Name, dirInfo.Name).Attr.Color = Color.Red;
                        graphResult.FindNode(dirInfo.Name).Attr.Color = Color.Red;
                    }
                    subDirs = subDirs.Skip(1).ToArray();
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
                    string matchname = fi.Name;
                    if (matchname.Equals(input))
                    {
                        fpath = fi.FullName;
                        // create tree with the root dir as root and all iterated files up to found file as leaves
                        graphResult.AddEdge(root.Name, matchname).Attr.Color = Color.Blue;
                        graphResult.FindNode(matchname).Attr.Color = Color.Blue;  
                        graphResult.FindNode(root.Name).Attr.Color = Color.Blue;
                        files = files.Skip(1).ToArray();
                        break;
                    }
                    else
                    {
                        graphResult.AddEdge(root.Name, matchname).Attr.Color = Color.Red;
                        graphResult.FindNode(matchname).Attr.Color = Color.Red;
                    }
                    files = files.Skip(1).ToArray();
                }
                foreach (FileInfo fi in files)
                {
                    graphResult.AddEdge(root.Name, fi.Name);
                }
            }
        }

        public void MultipleDFS(string input, ref string[] fpath, ref Graph graphResult)
        {
            string[] lastPath;
            if (fpath != null)
            {
                lastPath = new string[fpath.Length];
                Array.Copy(fpath, lastPath, fpath.Length);
            } else
            {
                lastPath = null;
            }
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
                    imp.MultipleDFS(input, ref fpath, ref graphResult);
                    if (fpath == null)
                    {
                        graphResult.AddEdge(root.Name, dirInfo.Name).Attr.Color = Color.Red;
                        graphResult.FindNode(dirInfo.Name).Attr.Color = Color.Red;
                    }
                    else if (lastPath == null && fpath != null || fpath.Length > lastPath.Length)
                    {
                        graphResult.AddEdge(root.Name, dirInfo.Name).Attr.Color = Color.Blue;
                        graphResult.FindNode(root.Name).Attr.Color = Color.Blue;
                    }
                    else
                    {
                        graphResult.AddEdge(root.Name, dirInfo.Name).Attr.Color = Color.Red;
                        graphResult.FindNode(dirInfo.Name).Attr.Color = Color.Red;
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
                    string matchname = fi.Name;
                    if (matchname.Equals(input))
                    {
                        if (fpath == null){
                            fpath = new string[] {matchpath};
                        }
                        else {
                            fpath = fpath.Concat(new string[] {matchpath}).ToArray();
                        }
                        graphResult.AddEdge(root.Name, matchname).Attr.Color = Color.Blue;
                        graphResult.FindNode(matchname).Attr.Color = Color.Blue;
                        graphResult.FindNode(root.Name).Attr.Color = Color.Blue;
                    }
                    else
                    {
                        graphResult.AddEdge(root.Name, matchname).Attr.Color = Color.Red;
                        graphResult.FindNode(matchname).Attr.Color = Color.Red;
                    }
                }
            }
        }
        
        public void BFS(string input, out string fpath, ref Graph graphResult, ref DirectoryInfo[] dirQueue, ref Dictionary<(string,string),Edge> edgeMap, ref Dictionary<string,string> prevRoot)
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
            // add every subDir to queue
            if (subDirs != null)
            {
                foreach (DirectoryInfo dirInfo in subDirs)
                {
                    Array.Resize(ref dirQueue, dirQueue.Length + 1);
                    dirQueue[dirQueue.Length - 1] = dirInfo;
                    edgeMap[(root.Name, dirInfo.Name)] = graphResult.AddEdge(root.Name, dirInfo.Name);
                    prevRoot[dirInfo.Name] = root.Name;
                } 
            }
            // If there's no more subdir then process through files
            try
            {
                files = root.GetFiles("*.*");
            }
            // Skip error
            catch (Exception) { }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    // Matching with the input file
                    string matchname = fi.Name;
                    if (matchname.Equals(input))
                    {
                        fpath = fi.FullName;
                        // create tree with the root dir as root and all iterated files up to found file as leaves
                        graphResult.AddEdge(root.Name, matchname).Attr.Color = Color.Blue;
                        graphResult.FindNode(matchname).Attr.Color = Color.Blue;
                        graphResult.FindNode(root.Name).Attr.Color = Color.Blue;
                        files = files.Skip(1).ToArray();
                        foreach (FileInfo restFile in files)
                        {
                            graphResult.AddEdge(root.Name, restFile.Name);
                        }
                        edgeMap[(prevRoot[root.Name], root.Name)].Attr.Color = Color.Blue;
                        graphResult.FindNode(prevRoot[root.Name]).Attr.Color = Color.Blue;
                        return;
                    }
                    else
                    {
                        graphResult.AddEdge(root.Name, matchname).Attr.Color = Color.Red;
                        graphResult.FindNode(matchname).Attr.Color = Color.Red;
                        files = files.Skip(1).ToArray();
                    }           
                }
            }
            // BFS
            if (dirQueue != null)
            {
                foreach (DirectoryInfo dirInfo in dirQueue)
                {
                    Implementation imp = new Implementation(dirInfo);
                    edgeMap[(prevRoot[dirInfo.Name], dirInfo.Name)].Attr.Color = Color.Red;
                    graphResult.FindNode(dirInfo.Name).Attr.Color = Color.Red;
                    dirQueue = dirQueue.Skip(1).ToArray();
                    imp.BFS(input, out fpath, ref graphResult, ref dirQueue, ref edgeMap, ref prevRoot);
                    if (fpath != null)
                    {
                        return;
                    }
                }
            }
        }
        //TODO MultipleBFS
    }
}
