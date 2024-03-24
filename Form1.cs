using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baslangıc_bitis_artis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         public void dongu(int basla, int bitis, int artıs)
         {
            int i;
            for(i = basla; i <= bitis; i = i+artıs)
            {
                label4.Text = label4.Text + i.ToString();
            }
         }
        private void button1_Click(object sender, EventArgs e)
        {
            int basla = Convert.ToInt16(textBox1.Text);
            int bitis = Convert.ToInt16(textBox2.Text);
            int artıs = Convert.ToInt16(textBox3.Text);
            dongu(basla, bitis, artıs);
        }

       
        
    }
}
