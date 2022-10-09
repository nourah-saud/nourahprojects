using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using projectRegisteration.App_Code;

namespace projectRegisteration.demo
{
    public partial class myProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblOutPut.Text = "";
            if(!IsPostBack)
            {
                radioButtonList();
           }
           
        }
        protected void radioButtonList()
        {
            CRUD myCrud = new CRUD();
            string mySql = "select projectId, projectName from project";
            SqlDataReader dr = myCrud.getDrPassSql(mySql);
            rblProject.SelectedIndex = 0;
            rblProject.DataValueField = "projectId";
            rblProject.DataTextField = "projectName";
            rblProject.DataSource = dr;
            rblProject.DataBind();

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string stdName = tbName.Text;
            string strSite = tbSite.Text;
            int totalSelectedItems = 0;
            int counter = 0;

            if (string.IsNullOrEmpty(strSite) & string.IsNullOrEmpty(stdName))
            {
                lblOutPut.Text = "Please enter a valid Data!";
                return;
            }

            foreach (ListItem item in rblProject.Items)
            {
                if (item.Selected)
                {
                    totalSelectedItems += 1;
                }
            }
            for (int i = 0; i < rblProject.Items.Count; i++)
            {
                if (rblProject.Items[i].Selected)
                {
                    int proId = 0;
                    counter += 1;
                    proId = int.Parse(rblProject.Items[i].Value);
                    //
                    if (proId == 0)
                    { lblOutPut.Text = "Please make Project selection!";
                        return;
                    }
                    registerStd(stdName, proId, strSite);


                }
            }
        }
        protected void registerStd(string stdName, int proId,string strSite)
        {

            //selectedCourses += myEmployeeId + " " + myCourseName;
            //lblOutput.Text = selectedCourses;
            string mySql = @"INSERT INTO student(studentFullName,studentSite,projectId )
                                       VALUES(@studentFullName,@studentSite,@projectId)";
            CRUD myCrud = new CRUD();
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            //myPara.Add("@studentId", stdId);
            myPara.Add("@studentSite", strSite);
            myPara.Add("@projectId", proId);
            myPara.Add("@studentFullName", stdName);
            int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            App_Code.common.PostMsg(lblOutPut, rtn);
            //if (rtn >= 1)
            //{
            //    lblOutput.Text = "Sucess";
            //}
            //else
            //{
            //    lblOutput.Text = "Failed";
            //}

        }

    }
}