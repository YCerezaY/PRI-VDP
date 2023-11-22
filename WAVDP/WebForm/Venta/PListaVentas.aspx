<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PListaVentas.aspx.cs" Inherits="WebForm_Venta_PListaVentas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <p></p>
        <div>
            <h1>Lista de Ventas</h1>
            <p></p>
            <asp:Button ID="btnCrear" runat="server" Text="Registrar Venta" OnClick="btnCrear_Click" CssClass="btn btn-primary" />
            <p></p>
            <div class="form-group">
                <asp:DropDownList ID="ddlFiltros" runat="server" CssClass="form-control" Width="250px" style="text-align: center;"></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label runat="server" Text="Buscar por la opción Seleccionada: " CssClass="label"></asp:Label>
                <asp:TextBox ID="txbFiltro" runat="server" CssClass="form-control" onkeypress="return Letras(event);" Width="300px"></asp:TextBox>
                <asp:Button CssClass="btn btn-primary" runat="server" ID="btnBuscar" Text="Buscar" onkeypress="return Letras(event);" OnClick="btnBuscar_Click" />
            </div>
            <div class="form-group">
                <asp:Button CssClass="btn btn-primary" runat="server" ID="btnRestaurar" Text="Restaurar la Lista Completa" OnClick="btnRestaurar_Click" />
            </div>
            <p></p>
            <div class="custom-card">
                <div class="card-header">
                    Ventas
                </div>
                <div class="card-body">
                    <asp:GridView ID="gvListaVentas" DataKeyNames="CodigoVenta" CssClass="table table-bordered table-striped" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="gvListaVentas_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="CodigoVenta" HeaderText="CodigoVenta" Visible="False" />
                            <asp:BoundField DataField="CodigoCliente" HeaderText="CodigoCliente" Visible="false" />
                            <asp:BoundField DataField="CodigoEmpleado" HeaderText="CodigoEmpleado" Visible="false" />
                            <asp:BoundField DataField="CodigoProducto" HeaderText="CodigoProducto" Visible="false" />
                            <asp:BoundField DataField="NombreCompletoEmpleado" HeaderText="Empleado" />
                            <asp:BoundField DataField="NombreCompletoCliente" HeaderText="Cliente" />
                            <asp:BoundField DataField="NombreProducto" HeaderText="Producto" />
                            <asp:BoundField DataField="CantidadProductoVenta" HeaderText="Cantidad de Producto" />
                            <asp:BoundField DataField="PrecioTotalVenta" HeaderText="Precio Total" />
                            <asp:BoundField DataField="MetodoPagoVenta" HeaderText="Metodo de Pago" />
                            <asp:BoundField DataField="TipoEntregaVenta" HeaderText="Tipo de Entrega" />
                            <asp:BoundField DataField="FechaRegistro" HeaderText="Fecha de Emision" />
                            <asp:ButtonField ButtonType="Button" CommandName="btnEliminar" Text="Eliminar" ControlStyle-CssClass="boton-delete" ItemStyle-Width="60px" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

