<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PListaProductos.aspx.cs" Inherits="WebForm_Productos_ListaProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <p></p>
        <h1>Lista de Productos</h1>
        <p></p>
        <asp:Button ID="btnCrear" runat="server" Text="Insertar Producto" OnClick="btnCrear_Click" CssClass="btn btn-primary" />
        <p></p>
        <div class="form-group">
            <asp:Label runat="server" Text="Buscar por Nombre de Producto: " CssClass="label"></asp:Label>
            <asp:TextBox ID="txbFiltro" runat="server" CssClass="form-control" onkeypress="return Letras(event);" Width="300px"></asp:TextBox>
            <asp:Button CssClass="btn btn-primary" runat="server" ID="btnBuscar" Text="Buscar" onkeypress="return Letras(event);" OnClick="btnBuscar_Click" />
        </div>
        <div class="form-group">
            <asp:Button CssClass="btn btn-primary" runat="server" ID="btnRestaurar" Text="Restaurar la Lista Completa" OnClick="btnRestaurar_Click" />
        </div>
        <p></p>
        <div class="custom-card">
            <div class="card-header">
                Productos
            </div>
            <div class="card-body">
                <asp:GridView ID="gvListaProductos" DataKeyNames="CodigoProducto" CssClass="table table-bordered table-striped" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="gvListaProductos_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="CodigoProducto" HeaderText="Código Producto" Visible="False" />
                        <asp:BoundField DataField="NombreProducto" HeaderText="Nombre" />
                        <asp:BoundField DataField="DescripcionProducto" HeaderText="Descripción" />
                        <asp:BoundField DataField="PrecioUnitarioProducto" HeaderText="Precio Unitario" />
                        <asp:BoundField DataField="StockProducto" HeaderText="Stock" />
                        <asp:ButtonField ButtonType="Button" CommandName="btnEditar" Text="Editar" ControlStyle-CssClass="boton-especifico" ItemStyle-Width="50px" />
                        <asp:ButtonField ButtonType="Button" CommandName="btnEliminar" Text="Eliminar" ControlStyle-CssClass="boton-delete" ItemStyle-Width="60px" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>

