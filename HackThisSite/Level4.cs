using ICSharpCode.SharpZipLib.BZip2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace HackThisSite
{
    public partial class Level4 : Form
    {
        public Level4()
        {
            InitializeComponent();
        }

        private void Level4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private string getFileName()
        {
            //TODO: get file name from the downloads folder
            return "";
        }

        private string unZipFile()
        {
            //TODO: Unzip the file
            FileInfo zipFileName = new FileInfo();
            using (FileStream fileToDecompressAsStream = zipFileName.OpenRead())
            {
                string decompressedFileName = @"c:\bzip2\decompressed.txt";
                using (FileStream decompressedStream = File.Create(decompressedFileName))
                {
                    try
                    {
                        BZip2.Decompress(fileToDecompressAsStream, decompressedStream, true);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
        private void Level4_Load(object sender, EventArgs e)
        {
            Bitmap drawingBitmap = new Bitmap(outputImage.Width, outputImage.Height);
            Graphics graphicsOutput = Graphics.FromImage(drawingBitmap);
            outputImage.Image = drawingBitmap;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Assets/plotMe.xml");
            XmlElement root = xmlDoc.DocumentElement;

            XmlNodeList lines = root.SelectNodes("Line");
            foreach (XmlNode line in lines)
            {
                string color = "white";
                if (line.SelectNodes("Color")[0] != null)
                    color = line.SelectNodes("Color")[0].InnerText;

                Pen pen = new Pen(Color.FromName(color));
                float XStart = float.Parse(line.SelectNodes("XStart")[0].InnerText);
                float YStart = float.Parse(line.SelectNodes("YStart")[0].InnerText);
                float XEnd = float.Parse(line.SelectNodes("XEnd")[0].InnerText);
                float YEnd = float.Parse(line.SelectNodes("YEnd")[0].InnerText);

                graphicsOutput.DrawLine(pen, XStart, YStart, XEnd, YEnd);
            }

            XmlNodeList arcs = root.SelectNodes("Arc");
            foreach (XmlNode arc in arcs)
            {
                string color = "white";
                if (arc.SelectNodes("Color")[0] != null)
                    color = arc.SelectNodes("Color")[0].InnerText;

                Pen pen = new Pen(Color.FromName(color));
                float YCenter = float.Parse(arc.SelectNodes("YCenter")[0].InnerText);
                float ArcStart = float.Parse(arc.SelectNodes("ArcStart")[0].InnerText);
                float ArcExtend = float.Parse(arc.SelectNodes("ArcExtend")[0].InnerText);
                float XCenter = float.Parse(arc.SelectNodes("XCenter")[0].InnerText);
                float Radius = float.Parse(arc.SelectNodes("Radius")[0].InnerText);

                //graphicsOutput.DrawArc(new Pen(Color.FromName("blue")), 50, 50, 100, 100, 180, 100);
                graphicsOutput.DrawArc(pen, XCenter - Radius, YCenter - Radius, Radius * 2, Radius * 2, ArcStart, ArcExtend);
                //graphicsOutput.DrawArc(new Pen(Color.FromName("red")), XCenter, YCenter, ArcStart, ArcExtend, Radius, 10);
            }

            outputImage.Invalidate();
        }
    }
}
