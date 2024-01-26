using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace HackThisSite
{
    public partial class Level1 : Form
    {
        private String fileContent = "";

        public Level1()
        {
            InitializeComponent();
            StreamReader streamReader = new StreamReader("Assets/wordlist.txt");
            fileContent = streamReader.ReadToEnd();
            streamReader.Close();
        }

        private void unscrambleText(string inputText)
        {
            List<string> words = new List<string>();

            foreach (var inputLine in inputText.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (inputLine == "\t")
                    continue;

                string trimmedInputLine = inputLine.Replace("\r", "");
                trimmedInputLine = trimmedInputLine.Replace("\n", "");
                Console.WriteLine(trimmedInputLine);

                foreach (var fileLine in fileContent.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    string trimmedFileLine = fileLine.Replace("\r", "");
                    trimmedFileLine = trimmedFileLine.Replace("\n", "");

                    if (trimmedInputLine.Length != trimmedFileLine.Length)
                        continue;

                    var fileText = trimmedFileLine;

                    foreach (var inputCharacter in trimmedInputLine.ToCharArray())
                    {

                        if (trimmedFileLine.Contains(inputCharacter))
                        {
                            var regex = new Regex(Regex.Escape(inputCharacter.ToString()));
                            fileText = regex.Replace(fileText, "", 1);
                        }
                    }

                    if (fileText != "")
                        continue;

                    words.Add(trimmedFileLine);
                }
            }

            RichTextBox outputTextBox = (RichTextBox)outputText;
            outputTextBox.Text = String.Join(",", words);
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            RichTextBox inputTextBox = (RichTextBox)sender;
            string inputText = inputTextBox.Text;

            unscrambleText(inputText);
        }

        private void Level1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

// gneusi
// rcaend
// hramme
// 888888
// syhcpo
// ierfrdib
// ikeymbrl
// nsunihs
// leaddi
// ernbae