using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.Msagl;
namespace Tubes2Stima-DeathFromStima-FolderCrawler
{
    internal class Class1
    {
        public static string lokasi;
        public static Bitmap Getpicture()
        {
            List<string[]> data = new List<string[]>() { };
            string[] directories = Getdirectories();
            int maxlength = 0;
            for (int i=0;i<directories.Length;i++)
            {
                data.Add(directories[i].Split('\\'));
                maxlength = Math.Max(maxlength, data[i].Count());
            }
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("");
            Addgraph(graph, data, maxlength);
            Microsoft.Msagl.GraphViewerGdi.GraphRenderer renderer = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer(graph);
            renderer.CalculateLayout();
            int width = 1085;
            int height = 739;
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppPArgb);
            renderer.Render(bitmap);
            return bitmap;
        }
        public static string Getlocation()
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
        public static string[] Getdirectories()
        {
            string location = Regex.Replace(lokasi, @"\\", @"\\");
            int index = location.LastIndexOf("\\");
            string[] entries = Directory.GetFileSystemEntries(location, "*", SearchOption.AllDirectories);
            for (int i = 0; i < entries.Count(); i++)
            {
                entries[i] = entries[i].Remove(0, index+1);
            }
            return entries;
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
