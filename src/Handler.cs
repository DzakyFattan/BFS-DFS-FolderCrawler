using System;
using System.Linq;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Drawing.Imaging;
namespace Tubes2Stima_DeathFromStima_FolderCrawler
{
    internal class Handler
    {
        public static string rootFolder;
        public static string fileName;
        public static string searchMode;
        public static string resultPath;
        public static string[] arrResultPath;
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
        public static Bitmap GetResultDFS()
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
        }
        public static Bitmap GetResultMultDFS()
        {
            Microsoft.Msagl.Drawing.Graph result = new Microsoft.Msagl.Drawing.Graph("");
            DirectoryInfo startDir = new DirectoryInfo(rootFolder);
            if (startDir.Exists)
            {
                Implementation imp = new Implementation(startDir);
                imp.MultipleDFS(fileName, ref arrResultPath, ref result);
                Microsoft.Msagl.GraphViewerGdi.GraphRenderer resultRenderer = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer(result);
                resultRenderer.CalculateLayout();
                Bitmap resultBitmap = new Bitmap(Math.Max((int)result.Width, picBoxWidth), Math.Max((int)result.Height, picBoxHeight), PixelFormat.Format32bppPArgb);
                resultRenderer.Render(resultBitmap);
                return resultBitmap;
            }
            return null;
        }
        public static Bitmap GetResultBFS()
        {
            Microsoft.Msagl.Drawing.Graph result = new Microsoft.Msagl.Drawing.Graph("");
            DirectoryInfo startDir = new DirectoryInfo(rootFolder);
            if (startDir.Exists)
            {
                Implementation imp = new Implementation(startDir);
                imp.MultipleDFS(fileName, ref arrResultPath, ref result);
                Microsoft.Msagl.GraphViewerGdi.GraphRenderer resultRenderer = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer(result);
                resultRenderer.CalculateLayout();
                Bitmap resultBitmap = new Bitmap(Math.Max((int)result.Width, picBoxWidth), Math.Max((int)result.Height, picBoxHeight), PixelFormat.Format32bppPArgb);
                resultRenderer.Render(resultBitmap);
                return resultBitmap;
            }
            return null;
        }
        public static Bitmap GetResultMultBFS()
        {
            Microsoft.Msagl.Drawing.Graph result = new Microsoft.Msagl.Drawing.Graph("");
            DirectoryInfo startDir = new DirectoryInfo(rootFolder);
            if (startDir.Exists)
            {
                Implementation imp = new Implementation(startDir);
                imp.MultipleDFS(fileName, ref arrResultPath, ref result);
                Microsoft.Msagl.GraphViewerGdi.GraphRenderer resultRenderer = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer(result);
                resultRenderer.CalculateLayout();
                Bitmap resultBitmap = new Bitmap(Math.Max((int)result.Width, picBoxWidth), Math.Max((int)result.Height, picBoxHeight), PixelFormat.Format32bppPArgb);
                resultRenderer.Render(resultBitmap);
                return resultBitmap;
            }
            return null;
        }
    }
}
