using SWLNVDP;
using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Productos_PEditarProducto : System.Web.UI.Page
{
    CProducto cProducto = new CProducto();
    EVProducto eVProducto = new EVProducto();
    private string CodigoProducto;
    protected void Page_Load(object sender, EventArgs e)
    {
        CodigoProducto = Request.QueryString["codigo"];
        if (!IsPostBack)
        {
            CargarDatos();
        }
    }
    private void CargarDatos()
    {
        eVProducto = cProducto.Obtener_VProducto_O_CodigoProducto(CodigoProducto);
        txbNombre.Text = eVProducto.NombreProducto;
        txbDescripcion.Text = eVProducto.DescripcionProducto;
        txbPrecio.Text = eVProducto.PrecioUnitarioProducto.ToString();
        txbStock.Text = eVProducto.StockProducto.ToString();

    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txbNombre.Text) || string.IsNullOrEmpty(txbDescripcion.Text)
             || string.IsNullOrEmpty(txbPrecio.Text) || string.IsNullOrEmpty(txbStock.Text))
        {
            Response.Write("<script>alert('No se permiten campos vacíos.');</script>");
        }
        else
        {
            cProducto.Actualizar_VProducto_A(CodigoProducto, txbNombre.Text.Trim(), txbNombre.Text.Trim(), decimal.Parse(txbPrecio.Text.Trim()), int.Parse(txbStock.Text.Trim()));
            Response.Redirect("PListaProductos.aspx");
        }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("PListaProductos.aspx");
    }
}