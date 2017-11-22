using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolEntities;
using SchoolBLL;

namespace SchoolWEB
{
    public partial class _Default : Page
    {
        CPersonBLL personB = new CPersonBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            gvListado.DataSource = personB.ListarBLL();
            gvListado.DataBind();
        }

        protected void gvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["PersonID"] = Convert.ToInt32(gvListado.SelectedRow.Cells[1].Text);
            Response.Redirect("UpdatePerson.aspx");
        }

        protected void InkNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertPerson.aspx");
        }
    }
}