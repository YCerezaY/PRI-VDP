using SWLNVDP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Venta_PCrearVenta : System.Web.UI.Page
{
    CVenta cVenta = new CVenta();
    CCliente cCliente = new CCliente();
    List<EVCliente> lstCliente = new List<EVCliente>();
    CProducto cProducto = new CProducto();
    List<EVProducto> lstProducto = new List<EVProducto>();
    CEmpleado cEmpleado = new CEmpleado();
    List<EVEmpleado> lstEmpleado = new List<EVEmpleado>();
    EVProducto eVProducto = new EVProducto();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Cargardll();
        }
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        string c = CGeneracionCodigo.GenerateUniqueId();
        string metodo = ddlMetodoPago.SelectedItem.Text;
        string tipoEntrega = ddlTipoEntrega.SelectedItem.Text;
        string cantidad = txbCantidadProducto.Text;
        string cliente = ddlCliente.SelectedValue.ToString();
        string producto = ddlProducto.SelectedValue.ToString();
        string empleado = ddlEmpleado.SelectedValue.ToString();

        if (string.IsNullOrEmpty(cantidad) || ddlTipoEntrega.SelectedItem.ToString() == "Seleccione un Tipo de Entrega"
            || ddlMetodoPago.SelectedItem.ToString() == "Seleccione un Metodo de Pago"
            || ddlCliente.SelectedItem.ToString() == "Seleccione un Cliente"
            || ddlProducto.SelectedItem.ToString() == "Seleccione un Producto"
            || ddlEmpleado.SelectedItem.ToString() == "Seleccione un Empleado")

        {
            Response.Write("<script>alert('No se permiten campos vacíos.');</script>");
        }
        else
        {
            eVProducto = new EVProducto();
            cProducto = new CProducto();
            eVProducto = cProducto.Obtener_VProducto_O_CodigoProducto(producto);

            if (eVProducto.StockProducto >= int.Parse(cantidad))
            {
                decimal precio = calcularPrecio(int.Parse(cantidad), producto);
                cVenta.Insertar_VVenta_I(c, metodo, tipoEntrega, int.Parse(cantidad), precio, cliente, producto, empleado);
                actualizarPrecio(producto, int.Parse(cantidad));

                ddlMetodoPago.ClearSelection();
                ddlTipoEntrega.ClearSelection();
                txbCantidadProducto.Text = "";
                ddlCliente.ClearSelection();
                ddlProducto.ClearSelection();
                ddlEmpleado.ClearSelection();

                
            }
            else
            {
                Response.Write("<script>alert('La cantidad del Producto no puede superar el stock del producto.');</script>");
            }

            
        }

    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("PListaVentas.aspx");
    }
    private void Cargardll()
    {
        lstCliente = cCliente.Obtener_VCliente_O_Todo().ToList();
        lstProducto = cProducto.Obtener_VProducto_O_Todo().ToList();
        lstEmpleado = cEmpleado.Obtener_VEmpleado_O_Todo().ToList();

        ddlMetodoPago.Items.Add(new ListItem("Seleccione un Metodo de Pago", "0"));
        ddlMetodoPago.Items.Add(new ListItem("Tarjeta de Credito", "1"));
        ddlMetodoPago.Items.Add(new ListItem("QR", "2"));
        ddlMetodoPago.Items.Add(new ListItem("Efectivo", "3"));

        ddlTipoEntrega.Items.Add(new ListItem("Seleccione un Tipo de Entrega", "0"));
        ddlTipoEntrega.Items.Add(new ListItem("Delivery", "1"));
        ddlTipoEntrega.Items.Add(new ListItem("Retiro en Local", "2"));

        ddlCliente.Items.Add(new ListItem("Seleccione un Cliente", "0"));
        ddlProducto.Items.Add(new ListItem("Seleccione un Producto", "0"));
        ddlEmpleado.Items.Add(new ListItem("Seleccione un Empleado", "0"));

        foreach (var cliente in lstCliente)
        {
            ddlCliente.Items.Add(new ListItem((cliente.NombreCliente + " " + cliente.ApellidoPaternoCliente + " " + cliente.ApellidoMaternoCliente), cliente.CodigoCliente));
        }
        foreach (var producto in lstProducto)
        {
            ddlProducto.Items.Add(new ListItem(producto.NombreProducto, producto.CodigoProducto));
        }
        foreach (var empleado in lstEmpleado)
        {
            ddlEmpleado.Items.Add(new ListItem((empleado.NombreEmpleado + " " + empleado.ApellidoPaternoEmpleado + " " + empleado.ApellidoMaternoEmpleado), empleado.CodigoEmpleado));
        }
    }
    private decimal calcularPrecio(int cantidad, string codigo)
    {
        eVProducto = new EVProducto();
        cProducto = new CProducto();
        eVProducto = cProducto.Obtener_VProducto_O_CodigoProducto(codigo);
        decimal precioU = eVProducto.PrecioUnitarioProducto;
        decimal precio = precioU * cantidad;
        return precio;     
    }
    private void actualizarPrecio(string codigo, int cantidad)
    {
        int stock = 0;
        eVProducto = new EVProducto();
        cProducto = new CProducto();
        eVProducto = cProducto.Obtener_VProducto_O_CodigoProducto(codigo);
        stock = eVProducto.StockProducto - cantidad;
        cProducto.Actualizar_VProducto_A(codigo, eVProducto.NombreProducto, eVProducto.DescripcionProducto, eVProducto.PrecioUnitarioProducto, stock);
        
    }
    protected void ddlProducto_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(ddlProducto.SelectedIndex == 0)
        {
            txbStock.Text = string.Empty;
        }
        else
        {
            string producto = ddlProducto.SelectedValue.ToString();
            txbStock.Text = CargarStockProductoSeleccionado(producto).ToString();
        }
    }
    private int CargarStockProductoSeleccionado(string codigo)
    {
        eVProducto = new EVProducto();
        cProducto = new CProducto();
        eVProducto = cProducto.Obtener_VProducto_O_CodigoProducto(codigo);
        int stock = eVProducto.StockProducto;
        return stock;
    }
}