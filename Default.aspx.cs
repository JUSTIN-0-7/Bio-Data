using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        lbldisplay1.Text = TextBox1.Text;
        lbldisplay2.Text = TextBox2.Text;
        lbldisplay3.Text = TextBox3.Text;
        lbldisplay4.Text = TextBox4.Text;
        lbldisplay5.Text = TextBox5.Text;
        lbldisplay6.Text = TextBox6.Text;
        lbldisplay7.Text = TextBox7.Text;
        lbldisplay8.Text = TextBox8.Text;
        lbldisplay9.Text = TextBox9.Text;
    }
    protected void TextBox9_TextChanged(object sender, EventArgs e)
    {

    }
}