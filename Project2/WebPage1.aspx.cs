using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace Project2
{
    public partial class WebPage1 : System.Web.UI.Page
    {
        String strConnString = ConfigurationManager.ConnectionStrings["FalseCarCon"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected void txtBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btn1_Click1(object sender, EventArgs e)
        {
            {
                Session["FName"] = txtBox1.Text;
                Session["LName"] = txtBox3.Text;
                Session["Color"] = color.Text;
                Session["Married"] = married.Text;
                Session["Children"] = children.Text;
                Session["Income"] = income.Text;
                Session["Gender"] = gender.Text;
                


                string FNAME = txtBox1.Text;
                string LNAME = txtBox3.Text;
                string COLOR = color.Text;
                string MARRIED = married.Text;
                string CHILDREN = children.Text;
                string INCOME = income.Text;
                string GENDER = gender.Text;
                
                
                    SqlConnection con = new SqlConnection(strConnString);
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "dbo.InsertUserInfo";
                        cmd.Parameters.Add("@FNAME", SqlDbType.Text).Value = FNAME;
                        cmd.Parameters.Add("@LNAME", SqlDbType.Text).Value = LNAME;
                        cmd.Parameters.Add("@COLOR", SqlDbType.Text).Value = COLOR;
                        cmd.Parameters.Add("@MARRIED", SqlDbType.Text).Value = MARRIED;
                        cmd.Parameters.Add("@CHILDREN", SqlDbType.Text).Value = CHILDREN;
                        cmd.Parameters.Add("@INCOME", SqlDbType.Text).Value = INCOME;
                        cmd.Parameters.Add("@GENDER", SqlDbType.Text).Value = GENDER;
                    
                    
                        cmd.Connection = con;

                                con.Open();
                                cmd.ExecuteNonQuery();

                                

                                con.Close();
                                con.Dispose();

                Response.Redirect("WebPage2.aspx");
                
            }
        }

        protected void color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void married_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void children_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void income_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
             
    }
}