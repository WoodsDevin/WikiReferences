using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WikiReferences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetReferences_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Get entered URL
            string url = txtURL.Text;
            if(url == null)
            {
                MessageBox.Show("Please enter a wikepedia address!");
            }

            // Create a new HtmlWeb Object and load a webpage from that object.
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument webPage = web.Load(url);

            // Use the SelectNodes method to select all nodes mathing the XPath
            // For those unfamilar with XPath, this is the full XPath Code for finding the elements.
            /*
              @"/html
                /body
                //div[@id=""content""]
                //div[@id=""bodyContent""]
                //div[@id=""mw-content-text""]
                //div[@class=""mw-parser-output""]
                //div[@class=""reflist columns references-column-width""]
                /ol
                //li
                /span[@class=""reference-text""]
                /cite
                /a"
             */
            // However, you can shorthand this by using the * operator, which does most of the finding for you,
            // and you can select explicitly where to begin parsing.
            string path =
                @"
                *
                //div[@class=""reflist columns references-column-width""]
                /ol
                //li
                /span[@class=""reference-text""]
                /cite
                /a[1]
                
                ";

            // Assign the found founds to a collection (HtmlNodeCollection is index-able)
            HtmlNodeCollection references = 
                references = webPage.DocumentNode.SelectNodes(path);

            // Loop through the found nodes and print the InnerHTML (Excludes own element tag)
            try
            {
                for (int i = 1; i < references.Count; i++)
                {
                    listBox1.Items.Add(i + ": " + references[i].InnerHtml + "\n");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show(
                "No reference table found.\n\n" + 
                "Make sure that your link is a Wikipedia page, and that it contains a references section.");
            }
            
        }
    }
}
