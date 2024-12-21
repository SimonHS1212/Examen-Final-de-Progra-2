<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionAsignaciones.aspx.cs" Inherits="Examen_Final_de_Progra_II.CapaVistas.GestionAsignaciones" %>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <title>Gestión de Asignaciones</title>
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
        <h1>Gestión de Asignaciones</h1>
    </header>
    <asp:GridView ID="gvAsignaciones" runat="server" AutoGenerateColumns="False" DataKeyNames="AsignacionID"
                  OnRowDeleting="gvAsignaciones_RowDeleting">
        <Columns>
            <asp:BoundField DataField="AsignacionID" HeaderText="ID" />
            <asp:BoundField DataField="NombreEmpleado" HeaderText="Empleado" />
            <asp:BoundField DataField="NombreProyecto" HeaderText="Proyecto" />
            <asp:BoundField DataField="FechaAsignacion" HeaderText="Fecha Asignación" />
            <asp:CommandField ShowDeleteButton="True" ButtonType="Button" />
        </Columns>
    </asp:GridView>
    <form id="formAgregar" runat="server">
        <h3>Asignar Empleado a Proyecto</h3>
        <label for="ddlEmpleado">Empleado</label>
        <asp:DropDownList ID="ddlEmpleado" runat="server"></asp:DropDownList>
        <label for="ddlProyecto">Proyecto</label>
        <asp:DropDownList ID="ddlProyecto" runat="server"></asp:DropDownList>
        <asp:Button ID="btnAgregar" runat="server" Text="Asignar" OnClick="btnAgregar_Click" />
    </form>
</body>
</html>
