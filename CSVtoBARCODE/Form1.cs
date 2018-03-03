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
using System.Drawing.Printing;

namespace CSVtoBARCODE
{
    public partial class frmBarcodePrint : Form
    {
        String UseFont = "";
        int fnSize = 0;
        

        public frmBarcodePrint()
        {
            InitializeComponent();
        }

        private void cmbCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCode.SelectedIndex == 0)
            {
                lblTestText.Font = new Font("EAN-13", 20);
            }else if (cmbCode.SelectedIndex == 1)
            {
                lblTestText.Font = new Font("CODE 128", 20);
            }else
            {
                lblTestText.Font = new Font("Microsfot Sans Serif", 20);
            }
        }

        private void txtTry_TextChanged(object sender, EventArgs e)
        {
            lblTestText.Text = txtTry.Text;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var dlgRes = dlgBrowseFile.ShowDialog();
            if (dlgRes == DialogResult.OK)
            {
                txtFileLocation.Text = dlgBrowseFile.FileName;
            }
        }

        private void PrintTextFileHandler(object sender,PrintPageEventArgs ppeArgs)
        {
            StreamReader reader = new StreamReader(txtFileLocation.Text);
            Font fn = new Font(UseFont, 20);
            Graphics g = ppeArgs.Graphics;
            float linesperpage = 0;
            float yPos = 0;

            int count = 0;

            float leftMargin = ppeArgs.MarginBounds.Left;

            float topMargin = ppeArgs.MarginBounds.Top;

            string line = null;
            linesperpage = ppeArgs.MarginBounds.Height / fn.GetHeight(g);

            while (count < linesperpage &&

                ((line = reader.ReadLine()) != null))

                {

                    //Calculate the starting position

                    yPos = topMargin + (count *

                    fn.GetHeight(g));

                    //Draw text

                    g.DrawString(line, fn, Brushes.Black,leftMargin, yPos, new StringFormat());

                    //Move to next line

                    count++;

                }
        }

        private void btnSetFont_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbCode.SelectedItem.ToString());
            if(cmbCode.SelectedIndex != 0)
            {
                if (fnSize > 79)
                {
                    MessageBox.Show("Maximum Size is 79");
                }
                else if (fnSize < 20)
                {
                    MessageBox.Show("Minum size is 20");
                }
                else
                {
                    UseFont = cmbCode.SelectedItem.ToString();
                    fnSize = Convert.ToInt32(txtSize.Text);
                }
            }else
            {
                MessageBox.Show("Please select font code.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(txtFileLocation.TextLength > 1)
            {
                PrintDocument pd = new PrintDocument();

                pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);

                pd.Print();
            }
            else
            {
                MessageBox.Show("No File selected!");
                btnBrowse.PerformClick();
            }

        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
