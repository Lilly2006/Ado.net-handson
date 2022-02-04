using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectTrial.DataConnection;

namespace ProjectTrial
{
    public partial class User_Info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            CarDbConnection obj = new CarDbConnection();
            CarModel carModelObj = new CarModel();
            carModelObj.car_model = txtcramodel.Text;
            carModelObj.category = txtcategory.Text;
            carModelObj.prize = Convert.ToInt32(txtprize.Text);
            carModelObj.Year_of_The_Model = Convert.ToInt32(txtyear.Text);
            carModelObj.Description = txtdescription.Text;
            string msg = obj.InsertCar(carModelObj);
            lblResult.Text = msg;
            LoadData();

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            CarDbConnection obj = new CarDbConnection();
            DataTable dtoutput = obj.EditCarbyCategory(txtcramodel.Text);
            //txtcramodel.Text = dtoutput.Rows[0][0].ToString();
            txtcategory.Text = dtoutput.Rows[0][1].ToString();
            txtprize.Text = dtoutput.Rows[0][2].ToString();
            txtyear.Text = dtoutput.Rows[0][3].ToString();
            txtdescription.Text = dtoutput.Rows[0][4].ToString();
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            CarDbConnection obj = new CarDbConnection();
            CarModel carModelobj = new CarModel();
            carModelobj.car_model = txtcramodel.Text;
            carModelobj.category = txtcategory.Text;
            carModelobj.prize =Convert.ToInt32( txtprize.Text);
            carModelobj.Year_of_The_Model = Convert.ToInt32(txtyear.Text);
            carModelobj.Description = txtdescription.Text;
            string msg = obj.UpdateCar(carModelobj);
            lblResult.Text = msg;
            LoadData();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            CarDbConnection obj = new CarDbConnection();
            string msg = obj.DeleteCar(txtcramodel.Text);
            lblResult.Text = msg;
            LoadData();
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            txtcramodel.Text = "";
            txtcategory.Text = "";
            txtprize.Text = "";
            txtyear.Text = "";
            txtdescription.Text = "";
        }
        protected void LoadData()
        {
            CarDbConnection obj = new CarDbConnection();
            DataTable dtResult = obj.SelectCar();
            gvDisplay.DataSource = dtResult;
            gvDisplay.DataBind();
        }
    }
}