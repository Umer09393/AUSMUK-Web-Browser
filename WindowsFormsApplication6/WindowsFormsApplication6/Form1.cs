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
    public interface IFontStyle
    {
        Font GetNewFontStyle(Control c);
       
    }
   



    enum FormNo
    {
        Form1,
        Form2,
        Form3
    }
    interface IForm
    {
        void Open();
        void close();

        void hide();
    }

 
    public partial class Form1 : Form, IForm
    {
     

        static void main(string[] are)
        {

          



        }
        public Form1()
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
        interface IFormFactory
        {
            IForm CreateForm(FormNo num);
        }
        class FormFactory : IFormFactory
        {
            public IForm CreateForm(FormNo num)
            {
                switch (num)
                {
                    case FormNo.Form1:
                        return new Form1();
                    case FormNo.Form2:
                        return new Form2();
                    case FormNo.Form3:
                        return new Form3();

                    default:
                        return new Form1();
                }
            }
        }
        public class Bold : IFontStyle
        {
            #region IFontStyle Members

            public Font GetNewFontStyle(System.Windows.Forms.Control c)
            {
                return new Font(c.Font, FontStyle.Bold);
            }

            #endregion
        }
        public class Italic : IFontStyle
        {
            #region IFontStyle Members

            public Font GetNewFontStyle(System.Windows.Forms.Control c)
            {
                return new Font(c.Font, FontStyle.Italic);
            }

            #endregion
        }
        

        public class FontStyleContext
        {
            //step 1: Create an object of Strategy Interface
            IFontStyle _IFontStyle;

            //step 2:Set the concrete call called by the client to the 
            //interface object defined in the step 1
            public FontStyleContext(IFontStyle IFontStyle)
            {
                this._IFontStyle = IFontStyle;
            }

            //step 3: A method that will return the font style
            public Font GetFontStyle(Control c)
            {
                return _IFontStyle.GetNewFontStyle(c);
            }
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            webControl1.GoForward();
        }
        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 != 0)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }

        }
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            webControl1.Source = new Uri("https://www.instagram.com/");
            list.Add(webControl1.Source.AbsoluteUri);
        }

        public static string homepage;

        public static void SetHomePage(string s)
        {
            homepage = s;
        }



        FormFactory fac = new FormFactory();
        

        int count = 0;
        //  public static string Theme = "Theme1";
        public static List<String> list = new List<String>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //webControl1.Width = tabControl1.Width;
            SetHomePage("https://www.google.com.pk/");
            webControl1.Zoom = Convert.ToInt32(label5.Text);



        }
        

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {

            //  Form2 f2 = new Form2();
            // f2.Show();
            IForm f = fac.CreateForm(FormNo.Form2);
            count++;
            if (count % 2 != 0)
            {
                f.Open();
            }
            else
            {
                f.close();
            }

        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //  Form3 f3 = new Form3();
            //  f3.Show();

            IForm f = fac.CreateForm(FormNo.Form3);
            count++;
            if (count % 2 != 0)
            {
                f.Open();
            }
            else
            {
                f.close();
            }

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {


            count++;
            if (count % 2 != 0)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dx = new DataClasses1DataContext();
            var query = (from a in dx.SignUps select a);

            foreach (var check in query)
            {
                if (textBox1.Text == check.Username.ToString() && textBox2.Text == check.Password.ToString())
                {



                    //    bunifuCustomLabel1.Text = "Logged in as " + textBox1.Text;
                    bunifuFlatButton7.Text = textBox1.Text;
                    panel1.Visible = false;


                }
                else
                {
                    label3.Text = "Account not registered";
                }



            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            webControl1.Source = new Uri("https://www.google.com.pk/");
            Historypanel hs = new Historypanel();
            //    Historypanel.list.Add("www.google.com.pk");
            list.Add(webControl1.Source.AbsoluteUri);



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            webControl1.Source = new Uri("https://www.facebook.com/");
            list.Add(webControl1.Source.AbsoluteUri);
        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            webControl1.Source = new Uri("https://www.facebook.com/");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            webControl1.Source = new Uri("https://www.yahoo.com/");
            list.Add(webControl1.Source.AbsoluteUri);
        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //     address = bunifuMaterialTextbox1.Text;
                if (bunifuMaterialTextbox1.Text.Contains(".com") || bunifuMaterialTextbox1.Text.Contains(".net") || bunifuMaterialTextbox1.Text.Contains(".org"))
                {
                    if (bunifuMaterialTextbox1.Text.Contains("www."))
                    {
                        webControl1.Source = new Uri("https://" + bunifuMaterialTextbox1.Text);
                        list.Add(webControl1.Source.AbsoluteUri);
                    }
                    else
                    {
                        webControl1.Source = new Uri("https://www." + bunifuMaterialTextbox1.Text);
                        list.Add(webControl1.Source.AbsoluteUri);
                    }

                }
                else
                {
                    webControl1.Source = new Uri("https://www.google.com.pk/search?ei=2FI0WoLMA8Hv6QS16qGoDQ&q=" + bunifuMaterialTextbox1.Text);
                    list.Add(webControl1.Source.AbsoluteUri);
                }

            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            webControl1.GoBack();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            webControl1.Reload(true);
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

            //    webControl1.Source = new Uri("https://www.google.com.pk/");
            webControl1.Source = new Uri(homepage);
            //   webControl1.GoToHome();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton8_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(label5.Text);
            a = a + 10;
            if (a <= 150)
            {
                label5.Text = a.ToString();
                webControl1.Zoom = a;
            }
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(label5.Text);
            a = a - 10;
            if (a > 0)
            {
                label5.Text = a.ToString();
                webControl1.Zoom = a;
            }

        }

        private void Awesomium_Windows_Forms_WebControl_DocumentReady(object sender, Awesomium.Core.UrlEventArgs e)
        {
            //  Historypanel.list.Add(webControl1.HasTargetURL.ToString());
            string s = webControl1.Source.Host.ToString();
            tabControl1.SelectedTab.Text = s;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontStyleContext fsc = new FontStyleContext(new Italic());


            button3.Font = fsc.GetFontStyle(button3);
            
            button2.Font = fsc.GetFontStyle(button2);
            bunifuFlatButton5.TextFont = fsc.GetFontStyle(bunifuFlatButton5);
            
            bunifuFlatButton1.TextFont = fsc.GetFontStyle(bunifuFlatButton1);
            


        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }



        


        

        

     
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
    }

  
}
