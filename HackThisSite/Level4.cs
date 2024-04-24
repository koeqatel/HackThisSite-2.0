using ICSharpCode.SharpZipLib.BZip2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace HackThisSite
{
    public partial class Level4 : Form
    {
        private int rotation = 0;
        private string pickedColor = "";
        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\plotMe.xml.bz2";

        public Level4()
        {
            InitializeComponent();
        }

        private void Level4_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(filePath);
            Application.Exit();
        }

        private string unZipFile()
        {
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
                return sUncompressed;
            }
        }

        private void DrawLetters(Dictionary<string, Graphics> graphicsOutput, string color, Bitmap drawingBitmap)
        {
            graphicsOutput[color] = Graphics.FromImage(drawingBitmap);

            outputImage.Image = drawingBitmap;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(unZipFile());
            XmlElement root = xmlDoc.DocumentElement;

            string usedColor = "";

            XmlNodeList lines = root.SelectNodes("Line");
            foreach (XmlNode line in lines)
            {
                string colorFromXml = "white";
                if (line.SelectNodes("Color")[0] != null)
                    colorFromXml = line.SelectNodes("Color")[0].InnerText;

                if (colorFromXml != color)
                    continue;

                Pen pen = new Pen(Color.FromName(color));
                float XStart = float.Parse(line.SelectNodes("XStart")[0].InnerText);
                float YStart = float.Parse(line.SelectNodes("YStart")[0].InnerText);
                float XEnd = float.Parse(line.SelectNodes("XEnd")[0].InnerText);
                float YEnd = float.Parse(line.SelectNodes("YEnd")[0].InnerText);

                graphicsOutput[color].DrawLine(pen, XStart, YStart, XEnd, YEnd);
                usedColor = colorFromXml;

            }

            XmlNodeList arcs = root.SelectNodes("Arc");
            foreach (XmlNode arc in arcs)
            {
                string colorFromXml = "white";
                if (arc.SelectNodes("Color")[0] != null)
                    colorFromXml = arc.SelectNodes("Color")[0].InnerText;

                if (colorFromXml != color)
                    continue;

                Pen pen = new Pen(Color.FromName(color));
                float YCenter = float.Parse(arc.SelectNodes("YCenter")[0].InnerText);
                float ArcStart = float.Parse(arc.SelectNodes("ArcStart")[0].InnerText);
                float ArcExtend = float.Parse(arc.SelectNodes("ArcExtend")[0].InnerText);
                float XCenter = float.Parse(arc.SelectNodes("XCenter")[0].InnerText);
                float Radius = float.Parse(arc.SelectNodes("Radius")[0].InnerText);

                graphicsOutput[color].DrawArc(pen, XCenter - Radius, YCenter - Radius, Radius * 2, Radius * 2, ArcStart, ArcExtend);
                usedColor = colorFromXml;
            }

            if (usedColor == color)
            {
                graphicsOutput[color].TranslateTransform((float)drawingBitmap.Width / 2, (float)drawingBitmap.Height / 2);
                graphicsOutput[color].RotateTransform(rotation);
                graphicsOutput[color].TranslateTransform(-(float)drawingBitmap.Width / 2, -(float)drawingBitmap.Height / 2);
                graphicsOutput[color].DrawImage(drawingBitmap, new System.Drawing.Point(0, 0));
            }
        }

        private void Level4_Load(object sender, EventArgs e)
        {
            Bitmap drawingBitmap = new Bitmap(outputImage.Width, outputImage.Height);
            var graphicsOutput = new Dictionary<string, Graphics>();

            List<string> colors = new List<string>();
            colors.Add("blue");
            colors.Add("green");
            colors.Add("red");
            colors.Add("yellow");
            colors.Add("white");

            foreach (string color in colors)
            {
                DrawLetters(graphicsOutput, color, drawingBitmap);
            }

            outputImage.Invalidate();
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            pickedColor = "blue";
            Bitmap drawingBitmap = new Bitmap(outputImage.Width, outputImage.Height);
            var graphicsOutput = new Dictionary<string, Graphics>();
            DrawLetters(graphicsOutput, "blue", drawingBitmap);
            outputImage.Invalidate();
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            pickedColor = "green";
            Bitmap drawingBitmap = new Bitmap(outputImage.Width, outputImage.Height);
            var graphicsOutput = new Dictionary<string, Graphics>();
            DrawLetters(graphicsOutput, "green", drawingBitmap);
            outputImage.Invalidate();
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            pickedColor = "red";
            Bitmap drawingBitmap = new Bitmap(outputImage.Width, outputImage.Height);
            var graphicsOutput = new Dictionary<string, Graphics>();
            DrawLetters(graphicsOutput, "red", drawingBitmap);
            outputImage.Invalidate();
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            pickedColor = "yellow";
            Bitmap drawingBitmap = new Bitmap(outputImage.Width, outputImage.Height);
            var graphicsOutput = new Dictionary<string, Graphics>();
            DrawLetters(graphicsOutput, "yellow", drawingBitmap);
            outputImage.Invalidate();
        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            pickedColor = "white";
            Bitmap drawingBitmap = new Bitmap(outputImage.Width, outputImage.Height);
            var graphicsOutput = new Dictionary<string, Graphics>();
            DrawLetters(graphicsOutput, "white", drawingBitmap);
            outputImage.Invalidate();
        }

        private void rotateLeft_Click(object sender, EventArgs e)
        {
            rotation -= 15;

            Bitmap drawingBitmap = new Bitmap(outputImage.Width, outputImage.Height);
            var graphicsOutput = new Dictionary<string, Graphics>();

            List<string> colors = new List<string>();
            colors.Add("blue");
            colors.Add("green");
            colors.Add("red");
            colors.Add("yellow");
            colors.Add("white");

            if (pickedColor == "")
            {
                foreach (string color in colors)
                {
                    DrawLetters(graphicsOutput, color, drawingBitmap);
                }
            }
            else
            {
                DrawLetters(graphicsOutput, pickedColor, drawingBitmap);
            }

            outputImage.Invalidate();
        }

        private void rotateRight_Click(object sender, EventArgs e)
        {
            rotation += 15;

            Bitmap drawingBitmap = new Bitmap(outputImage.Width, outputImage.Height);
            var graphicsOutput = new Dictionary<string, Graphics>();

            List<string> colors = new List<string>();
            colors.Add("blue");
            colors.Add("green");
            colors.Add("red");
            colors.Add("yellow");
            colors.Add("white");

            if (pickedColor == "")
            {
                foreach (string color in colors)
                {
                    DrawLetters(graphicsOutput, color, drawingBitmap);
                }
            }
            else
            {
                DrawLetters(graphicsOutput, pickedColor, drawingBitmap);
            }

            outputImage.Invalidate();
        }
    }
}
