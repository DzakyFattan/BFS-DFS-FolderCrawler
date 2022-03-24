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
        private string input;
        private string[] resultPath;
        public DirectoryInfo Root
        {
            get { return root; }
            set { root = value; }
        }
        public string Input
        {
            get { return input; }
            set { input = value; }
        }
        public string[] ResultPath
        {
            get { return resultPath; }
            set { resultPath = value; }
        }
        public Implementation(DirectoryInfo dir, string inp, string[] res)
        {
            root = dir;
            input = inp;
            resultPath = res;
        }

        public void DFS(ref Graph graphResult, bool multiple)
        {
            graphResult.AddNode(root.Name);
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;
            string[] lastPath = null;
            if (multiple)
            {
                if (resultPath != null)
                {
                    lastPath = new string[resultPath.Length];
                    resultPath.CopyTo(lastPath, 0);
                }
            }
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
                    Implementation imp = new Implementation(dirInfo, input, resultPath);
                    imp.DFS(ref graphResult, multiple);
                    if (imp.ResultPath != null && resultPath == null || resultPath != null && imp.ResultPath.Length > resultPath.Length)
                    {
                        // create tree with the root dir as root and all iterated subDir up to subDir with found file as subTree
                        graphResult.AddEdge(root.Name, dirInfo.Name).Attr.Color = Color.Blue;
                        graphResult.FindNode(root.Name).Attr.Color = Color.Blue;
                        resultPath = imp.ResultPath;
                        if (!multiple)
                        {
                            subDirs = subDirs.Skip(1).ToArray();
                            foreach (DirectoryInfo restdir in subDirs)
                            {
                                graphResult.AddEdge(root.Name, restdir.Name);
                            }
                            return;
                        }
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
            catch (Exception) { }

            if (files != null)
            {
                foreach (FileInfo fi in files)
                {
                    // Matching with the input file
                    string matchpath = fi.FullName;
                    string matchname = fi.Name;
                    if (matchname.Equals(input))
                    {
                        if (resultPath == null)
                        {
                            resultPath = new string[] { matchpath };
                        }
                        else
                        {
                            resultPath = resultPath.Concat(new string[] { matchpath }).ToArray();
                        }
                        // create tree with the root dir as root and all iterated files up to found file as leaves
                        graphResult.AddEdge(root.Name, matchname).Attr.Color = Color.Blue;
                        graphResult.FindNode(matchname).Attr.Color = Color.Blue;
                        graphResult.FindNode(root.Name).Attr.Color = Color.Blue;
                        files = files.Skip(1).ToArray();
                        if (!multiple)
                        {
                            break;
                        }
                    }
                    else
                    {
                        graphResult.AddEdge(root.Name, matchname).Attr.Color = Color.Red;
                        graphResult.FindNode(matchname).Attr.Color = Color.Red;
                        files = files.Skip(1).ToArray();
                    }
                }
                if (!multiple)
                {
                    foreach (FileInfo fi in files)
                    {
                        graphResult.AddEdge(root.Name, fi.Name);
                    }
                }
            }
            if (graphResult.FindNode(root.Name) != null && graphResult.FindNode(root.Name).Attr.Color != Color.Blue)
            {
                graphResult.FindNode(root.Name).Attr.Color = Color.Red;
            }
        }

        public void BFS(ref Graph graphResult, ref DirectoryInfo[] dirQueue, ref Dictionary<(string, string), Edge> edgeMap, ref Dictionary<string, string> prevRoot, bool multiple)
        {
            graphResult.AddNode(root.Name);
            FileInfo[] files = null;
            DirectoryInfo[] subDirs = null;
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
                    edgeMap[(root.Name, dirInfo.Name)].Attr.Color = Color.Red;
                    graphResult.FindNode(dirInfo.Name).Attr.Color = Color.Red;
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
                    string matchpath = fi.FullName;
                    string matchname = fi.Name;
                    if (matchname.Equals(input))
                    {
                        if (resultPath == null)
                        {
                            resultPath = new string[] { matchpath };
                        }
                        else
                        {
                            resultPath = resultPath.Concat(new string[] { matchpath }).ToArray();
                        }
                        // create tree with the root dir as root and all iterated files up to found file as leaves
                        graphResult.AddEdge(root.Name, matchname).Attr.Color = Color.Blue;
                        graphResult.FindNode(matchname).Attr.Color = Color.Blue;
                        graphResult.FindNode(root.Name).Attr.Color = Color.Blue;
                        if (prevRoot.ContainsKey(root.Name))
                        {
                            edgeMap[(prevRoot[root.Name], root.Name)].Attr.Color = Color.Blue;
                            graphResult.FindNode(prevRoot[root.Name]).Attr.Color = Color.Blue;
                        }
                        files = files.Skip(1).ToArray();
                        if (!multiple)
                        {
                            foreach (FileInfo restFile in files)
                            {
                                graphResult.AddEdge(root.Name, restFile.Name);
                            }
                            return;
                        }
                    }
                    else
                    {
                        graphResult.AddEdge(root.Name, matchname).Attr.Color = Color.Red;
                        graphResult.FindNode(matchname).Attr.Color = Color.Red;
                        if (prevRoot.ContainsKey(root.Name))
                        {
                            edgeMap[(prevRoot[root.Name], root.Name)].Attr.Color = Color.Red;
                            graphResult.FindNode(prevRoot[root.Name]).Attr.Color = Color.Red;
                        }
                        files = files.Skip(1).ToArray();
                    }
                }
            }
            // BFS
            if (dirQueue != null && dirQueue.Length > 0)
            {
                DirectoryInfo dirInfo = dirQueue[0];
                Implementation imp = new Implementation(dirInfo, input, resultPath);
                dirQueue = dirQueue.Skip(1).ToArray();
                imp.BFS(ref graphResult, ref dirQueue, ref edgeMap, ref prevRoot, multiple);
                if (imp.ResultPath != null)
                {
                    this.resultPath = imp.ResultPath;
                    if (graphResult.FindNode(dirInfo.Name).Attr.Color == Color.Blue)
                    {
                        edgeMap[(prevRoot[dirInfo.Name], dirInfo.Name)].Attr.Color = Color.Blue;
                        graphResult.FindNode(prevRoot[dirInfo.Name]).Attr.Color = Color.Blue;
                    }
                }
            }
            if (graphResult.FindNode(root.Name) != null && graphResult.FindNode(root.Name).Attr.Color != Color.Blue)
            {
                graphResult.FindNode(root.Name).Attr.Color = Color.Red;
            }
        }
    }
}