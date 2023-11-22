using System;
using System.Collections.Generic;
//using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class SWADNETVDP : ISWADNETVDP
{
    #region Tabla : Cliente
    public void Insertar_VCliente_I(EVCliente eVCliente)
    {
        CVCliente cVCliente = new CVCliente();
        cVCliente.Insertar_VCliente_I(eVCliente);
    }
    public List<EVCliente> Obtener_VCliente_O_Todo()
    {
        CVCliente cVCliente = new CVCliente();
        return cVCliente.Obtener_VCliente_O_Todo();
    }
    public EVCliente Obtener_VCliente_O_CodigoCliente(string CodigoCliente)
    {
        CVCliente cVCliente = new CVCliente();
        EVCliente eVCliente = new EVCliente();
        eVCliente = cVCliente.Obtener_VCliente_O_CodigoCliente(CodigoCliente);
        return eVCliente;
    }
    public List<EVCliente> Obtener_VCliente_O_ApellidoPaternoCliente(string ApellidoPaternoCliente)
    {
        CVCliente cVCliente = new CVCliente();
        return cVCliente.Obtener_VCliente_O_ApellidoPaternoCliente(ApellidoPaternoCliente);
    }
    public void Actualizar_VCliente_A(EVCliente eVCliente)
    {
        CVCliente cVCliente = new CVCliente();
        cVCliente.Actualizar_VCliente_A(eVCliente);
    }
    #endregion
    #region Tabla : VProducto
    public void Insertar_VProducto_I(EVProducto eVProducto)
    {
        CVProducto cVProducto = new CVProducto();
        cVProducto.Insertar_VPorducto_I(eVProducto);
    }
    public List<EVProducto> Obtener_VProducto_O_Todo()
    {
        CVProducto cVProducto = new CVProducto();
        return cVProducto.Obtener_VProducto_O_Todo();
    }
    public EVProducto Obtener_VProducto_O_CodigoProducto(string CodigoProducto)
    {
        CVProducto cVProducto = new CVProducto();
        EVProducto eVProducto = new EVProducto();
        eVProducto = cVProducto.Obtener_VProducto_O_CodigoProducto(CodigoProducto);
        return eVProducto;
    }
    
    public List<EVProducto> Obtener_VProducto_O_NombreProducto(string NombreProducto)
    {
        CVProducto cVProducto = new CVProducto();
        return cVProducto.Obtener_VProducto_O_NombreProducto(NombreProducto);
    }

    public void Actualizar_VProducto_A(EVProducto eVProducto)
    {
        CVProducto cVProducto = new CVProducto();
        cVProducto.Actualizar_VProducto_A(eVProducto);
    }
    public void Eliminar_VProducto_E(string CodigoProducto)
    {
        CVProducto cRProducto = new CVProducto();
        cRProducto.Eliminar_VProducto_E(CodigoProducto);
    }
    
    #endregion
    #region Tabla : VEmpleado
    public void Insertar_VEmpleado_I(EVEmpleado eVEmpleado)
    {
        CVEmpleado cVEmpleado = new CVEmpleado();
        cVEmpleado.Insertar_VEmpleado_I(eVEmpleado);
    }

    public List<EVEmpleado> Obtener_VEmpleado_O_Todo()
    {
        CVEmpleado cVEmpleado = new CVEmpleado();
        return cVEmpleado.Obtener_VEmpleado_O_Todo();
    }

    public EVEmpleado Obtener_VEmpleado_O_CodigoEmpleado(string CodigoEmpleado)
    {
        CVEmpleado cVEmpleado = new CVEmpleado();
        EVEmpleado eVEmpleado = new EVEmpleado();
        eVEmpleado = cVEmpleado.Obtener_VEmpleado_O_CodigoEmpleado(CodigoEmpleado);
        return eVEmpleado;
    }

    public List<EVEmpleado> Obtener_VEmpleado_O_ApellidoPaternoEmpleado(string ApellidoPaternoEmpleado)
    {
        CVEmpleado cVEmpleado = new CVEmpleado();
        return cVEmpleado.Obtener_VEmpleado_O_ApellidoPaternoEmpleado(ApellidoPaternoEmpleado);
    }

    public void Actualizar_VEmpleado_A(EVEmpleado eVEmpleado)
    {
        CVEmpleado cVEmpleado = new CVEmpleado();
        cVEmpleado.Actualizar_VEmpleado_A(eVEmpleado);
    }

    public void Eliminar_VEmpleado_E(string CodigoEmpleado)
    {
        CVEmpleado cVEmpleado = new CVEmpleado();
        cVEmpleado.Eliminar_VEmpleado_E(CodigoEmpleado);
    }
    #endregion
    #region Tabla : VVenta
    public void Insertar_VVenta_I(EVVenta eVVenta)
    {
        CVVenta cVVenta = new CVVenta();
        cVVenta.Insertar_VVenta_I(eVVenta);
    }
    public List<EVVenta> Obtener_VVenta_O_Todo()
    {
        CVVenta cVVenta = new CVVenta();
        return cVVenta.Obtener_VVenta_O_Todo();
    }
    public EVVenta Obtener_VVenta_O_CodigoVenta(string CodigoVenta)
    {
        CVVenta cVVenta = new CVVenta();
        EVVenta eVVenta = new EVVenta();
        eVVenta = cVVenta.Obtener_VVenta_O_CodigoVenta(CodigoVenta);
        return eVVenta;
    }
    public List<EVVenta> Obtener_VVenta_O_CodigoCliente(string CodigoCliente)
    {
        CVVenta cVVenta = new CVVenta();
        return cVVenta.Obtener_VVenta_O_CodigoCliente(CodigoCliente);
    }

    public List<EVVenta> Obtener_VVenta_O_CodigoEmpleado(string CodigoEmpleado)
    {
        CVVenta cVVenta = new CVVenta();
        return cVVenta.Obtener_VVenta_O_CodigoEmpleado(CodigoEmpleado);
    }

    public List<EVVenta> Obtener_VVenta_O_CodigoProducto(string CodigoProducto)
    {
        CVVenta cVVenta = new CVVenta();
        return cVVenta.Obtener_VVenta_O_CodigoProducto(CodigoProducto);
    }
    public void Eliminar_VVenta_E(string CodigoVenta)
    {
        CVVenta cVVenta = new CVVenta();
        cVVenta.Eliminar_VVenta_E(CodigoVenta);
    }
    #endregion
}
