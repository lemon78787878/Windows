using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// クリックした時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Actionbutton_Click(object sender, EventArgs e)
        {
            this.Messagelabel.Text = "クリックしました";
        }

        /// <summary>
        /// マウスが乗ったとき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Actionbutton_MouseHover(object sender, EventArgs e)
        {
            this.Messagelabel.Text = "マウスが乗りました";
        }

        /// <summary>
        /// マウスが外れた時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Actionbutton_MouseLeave(object sender, EventArgs e)
        {
            this.Messagelabel.Text = "マウスが外れました";
        }
    }
}
