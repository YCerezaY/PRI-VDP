using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using SWLNVDP;

/// <summary>
/// Descripción breve de LNServicio
/// </summary>
public class LNServicio
{
    #region Propiedades
    public string NombreClase
    {
        get { return GetType().Name; }
    }
    #endregion

    #region Atributos
    private SWLNVDPClient sWLNVDP;
    #endregion

    #region Constructor
    public LNServicio()
    {
        sWLNVDP = new SWLNVDPClient();
    }

    private EDefecto ConstruirDefecto(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje, string stackTrace)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = tipoDefecto,
            Servicio = SDatosGlobales.NOMBRE_APLICACION,
            Clase = NombreClase,
            Metodo = metodo,
            Mensaje = mensaje,
            Excepcion = excepcion,
        };

        return eDefecto;
    }

    private EDefecto ConstruirDefecto(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = tipoDefecto,
            Servicio = SDatosGlobales.NOMBRE_APLICACION,
            Clase = NombreClase,
            Metodo = metodo,
            Mensaje = mensaje,
            Excepcion = excepcion
        };

        return eDefecto;
    }

    private EDefecto ConstruirDefecto(FaultException<EDefecto> ex)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = ex.Detail.TipoDefecto,
            Servicio = ex.Detail.Servicio,
            Clase = ex.Detail.Clase,
            Metodo = ex.Detail.Metodo,
            Excepcion = ex.Detail.Excepcion,
            Mensaje = ex.Detail.Mensaje,
        };
        return eDefecto;
    }
    #endregion
    #region Metodos Publicos
    #region VProducto
    public void Insertar_VProducto_I(string CodigoProducto, string NombreProducto, string DescripcionProducto, decimal PrecioUnitarioProducto, int StockProducto)
    {
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                cliente.Insertar_VProducto_I(CodigoProducto, NombreProducto, DescripcionProducto, PrecioUnitarioProducto, StockProducto);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVProducto> Obtener_VProducto_O_Todo()
    {
        List<EVProducto> lstProducto = new List<EVProducto>();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                lstProducto = cliente.Obtener_VProducto_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstProducto;
    }
    public EVProducto Obtener_VProducto_O_CodigoProducto(string CodigoEmpleado)
    {
        EVProducto eVProducto = new EVProducto();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                eVProducto = cliente.Obtener_VProducto_O_CodigoProducto(CodigoEmpleado);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eVProducto;
    }

    public List<EVProducto> Obtener_VProducto_O_NombreProducto(string NombreProducto)
    {
        List<EVProducto> lstProducto = new List<EVProducto>();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                lstProducto = cliente.Obtener_VProducto_O_NombreProducto(NombreProducto).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstProducto;
    }

    public void Actualizar_VProducto_A(string CodigoProducto, string NombreProducto, string DescripcionProducto, decimal PrecioUnitarioProducto, int StockProducto)
    {
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                cliente.Actualizar_VProducto_A(CodigoProducto, NombreProducto, DescripcionProducto, PrecioUnitarioProducto, StockProducto);
            }
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
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                cliente.Eliminar_VProducto_E(CodigoProducto);
            }
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
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                cliente.Insertar_VCliente_I(CodigoCliente, NombreCliente, ApellidoPaternoCliente, ApellidoMaternoCliente, DireccionCliente, TelefonoCliente);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVCliente> Obtener_VCliente_O_Todo()
    {
        List<EVCliente> lstCliente = new List<EVCliente>();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                lstCliente = cliente.Obtener_VCliente_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstCliente;
    }
    public EVCliente Obtener_VCliente_O_CodigoCliente(string CodigoCliente)
    {
        EVCliente eVCliente = new EVCliente();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                eVCliente = cliente.Obtener_VCliente_O_CodigoCliente(CodigoCliente);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eVCliente;
    }

    public List<EVCliente> Obtener_VCliente_O_ApellidoPaternoCliente(string ApellidoPaternoCliente)
    {
        List<EVCliente> lstCliente = new List<EVCliente>();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                lstCliente = cliente.Obtener_VCliente_O_ApellidoPaternoCliente(ApellidoPaternoCliente).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstCliente;
    }

    public void Actualizar_VCliente_A(string CodigoCliente, string NombreCliente, string ApellidoPaternoCliente, string ApellidoMaternoCliente, string DireccionCliente, int TelefonoCliente)
    {
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                cliente.Actualizar_VCliente_A(CodigoCliente, NombreCliente, ApellidoPaternoCliente, ApellidoMaternoCliente, DireccionCliente, TelefonoCliente);
            }
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
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                cliente.Insertar_VEmpleado_I(CodigoEmpleado, NombreEmpleado, ApellidoPaternoEmpleado, ApellidoMaternoEmpleado);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVEmpleado> Obtener_VEmpleado_O_Todo()
    {
        List<EVEmpleado> lstEmpleado = new List<EVEmpleado>();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                lstEmpleado = cliente.Obtener_VEmpleado_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEmpleado;
    }
    public EVEmpleado Obtener_VEmpleado_O_CodigoEmpleado(string CodigoEmpleado)
    {
        EVEmpleado eVEmpleado = new EVEmpleado();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                eVEmpleado = cliente.Obtener_VEmpleado_O_CodigoEmpleado(CodigoEmpleado);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eVEmpleado;
    }
    public List<EVEmpleado> Obtener_VEmpleado_O_ApellidoPaternoEmpleado(string ApellidoPaternoEmpleado)
    {
        List<EVEmpleado> lstEmpleado = new List<EVEmpleado>();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                lstEmpleado = cliente.Obtener_VEmpleado_O_ApellidoPaternoEmpleado(ApellidoPaternoEmpleado).ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstEmpleado;
    }
    public void Actualizar_VEmpleado_A(string CodigoEmpleado, string NombreEmpleado, string ApellidoPaternoEmpleado, string ApellidoMaternoEmpleado)
    {
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                cliente.Actualizar_VEmpleado_A(CodigoEmpleado, NombreEmpleado, ApellidoPaternoEmpleado, ApellidoMaternoEmpleado);
            }
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
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                cliente.Eliminar_VEmpleado_E(CodigoEmpleado);
            }
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
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                cliente.Insertar_VVenta_I(CodigoVenta, MetodoPagoVenta, TipoEntregaVenta, CantidadProductoVenta, PrecioTotalVenta, CodigoCliente, CodigoProducto, CodigoEmpleado);
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVVenta> Obtener_VVenta_O_Todo()
    {
        List<EVVenta> lstVenta = new List<EVVenta>();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                lstVenta = cliente.Obtener_VVenta_O_Todo().ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return lstVenta;
    }
    public EVVenta Obtener_VVenta_O_CodigoVenta(string CodigoVenta)
    {
        EVVenta eVVenta = new EVVenta();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                eVVenta = cliente.Obtener_VVenta_O_CodigoVenta(CodigoVenta);
            }
        }
        catch (Exception)
        {
            throw;
        }
        return eVVenta;
    }
    public void Eliminar_VVenta_E(string CodigoVenta)
    {
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                cliente.Eliminar_VVenta_E(CodigoVenta);
            }
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
        List<EVVentaCompleja> lstVentaCompleja = new List<EVVentaCompleja>();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                lstVentaCompleja = cliente.Obtener_VVenta_O_Compleja().ToList();
            }
        }
        catch
        {
            throw;
        }
        return lstVentaCompleja;
    }

    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoCliente(string CodigoCliente) 
    {
        List<EVVentaCompleja> lstVentaCompleja = new List<EVVentaCompleja>();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                lstVentaCompleja = cliente.Obtener_VVenta_O_Compleja_CodigoCliente(CodigoCliente).ToList();
            }
        }
        catch
        {
            throw;
        }
        return lstVentaCompleja;
    }

    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoEmpleado(string CodigoEmpleado)
    {
        List<EVVentaCompleja> lstVentaCompleja = new List<EVVentaCompleja>();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                lstVentaCompleja = cliente.Obtener_VVenta_O_Compleja_CodigoEmpleado(CodigoEmpleado).ToList();
            }
        }
        catch
        {
            throw;
        }
        return lstVentaCompleja;
    }

    public List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoProducto(string CodigoProducto)
    {
        List<EVVentaCompleja> lstVentaCompleja = new List<EVVentaCompleja>();
        try
        {
            using (SWLNVDPClient cliente = new SWLNVDPClient())
            {
                lstVentaCompleja = cliente.Obtener_VVenta_O_Compleja_CodigoProducto(CodigoProducto).ToList();
            }
        }
        catch
        {
            throw;
        }
        return lstVentaCompleja;
    }

    #endregion
    #endregion
}