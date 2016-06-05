using System;
using System.Drawing;
using System.Windows.Forms;
using GamePlayCore;

namespace ColorGame
{
    public partial class Form1 : Form
    {
        private const int ChooseColorSize = 30;

        private int _chooseCount = 0;

        public Form1()
        {
            InitializeComponent();

            _chooseCount = (int) numericUpDownColors.Value;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          //  base.OnPaint(e);
            using (Graphics g = e.Graphics)
            {
                g.Clear(Color.AliceBlue);
                DrowArroayOfColors(g, _chooseCount);
            }
        }

        private void DrowArroayOfColors(Graphics g, int count)
        {
            for (var i = 0; i < count; i++)
            {
                var point = new Point(i*(30+5), 0);
                DrawHelper.DrowBox(g, point, AvalibleColors.GetColorByIndex(i), ChooseColorSize);
            }
        }

        private void numericUpDownColors_ValueChanged(object sender, EventArgs e)
        {
            //clear
            _chooseCount = (int)numericUpDownColors.Value;
            //drow

            panel1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // load form

            this.Hide();
            var formGameScreen = new FormGameScreen((int) numWidth.Value, (int) numHeight.Value, _chooseCount);

            formGameScreen.ShowDialog();
            this.Show();
        }

        private void panelPlayer1_Paint(object sender, PaintEventArgs e)
        {
            using (var g = e.Graphics)
            {
                DrawHelper.DrowBox(g,new Point(0,0),AvalibleColors.GetPlayer1Color(),30 );
            }
        }

        private void panelPlayer2_Paint(object sender, PaintEventArgs e)
        {
            using (var g = e.Graphics)
            {
                DrawHelper.DrowBox(g, new Point(0, 0), AvalibleColors.GetPlayer2Color(), 30);
            }
        }
    }
}
