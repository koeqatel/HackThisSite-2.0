using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;

namespace HackThisSite
{
    public partial class Level6 : Form
    {
        public Level6()
        {
            InitializeComponent();
        }

        private void Level6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private Vector2 PositionImage(Bitmap imageBitmap)
        {
            int startX = 0;
            int startY = 0;

            for (int x = 0; x < imageBitmap.Width; x++)
            {
                if (startX != 0)
                    break;

                for (int y = 0; y < imageBitmap.Height; y++)
                {
                    Color pixel = imageBitmap.GetPixel(x, y);
                    if (pixel.G != 0)
                    {
                        startX = x - 1;
                        break;
                    }
                }
            }
            for (int y = 0; y < imageBitmap.Height; y++)
            {
                if (startY != 0)
                    break;

                for (int x = 0; x < imageBitmap.Width; x++)
                {
                    Color pixel = imageBitmap.GetPixel(x, y);
                    if (pixel.G != 0)
                    {
                        startY = y - 1;
                        break;
                    }
                }
            }

            return new Vector2(startX, startY);
        }

        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            var bitmap = new Bitmap(section.Width, section.Height);
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
                return bitmap;
            }
        }

        List<List<Point>> characterLocations = new List<List<Point>>();    

        private void generateCharacterLocations()
        {
            List<Point> points0 = new List<Point>();
            points0.Add(new Point(337, 250));
            points0.Add(new Point(352, 250));
            points0.Add(new Point(352, 270));
            points0.Add(new Point(337, 270));

            characterLocations.Add(points0);   
            
            List<Point> points1 = new List<Point>();
            points1.Add(new Point(355, 247));
            points1.Add(new Point(367, 250));
            points1.Add(new Point(367, 270));
            points1.Add(new Point(355, 270));

            characterLocations.Add(points1);
        }

        private string ScanImage(Graphics graphicsOutput, Bitmap imageBitmap)
        {
            // Create a new bitmap to hold the cropped image
            Bitmap croppedImage = new Bitmap(TestImage.Width, TestImage.Height);

            // Define the polygonal region (list of points)
            foreach (List<Point> points in characterLocations)
            {
                // Create a graphics path from the list of points
                GraphicsPath path = new GraphicsPath();
                path.AddPolygon(points.ToArray());          

                // Create a graphics object from the new bitmap
                using (Graphics g = Graphics.FromImage(croppedImage))
                {
                    // Set the graphics object's clip to the region
                    g.SetClip(path);

                    // Draw the original image onto the new bitmap, but only the clipped region will be drawn
                    g.DrawImage(imageBitmap, 0, 0);
                }
            }       

            TestImage.Image = croppedImage;

            return "";
        }

        private void Level6_Load(object sender, EventArgs e)
        {
            generateCharacterLocations();
            Image clipBoardImage = Clipboard.GetImage();

            Bitmap imageBitmap = new Bitmap(clipBoardImage);
            Graphics graphicsOutput = Graphics.FromImage(imageBitmap);

            Vector2 pixels = PositionImage(imageBitmap);
            graphicsOutput.DrawImage(imageBitmap, new System.Drawing.Point(0 - int.Parse(pixels.X.ToString()), 0 - int.Parse(pixels.Y.ToString())));

            outputImage.Image = imageBitmap;

            string output = ScanImage(graphicsOutput, imageBitmap);
            outputTextbox.Text = output;
        }
    }
}
