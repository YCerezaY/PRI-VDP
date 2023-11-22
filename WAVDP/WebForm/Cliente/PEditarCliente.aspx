<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PEditarCliente.aspx.cs" Inherits="WebForm_Cliente_PEditarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <h1>Formulario de Edición del Cliente</h1>

        <div class="form-group">
            <asp:Label runat="server" Text="Nombre: " CssClass="label"></asp:Label>
            <asp:TextBox ID="txbNombre" runat="server" CssClass="form-control" onkeypress="return Letras(event);"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Apellido Paterno: " CssClass="label"></asp:Label>
            <asp:TextBox ID="txbApellidoPaterno" runat="server" CssClass="form-control" onkeypress="return Letras(event);"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Apellido Materno: " CssClass="label"></asp:Label>
            <asp:TextBox ID="txbApellidoMaterno" runat="server" CssClass="form-control" onkeypress="return Letras(event);"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Dirección: " CssClass="label"></asp:Label>
            <asp:TextBox ID="txbDireccion" runat="server" CssClass="form-control" onkeypress="return LetrasYNumeros(event);"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label runat="server" Text="Teléfono: " CssClass="label"></asp:Label>
            <asp:TextBox ID="txbTelefono" runat="server" CssClass="form-control" onkeypress="return Numeros(event);"></asp:TextBox>
        </div>
        <asp:Button ID="btnGuardar" Text="Guardar" runat="server" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
        <asp:Button ID="btnVolver" Text="Volver" runat="server" OnClick="btnVolver_Click" CssClass="btn btn-secondary" />
    </div>

</asp:Content>

