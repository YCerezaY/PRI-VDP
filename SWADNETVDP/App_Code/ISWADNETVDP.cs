using System;
using System.Collections.Generic;
//using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWADNETVDP
{
    #region Tabla : VCliente
    [OperationContract]
    void Insertar_VCliente_I(EVCliente eVCliente);
    [OperationContract]
    List<EVCliente> Obtener_VCliente_O_Todo();
    [OperationContract]
    EVCliente Obtener_VCliente_O_CodigoCliente(string CodigoCliente);
    [OperationContract]
    List<EVCliente> Obtener_VCliente_O_ApellidoPaternoCliente(string ApellidoPaternoCliente);

    [OperationContract]
    void Actualizar_VCliente_A(EVCliente eVCliente);
    #endregion
    #region Tabla : VProducto
    [OperationContract]
    void Insertar_VProducto_I(EVProducto eVProducto);
    [OperationContract]
    List<EVProducto> Obtener_VProducto_O_Todo();
    [OperationContract]
    EVProducto Obtener_VProducto_O_CodigoProducto(string CodigoProducto);
    [OperationContract]
    List<EVProducto> Obtener_VProducto_O_NombreProducto(string NombreProducto);
    [OperationContract]
    void Actualizar_VProducto_A(EVProducto eVProducto);
    [OperationContract]
    void Eliminar_VProducto_E(string CodigoProducto);
    #endregion
    #region Tabla : VEmpleado
    [OperationContract]
    void Insertar_VEmpleado_I(EVEmpleado eVEmpleado);
    [OperationContract]
    List<EVEmpleado> Obtener_VEmpleado_O_Todo();
    [OperationContract]
    EVEmpleado Obtener_VEmpleado_O_CodigoEmpleado(string CodigoEmpleado);
    [OperationContract]
    List<EVEmpleado> Obtener_VEmpleado_O_ApellidoPaternoEmpleado(string ApellidoPaternoEmpleado);

    [OperationContract]
    void Actualizar_VEmpleado_A(EVEmpleado eVEmpleado);
    [OperationContract]
    void Eliminar_VEmpleado_E(string CodigoEmpleado);
    #endregion
    #region Tabla : VVenta
    [OperationContract]
    void Insertar_VVenta_I(EVVenta eVVenta);
    [OperationContract]
    List<EVVenta> Obtener_VVenta_O_Todo();
    [OperationContract]
    EVVenta Obtener_VVenta_O_CodigoVenta(string CodigoVenta);
    [OperationContract]
    List<EVVenta> Obtener_VVenta_O_CodigoCliente(string CodigoCliente);
    [OperationContract]
    List<EVVenta> Obtener_VVenta_O_CodigoEmpleado(string CodigoEmpleado);
    [OperationContract]
    List<EVVenta> Obtener_VVenta_O_CodigoProducto(string CodigoProducto);
    [OperationContract]
    void Eliminar_VVenta_E(string CodigoVenta);
    #endregion
}


