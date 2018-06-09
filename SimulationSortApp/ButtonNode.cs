using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Drawing.Drawing2D;

namespace SimulationSortApp
{
    class ButtonNode:Button
    {
        
        public int giaTri;
        public int vitriHienTai;
        public TextBox nhapTayTexbox;
        public ButtonNode(int vitrihientai, int giatri)
        {
            
            // Node : property + event
            
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = System.Drawing.Color.White;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Size = new Size(40,40);
            this.Padding = new Padding(0);
            this.Font = new Font("Consolas", 40 / 3.2f, FontStyle.Bold);
            this.UseCompatibleTextRendering = true;

            this.Text = giatri.ToString();
            giaTri = giatri;
            vitriHienTai = vitrihientai;
            this.GotFocus += new EventHandler(Node_GotFocus);
            
            // NhapTay TextBox : property + event
            nhapTayTexbox = new TextBox();
            nhapTayTexbox.MaxLength = 2;
            nhapTayTexbox.TextAlign = HorizontalAlignment.Center;
            nhapTayTexbox.BorderStyle = BorderStyle.Fixed3D;
            nhapTayTexbox.Visible = false;
            nhapTayTexbox.Size = new Size(40, 40);
            nhapTayTexbox.Font = new Font("Consolas", 40 / 2, FontStyle.Bold);
            this.Controls.Add(nhapTayTexbox);
            
          /*  nhapTayTexbox.KeyPress += new KeyPressEventHandler(nhapTayTexbox_KeyPress);
            nhapTayTexbox.KeyDown += new KeyEventHandler(nhapTayTexbox_KeyDown);
            nhapTayTexbox.TextChanged += new EventHandler(nhapTayTexbox_TextChanged);
            nhapTayTexbox.LostFocus += new EventHandler(nhapTayTexbox_LostFocus);*/
        }
        private void Node_GotFocus(object sender, EventArgs e)
        {
            if (nhapTayTexbox.Enabled == true)   // Nếu textbox bị tắt (khi node đang sắp xếp) thì texbox không đc bật lên để sửa
            {
                
                nhapTayTexbox.BackColor = this.BackColor;
                nhapTayTexbox.Visible = true;
                nhapTayTexbox.Text = this.Text;
                nhapTayTexbox.SelectAll();
                nhapTayTexbox.Focus();
            }
        }
        #region Các hàm Chuyển động lên xuống, qua, lại
        // Property dùng để Pause  -  dùng ManualResetEvent
        public static ManualResetEvent pauseStatus = new ManualResetEvent(true);
        public static bool IsPause = false;

        public void ChuyenXuong()
        {
            int y_ViTriMoi = this.Location.Y + ThamSo.KhoanCachTrenDuoiNode;
            while (this.Location.Y < y_ViTriMoi)
            {
                pauseStatus.WaitOne(Timeout.Infinite);

                Thread.Sleep(ThamSo.TocDo);
                this.Location = new Point(this.Location.X, this.Location.Y + 2);
            }
        }
        public void ChuyenLen()
        {
            int y_ViTriMoi = this.Location.Y - ThamSo.KhoanCachTrenDuoiNode;
            while (this.Location.Y > y_ViTriMoi)
            {
                pauseStatus.WaitOne(Timeout.Infinite);
                Thread.Sleep(ThamSo.TocDo);
                //Task.Delay(ThamSo.TocDo);
                this.Location = new Point(this.Location.X, this.Location.Y - 2);
            }
        }
        public void ChuyenQua(int vitriMoi)
        {
            int x_vitririMoi;
            if (vitriMoi > this.vitriHienTai)
            {
                x_vitririMoi = this.Location.X + ((vitriMoi - vitriHienTai) * ThamSo.KhoanCachGiuaCacNode);
                while (this.Location.X < x_vitririMoi)
                {
                    pauseStatus.WaitOne(Timeout.Infinite);

                    Thread.Sleep(ThamSo.TocDo);
                    this.Location = new Point(this.Location.X + 2, this.Location.Y);
                }
            }
            else
            {
                x_vitririMoi = this.Location.X - ((vitriHienTai - vitriMoi) * ThamSo.KhoanCachGiuaCacNode);
                while (this.Location.X > x_vitririMoi)
                {
                    pauseStatus.WaitOne(Timeout.Infinite);
                    Thread.Sleep(ThamSo.TocDo);
                    this.Location = new Point(this.Location.X - 2, this.Location.Y);
                }
            }
        }
        #endregion

    }
}
