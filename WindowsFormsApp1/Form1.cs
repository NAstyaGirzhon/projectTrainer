using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void EnterRegstButton_Click(object sender, EventArgs e)
        {
           
            WindowRegstr windowRegstr = new WindowRegstr();
            windowRegstr.Show();

        }

        private void EnterDocButton_Click(object sender, EventArgs e)
        {
           
            WindowDoctor windowDoctor = new WindowDoctor();
            windowDoctor.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        Point LastPoint;
        // перемещение от первого нажатия мыши до того места, где зажата клавиша мыши. Действует только при наведении на panel1
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }        
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

      
    }
}
