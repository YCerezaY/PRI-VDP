using SWADNETVDP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CRVDP
/// </summary>
public class CRVDP
{
    #region Atributos
    ASNETVDP aSNETVDP;
    List<EVVentaCompleja> lstVentaCompleja = new List<EVVentaCompleja>();
    List<EVVenta> lstVenta = new List<EVVenta>();
    EVVentaCompleja eVVentaCompleja;
    EVCliente vCliente;
    EVProducto vProducto;
    EVEmpleado vEmpleado;
    #endregion
    #region Constructores
    public CRVDP()
    {
        aSNETVDP = new ASNETVDP();
    }
    #endregion
    #region Metodos privados

    private EDefecto ContruirErrorServicio(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto();
        eDefecto.TipoDefecto = tipoDefecto;
        eDefecto.Servicio = "SWLNVDP";
        eDefecto.Clase = "CVDP";
        eDefecto.Metodo = metodo;
        eDefecto.Excepcion = excepcion;
        eDefecto.Mensaje = mensaje;
        return eDefecto;
    }

    #endregion
    #region Metodos Publicos
    #region VProductos
    public void Insertar_VProducto_I(string CodigoProducto, string NombreProducto, string DescripcionProducto, decimal PrecioUnitarioProducto, int StockProducto)
    {
        EVProducto eVProducto = new EVProducto();
        try
        {
            eVProducto.CodigoProducto = CodigoProducto;
            eVProducto.NombreProducto = NombreProducto;
            eVProducto.DescripcionProducto = DescripcionProducto;
            eVProducto.PrecioUnitarioProducto = PrecioUnitarioProducto;
            eVProducto.StockProducto = StockProducto;
            aSNETVDP.Insertar_VProducto_I(eVProducto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVProducto> Obtener_VProducto_O_Todo()
    {
        try
        {
            return aSNETVDP.Obtener_VProducto_O_Todo();

        }
        catch (Exception)
        {
            throw;
        }
    }
    public EVProducto Obtener_VProducto_O_CodigoProducto(string CodigoProducto)
    {
        EVProducto eVProducto = new EVProducto();
        try
        {
            eVProducto = aSNETVDP.Obtener_VProducto_O_CodigoProducto(CodigoProducto);
            return eVProducto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVProducto> Obtener_VProducto_O_NombreProducto(string NombreProducto)
    {
        try
        {
            return aSNETVDP.Obtener_VProducto_O_NombreProducto(NombreProducto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VProducto_A(string CodigoProducto, string NombreProducto, string DescripcionProducto, decimal PrecioUnitarioProducto, int StockProducto)
    {
        EVProducto eVProducto = new EVProducto();
        try
        {
            eVProducto.CodigoProducto = CodigoProducto;
            eVProducto.NombreProducto = NombreProducto;
            eVProducto.DescripcionProducto = DescripcionProducto;
            eVProducto.PrecioUnitarioProducto = PrecioUnitarioProducto;
            eVProducto.StockProducto = StockProducto;
            aSNETVDP.Actualizar_VProducto_A(eVProducto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_VProducto_E(string CodigoProducto)
    {
        try
        {
            aSNETVDP.Eliminar_VProducto_E(CodigoProducto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region VCliente
    public void Insertar_VCliente_I(string CodigoCliente, string NombreCliente, string ApellidoPaternoCliente, string ApellidoMaternoCliente, string DireccionCliente, int TelefonoCliente)
    {
        EVCliente eVCliente = new EVCliente();
        try
        {
            eVCliente.CodigoCliente = CodigoCliente;
            eVCliente.NombreCliente = NombreCliente;
            eVCliente.ApellidoPaternoCliente = ApellidoPaternoCliente;
            eVCliente.ApellidoMaternoCliente = ApellidoMaternoCliente;
            eVCliente.DireccionCliente = DireccionCliente;
            eVCliente.TelefonoCliente = TelefonoCliente;
            aSNETVDP.Insertar_VCliente_I(eVCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVCliente> Obtener_VCliente_O_Todo()
    {
        try
        {
            return aSNETVDP.Obtener_VCliente_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EVCliente Obtener_VCliente_O_CodigoCliente(string CodigoCliente)
    {
        EVCliente eVCliente = new EVCliente();
        try
        {
            eVCliente = aSNETVDP.Obtener_VCliente_O_CodigoCliente(CodigoCliente);
            return eVCliente;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVCliente> Obtener_VCliente_O_ApellidoPaternoCliente(string ApellidoPaternoCliente)
    {
        try
        {
            return aSNETVDP.Obtener_VCliente_O_ApellidoPaternoCliente(ApellidoPaternoCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VCliente_A(string CodigoCliente, string NombreCliente, string ApellidoPaternoCliente, string ApellidoMaternoCliente, string DireccionCliente, int TelefonoCliente)
    {
        EVCliente eVCliente = new EVCliente();
        try
        {
            eVCliente.CodigoCliente = CodigoCliente;
            eVCliente.NombreCliente = NombreCliente;
            eVCliente.ApellidoPaternoCliente = ApellidoPaternoCliente;
            eVCliente.ApellidoMaternoCliente = ApellidoMaternoCliente;
            eVCliente.DireccionCliente = DireccionCliente;
            eVCliente.TelefonoCliente = TelefonoCliente;
            aSNETVDP.Actualizar_VCliente_A(eVCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region VEmpleado
    public void Insertar_VEmpleado_I(string CodigoEmpleado, string NombreEmpleado, string ApellidoPaternoEmpleado, string ApellidoMaternoEmpleado)
    {
        EVEmpleado eVEmpleado = new EVEmpleado();
        try
        {
            eVEmpleado.CodigoEmpleado = CodigoEmpleado;
            eVEmpleado.NombreEmpleado = NombreEmpleado;
            eVEmpleado.ApellidoPaternoEmpleado = ApellidoPaternoEmpleado;
            eVEmpleado.ApellidoMaternoEmpleado = ApellidoMaternoEmpleado;
            aSNETVDP.Insertar_VEmpleado_I(eVEmpleado);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVEmpleado> Obtener_VEmpleado_O_Todo()
    {
        try
        {
            return aSNETVDP.Obtener_VEmpleado_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EVEmpleado Obtener_VEmpleado_O_CodigoEmpleado(string CodigoEmpleado)
    {
        EVEmpleado eVEmpleado = new EVEmpleado();
        try
        {
            eVEmpleado = aSNETVDP.Obtener_VEmpleado_O_CodigoEmpleado(CodigoEmpleado);
            return eVEmpleado;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVEmpleado> Obtener_VEmpleado_O_ApellidoPaternoEmpleado(string ApellidoPaternoEmpleado)
    {
        try
        {
            return aSNETVDP.Obtener_VEmpleado_O_ApellidoPaternoEmpleado(ApellidoPaternoEmpleado);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VEmpleado_A(string CodigoEmpleado, string NombreEmpleado, string ApellidoPaternoEmpleado, string ApellidoMaternoEmpleado)
    {
        EVEmpleado eVEmpleado = new EVEmpleado();
        try
        {
            eVEmpleado.CodigoEmpleado = CodigoEmpleado;
            eVEmpleado.NombreEmpleado = NombreEmpleado;
            eVEmpleado.ApellidoPaternoEmpleado = ApellidoPaternoEmpleado;
            eVEmpleado.ApellidoMaternoEmpleado = ApellidoMaternoEmpleado;
            aSNETVDP.Actualizar_VEmpleado_A(eVEmpleado);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_VEmpleado_E(string CodigoEmpleado)
    {
        try
        {
            aSNETVDP.Eliminar_VEmpleado_E(CodigoEmpleado);
        }
        catch(Exception) 
        { 
            throw; 
        }
    }
    #endregion
    #region VVenta
    public void Insertar_VVenta_I(string CodigoVenta, string MetodoPagoVenta, string TipoEntregaVenta, int CantidadProductoVenta, decimal PrecioTotalVenta, string CodigoCliente, string CodigoProducto, string CodigoEmpleado)
    {
        EVVenta eVVenta = new EVVenta();
        try
        {
            eVVenta.CodigoVenta = CodigoVenta;
            eVVenta.MetodoPagoVenta = MetodoPagoVenta;
            eVVenta.TipoEntregaVenta = TipoEntregaVenta;
            eVVenta.CantidadProductoVenta = CantidadProductoVenta;
            eVVenta.PrecioTotalVenta = PrecioTotalVenta;
            eVVenta.CodigoCliente = CodigoCliente;
            eVVenta.CodigoProducto = CodigoProducto;
            eVVenta.CodigoEmpleado = CodigoEmpleado;
            aSNETVDP.Insertar_VVenta_I(eVVenta);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVVenta> Obtener_VVenta_O_Todo()
    {
        try
        {
            return aSNETVDP.Obtener_VVenta_O_Todo();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public EVVenta Obtener_VVenta_O_CodigoVenta(string CodigoVenta)
    {
        EVVenta eVVenta = new EVVenta();
        try
        {
            eVVenta = aSNETVDP.Obtener_VVenta_O_CodigoVenta(CodigoVenta);
            return eVVenta;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Eliminar_VVenta_E(string CodigoVenta)
    {
        try
        {
            aSNETVDP.Eliminar_VVenta_E(CodigoVenta);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    //Complejas
    #region VVentaCompleja
    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja()
    {
        lstVentaCompleja = new List<EVVentaCompleja>();
        lstVenta = new List<EVVenta>();
        try
        {
            lstVenta = aSNETVDP.Obtener_VVenta_O_Todo();
            foreach (var ventas in lstVenta)
            {
                vCliente = new EVCliente();
                vCliente = aSNETVDP.Obtener_VCliente_O_CodigoCliente(ventas.CodigoCliente);
                vProducto = new EVProducto();
                vProducto = aSNETVDP.Obtener_VProducto_O_CodigoProducto(ventas.CodigoProducto);
                vEmpleado = new EVEmpleado();
                vEmpleado = aSNETVDP.Obtener_VEmpleado_O_CodigoEmpleado(ventas.CodigoEmpleado);


                eVVentaCompleja = new EVVentaCompleja();
                eVVentaCompleja.CodigoVenta = ventas.CodigoVenta;
                eVVentaCompleja.MetodoPagoVenta = ventas.MetodoPagoVenta;
                eVVentaCompleja.TipoEntregaVenta = ventas.TipoEntregaVenta;
                eVVentaCompleja.CantidadProductoVenta = ventas.CantidadProductoVenta;
                eVVentaCompleja.PrecioTotalVenta = ventas.PrecioTotalVenta;
                eVVentaCompleja.CodigoCliente = vCliente.CodigoCliente;
                eVVentaCompleja.NombreCompletoCliente = (vCliente.NombreCliente + " " + vCliente.ApellidoPaternoCliente);
                eVVentaCompleja.CodigoProducto = vProducto.CodigoProducto;
                eVVentaCompleja.NombreProducto = vProducto.NombreProducto;
                eVVentaCompleja.FechaRegistro = ventas.FechaRegistro;
                eVVentaCompleja.CodigoEmpleado = vEmpleado.CodigoEmpleado;
                eVVentaCompleja.NombreCompletoEmpleado = (vEmpleado.NombreEmpleado + " " + vEmpleado.ApellidoPaternoEmpleado);
                lstVentaCompleja.Add(eVVentaCompleja);
            }

        }
        catch (Exception)
        {
            throw;
        }
        return lstVentaCompleja;
    }

    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoCliente(string CodigoCliente)
    {
        lstVentaCompleja = new List<EVVentaCompleja>();
        lstVenta = new List<EVVenta>();
        try
        {
            lstVenta = aSNETVDP.Obtener_VVenta_O_CodigoCliente(CodigoCliente);
            foreach (var ventas in lstVenta)
            {
                vCliente = new EVCliente();
                vCliente = aSNETVDP.Obtener_VCliente_O_CodigoCliente(ventas.CodigoCliente);
                vProducto = new EVProducto();
                vProducto = aSNETVDP.Obtener_VProducto_O_CodigoProducto(ventas.CodigoProducto);
                vEmpleado = new EVEmpleado();
                vEmpleado = aSNETVDP.Obtener_VEmpleado_O_CodigoEmpleado(ventas.CodigoEmpleado);


                eVVentaCompleja = new EVVentaCompleja();
                eVVentaCompleja.CodigoVenta = ventas.CodigoVenta;
                eVVentaCompleja.MetodoPagoVenta = ventas.MetodoPagoVenta;
                eVVentaCompleja.TipoEntregaVenta = ventas.TipoEntregaVenta;
                eVVentaCompleja.CantidadProductoVenta = ventas.CantidadProductoVenta;
                eVVentaCompleja.PrecioTotalVenta = ventas.PrecioTotalVenta;
                eVVentaCompleja.CodigoCliente = vCliente.CodigoCliente;
                eVVentaCompleja.NombreCompletoCliente = (vCliente.NombreCliente + " " + vCliente.ApellidoPaternoCliente);
                eVVentaCompleja.CodigoProducto = vProducto.CodigoProducto;
                eVVentaCompleja.NombreProducto = vProducto.NombreProducto;
                eVVentaCompleja.FechaRegistro = ventas.FechaRegistro;
                eVVentaCompleja.CodigoEmpleado = vEmpleado.CodigoEmpleado;
                eVVentaCompleja.ApellidoPaternoCliente = vCliente.ApellidoPaternoCliente;
                eVVentaCompleja.NombreCompletoEmpleado = (vEmpleado.NombreEmpleado + " " + vEmpleado.ApellidoPaternoEmpleado);
                lstVentaCompleja.Add(eVVentaCompleja);
            }

        }
        catch (Exception)
        {
            throw;
        }
        return lstVentaCompleja;
    }

    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoEmpleado(string CodigoEmpleado)
    {
        lstVentaCompleja = new List<EVVentaCompleja>();
        lstVenta = new List<EVVenta>();
        try
        {
            lstVenta = aSNETVDP.Obtener_VVenta_O_CodigoEmpleado(CodigoEmpleado);
            foreach (var ventas in lstVenta)
            {
                vCliente = new EVCliente();
                vCliente = aSNETVDP.Obtener_VCliente_O_CodigoCliente(ventas.CodigoCliente);
                vProducto = new EVProducto();
                vProducto = aSNETVDP.Obtener_VProducto_O_CodigoProducto(ventas.CodigoProducto);
                vEmpleado = new EVEmpleado();
                vEmpleado = aSNETVDP.Obtener_VEmpleado_O_CodigoEmpleado(ventas.CodigoEmpleado);


                eVVentaCompleja = new EVVentaCompleja();
                eVVentaCompleja.CodigoVenta = ventas.CodigoVenta;
                eVVentaCompleja.MetodoPagoVenta = ventas.MetodoPagoVenta;
                eVVentaCompleja.TipoEntregaVenta = ventas.TipoEntregaVenta;
                eVVentaCompleja.CantidadProductoVenta = ventas.CantidadProductoVenta;
                eVVentaCompleja.PrecioTotalVenta = ventas.PrecioTotalVenta;
                eVVentaCompleja.CodigoCliente = vCliente.CodigoCliente;
                eVVentaCompleja.NombreCompletoCliente = (vCliente.NombreCliente + " " + vCliente.ApellidoPaternoCliente);
                eVVentaCompleja.CodigoProducto = vProducto.CodigoProducto;
                eVVentaCompleja.NombreProducto = vProducto.NombreProducto;
                eVVentaCompleja.FechaRegistro = ventas.FechaRegistro;
                eVVentaCompleja.CodigoEmpleado = vEmpleado.CodigoEmpleado;
                eVVentaCompleja.ApellidoPaternoEmpleado = vEmpleado.ApellidoPaternoEmpleado;
                eVVentaCompleja.NombreCompletoEmpleado = (vEmpleado.NombreEmpleado + " " + vEmpleado.ApellidoPaternoEmpleado);
                lstVentaCompleja.Add(eVVentaCompleja);
            }

        }
        catch (Exception)
        {
            throw;
        }
        return lstVentaCompleja;
    }

    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoProducto(string CodigoProducto)
    {
        lstVentaCompleja = new List<EVVentaCompleja>();
        lstVenta = new List<EVVenta>();
        try
        {
            lstVenta = aSNETVDP.Obtener_VVenta_O_CodigoProducto(CodigoProducto);
            foreach (var ventas in lstVenta)
            {
                EVCliente vCliente = new EVCliente();
                vCliente = aSNETVDP.Obtener_VCliente_O_CodigoCliente(ventas.CodigoCliente);
                EVProducto vProducto = new EVProducto();
                vProducto = aSNETVDP.Obtener_VProducto_O_CodigoProducto(ventas.CodigoProducto);
                EVEmpleado vEmpleado = new EVEmpleado();
                vEmpleado = aSNETVDP.Obtener_VEmpleado_O_CodigoEmpleado(ventas.CodigoEmpleado);


                eVVentaCompleja = new EVVentaCompleja();
                eVVentaCompleja.CodigoVenta = ventas.CodigoVenta;
                eVVentaCompleja.MetodoPagoVenta = ventas.MetodoPagoVenta;
                eVVentaCompleja.TipoEntregaVenta = ventas.TipoEntregaVenta;
                eVVentaCompleja.CantidadProductoVenta = ventas.CantidadProductoVenta;
                eVVentaCompleja.PrecioTotalVenta = ventas.PrecioTotalVenta;
                eVVentaCompleja.CodigoCliente = vCliente.CodigoCliente;
                eVVentaCompleja.NombreCompletoCliente = (vCliente.NombreCliente + " " + vCliente.ApellidoPaternoCliente);
                eVVentaCompleja.CodigoProducto = vProducto.CodigoProducto;
                eVVentaCompleja.NombreProducto = vProducto.NombreProducto;
                eVVentaCompleja.FechaRegistro = ventas.FechaRegistro;
                eVVentaCompleja.CodigoEmpleado = vEmpleado.CodigoEmpleado;
                eVVentaCompleja.NombreCompletoEmpleado = (vEmpleado.NombreEmpleado + " " + vEmpleado.ApellidoPaternoEmpleado);
                lstVentaCompleja.Add(eVVentaCompleja);
            }

        }
        catch (Exception)
        {
            throw;
        }
        return lstVentaCompleja;
    }

    #endregion
    #endregion
}
