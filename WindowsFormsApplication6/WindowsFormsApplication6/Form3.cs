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
    public partial class Form3 : Form,IForm
    {
        public Form3()
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dx = new DataClasses1DataContext();
            SignUp tb = new SignUp
            {
                Username = bunifuMetroTextbox1.Text,
                Email = bunifuMetroTextbox2.Text,
                Password = bunifuMetroTextbox3.Text
               
                
            };
           
            dx.SignUps.InsertOnSubmit(tb);
            dx.SubmitChanges();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.hide();
        }
    }
}
