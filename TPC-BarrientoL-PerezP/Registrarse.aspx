<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Registrarse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
    <div class="mb-3">
  
     <asp:Label ID="lblDni" runat="server" Text="Dni" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBDni" runat="server"  Cssclass="form-control" placeholder="Dni"></asp:TextBox>
    </div>
    
    <div class="mb-3">
    <asp:Label ID="lblNombre" runat="server" Text="Nombre" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBNombre" runat="server"  Cssclass="form-control" placeholder="Nombre"></asp:TextBox>
    </div>

    <div class="mb-3">
    <asp:Label ID="lblApellido" runat="server" Text="Apellido" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBApellido" runat="server"  Cssclass="form-control" placeholder="Apellido"></asp:TextBox>
    </div>

    <div class="mb-3">
    <asp:Label ID="lblNacimiento" runat="server" Text="Nacimiento" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBNacimiento" runat="server"  Cssclass="form-control" placeholder="aaaa-mm-dd"></asp:TextBox>
    </div>

    <div class="mb-3">
    <asp:Label ID="lblEmail" runat="server" Text="Email" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBMail" runat="server"  Cssclass="form-control" placeholder="nombre@ejemplo.com"></asp:TextBox>
    </div>

    <div class="mb-3">
    <asp:Label ID="lblNombreUsuario" runat="server" Text="NombreUsuario" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBNombreUsuario" runat="server"  Cssclass="form-control" placeholder="Nombre de Usuario"></asp:TextBox>
    </div>

    <div class="mb-3">
    <asp:Label ID="lblContraseña" runat="server" Text="Contraseña" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBContraseña" runat="server"  Cssclass="form-control" placeholder="Contraseña"></asp:TextBox>
    </div>

    <div class="mb-3">
    <asp:Label ID="lblTelefono" runat="server" Text="Telefono" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBTelefono" runat="server"  Cssclass="form-control" placeholder="1122223333"></asp:TextBox>
    </div>

    <div class="mb-3">
    <asp:Label ID="lblAdmin" runat="server" Text="Si queres registrarte como administrador, Introduzca la password de admin" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBAdmin" runat="server"  Cssclass="form-control" placeholder=""></asp:TextBox>
    </div>
    
    <div class="mb-3">
    <asp:Label ID="lblcheckclick" runat="server" Text="Si queres registrarte como administrador, Introduzca la password de admin" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBClick" runat="server"  Cssclass="form-control" placeholder=""></asp:TextBox>
    </div>

    <div class="mb-3">
        <asp:Button Text="Agregar" runat="server" OnClick="BtnAgregar_Click" ID="BtnAgregar" Cssclass="btn btn-outline-success"  />
    </div>

</asp:Content>
