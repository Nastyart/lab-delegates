using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      private void Form1_Load(object sender, EventArgs e)
      {
          listBox2.Text = "";
      }

      private void button3_Click(object sender, EventArgs e)//добавить
      {
          listBox2.Items.Add(textBox2.Text);
      }

      private void button4_Click(object sender, EventArgs e)//удалить
      {
          if (listBox2.SelectedIndex != -1)
          {
              listBox2.Items.RemoveAt(listBox2.SelectedIndex);
          }
      }

    }
}
