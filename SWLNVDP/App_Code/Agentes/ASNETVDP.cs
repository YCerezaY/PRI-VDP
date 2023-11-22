using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using SWADNETVDP;
/// <summary>
/// Descripción breve de ASNETVDP
/// </summary>
public class ASNETVDP
{
    #region Atributos
    private SWADNETVDPClient sWADNETVDP;
    #endregion
    #region Constructores
    public ASNETVDP()
    {
        sWADNETVDP = new SWADNETVDPClient();
    }
    #endregion
    #region Metodos privados

    private EDefecto ContruirErrorServicio(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto();
        eDefecto.TipoDefecto = tipoDefecto;
        eDefecto.Servicio = "SWLNVDP";
        eDefecto.Clase = "ASNETVDP";
        eDefecto.Metodo = metodo;
        eDefecto.Excepcion = excepcion;
        eDefecto.Mensaje = mensaje;
        return eDefecto;
    }
    #endregion
    #region Metodos Publicos
    #region VCliente
    public void Insertar_VCliente_I(EVCliente eVCliente)
    {
        try
        {
            sWADNETVDP.Insertar_VCliente_I(eVCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVCliente> Obtener_VCliente_O_Todo()
    {
        List<EVCliente> lstVCliente = new List<EVCliente>();
        try
        {
            lstVCliente = sWADNETVDP.Obtener_VCliente_O_Todo().ToList();
            return lstVCliente;
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
            eVCliente = sWADNETVDP.Obtener_VCliente_O_CodigoCliente(CodigoCliente);
            return eVCliente;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVCliente> Obtener_VCliente_O_ApellidoPaternoCliente(string ApellidoPaternoCliente)
    {
        List<EVCliente> lstVCliente = new List<EVCliente>();
        try
        {
            lstVCliente = sWADNETVDP.Obtener_VCliente_O_ApellidoPaternoCliente(ApellidoPaternoCliente).ToList();
            return lstVCliente;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VCliente_A(EVCliente eVCliente)
    {
        try
        {
            sWADNETVDP.Actualizar_VCliente_A(eVCliente);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region VProducto
    public void Insertar_VProducto_I(EVProducto eVProducto)
    {
        try
        {
            sWADNETVDP.Insertar_VProducto_I(eVProducto);
        }
        catch (Exception )
        {
            throw;
        }

    }
    public List<EVProducto> Obtener_VProducto_O_Todo()
    {
        List<EVProducto> lstProducto = new List<EVProducto>();
        try
        {
            lstProducto = sWADNETVDP.Obtener_VProducto_O_Todo().ToList();
            return lstProducto;
        }
        catch (Exception )
        {
            throw;
        }
    
    }
    public EVProducto Obtener_VProducto_O_CodigoProducto(string CodigoProducto)
    {
        EVProducto eVProducto = new EVProducto();
        try
        {
            eVProducto = sWADNETVDP.Obtener_VProducto_O_CodigoProducto(CodigoProducto);
            return eVProducto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVProducto> Obtener_VProducto_O_NombreProducto(string NombreProducto)
    {
        List<EVProducto> lstVProducto = new List<EVProducto>();
        try
        {
            lstVProducto = sWADNETVDP.Obtener_VProducto_O_NombreProducto(NombreProducto).ToList();
            return lstVProducto;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public void Actualizar_VProducto_A(EVProducto eVProducto)
    {
        try
        {
            sWADNETVDP.Actualizar_VProducto_A(eVProducto);
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
            sWADNETVDP.Eliminar_VProducto_E(CodigoProducto);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #region VEmpleado
    public void Insertar_VEmpleado_I(EVEmpleado eVEmpleado)
    {
        try
        {
            sWADNETVDP.Insertar_VEmpleado_I(eVEmpleado);
        }
        catch (Exception)
        {
            throw;
        }
    }
    public List<EVEmpleado> Obtener_VEmpleado_O_Todo()
    {
        List<EVEmpleado> lstVEmpleado = new List<EVEmpleado>();
        try
        {
            lstVEmpleado = sWADNETVDP.Obtener_VEmpleado_O_Todo().ToList();
            return lstVEmpleado;
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
            eVEmpleado = sWADNETVDP.Obtener_VEmpleado_O_CodigoEmpleado(CodigoEmpleado);
            return eVEmpleado;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EVEmpleado> Obtener_VEmpleado_O_ApellidoPaternoEmpleado(string ApellidoPaternoEmpleado)
    {
        List<EVEmpleado> lstVEmpleado = new List<EVEmpleado>();
        try
        {
            lstVEmpleado = sWADNETVDP.Obtener_VEmpleado_O_ApellidoPaternoEmpleado(ApellidoPaternoEmpleado).ToList();
            return lstVEmpleado;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Actualizar_VEmpleado_A(EVEmpleado eVEmpleado)
    {
        try
        {
            sWADNETVDP.Actualizar_VEmpleado_A(eVEmpleado);
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
            sWADNETVDP.Eliminar_VEmpleado_E(CodigoEmpleado);
        }
        catch(Exception)
        {
            throw;
        }
    }

    #endregion
    #region VVenta
    public void Insertar_VVenta_I(EVVenta eVVenta)
    {
        try
        {
            sWADNETVDP.Insertar_VVenta_I(eVVenta);
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
            lstVenta = sWADNETVDP.Obtener_VVenta_O_Todo().ToList();
            return lstVenta;
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
            eVVenta = sWADNETVDP.Obtener_VVenta_O_CodigoVenta(CodigoVenta);
            return eVVenta;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EVVenta> Obtener_VVenta_O_CodigoCliente(string CodigoCliente)
    {
        List<EVVenta> lstVVenta = new List<EVVenta>();
        try
        {
            lstVVenta = sWADNETVDP.Obtener_VVenta_O_CodigoCliente(CodigoCliente).ToList();
            return lstVVenta;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EVVenta> Obtener_VVenta_O_CodigoEmpleado(string CodigoEmpleado)
    {
        List<EVVenta> lstVVenta = new List<EVVenta>();
        try
        {
            lstVVenta = sWADNETVDP.Obtener_VVenta_O_CodigoEmpleado(CodigoEmpleado).ToList();
            return lstVVenta;
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<EVVenta> Obtener_VVenta_O_CodigoProducto(string CodigoProducto)
    {
        List<EVVenta> lstVVenta = new List<EVVenta>();
        try
        {
            lstVVenta = sWADNETVDP.Obtener_VVenta_O_CodigoProducto(CodigoProducto).ToList();
            return lstVVenta;
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
            sWADNETVDP.Eliminar_VVenta_E(CodigoVenta);
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
    #endregion
}
