using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Imaging;
using static Tubes2Stima_DeathFromStima_FolderCrawler.Implementation;
namespace Tubes2Stima_DeathFromStima_FolderCrawler
{
    internal class Handler
    {
        public static string rootFolder;
        public static string fileName;
        public static string searchMode;
        public static string resultPath;
        public static int picBoxWidth;
        public static int picBoxHeight;
        public static bool findAllOccurence;
        public static string GetLocation()
        {
            string location = null;
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = ".";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                location = dialog.FileName;
            }
            return location;
        }
        public static string[] DirToArrayOfString()
        {
            string location = Regex.Replace(rootFolder, @"\\", @"\\");
            int index = location.LastIndexOf("\\");
            string[] parentFolder = { location.Substring(index + 1, (location.Length - index - 1)) };
            Console.WriteLine(parentFolder[0]);
            string[] entries = Directory.GetFileSystemEntries(location, "*", SearchOption.AllDirectories);
            string[] ListPath = new string[1 + entries.Length];
            parentFolder.CopyTo(ListPath, 0);
            entries.CopyTo(ListPath, 1);

            for (int i = 1; i < ListPath.Count(); i++)
            {
                ListPath[i] = ListPath[i].Remove(0, index + 1);
            }
            return ListPath;
        }
        public static Bitmap GetResult()
        {
            Microsoft.Msagl.Drawing.Graph result = new Microsoft.Msagl.Drawing.Graph("");
            DirectoryInfo startDir = new DirectoryInfo(rootFolder);
            if (startDir.Exists)
            {
                Implementation imp = new Implementation(startDir);
                imp.DFS(fileName, out resultPath, ref result);
                Microsoft.Msagl.GraphViewerGdi.GraphRenderer resultRenderer = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer(result);
                resultRenderer.CalculateLayout();
                Bitmap resultBitmap = new Bitmap(Math.Max((int)result.Width, picBoxWidth), Math.Max((int)result.Height, picBoxHeight), PixelFormat.Format32bppPArgb);
                resultRenderer.Render(resultBitmap);
                return resultBitmap;
            }
            return null;

            // List<string[]> data = new List<string[]>() { };
            // string[] directories = DirToArrayOfString();
            // int maxlength = 0;
            // for (int i=0;i<directories.Length;i++)
            // {
            //     data.Add(directories[i].Split('\\'));
            //     Console.WriteLine("dir " + i + " " + directories[i]);
            //     maxlength = Math.Max(maxlength, data[i].Count());
            // }
            // 
            // Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("");
            // Addgraph(graph, data, maxlength);
            // Microsoft.Msagl.GraphViewerGdi.GraphRenderer renderer = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer(graph);
            // renderer.CalculateLayout();
            // Bitmap bitmap = new Bitmap(Math.Max((int)graph.Width, picBoxWidth), Math.Max((int)graph.Height, picBoxHeight), PixelFormat.Format32bppPArgb);
            // renderer.Render(bitmap);
            // return bitmap;
        }

        public static void Addgraph(Microsoft.Msagl.Drawing.Graph graph, List<string[]> data, int maxlength, int index=0)
        {
            if (index<maxlength-1)
            {
                int position = index;
                for (int i = 0; i < data.Count; i++)
                {
                    if (data[i].Count() == position + 2)
                    {
                        
                        graph.AddEdge(data[i][position], data[i][position + 1]);
                    }
                }
                position++;
                Addgraph(graph, data, maxlength, position);
            }
            
        }
    }
}
