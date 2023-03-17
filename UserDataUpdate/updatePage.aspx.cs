using LoginRegisterPage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserDataUpdate
{
    public partial class updatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            Panel1.Visible = false;
            if (!IsPostBack)
            {
                int id = Convert.ToInt16(Request.QueryString[0]);
                UserCRUD usercrud = new UserCRUD();
                DataTable dt = usercrud.userSearch(id);
                TextBox1.Text = dt.Rows[0][1].ToString();
                TextBox2.Text = dt.Rows[0][2].ToString();
                TextBox3.Text = dt.Rows[0][3].ToString();
                TextBox4.Text = dt.Rows[0][4].ToString();
                TextBox5.Text = dt.Rows[0][5].ToString();
            }
            
        }

      

        protected void Button1_Click1(object sender, EventArgs e)
        {
            User user = new User();
            UserCRUD usercrud=new UserCRUD();
            user.FName = TextBox1.Text;
            user.LName= TextBox2.Text;
            user.UsName= TextBox3.Text;
            user.Mail = TextBox4.Text;
            user.Psw = TextBox5.Text;
            bool answe = usercrud.update(Convert.ToInt16(Request.QueryString[0]), user);
            if (Convert.ToBoolean(answe) == true)
            {
                Panel1.Visible = true;
            }
        }
    }
}