<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionEmpleados.aspx.cs" Inherits="Examen_Final_de_Progra_II.CapaVistas.GestionEmpleados" %>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <title>Gestión de Empleados</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        header {
            text-align: center;
            margin-bottom: 30px;
        }
        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }
        th, td {
            border: 1px solid #ddd;
            padding: 10px;
            text-align: left;
        }
        th {
            background-color: #f4f4f4;
        }
    </style>
</head>
<body>
    <header>
        <h1>Gestión de Empleados</h1>
    </header>
    <asp:GridView ID="gvEmpleados" runat="server" AutoGenerateColumns="False" DataKeyNames="EmpleadoID"
                  OnRowDeleting="gvEmpleados_RowDeleting">
        <Columns>
            <asp:BoundField DataField="EmpleadoID" HeaderText="ID" />
            <asp:BoundField DataField="NumeroCarnet" HeaderText="Número Carnet" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha Nacimiento" />
            <asp:BoundField DataField="CategoriaNombre" HeaderText="Categoría" />
            <asp:BoundField DataField="Salario" HeaderText="Salario" />
            <asp:BoundField DataField="Direccion" HeaderText="Dirección" />
            <asp:BoundField DataField="Telefono" HeaderText="Teléfono" />
            <asp:BoundField DataField="Correo" HeaderText="Correo" />
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
        </Columns>
    </asp:GridView>
    <form id="formAgregar" runat="server">
        <h3>Agregar Empleado</h3>
        <label for="txtNumeroCarnet">Número Carnet</label>
        <asp:TextBox ID="txtNumeroCarnet" runat="server" />
        <label for="txtNombre">Nombre</label>
        <asp:TextBox ID="txtNombre" runat="server" />
        <label for="txtFechaNacimiento">Fecha Nacimiento</label>
        <asp:TextBox ID="txtFechaNacimiento" runat="server" />
        <label for="ddlCategoria">Categoría</label>
        <asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>
        <label for="txtSalario">Salario</label>
        <asp:TextBox ID="txtSalario" runat="server" />
        <label for="txtDireccion">Dirección</label>
        <asp:TextBox ID="txtDireccion" runat="server" />
        <label for="txtTelefono">Teléfono</label>
        <asp:TextBox ID="txtTelefono" runat="server" />
        <label for="txtCorreo">Correo</label>
        <asp:TextBox ID="txtCorreo" runat="server" />
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar Empleado" OnClick="btnAgregar_Click" />
    </form>
</body>
</html>
