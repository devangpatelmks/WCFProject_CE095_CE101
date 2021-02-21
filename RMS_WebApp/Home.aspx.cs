using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RMS_WebApp.ServiceReference1;
using System.Data;

namespace RMS_WebApp
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void Button1_Click1(object sender, EventArgs e)
        {
            InsertOrder o = new InsertOrder();
            o.O_Name = TextBox1.Text;
            o.O_Desc = TextBox2.Text;
            o.O_Price = TextBox3.Text;
            o.O_Type = RadioButtonList1.SelectedValue;
            o.O_Stat = RadioButtonList2.SelectedValue;
            o.O_Cate = DropDownList1.SelectedValue;

            string r = client.Insert(o);
            lblmsg.Visible = true;
            lblmsg.Text = r.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.getdata g = new ServiceReference1.getdata();
            g = client.GetOI();
            DataTable dt = new DataTable();
            dt = g.Res_Tab;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            UpdateOI o = new UpdateOI();
            o.O_ID = int.Parse(txtoi.Text);
            o.O_Name = TextBox1.Text;
            o.O_Desc = TextBox2.Text;
            o.O_Price = TextBox3.Text;
            o.O_Type = RadioButtonList1.SelectedValue;
            o.O_Stat = RadioButtonList2.SelectedValue;
            o.O_Cate = DropDownList1.SelectedValue;
            string result = client.Update(o);
            lblmsg.Visible = true;
            lblmsg.Text = result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DeleteOI d = new DeleteOI();
            d.O_ID = int.Parse(txtoi.Text);
            string res = client.Delete(d);
            lblmsg.Visible = true;
            lblmsg.Text = res.ToString();
        }
    }
}