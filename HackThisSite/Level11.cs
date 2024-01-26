using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackThisSite
{
    public partial class Level11 : Form
    {
        public string prevClipboardText = "";

        public Level11()
        {
            InitializeComponent();
        }

        private void Level11_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CoreWebView2_PermissionRequested(object sender, CoreWebView2PermissionRequestedEventArgs e)
        {
            Debug.WriteLine(e.PermissionKind.ToString());
            e.State = CoreWebView2PermissionState.Allow;
        }

        async private void InitializeWebView()
        {
            await webView.EnsureCoreWebView2Async();
            webView.CoreWebView2.PermissionRequested += CoreWebView2_PermissionRequested;
        }

        private async void Level11_LoadAsync(object sender, EventArgs e)
        {
            InitializeWebView();

            await webView.EnsureCoreWebView2Async();

            webView.CoreWebView2.NavigationCompleted += async delegate (object NavigationCompletedSender, CoreWebView2NavigationCompletedEventArgs NavigationCompletedArgs)
            {
                InitializeWebView();

                await webView.EnsureCoreWebView2Async();

                var html = await webView.CoreWebView2.ExecuteScriptAsync("document.body.outerHTML");

                string generatedString = Regex.Match(html, @"Generated String:\s(.*?)\\u003Cbr>", RegexOptions.IgnoreCase).Groups[1].Value.Replace("\\u003Cbr>", "");
                string shift = Regex.Match(html, @"Shift:\s(.*?)\\u003Cbr>", RegexOptions.IgnoreCase).Groups[1].Value.Replace("\\u003Cbr>", "");

                if (generatedString == "")
                    return;

                string[] characterInts = generatedString.Split(generatedString[generatedString.Length - 1]);

                string outputString = "";
                foreach (string character in characterInts)
                {
                    if (character == "")
                        continue;

                    int asciiNumber = int.Parse(character) - int.Parse(shift);
                    char characterChar = Convert.ToChar(asciiNumber);

                    outputString += characterChar;


                }

                await webView.ExecuteScriptAsync($"document.getElementsByName('solution')[0].value = '{outputString}';");
                await webView.ExecuteScriptAsync($"document.getElementsByName('submitbutton')[0].click()");
                Console.WriteLine(outputString);
                //Console.WriteLine(generatedString);
                //Console.WriteLine(shift);

            };
        }
    }
}
