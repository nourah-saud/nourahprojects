using projectRegisteration.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectRegisteration.demo
{
    public partial class admin : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(CRUD.conStr);
       

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                tbGrade.Focus();
                if (!IsPostBack)
                {
                   FillGrid();
                }
            }
           
          
            catch
            {

            }
        }

        void FillGrid()
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandText = "Select studentId,studentFullName,studentSite,grade ,projectid from student ";
            //    cmd.Connection = con;
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    gv.DataSource = dt;
            //    gv.DataBind();
            //}
            //catch
            //{

            //}
            CRUD myCrud = new CRUD();
            string mySql = @"Select studentId,studentFullName,studentSite,grade ,projectid from student ";
            DataTable dt = myCrud.getDT(mySql);
            gv.DataSource = dt;
            gv.DataBind();
        }
        void ClearControls()
        {
            try
            {
               
                tbGrade.Text = "";
                btnSave.Visible = true;
                btnClear.Visible = true;
               
            }
            catch
            {
                throw;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"update into student(grade) value (@grade)";
                
                cmd.Parameters.AddWithValue("@grade", tbGrade.Text);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                FillGrid();
                ClearControls();
           //   lblMessage.Text = "Saved Successfully.";
            }
            catch
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            FillGrid();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearControls();
            }
            catch
            {

            }
        }


        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
               server control at run time. */
        }

      /*   protected void populateGvClient()

        {
            CRUD myCrud = new CRUD();
            string mySql = @"select * from  student";
            SqlDataReader dr = myCrud.getDrPassSql(mySql);
            gv.DataSource = dr;
            gv.DataBind();
        }*/


        public void ExportGridToExcel(GridView grd)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", "attachment;filename=GridViewExport.xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            grd.AllowPaging = false;
           //populateGvClient();
            grd.RenderControl(hw);
            string style = @"<style> .textmode { mso-number-format:\@; } </style>";
            Response.Write(style);
            Response.Output.Write(sw.ToString());
            Response.Flush();
            Response.End();
        }

      /*  protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            ExportGridToExcel(gv);
        }*/

        protected void btnExport_Click(object sender, EventArgs e)
        {
            ExportGridToExcel(gv);
        }

       /* protected void btnSave_Click1(object sender, EventArgs e)
        {
        

        }*/

        protected void btnEdit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbGrade.Text))
            {
                lblOutput.Text = "Please enter Grade !";
                return;
            }
            // this is how you access the gv values through btn > grow > then to find the control 
            // gvDepartments.BackColor = System.Drawing.Color.White; //  
            try
            {
//gvChangeColor();
  //              ClearControls();
                Button btn = sender as Button;
                GridViewRow grow = btn.NamingContainer as GridViewRow;
              int projectId = int.Parse((grow.FindControl("lblProjectId") as Label).Text);
                int myGrade = int.Parse(tbGrade.Text); 
              // tbGrade.Text =  (grow.FindControl("lblGrade") as Label).Text;
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                // btnUpdate.Visible = true;
                grow.BackColor = System.Drawing.Color.Yellow; //   
                updateStudentGrade(projectId, myGrade);
                
            }
            catch (Exception ex)
            {
                lblOutput.Text = ex.Message.ToString();
            }
        }

        protected void updateStudentGrade(int projectId, int myGrade)
        {
            //
            CRUD myCrud = new CRUD();
            string mySql = @"update student
                            set grade =@grade
                            where projectId = @projectId";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@grade",myGrade);
            myPara.Add("@projectId", projectId);
           int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            if (rtn >= 1)
            { lblOutput.Text = "Operation Successfull!"; }
            else
            { lblOutput.Text = "Operation Failed!"; }

            FillGrid();
        }

        protected void updateStudentGrade2(int studentId, int myGrade)
        {
            //
            CRUD myCrud = new CRUD();
            string mySql = @"update student
                            set grade =@grade
                            where studentId = @studentId";
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@grade", myGrade);
            myPara.Add("@studentId", studentId);
            int rtn = myCrud.InsertUpdateDelete(mySql, myPara);
            if (rtn >= 1)
            { lblOutput.Text = "Operation Successfull!"; }
            else
            { lblOutput.Text = "Operation Failed!"; }

            FillGrid();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // shows how to access gvr when the sender is a button inside the gv
            try
            {
                ClearControls();
                Button btn = sender as Button;
                GridViewRow grow = btn.NamingContainer as GridViewRow;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "delete  student where grade=@grade";
                cmd.Parameters.AddWithValue("@grade", (grow.FindControl("lblStudentId") as Label).Text);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                FillGrid();
               // lblMessage.Text = "Deleted Successfully.";
            }
            catch
            {

            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            FillGrid();
        }
        protected void btnDelete2_Click(object sender, EventArgs e)
        {
            // shows how to access gvr when the sender is a button inside the gv
            try
            {
                ClearControls();
                Button btn = sender as Button;
                GridViewRow grow = btn.NamingContainer as GridViewRow;
                int myStudentId = int.Parse((grow.FindControl("lblStudentId") as Label).Text);
                updateStudentGrade2(myStudentId, 0);

                FillGrid();
            }
            catch
            {
            }
            finally
            {
            }
            FillGrid();
        }

        protected void gvChangeColor()
        {
            foreach (GridViewRow row in gv.Rows)
            {
                if (row.RowIndex == gv.SelectedIndex)
                {
                    row.BackColor = System.Drawing.Color.Green;  // not applicable
                }
                else
                {
                    row.BackColor = System.Drawing.Color.White;//ColorTranslator.FromHtml("#FFFFFF");
                }
            }
        }

        protected void gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit_Click(sender,e);
        }


        

        /* protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
         {
             // call method to get the data into text box
             string  myId = ddl1.SelectedItem.Value;
             Response.Write(myId);
            // tBox1.Text = myId;
             CRUD myCrud = new CRUD();
             string mySql = @"select * from student 
                                 where projectId = @projectId";
             Dictionary<string, object> myPara = new Dictionary<string, object>();
             myPara.Add("@projectId",myId);
            SqlDataReader dr =  myCrud.getDrPassSql(mySql, myPara);
             string studentName = "";
             while(dr.HasRows )
             {
                 if (dr.Read())
                 {
                     //studentId	studentFullName	studentSite	grade	projectId
                     studentName += dr["studentId"];
                     studentName += dr["studentFullName"];
                     studentName += dr["studentSite"];
                     studentName += dr["grade"];
                     studentName += dr["projectId"];
                 }
             }
             tBox1.Text = studentName;
         }*/

    } //cls
} //ns
