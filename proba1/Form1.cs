using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "sursa.txt");
            string text = File.ReadAllText(path, Encoding.UTF8);
            // Replace [NAME] with a variable's value
            string codBare1 = "ana";
            string cpn = "are";
            string pnData = "multe";
            string codBare2 = "Bob";

            int ana = 477;
            int are = 25;
            int multe = 42;
            int mere = 50;
            int gustoase = 42;

            string modifiedContent = text
                .Replace("[codBare1]", codBare1)
                .Replace("[cpn]", cpn)
                .Replace("[pnData]", pnData)
                .Replace("[codBare2]", codBare2)
                .Replace("[ana]", (ana + int.Parse(txtOffset.Text)).ToString())
                .Replace("[are]", (are + int.Parse(txtOffset.Text)).ToString())
                .Replace("[multe]", (multe + int.Parse(txtOffset.Text)).ToString())
                 .Replace("[mere]", (mere + int.Parse(txtOffset.Text)).ToString())
                .Replace("[gustoase]", gustoase + int.Parse(txtOffset.Text).ToString());
            txtArat.Text= modifiedContent;
        }
    }
}