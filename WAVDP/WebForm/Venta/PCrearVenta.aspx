<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PCrearVenta.aspx.cs" Inherits="WebForm_Venta_PCrearVenta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <h1>Formulario de Ingreso de Nueva Venta</h1>

        <div class="form-group">
            <asp:Label runat="server" Text="Cliente:" CssClass="label"></asp:Label>
            <asp:DropDownList ID="ddlCliente" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Producto:" CssClass="label"></asp:Label>
            <asp:DropDownList ID="ddlProducto" runat="server" CssClass="form-control" OnSelectedIndexChanged="ddlProducto_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Stock del Producto Selecciondo:" CssClass="label"></asp:Label>
            <asp:TextBox ID="txbStock" runat="server" CssClass="form-control" onkeypress="return Numeros(event);" ReadOnly="true" Enabled="false"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Cantidad de Productos:" CssClass="label"></asp:Label>
            <asp:TextBox ID="txbCantidadProducto" runat="server" CssClass="form-control" onkeypress="return Numeros(event);"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Empleado:" CssClass="label"></asp:Label>
            <asp:DropDownList ID="ddlEmpleado" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Método de Pago:" CssClass="label"></asp:Label>
            <asp:DropDownList ID="ddlMetodoPago" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Tipo de Entrega:" CssClass="label"></asp:Label>
            <asp:DropDownList ID="ddlTipoEntrega" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="form-group">
            <asp:Button ID="btnGuardar" Text="Guardar Nueva Venta" runat="server" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
            <asp:Button ID="btnVolver" Text="Volver" runat="server" OnClick="btnVolver_Click" CssClass="btn btn-secondary" />
        </div>
    </div>
</asp:Content>

