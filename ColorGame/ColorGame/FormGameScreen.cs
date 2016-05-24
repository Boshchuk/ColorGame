using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePlayCore;

namespace ColorGame
{
    public partial class FormGameScreen : Form
    {
        private Field _field;

        public FormGameScreen(int width, int height, int colorsCount)
        {
            InitializeComponent();

            _field = new Field(width, height, colorsCount);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
