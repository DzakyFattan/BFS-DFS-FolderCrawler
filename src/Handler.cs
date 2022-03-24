using System;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
namespace Tubes2Stima_DeathFromStima_FolderCrawler
{
    internal class Handler
    {
        public static string rootFolder;
        public static string fileName;
        public static string searchMode;
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

        public static (Bitmap,string[]) GetResultDFS(bool multiple)
        {
            Graph result = new Graph("");
            DirectoryInfo startDir = new DirectoryInfo(rootFolder);
            if (startDir.Exists)
            {
                Implementation imp = new Implementation(startDir,fileName, arrResultPath);
                imp.DFS(ref result, multiple);
                GraphRenderer resultRenderer = new GraphRenderer(result);
                resultRenderer.CalculateLayout();
                Bitmap resultBitmap = new Bitmap(Math.Max((int)result.Width, picBoxWidth), Math.Max((int)result.Height, picBoxHeight), PixelFormat.Format32bppPArgb);
                resultRenderer.Render(resultBitmap);
                return (resultBitmap,imp.ResultPath);
            }
            return (null,null);
        }
        public static (Bitmap, string[]) GetResultBFS(bool multiple)
        {
            Dictionary<(string, string), Edge> edgeMap = new Dictionary<(string, string), Edge>();
            Dictionary<string, string> prevRoot = new Dictionary<string, string>();
            DirectoryInfo[] dirQueue = new DirectoryInfo[0];
            Graph result = new Graph("");
            DirectoryInfo startDir = new DirectoryInfo(rootFolder);
            if (startDir.Exists)
            {
                Implementation imp = new Implementation(startDir, fileName, arrResultPath);
                imp.BFS(ref result, ref dirQueue, ref edgeMap, ref prevRoot, multiple);
                GraphRenderer resultRenderer = new GraphRenderer(result);
                resultRenderer.CalculateLayout();
                Bitmap resultBitmap = new Bitmap(Math.Max((int)result.Width, picBoxWidth), Math.Max((int)result.Height, picBoxHeight), PixelFormat.Format32bppPArgb);
                resultRenderer.Render(resultBitmap);
                return (resultBitmap, imp.ResultPath);
            }
            return (null, null);
        }
    }
}
