<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PCrearEmpleado.aspx.cs" Inherits="WebForm_Empleado_PCrearEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <h1>Formulario de Ingreso de Nuevo Empleado</h1>

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
        <asp:Button ID="btnGuardar" Text="Guardar Nuevo Empleado" runat="server" OnClick="btnGuardar_Click" CssClass="btn btn-primary" />
        <asp:Button ID="btnVolver" Text="Volver" runat="server" OnClick="btnVolver_Click" CssClass="btn btn-secondary" />
    </div>
</asp:Content>

