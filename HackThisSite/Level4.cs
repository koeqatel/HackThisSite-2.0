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
using ICSharpCode.SharpZipLib.BZip2;

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
            string filePath = "C:\\Users\\Koeqatel\\Downloads\\plotMe.xml.bz2";

            // Read the compressed file directly
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                // Create a BZip2 input stream
                BZip2InputStream zisUncompressed = new BZip2InputStream(fs);

                // Create a memory stream to hold the decompressed data
                MemoryStream msUncompressed = new MemoryStream();

                byte[] buffer = new byte[4096];
                int bytesRead;
                // Read from the BZip2 stream and write to the memory stream
                while ((bytesRead = zisUncompressed.Read(buffer, 0, buffer.Length)) > 0)
                {
                    msUncompressed.Write(buffer, 0, bytesRead);
                }

                // Close the streams
                zisUncompressed.Close();
                msUncompressed.Close();

                // Convert the decompressed data to a string
                string sUncompressed = Encoding.ASCII.GetString(msUncompressed.ToArray());

                // Output the decompressed data
                File.Delete(filePath);
                return sUncompressed;
            }
        }
        private void Level4_Load(object sender, EventArgs e)
        {
            Bitmap drawingBitmap = new Bitmap(outputImage.Width, outputImage.Height);
            Graphics graphicsOutput = Graphics.FromImage(drawingBitmap);
            outputImage.Image = drawingBitmap;

            Bitmap drawing2Bitmap = new Bitmap(outputImage2.Width, outputImage2.Height);
            Graphics graphics2Output = Graphics.FromImage(drawing2Bitmap);
            outputImage2.Image = drawing2Bitmap;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(unZipFile());
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

                if (color == "blue" || color == "green" || color == "red")
                    graphicsOutput.DrawLine(pen, XStart, YStart, XEnd, YEnd);
                else if (color == "yellow" || color == "white")
                    graphics2Output.DrawLine(pen, XStart, YStart, XEnd, YEnd);
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

                if (color == "blue" || color == "green" || color == "red")
                    graphicsOutput.DrawArc(pen, XCenter - Radius, YCenter - Radius, Radius * 2, Radius * 2, ArcStart, ArcExtend);
                else if (color == "yellow" || color == "white")
                    graphics2Output.DrawArc(pen, XCenter - Radius, YCenter - Radius, Radius * 2, Radius * 2, ArcStart, ArcExtend);
            }

            outputImage.Invalidate();
            outputImage2.Invalidate();
        }
    }
}
