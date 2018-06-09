using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulationSortApp
{
    public partial class Form1 : Form
    {
        private List<ButtonNode> nodeArr = new List<ButtonNode>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            ManualGenerate(int.Parse(NumberOfElementTxt.Text));
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void RandomGenerateButton(object sender, EventArgs e)
        {
            RandomGenerate(int.Parse(NumberOfElementTxt.Text));
        }
        private void RandomGenerate(int numberofelement)
        {
            Random rd = new Random();
            for (int i = 0; i < numberofelement; i++)
            {
                int giaTri = rd.Next(0, 99);
                ButtonNode temp = new ButtonNode(i, giaTri);
                this.ViewPanel.Controls.Add(temp);
                nodeArr.Add(temp);
                temp.Location = new Point(ViewPanel.Location.X + i * 80, ViewPanel.Location.Y - 40 / 2);
               // TaoLabelSoThuTuChoMang(i);
            }
        }
        private void ManualGenerate(int numberofelement)
        {
            
            for (int i = 0; i < numberofelement; i++)
            {
                int giaTri = 0;
                ButtonNode temp = new ButtonNode(i, giaTri);
                temp.Visible = true; 
                this.ViewPanel.Controls.Add(temp);
                nodeArr.Add(temp);
                temp.Location = new Point(ViewPanel.Location.X + i * 80, ViewPanel.Location.Y - 40 / 2);
                // TaoLabelSoThuTuChoMang(i);

            }
            nodeArr[0].Focus();
           // destroyButton.Enabled = true;
        }
    }
}
