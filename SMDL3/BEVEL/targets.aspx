<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="targets.aspx.cs" Inherits="SMDL3.BEVEL.targets" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script language=Javascript>
          <!--
        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : event.keyCode
            if (charCode > 31 && (charCode < 46 || charCode > 57 || charCode == 47 ))
                return false;

            return true;
        }
          //-->
    </script>
    
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    <title>Definición de Targets</title>

    <link href="../css/bootstrap.min.css" rel="stylesheet">
    <link href="../font-awesome/css/font-awesome.css" rel="stylesheet">

    <link href="../css/plugins/dataTables/datatables.min.css" rel="stylesheet">

    <link href="../css/animate.css" rel="stylesheet">
    <link href="../css/style.css" rel="stylesheet">

</head>
<body>
    <div id="wrapper">
        <nav class="navbar-default navbar-static-side" role="navigation">
        <div class="sidebar-collapse">
            <ul class="nav metismenu" id="side-menu">
                <li class="nav-header">
                <div class="dropdown profile-element">
                    <img alt="image" src="../img/bat.png"/>
                </div>
                <div class="logo-element">
                    FTEM
                </div>
                </li>
                <li>
                    <a href="..\GDXL\index.aspx"><i class="fa fa-industry"></i> <span class="nav-label">GD XL</span> <span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level collapse">
                         <li><a href="..\GDXL\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\GDXL\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\GDXL\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\GDXL\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\GDXL\targets.aspx"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>
                <li>
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">GD</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level collapse">
                         <li><a href="..\GD\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\GD\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\GD\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\GD\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\GD\targets.aspx"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>
                <li>
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">FOCKE</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level collapse">
                         <li><a href="..\FOCKE\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\FOCKE\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\FOCKE\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\FOCKE\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\FOCKE\targets.aspx"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>
                <li class="active">
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">BEVEL</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level">
                         <li><a href="..\BEVEL\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\BEVEL\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\BEVEL\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\BEVEL\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li class="active"><a href="..\BEVEL\targets.aspx"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>
                <li>
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">SLIDE & SHELL</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level collapse">
                         <li><a href="..\SLIDESHELL\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\SLIDESHELL\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\SLIDESHELL\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\SLIDESHELL\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\SLIDESHELL\targets.aspx"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>
                <li>
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">SIDE PACK</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level collapse">
                         <li><a href="..\SIDEPACK\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\SIDEPACK\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\SIDEPACK\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\SIDEPACK\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\SIDEPACK\targets.aspx"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>
            </ul>
        </div>
        </nav>

        <div id="page-wrapper" class="gray-bg dashbard-1">
            <div class="wrapper wrapper-content ">
                <div class="row">
                    <div class="col-md-12">
                        <form id="form1" runat="server">
                            <div class="ibox ">
                                <div class="ibox-title">
                                    <div class="float-right">
                                        <asp:Button ID="btnGuardar" class="btn-success" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
                                    </div> 
                                    <h2>Dashboard BEVEL [L3] - Definición de Targets</h2>
                                </div>
                                    <div class="row">
                                        <div class="col-lg-4">
                                        <div class="ibox ">
                                            <div class="ibox-title">
                                                        <h5>INTENSITY BEVEL [L3]</h5>
                                            </div>
                                            <div class="ibox-content">
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="220px" ID="Label1" runat="server" Text="BEVEL KWH [KWh/MCE]" Height="35px"></asp:Label>
                                                                <asp:TextBox Width="70" ID="txt369" runat="server"  onkeypress="return isNumberKey(event)" type="text"  Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="220" ID="Label2" runat="server" Text="BEVEL A.C. [Nm3/MCE]" Height="35px">   </asp:Label>
                                                                <asp:TextBox Width="70" ID="txt370" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="220" ID="Label3" runat="server" Text="BEVEL Vacío [Nm3/MCE]" Height="35px">   </asp:Label>
                                                                <asp:TextBox Width="70" ID="txt371" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                            </div>
                                        </div>
                                        </div>
                                        </div>
                                        <div class="row">
                                        <div class="col-lg-3">
                                        <form>
                                            <div class="ibox ">
                                                <div class="ibox-title">
                                                        <h5>SD24</h5>
                                                </div>
                                                <div class="ibox-content">
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160" ID="Label5" runat="server" Text="KWH [KWh/MCE]" Height="35px"></asp:Label>
                                                                <asp:TextBox Width="60" ID="txt373" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160" ID="Label6" runat="server" Text="Aire Com. [Nm3/MCE]" Height="35px">   </asp:Label>
                                                                <asp:TextBox Width="60" ID="txt374" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160" ID="Label7" runat="server" Text="Vacío [Nm3/MCE]" Height="35px"></asp:Label>
                                                                <asp:TextBox Width="60" ID="txt375" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                </div>
                                            </div>
                                        </form>
                                        </div>
                                        <div class="col-lg-3">
                                               <div class="ibox "> 
                                                    <div class="ibox-title">
                                                        <h5>SD26</h5>
                                                    </div>
                                                    <div class="ibox-content">
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160px" ID="Label46" runat="server" Text="[KWH/MCE]"  Height="35px"></asp:Label>
                                                                <asp:TextBox Width="60px" ID="txt377" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160px" ID="Label47" runat="server" Text="Aire Comp. [Nm3/MCE]" Height="35px" >   </asp:Label>
                                                                <asp:TextBox Width="60px" ID="txt378" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160px" ID="Label38" runat="server" Text="Vacío [Nm3/MCE]"  Height="35px"></asp:Label>
                                                                <asp:TextBox Width="60px" ID="txt379" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                    </div>
                                                </div>
                                         

                                        </div>
                                        <div class="col-lg-3">
                                               <div class="ibox "> 
                                                    <div class="ibox-title">
                                                        <h5>SD27</h5>
                                                    </div>
                                                    <div class="ibox-content">
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160px" ID="Label4" runat="server" Text="KWH [KWh/MCE]"  Height="35px"></asp:Label>
                                                                <asp:TextBox Width="60px" ID="txt381" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160px" ID="Label8" runat="server" Text="Aire Comp. [Nm3/MCE]" Height="35px" >   </asp:Label>
                                                                <asp:TextBox Width="60px" ID="txt382" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160px" ID="Label9" runat="server" Text="Vacío [Nm3/MCE]"  Height="35px"></asp:Label>
                                                                <asp:TextBox Width="60px" ID="txt383" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                    </div>
                                               </div>
                                        </div>
                                        <div class="col-lg-3">
                                               <div class="ibox "> 
                                                    <div class="ibox-title">
                                                        <h5>SD42</h5>
                                                    </div>
                                                    <div class="ibox-content">
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160px" ID="Label10" runat="server" Text="KWH [KWh/MCE]"  Height="35px"></asp:Label>
                                                                <asp:TextBox Width="60px" ID="txt385" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160px" ID="Label11" runat="server" Text="Aire Comp. [Nm3/MCE]" Height="35px" >   </asp:Label>
                                                                <asp:TextBox Width="60px" ID="txt386" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                            <div class="row" style="padding-left:10px">
                                                                <asp:Label Width="160px" ID="Label12" runat="server" Text="Vacío [Nm3/MCE]"  Height="35px"></asp:Label>
                                                                <asp:TextBox Width="60px" ID="txt387" runat="server" onkeypress="return isNumberKey(event)" type="text" Height="25px" style="text-align: right"></asp:TextBox>
                                                            </div>
                                                    </div>
                                               </div>
                                        </div>
                                        </div>
                                    </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Mainly scripts -->
    <script src="../js/jquery-3.1.1.min.js"></script>
    <script src="../js/popper.min.js"></script>
    <script src="../js/bootstrap.js"></script>
    --<script src="../js/plugins/metisMenu/jquery.metisMenu.js"></script>
    <script src="../js/plugins/slimscroll/jquery.slimscroll.min.js"></script>

    <!-- Custom and plugin javascript -->
    <script src="../js/inspinia.js"></script>

    <script src="../js/plugins/dataTables/datatables.min.js"></script>
    <script src="../js/plugins/dataTables/dataTables.bootstrap4.min.js"></script>

</body>
</html>
