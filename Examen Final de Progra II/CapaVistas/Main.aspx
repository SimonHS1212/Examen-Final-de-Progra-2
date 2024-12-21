<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Examen_Final_de_Progra_II.CapaVistas.Main" %>
<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="utf-8" />
    <title>Sistema de Gestión de Proyectos</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
            text-align: center;
        }
        header {
            margin-bottom: 30px;
        }
        button {
            font-size: 16px;
            padding: 10px 20px;
            margin: 10px;
            cursor: pointer;
        }
    </style>
</head>
<body>
    <header>
        <h1>Sistema de Gestión de Proyectos</h1>
        <p>Seleccione una opción para administrar los recursos del sistema.</p>
    </header>
    <main>
        <form>
            <button type="button" onclick="location.href='GestionEmpleados.aspx'">Gestión de Empleados</button>
            <button type="button" onclick="location.href='GestionProyectos.aspx'">Gestión de Proyectos</button>
            <button type="button" onclick="location.href='GestionAsignaciones.aspx'">Gestión de Asignaciones</button>
        </form>
    </main>
</body>
</html>
