using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ColorGame
{
    public partial class Form1 : Form
    {
        private const int ChooseColorSize = 30;

        private List< Color> GameColors = new List<Color>();

        private int chooseCount = 0;

        public Form1()
        {

            GameColors.Add(Color.Black);
            GameColors.Add(Color.Aqua);
            GameColors.Add(Color.Blue);
            GameColors.Add(Color.BlueViolet);
            GameColors.Add(Color.Brown);
            GameColors.Add(Color.Chartreuse);
            GameColors.Add(Color.CornflowerBlue);
            GameColors.Add(Color.DarkGreen);
            GameColors.Add(Color.Red);
            GameColors.Add(Color.DimGray);
            GameColors.Add(Color.Lime);

            InitializeComponent();

            chooseCount = (int) numericUpDownColors.Value;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          //  base.OnPaint(e);
            
            using (Graphics g = e.Graphics)
            {
                g.Clear(Color.AliceBlue);
                DrowArroayOfColors(g, chooseCount);
            }
        }

       

        private void DrowArroayOfColors(Graphics g, int count)
        {
            for (var i = 0; i < count; i++)
            {
                var point = new Point(i*(30+5), 0);
                DrawHelper.DrowChooseBox(g, point, GameColors[i], ChooseColorSize);
            }
        }

        private void numericUpDownColors_ValueChanged(object sender, EventArgs e)
        {
            //clear
            chooseCount = (int)numericUpDownColors.Value;
            //drow

            panel1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // load form

            this.Hide();

           


            var formGameScreen = new FormGameScreen((int) numHeight.Value, (int) numWidth.Value, chooseCount);

            formGameScreen.ShowDialog();


            this.Show();
        }
    }
}
