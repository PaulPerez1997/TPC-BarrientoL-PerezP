<%@ Page Title="IniciarSesion" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Cuenta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="mb-3">
  <%--  <label for="exampleInputEmail1" class="form-label">Email address</label>
    <input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">--%>

      <asp:Label Text="Nombre de Usuario" ID="lblMail" runat="server" Cssclass="form-label"/>
      <asp:TextBox runat="server" ID="TBUser" type="email" Cssclass="form-control"/>
    
         </div>
        

  <div class="mb-3">
   <%-- <label for="exampleInputPassword1" class="form-label">Password</label>
    <input type="password" class="form-control" id="exampleInputPassword1">--%>

      <asp:Label Text="Contraseña" ID="lblContraseña" runat="server" Cssclass="form-label"/>
      <asp:TextBox runat="server" ID="TBContraseña" type="password" Cssclass="form-control"/>
  </div>


  
    <asp:Button Text="Ingresar" ID="BtnIngresar" runat="server" Cssclass="btn btn-primary" OnClick="BtnIngresar_Click"/>

     <div class="mb-3">
  
      <asp:Label Text="" ID="Welcome" runat="server" Cssclass="form-label"/>
    
  </div>

</asp:Content>
