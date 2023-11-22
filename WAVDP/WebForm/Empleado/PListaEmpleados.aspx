<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PListaEmpleados.aspx.cs" Inherits="WebForm_Empleado_PListaEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <p></p>
        <div>
            <h1>Lista de Empleados</h1>
            <p></p>
            <asp:Button ID="Button1" runat="server" Text="Insertar Empleado" OnClick="btnCrear_Click" CssClass="btn btn-primary" />
            <p></p>
            <div class="form-group">
                <asp:Label runat="server" Text="Buscar por Apellido Paterno: " CssClass="label"></asp:Label>
                <asp:TextBox ID="txbFiltro" runat="server" CssClass="form-control" onkeypress="return Letras(event);" Width="300px"></asp:TextBox>
                <asp:Button CssClass="btn btn-primary" runat="server" ID="btnBuscar" Text="Buscar" onkeypress="return Letras(event);" OnClick="btnBuscar_Click" />
            </div>
            <div class="form-group">
                <asp:Button CssClass="btn btn-primary" runat="server" ID="btnRestaurar" Text="Restaurar la Lista Completa" OnClick="btnRestaurar_Click" />
            </div>
            <p></p>
            <div class="custom-card">
                <div class="card-header">
                    Empleados
                </div>
                <div class="card-body">
                    <asp:GridView ID="gvListaEmpleados" DataKeyNames="CodigoEmpleado" CssClass="table table-bordered table-striped" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="gvListaEmpleados_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="CodigoEmpleado" HeaderText="Código Empleado" Visible="False" />
                            <asp:BoundField DataField="NombreEmpleado" HeaderText="Nombre" />
                            <asp:BoundField DataField="ApellidoPaternoEmpleado" HeaderText="Apellido Paterno" />
                            <asp:BoundField DataField="ApellidoMaternoEmpleado" HeaderText="Apellido Materno" />
                            <asp:ButtonField ButtonType="Button" CommandName="btnEditar" Text="Editar" ControlStyle-CssClass="boton-especifico" ItemStyle-Width="50px" />
                            <asp:ButtonField ButtonType="Button" CommandName="btnEliminar" Text="Eliminar" ControlStyle-CssClass="boton-delete" ItemStyle-Width="60px" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

