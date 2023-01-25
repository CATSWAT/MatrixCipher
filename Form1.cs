using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string plainText = richTextBox1.Text;

            char[,] matrix = new char[3, 3] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' }, { 'g', 'h', 'i' } };

            string cipherText = "";

            for (int i = 0; i < plainText.Length; i++)
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)  
                    {
                        if (plainText[i] == matrix[row, col]) 
                        cipherText += row + "" + col + " ";
                        richTextBox2.Text = cipherText;
                        
                    }
                }
            }
        }
    }
}
