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
    public partial class Level2 : Form
    {
        public Level2()
        {
            InitializeComponent();
        }

        private void Level2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private string decodeMorse(string morse)
        {
            Dictionary<string, string> decoder = new Dictionary<string, string>();
            decoder.Add(".-", "a");
            decoder.Add("-...", "b");
            decoder.Add("-.-.", "c");
            decoder.Add("-..", "d");
            decoder.Add(".", "e");
            decoder.Add("..-.", "f");
            decoder.Add("--.", "g");
            decoder.Add("....", "h");
            decoder.Add("..", "i");
            decoder.Add(".---", "j");
            decoder.Add("-.-", "k");
            decoder.Add(".-..", "l");
            decoder.Add("--", "m");
            decoder.Add("-.", "n");
            decoder.Add("---", "o");
            decoder.Add(".--.", "p");
            decoder.Add("--.-", "q");
            decoder.Add(".-.", "r");
            decoder.Add("...", "s");
            decoder.Add("-", "t");
            decoder.Add("..-", "u");
            decoder.Add("...-", "v");
            decoder.Add(".--", "w");
            decoder.Add("-..-", "x");
            decoder.Add("-.--", "y");
            decoder.Add("--..", "z");
            decoder.Add(".----", "1");
            decoder.Add("..---", "2");
            decoder.Add("...--", "3");
            decoder.Add("....-", "4");
            decoder.Add(".....", "5");
            decoder.Add("-....", "6");
            decoder.Add("--...", "7");
            decoder.Add("---..", "8");
            decoder.Add("----.", "9");
            decoder.Add("-----", "0");
            decoder.Add("", "");
            string decodedMorse = "";

            foreach (string letter in morse.Split(' '))
            {
                decodedMorse += decoder[letter];
            }


            return decodedMorse;
        }

        private void inputPictureBox_Click(object sender, EventArgs e)
        {
            Image image = null;
            if (Clipboard.ContainsImage())
            {
                image = Clipboard.GetImage();
            }

            inputPictureBox.Image = image;

            int counter = 0;
            string morse = "";

            Bitmap imageBitmap = (Bitmap)image;

            for (int y = 0; y < imageBitmap.Height; y++)
            {
                for (int x = 0; x < imageBitmap.Width; x++)
                {
                    Color color = imageBitmap.GetPixel(x, y);

                    if (color.R == 0)
                        counter++;
                    else if (color.R == 255)
                    {
                        Console.WriteLine(counter);
                        char charLetter = (char)counter;
                        morse += charLetter;
                        counter = 1;
                    }
                }
            }

            outputText.Text = decodeMorse(morse);
        }
    }
}
