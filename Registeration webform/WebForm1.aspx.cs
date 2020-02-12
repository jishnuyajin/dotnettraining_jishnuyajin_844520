using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fn = TextBox1.Text;
            string age = TextBox2.Text;
            string login = TextBox3.Text;
            string pass = TextBox4.Text;
            string cpass = TextBox5.Text;
            string exp = TextBox6.Text;
            string sal = TextBox7.Text;

            webformEntities1 x = new webformEntities1();
            reg_form reg = new reg_form();
            reg.firstname = fn;
            reg.age = int.Parse(age);
            reg.loginname = login;
            reg.pass = pass;
            reg.cpass = cpass;
            reg.experience = int.Parse(exp);
            reg.salaryexpected = int.Parse(sal);
            x.reg_form.Add(reg);
            x.SaveChanges();
            Response.Redirect("WebForm2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}