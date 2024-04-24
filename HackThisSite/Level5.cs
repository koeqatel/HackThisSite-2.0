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

namespace HackThisSite
{
    public partial class Level5 : Form
    {
        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\corrupted.png.bz2";

        public Level5()
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
                Console.WriteLine(fs);
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

        private void Level5_Load(object sender, EventArgs e)
        {
            //This function crashed :)
            unZipFile();
        }
    }
}
