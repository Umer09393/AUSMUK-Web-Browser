using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Historypanel : Form
    {
        public Historypanel()
        {
            InitializeComponent();
        }

        


        private void Historypanel_Load(object sender, EventArgs e)
        {

            //    radListView1.Items.Add(Form1.address);
            for (int i = 0; i < Form1.list.Count; i++)
            {
                radListView1.Items.Add(Form1.list[i]);
            }
            
     //       radListView1.Items.Add(list);
            
        }
        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            radListView1.Items.Clear();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            radListView1.Items.Remove(radListView1.SelectedItem);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
