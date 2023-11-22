using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using SWADNETVDP;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWLNVDP : ISWLNVDP
{
    #region Tabla : VProducto
    public void Insertar_VProducto_I(string CodigoProducto, string NombreProducto, string DescripcionProducto, decimal PrecioUnitarioProducto, int StockProducto)
    {
        CRVDP cRVDP = new CRVDP();
        cRVDP.Insertar_VProducto_I(CodigoProducto, NombreProducto, DescripcionProducto, PrecioUnitarioProducto, StockProducto);
    }

    public List<EVProducto> Obtener_VProducto_O_Todo()
    {
        CRVDP cRVDP = new CRVDP();
        return cRVDP.Obtener_VProducto_O_Todo();
    }

    public EVProducto Obtener_VProducto_O_CodigoProducto(string CodigoProducto)
    {
        CRVDP cRVDP = new CRVDP();
        EVProducto eVProducto = new EVProducto();
        eVProducto = cRVDP.Obtener_VProducto_O_CodigoProducto(CodigoProducto);
        return eVProducto;
    }

    public List<EVProducto> Obtener_VProducto_O_NombreProducto(string NombreProducto)
    {
        CRVDP cRVDP = new CRVDP();
        return cRVDP.Obtener_VProducto_O_NombreProducto(NombreProducto);
    }


    public void Actualizar_VProducto_A(string CodigoProducto, string NombreProducto, string DescripcionProducto, decimal PrecioUnitarioProducto, int StockProducto)
    {
        CRVDP cRProducto = new CRVDP();
        cRProducto.Actualizar_VProducto_A(CodigoProducto, NombreProducto, DescripcionProducto, PrecioUnitarioProducto, StockProducto);
    }
    
    public void Eliminar_VProducto_E(string CodigoProducto)
    {
        CRVDP cRVDP = new CRVDP();
        cRVDP.Eliminar_VProducto_E(CodigoProducto);
    }
    #endregion
    #region Tabla : VCliente
    public void Insertar_VCliente_I(string CodigoCliente, string NombreCliente, string ApellidoPaternoCliente, string ApellidoMaternoCliente, string DireccionCliente, int TelefonoCliente)
    { 
        CRVDP cRVDP = new CRVDP();
        cRVDP.Insertar_VCliente_I(CodigoCliente, NombreCliente, ApellidoPaternoCliente, ApellidoMaternoCliente, DireccionCliente, TelefonoCliente);
    }
    public List<EVCliente> Obtener_VCliente_O_Todo()
    {
        CRVDP cRVDP = new CRVDP();
        return cRVDP.Obtener_VCliente_O_Todo();
    }
    public EVCliente Obtener_VCliente_O_CodigoCliente(string CodigoCliente)
    {
        CRVDP cRVDP = new CRVDP();
        EVCliente eVCliente = new EVCliente();
        eVCliente = cRVDP.Obtener_VCliente_O_CodigoCliente(CodigoCliente);
        return eVCliente;
    }
    public List<EVCliente> Obtener_VCliente_O_ApellidoPaternoCliente(string ApellidoPaternoCliente)
    {
        CRVDP cRVDP = new CRVDP();
        return cRVDP.Obtener_VCliente_O_ApellidoPaternoCliente(ApellidoPaternoCliente);
    }
    public void Actualizar_VCliente_A(string CodigoCliente, string NombreCliente, string ApellidoPaternoCliente, string ApellidoMaternoCliente, string DireccionCliente, int TelefonoCliente)
    {
        CRVDP cRVDP = new CRVDP();
        cRVDP.Actualizar_VCliente_A(CodigoCliente, NombreCliente, ApellidoPaternoCliente, ApellidoMaternoCliente, DireccionCliente, TelefonoCliente);
    }
    #endregion
    #region Tabla : VEmpleado
    public void Insertar_VEmpleado_I(string CodigoEmpleado, string NombreEmpleado, string ApellidoPaternoEmpleado, string ApellidoMaternoEmpleado)
    {
        CRVDP cRVDP = new CRVDP();
        cRVDP.Insertar_VEmpleado_I(CodigoEmpleado, NombreEmpleado, ApellidoPaternoEmpleado, ApellidoMaternoEmpleado);
    }

    public List<EVEmpleado> Obtener_VEmpleado_O_Todo()
    {
        CRVDP cRVDP = new CRVDP();
        return cRVDP.Obtener_VEmpleado_O_Todo();
    }

    public EVEmpleado Obtener_VEmpleado_O_CodigoEmpleado(string CodigoEmpleado)
    {
        CRVDP cRVDP = new CRVDP();
        EVEmpleado eVEmpleado = new EVEmpleado();
        eVEmpleado = cRVDP.Obtener_VEmpleado_O_CodigoEmpleado(CodigoEmpleado);
        return eVEmpleado;
    }

    public List<EVEmpleado> Obtener_VEmpleado_O_ApellidoPaternoEmpleado(string ApellidoPaternoEmpleado)
    {
        CRVDP cRVDP = new CRVDP();
        return cRVDP.Obtener_VEmpleado_O_ApellidoPaternoEmpleado(ApellidoPaternoEmpleado);
    }


    public void Actualizar_VEmpleado_A(string CodigoEmpleado, string NombreEmpleado, string ApellidoPaternoEmpleado, string ApellidoMaternoEmpleado)
    {
        CRVDP cRVDP = new CRVDP();
        cRVDP.Actualizar_VEmpleado_A(CodigoEmpleado, NombreEmpleado, ApellidoPaternoEmpleado, ApellidoMaternoEmpleado);
    }

    public void Eliminar_VEmpleado_E(string CodigoEmpleado)
    {
        CRVDP cRVDP = new CRVDP();
        cRVDP.Eliminar_VEmpleado_E(CodigoEmpleado);
    }

    #endregion
    #region Tabla : VVenta
    public void Insertar_VVenta_I(string CodigoVenta, string MetodoPagoVenta, string TipoEntregaVenta, int CantidadProductoVenta, decimal PrecioTotalVenta, string CodigoCliente, string CodigoProducto, string CodigoEmpleado)
    {
        CRVDP cRVDP = new CRVDP();
        cRVDP.Insertar_VVenta_I(CodigoVenta, MetodoPagoVenta, TipoEntregaVenta, CantidadProductoVenta, PrecioTotalVenta, CodigoCliente, CodigoProducto, CodigoEmpleado);
    }

    public List<EVVenta> Obtener_VVenta_O_Todo()
    {
        CRVDP cRVDP = new CRVDP();
        return cRVDP.Obtener_VVenta_O_Todo();
    }

    public EVVenta Obtener_VVenta_O_CodigoVenta(string CodigoVenta)
    {
        CRVDP cRVDP = new CRVDP();
        EVVenta eVVenta = new EVVenta();
        eVVenta = cRVDP.Obtener_VVenta_O_CodigoVenta(CodigoVenta);
        return eVVenta;
    }

    public void Eliminar_VVenta_E(string CodigoVenta)
    {
        CRVDP cRVDP = new CRVDP();
        cRVDP.Eliminar_VVenta_E(CodigoVenta);
    }

    #endregion
    //Compleja
    #region VVentaCompleja
    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja()
    {
        CRVDP cRVDP = new CRVDP();
        return cRVDP.Obtener_VVenta_O_Compleja();
    }
    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoCliente(string CodigoCliente)
    {
        CRVDP cRVDP = new CRVDP();
        return cRVDP.Obtener_VVenta_O_Compleja_CodigoCliente(CodigoCliente);
    }
    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoEmpleado(string CodigoEmpleado)
    {
        CRVDP cRVDP = new CRVDP();
        return cRVDP.Obtener_VVenta_O_Compleja_CodigoEmpleado(CodigoEmpleado);
    }
    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoProducto(string CodigoProducto)
    {
        CRVDP cRVDP = new CRVDP();
        return cRVDP.Obtener_VVenta_O_Compleja_CodigoProducto(CodigoProducto);
    }

    #endregion
}
