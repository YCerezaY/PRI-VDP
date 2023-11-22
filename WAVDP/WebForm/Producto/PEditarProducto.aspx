<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PEditarProducto.aspx.cs" Inherits="WebForm_Productos_PEditarProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1>Formulario de Edición de Producto</h1>

        <div class="form-group">
            <asp:Label runat="server" Text="Nombre: " CssClass="label"></asp:Label>
            <asp:TextBox ID="txbNombre" runat="server" CssClass="form-control" onkeypress="return Letras(event);"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Descripción: " CssClass="label"></asp:Label>
            <asp:TextBox ID="txbDescripcion" runat="server" CssClass="form-control" onkeypress="return LetrasYNumeros(event);"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Precio Unitario: " CssClass="label"></asp:Label>
            <asp:TextBox ID="txbPrecio" runat="server" CssClass="form-control" onkeypress="return Decimales(event);"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Stock: " CssClass="label"></asp:Label>
            <asp:TextBox ID="txbStock" runat="server" CssClass="form-control" onkeypress="return Numeros(event);"></asp:TextBox>
        </div>
        <asp:Button ID="btnGuardar" Text="Guardar" runat="server" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
        <asp:Button ID="btnVolver" Text="Volver" runat="server" OnClick="btnVolver_Click" CssClass="btn btn-secondary" />
    </div>

</asp:Content>
