using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Productos_PCrearProducto : System.Web.UI.Page
{
    CProducto cProducto = new CProducto();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        string c = CGeneracionCodigo.GenerateUniqueId();
        string nombre = txbNombre.Text.Trim();
        string descripcion = txbDescripcion.Text.Trim();
        string precio = txbPrecio.Text.Trim();
        string stock = txbStock.Text.Trim();
        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion)
             || string.IsNullOrEmpty(precio) || string.IsNullOrEmpty(stock))
        {
            Response.Write("<script>alert('No se permiten campos vacíos.');</script>");
        }
        else
        {
            cProducto.Insertar_VProducto_I(c, nombre, descripcion, decimal.Parse(precio), int.Parse(stock));

            txbNombre.Text = "";
            txbDescripcion.Text = "";
            txbPrecio.Text = "";
            txbStock.Text = "";
        }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("PListaProductos.aspx");
    }
}