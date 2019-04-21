using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CadastroAlunos
{
    public partial class FRMSair : Form
    {
        public FRMSair()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var num="lucas";

                var elements = webBrowser1.Document.GetElementsByTagName("input");
                
                var cont=0;
                foreach (HtmlElement intro in elements)
                {
                    if (intro.GetAttribute("value") == "")
                    {
                        cont++;
                    }
                }
                elements = webBrowser1.Document.GetElementsByTagName("textarea");
                foreach (HtmlElement intro in elements)
                {
                    
                    intro.InnerHtml=intro.InnerHtml.Trim();
                    if (intro.InnerHtml == string.Empty)
                    {
                        
                        cont++;
                    }
                }
                if (cont == 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Existem Campos sem preencher");
                }
                //webBrowser1.Document.GetElementById("ss-submit").InvokeMember("click");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Existem Campos sem preencher");
            }

           
        }
    }
}
