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
    public partial class Form2 : Form,IForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void Open()
        {
            this.Show();
        }
        public void close()
        {
            this.Close();
        }
        public void hide()
        {
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            
          //  Form1 f1 = new Form1();
          //  f1.BackColor = Color.Red;
        }

        private void radDropDownList1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    if (radDropDownList1.SelectedValue.ToString() == "Theme 1")
            //    {
            //        Form1 f1 = new Form1();
            //        f1.BackColor = Color.Red;
            //    }
            
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(label5.Text);
            a = a - 10;
            if (a > 0)
            {
                label5.Text = a.ToString();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Historypanel hs = new Historypanel();
            hs.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(label5.Text);
            a = a + 10;
            if (a <= 150)
            {
                label5.Text = a.ToString();
                
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1.SetHomePage(textBox1.Text);
      //      Form1.SetTheme(radDropDownList1.SelectedItem.Text);
            
        }
    }
}
