<%@ Page Title="Registrarse" Language="C#" MasterPageFile="~/MasterPeassy.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="TPC_BarrientoL_PerezP.Registrarse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
    <%-- <script>
        function validar() {
            var dni = document.getElementById("<%=TBDni.ClientID %>").val();
            var nombre = document.getElementById("<%=TBNombre.ClientID %>").value;
            var apellido = document.getElementById("<%=TBApellido.ClientID %>").value; 
            var nacimiento = document.getElementById("<%=TBNacimiento.ClientID %>").value; 
            var email = document.getElementById("<%=TBMail.ClientID %>").value; 
            var nombreusuario = document.getElementById("<%=TBNombreUsuario.ClientID %>").value; 
            var contraseña = document.getElementById("<%=TBContraseña.ClientID %>").value; 
            var telefono = document.getElementById("<%=TBTelefono.ClientID %>").value; 
            var valido = true;
            if (dni === "") {
                $("#<%=TBDni.ClientID%>").removeClass("is-valid");
                $("#<%=TBDni.ClientID%>").addClass("is-invalid");
                valido = false;
            } 
            else {
                $("#<%=TBDni.ClientID%>").removeClass("is-invalid");
                $("#<%=TBDni.ClientID%>").addClass("is-valid");
            }
            if (nombre === "") {
                $("#<% = TBNombre.ClientID %>").removeClass("is-valid");
                $("#<% = TBNombre.ClientID %>").addClass("is-invalid");
                valido = false;
            }
            else {
                $("#<% = TBNombre.ClientID %>").removeClass("is-invalid");
                $("#<% = TBNombre.ClientID %>").addClass("is-valid");
            }
            if (apellido === "") {
                $("#<%=TBApellido.ClientID%>").removeClass("is-valid");
                $("#<%=TBApellido.ClientID%>").addClass("is-invalid");
                valido = false;
            }
            else {
                $("<%=TBApellido.ClientID%>").removeClass("is-invalid");
                $("<%=TBApellido.ClientID%>").addClass("is-valid");
            }
            if (nacimiento === "") {
                $("<%=TBNacimiento.ClientID%>").removeClass("is-valid");
                $("<%=TBNacimiento.ClientID%>").addClass("is-invalid");
                valido = false;
            }
            else {
                $("<%=TBNacimiento.ClientID%>").removeClass("is-invalid");
                $("<%=TBNacimiento.ClientID%>").addClass("is-valid");
            }
            if (email === "") {
                $("<%=TBMail.ClientID%>").removeClass("is-valid");
                $("<%=TBMail.ClientID%>").addClass("is-invalid");
                valido = false;
            }
            else {
                $("<%=TBMail.ClientID%>").removeClass("is-invalid");
                $("<%=TBMail.ClientID%>").addClass("is-valid");
            }
            if (nombreusuario === "") {
                $("<%=TBNombreUsuario.ClientID%>").removeClass("is-valid");
                $("<%=TBNombreUsuario.ClientID%>").addClass("is-invalid");
                valido = false;
            }
            else {
                $("<%=TBNombreUsuario.ClientID%>").removeClass("is-invalid");
                $("<%=TBNombreUsuario.ClientID%>").addClass("is-valid");
            }
            if (contraseña === "") {
                $("<%=TBContraseña.ClientID%>").removeClass("is-valid");
                $("<%=TBContraseña.ClientID%>").addClass("is-invalid");
                valido = false;
            }
            else {
                $("<%=TBContraseña.ClientID%>").removeClass("is-invalid");
                $("<%=TBContraseña.ClientID%>").addClass("is-valid");
            }
            if (telefono === "") {
                $("<%=TBTelefono.ClientID%>").removeClass("is-valid");
                $("<%=TBTelefono.ClientID%>").addClass("is-invalid");
                valido = false;
            }
            else {
                $("<%=TBTelefono.ClientID%>").removeClass("is-invalid");
                $("<%=TBTelefono.ClientID%>").addClass("is-valid");
            }
            if (!valido) {
                return valido;
            }
            return true;
        }
     </script>--%>

 <div class="container" style="margin:10px;">   
     <div class="row" style="margin:10px;">
       <div class="col-2"></div> 
        <div class="col-4">
            <asp:Label ID="Label1" runat="server" Text="Dni" Cssclass="form-label" ></asp:Label>
             <asp:TextBox ID="TBDni" runat="server"  Cssclass="form-control" placeholder="Dni"></asp:TextBox> 
        </div>
         </div>
   
    <div class="row" style="margin:10px;">
       <div class="col-2"></div> 
    <div class="col-4">
    <asp:Label ID="lblNombre" runat="server" Text="Nombre" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBNombre" runat="server"  Cssclass="form-control" placeholder="Nombre"></asp:TextBox>
    </div>
        </div>

    <div class="row" style="margin:10px;">
       <div class="col-2"></div> 
    <div class="col-4">
    <asp:Label ID="lblApellido" runat="server" Text="Apellido" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBApellido" runat="server"  Cssclass="form-control" placeholder="Apellido"></asp:TextBox>
    </div>
        </div>

    <div class="row" style="margin:10px;">
       <div class="col-2"></div> 
    <div class="col-4">
    <asp:Label ID="lblNacimiento" runat="server" Text="Nacimiento" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBNacimiento" runat="server"  Cssclass="form-control" placeholder="aaaa-mm-dd"></asp:TextBox>
    </div>
        </div>

    <div class="row" style="margin:10px;">
       <div class="col-2"></div> 
    <div class="col-4">
    <asp:Label ID="lblEmail" runat="server" Text="Email" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBMail" runat="server"  Cssclass="form-control" placeholder="nombre@ejemplo.com"></asp:TextBox>
    </div>
        </div>

     <div class="row" style="margin:10px;">
       <div class="col-2"></div> 
    <div class="col-4">
    <asp:Label ID="lblNombreUsuario" runat="server" Text="NombreUsuario" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBNombreUsuario" runat="server"  Cssclass="form-control" placeholder="Nombre de Usuario"></asp:TextBox>
    </div>
         </div>

     <div class="row" style="margin:10px;">
       <div class="col-2"></div> 
    <div class="col-4">
    <asp:Label ID="lblContraseña" runat="server" Text="Contraseña" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBContraseña" runat="server"  Cssclass="form-control" placeholder="Contraseña"></asp:TextBox>
    </div>
         </div>

     <div class="row" style="margin:10px;">
       <div class="col-2"></div> 
    <div class="col-4">
    <asp:Label ID="lblTelefono" runat="server" Text="Telefono" Cssclass="form-label" ></asp:Label>
     <asp:TextBox ID="TBTelefono" runat="server"  Cssclass="form-control" placeholder="1122223333"></asp:TextBox>
    </div>
         </div>

  

     <div class="row" style="margin:10px;">
       <div class="col-3"></div> 
    <div class="col-4">
        <asp:Button Text="Agregar" runat="server" OnClick="BtnAgregar_Click" ID="BtnAgregar" Cssclass="btn btn-outline-success"  />
    </div>
         </div>

 </div>

</asp:Content>
