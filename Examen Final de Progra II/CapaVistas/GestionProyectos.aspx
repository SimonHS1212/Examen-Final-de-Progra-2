<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionProyectos.aspx.cs" Inherits="Examen_Final_de_Progra_II.CapaVistas.GestionProyectos" %>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <title>Gestión de Proyectos</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        header {
            text-align: center;
            margin-bottom: 30px;
        }
    </style>
</head>
<body>
    <header>
        <h1>Gestión de Proyectos</h1>
    </header>
    <asp:GridView ID="gvProyectos" runat="server" AutoGenerateColumns="False" DataKeyNames="ProyectoID"
                  OnRowDeleting="gvProyectos_RowDeleting">
        <Columns>
            <asp:BoundField DataField="ProyectoID" HeaderText="ID" />
            <asp:BoundField DataField="Codigo" HeaderText="Código" />
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="FechaInicio" HeaderText="Fecha Inicio" />
            <asp:BoundField DataField="FechaFin" HeaderText="Fecha Fin" />
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
        </Columns>
    </asp:GridView>
    <form id="formAgregar" runat="server">
        <h3>Agregar Proyecto</h3>
        <label for="txtCodigo">Código</label>
        <asp:TextBox ID="txtCodigo" runat="server" />
        <label for="txtNombre">Nombre</label>
        <asp:TextBox ID="txtNombre" runat="server" />
        <label for="txtFechaInicio">Fecha Inicio</label>
        <asp:TextBox ID="txtFechaInicio" runat="server" />
        <label for="txtFechaFin">Fecha Fin</label>
        <asp:TextBox ID="txtFechaFin" runat="server" />
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar Proyecto" OnClick="btnAgregar_Click" />
    </form>
</body>
</html>
