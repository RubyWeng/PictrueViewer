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

namespace HWpictrueBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private static string filePath = ""; 
        private static string[] fileArray = new string[] { };
        private int numbers = 0,location=0;//宣告檔案的數量numbers,當前的圖片位置location
        private void btnInput_Click(object sender, EventArgs e)
        {           
            FolderBrowserDialog openFile = new FolderBrowserDialog();            
            
            if (openFile.ShowDialog()==DialogResult.OK)
            {
                //input
                filePath = openFile.SelectedPath;//將輸入的路徑存到fillPath
                fileArray = Directory.GetFiles(filePath, "*.png", SearchOption.AllDirectories);//將檔名輸入陣列
                numbers = fileArray.Length;

                //output             
                location = 0;//當有資料輸入將位置歸零
                output();
            }
          
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (location!=0)
            {
                location--;
                output();
            }
            else
            {
                location = numbers - 1;
                output();
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (location!= numbers-1)
            {
                location++;
                output();
            }
            else
            {
                location = 0;
                output();
            }
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (location != numbers - 1)
            {
                location++;
                output();
            }
            else
            {
                location = 0;
                output();
            }
        }

        private void btnTimeEnd_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        void output()
        {
            ptBox1.ClientSize = new Size(400, 300);
            ptBox1.Image = Image.FromFile(fileArray[location]);
            txbPath.Text = fileArray[location];
        }

    }
}
