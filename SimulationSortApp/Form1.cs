using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SimulationSortApp.Movement;


namespace SimulationSortApp
{
    public partial class Form1 : Form
    {
        private List<ButtonNode> nodeArr = new List<ButtonNode>();
        int[] M;
        public static ManualResetEvent pauseStatus = new ManualResetEvent(true);
        public static bool IsPause = false;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AscRadioButton.Checked = true;
            RandomGenerateBtn.Enabled = true;
            ManualGenerateBtn.Enabled = true;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
                 ManualGenerate(int.Parse(NumberOfElementTxt.Text));
        }
               
        private void RandomGenerateButton(object sender, EventArgs e)
        {
            RandomGenerate(int.Parse(NumberOfElementTxt.Text));
        }

        private void RandomGenerate(int numberofelement)
        {
            deletebuttonnode();            
            Random rd = new Random();
            M = new int[numberofelement];

            for (int i = 0; i < numberofelement; i++)
            {
                int giaTri = rd.Next(0, 99);
                ButtonNode temp = new ButtonNode(i, giaTri);
                this.ViewPanel.Controls.Add(temp);
                nodeArr.Add(temp);
                temp.Location = new Point(ViewPanel.Location.X + i * 80, ViewPanel.Location.Y - 40 / 2);
                M[i] = giaTri;
            }
        }

        private void ManualGenerate(int numberofelement)
        {
            deletebuttonnode();
            M = new int[numberofelement];
            for (int i = 0; i < numberofelement; i++)
            {
                int giaTri = 0;
                ButtonNode temp = new ButtonNode(i, giaTri);
                this.ViewPanel.Controls.Add(temp);
                nodeArr.Add(temp);
                temp.Location = new Point(ViewPanel.Location.X + i * 80, ViewPanel.Location.Y - 40 / 2);
                M[i] = giaTri;
            }
            nodeArr[0].Focus();
        }
        
        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (nodeArr.Count==0) { MessageBox.Show("Please generate array"); return; }
            for (int i=0;i< int.Parse(NumberOfElementTxt.Text);i++)
            {
                M[i] = nodeArr[i].giaTri;
            }
            RandomGenerateBtn.Enabled = false;
            ManualGenerateBtn.Enabled = false;
            StartBtn.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            Pause();
        }

        private void DeleteArrayBtn_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy) { backgroundWorker1.CancelAsync(); }
            RandomGenerateBtn.Enabled = true;
            ManualGenerateBtn.Enabled = true;
            StartBtn.Enabled = true;
        }

        private void BubbleSort(int[] M)
        {
            int i, j;
            int n = M.Length;
            Status st = new Status();
            for (i = 0; i < n; i++)
            {
                for (j = n - 1; j > i; j--)
                {
                    if (backgroundWorker1.CancellationPending) return;
                    if ( ((AscRadioButton.Checked==true)&&(M[j] < M[j - 1])) || ((DescRadioButton.Checked == true)&& (M[j] > M[j - 1])) )
                    {
                        int tam = M[j];
                        M[j] = M[j - 1];
                        M[j - 1] = tam;
                        System.Threading.Thread.Sleep(15);
                        DiChuyenBubbleSort(j, j - 1);
                    }
                }
            }
        }

        private void DiChuyenBubbleSort(int vt1, int vt2)
        {
            if (backgroundWorker1.CancellationPending) return;
            Status st = new Status();
            st.Vt1 = vt1;
            st.Vt2 = vt2;
            st.Type = LoaiDiChuyen.DI_LEN_DI_XUONG;
            for (int x = 0; x < 100; x++)
            {
                backgroundWorker1.ReportProgress(0, st); //gọi hàm ProgressChanged để cập nhật giao diện
                pauseStatus.WaitOne(Timeout.Infinite);
                System.Threading.Thread.Sleep(15);
            }
            st.Type = LoaiDiChuyen.QUA_PHAI_QUA_TRAI;
            int WIDTH = Math.Abs(vt1 - vt2) * (40 + 80) - 40;

            for (int x = 0; x < WIDTH; x++)
            {
                backgroundWorker1.ReportProgress(0, st);//gọi hàm ProgressChanged để cập nhật giao diện
                pauseStatus.WaitOne(Timeout.Infinite);
                System.Threading.Thread.Sleep(15);
            }//ok làm tiếp cho nút di chuyển ngược lại đi xuống đi lên để vào 1 hàng
            st.Type = LoaiDiChuyen.DI_XUONG_DI_LEN;
            for (int x = 0; x < 100; x++)
            {
                backgroundWorker1.ReportProgress(0, st);//gọi hàm ProgressChanged để cập nhật giao diện
                pauseStatus.WaitOne(Timeout.Infinite);
                System.Threading.Thread.Sleep(15);
            }//làm tiếp trường hợp dừng
            st.Type = LoaiDiChuyen.DUNG;
            backgroundWorker1.ReportProgress(0, st);
        }
     
        public void Pause()
        {
            if (IsPause)
            {
                pauseStatus.Set();     // hàm để resume
                IsPause = false;
                PauseBtn.Text = "Pause";
                timer1.Start();
                bunifuFlatButton2.Enabled = true;
            }
            else
            {
                pauseStatus.Reset();    // hàm để pause
                IsPause = true;
                PauseBtn.Text = "Continue";
                timer1.Stop();
                StartBtn.Enabled = false;
                bunifuFlatButton2.Enabled = false;
            }
        }
       
        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            BubbleSort(M);
        }
       
        private void backgroundWorker1_ProgressChanged_1(object sender, ProgressChangedEventArgs e)
        {
            //Cập nhật giao diện thời gian thực xong chuyển đến hàm dowork
            Status st = e.UserState as Status;
            if (st == null) return;//không làm gì cả
            //dừng đã làm rồi 
            if (st.Type == LoaiDiChuyen.DUNG)//nếu dừng tiến trình thì thay đổi giá trị của 2 nút trong mảng
            {
                ButtonNode tam = nodeArr[st.Vt2];
                nodeArr[st.Vt2] = nodeArr[st.Vt1];
                nodeArr[st.Vt1] = tam;
                return;
            }
            Button btn1 = nodeArr[st.Vt1];
            Button btn2 = nodeArr[st.Vt2];
            if (st.Type == LoaiDiChuyen.DI_LEN_DI_XUONG)
            {
                btn1.Top = btn1.Top + 1;//Nút 1 đi lên
                btn2.Top = btn2.Top - 1;//Nút 2 đi xuống
            }
            else if (st.Type == LoaiDiChuyen.QUA_PHAI_QUA_TRAI)
            {
                btn1.Left = btn1.Left - 1;//nút 1 qa phải
                btn2.Left = btn2.Left + 1;//Nút 2 di chuyển qua trái
            }
            else if (st.Type == LoaiDiChuyen.DI_XUONG_DI_LEN)
            {
                btn1.Top = btn1.Top - 1;//Nút 1 đi xuống
                btn2.Top = btn2.Top + 1;//Nút 2 đi lên
            }

        }

        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("thread died");
            deletebuttonnode();
            RandomGenerateBtn.Enabled = true;
            ManualGenerateBtn.Enabled = true;


        }

        private void deletebuttonnode()
        {
            foreach (Control node in nodeArr)
            {
                node.Dispose();
            }
            nodeArr.Clear();
            if (IsPause) { IsPause = false; }
        }
     
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {

        }
        
        Boolean flag;
        int x, y;

        private void TaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        private void TaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void TaskBar_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag== true)
            {
               this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}

