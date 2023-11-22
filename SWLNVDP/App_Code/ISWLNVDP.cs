using SWADNETVDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface ISWLNVDP
{
    #region Tabla : VProducto
    [OperationContract]
    void Insertar_VProducto_I(string CodigoProducto, string NombreProducto, string DescripcionProducto, decimal PrecioUnitarioProducto, int StockProducto);
    [OperationContract]
    List<EVProducto> Obtener_VProducto_O_Todo();
    [OperationContract]
    EVProducto Obtener_VProducto_O_CodigoProducto(string CodigoProducto);
    [OperationContract]
    List<EVProducto> Obtener_VProducto_O_NombreProducto(string NombreProducto);
    [OperationContract]
    void Actualizar_VProducto_A(string CodigoProducto, string NombreProducto, string DescripcionProducto, decimal PrecioUnitarioProducto, int StockProducto);
    [OperationContract]
    void Eliminar_VProducto_E(string CodigoProducto);
    #endregion
    #region Tabla : VCliente
    [OperationContract]
    void Insertar_VCliente_I(string CodigoCliente, string NombreCliente, string ApellidoPaternoCliente, string ApellidoMaternoCliente, string DireccionCliente, int TelefonoCliente);
    [OperationContract]
    List<EVCliente> Obtener_VCliente_O_Todo();
    [OperationContract]
    EVCliente Obtener_VCliente_O_CodigoCliente(string CodigoCliente);
    [OperationContract]
    List<EVCliente> Obtener_VCliente_O_ApellidoPaternoCliente(string ApellidoPaternoCliente);
    [OperationContract]
    void Actualizar_VCliente_A(string CodigoCliente, string NombreCliente, string ApellidoPaternoCliente, string ApellidoMaternoCliente, string DireccionCliente, int TelefonoCliente);
    #endregion
    #region Tabla : VEmpleado
    [OperationContract]
    void Insertar_VEmpleado_I(string CodigoEmpleado, string NombreEmpleado, string ApellidoPaternoEmpleado, string ApellidoMaternoEmpleado);
    [OperationContract]
    List<EVEmpleado> Obtener_VEmpleado_O_Todo();
    [OperationContract]
    EVEmpleado Obtener_VEmpleado_O_CodigoEmpleado(string CodigoEmpleado);
    [OperationContract]
    List<EVEmpleado> Obtener_VEmpleado_O_ApellidoPaternoEmpleado(string ApellidoPaternoEmpleado);
    [OperationContract]
    void Actualizar_VEmpleado_A(string CodigoEmpleado, string NombreEmpleado, string ApellidoPaternoEmpleado, string ApellidoMaternoEmpleado);
    [OperationContract]
    void Eliminar_VEmpleado_E(string CodigoEmpleado);
    #endregion
    #region Tabla : VVenta
    [OperationContract]
    void Insertar_VVenta_I(string CodigoVenta, string MetodoPagoVenta, string TipoEntregaVenta, int CantidadProductoVenta, decimal PrecioTotalVenta, string CodigoCliente, string CodigoProducto, string CodigoEmpleado);
    [OperationContract]
    List<EVVenta> Obtener_VVenta_O_Todo();
    [OperationContract]
    EVVenta Obtener_VVenta_O_CodigoVenta(string CodigoVenta);
    [OperationContract]
    void Eliminar_VVenta_E(string CodigoVenta);
    #endregion
    //Compleja
    #region VVentaCompleja
    [OperationContract]
    List<EVVentaCompleja> Obtener_VVenta_O_Compleja();
    [OperationContract]
    List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoCliente(string CodigoCliente);
    [OperationContract]
    List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoEmpleado(string CodigoEmpleado);
    [OperationContract]
    List<EVVentaCompleja> Obtener_VVenta_O_Compleja_CodigoProducto(string CodigoProducto);
    #endregion
}
