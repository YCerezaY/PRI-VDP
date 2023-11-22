<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PListaClientes.aspx.cs" Inherits="WebForm_Cliente_PListaClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <p></p>
        <h1>Lista de Clientes</h1>
        <p></p>
        <asp:Button ID="btnCrear" runat="server" Text="Insertar Cliente" OnClick="btnCrear_Click" CssClass="btn btn-primary" />
        <p></p>
        <div class="form-group">
            <asp:Label runat="server" Text="Buscar por Apellido Paterno: " CssClass="label"></asp:Label>
            <asp:TextBox ID="txbFiltro" runat="server" CssClass="form-control" onkeypress="return Letras(event);" Width="300px"></asp:TextBox>
            <asp:Button CssClass="btn btn-primary" runat="server" ID="btnBuscar" Text="Buscar" onkeypress="return Letras(event);" OnClick="btnBuscar_Click"/>
        </div>
        <div class="form-group">
             <asp:Button CssClass="btn btn-primary" runat="server" ID="btnRestaurar" Text="Restaurar la Lista Completa" OnClick="btnRestaurar_Click"/>
        </div>
         <p></p>
        <div class="custom-card">
            <div class="card-header">
                Clientes
            </div>
            <div class="card-body">
                <asp:GridView ID="gvListaClientes" DataKeyNames="CodigoCliente" CssClass="table table-bordered table-striped" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="gvListaClientes_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="CodigoCliente" HeaderText="Código Cliente" Visible="False" />
                        <asp:BoundField DataField="NombreCliente" HeaderText="Nombre" />
                        <asp:BoundField DataField="ApellidoPaternoCliente" HeaderText="Apellido Paterno" />
                        <asp:BoundField DataField="ApellidoMaternoCliente" HeaderText="Apellido Materno" />
                        <asp:BoundField DataField="DireccionCliente" HeaderText="Dirección" />
                        <asp:BoundField DataField="TelefonoCliente" HeaderText="Teléfono" />
                        <asp:ButtonField ButtonType="Button" CommandName="btnEditar" Text="Editar" ControlStyle-CssClass="boton-especifico" ItemStyle-Width="50px" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>

