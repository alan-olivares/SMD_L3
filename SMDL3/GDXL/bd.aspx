<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bd.aspx.cs" Inherits="Datos.bd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>--%>


<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="bd.aspx.cs" Inherits="SMDL3.GDXL.bd" %>
<!DOCTYPE html>

<html>
<head runat="server">

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    <title>Base de Datos</title>

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
                <li><a href="index.html"><i class="fa fa-table"></i> <span class="nav-label">Graficas</span></a></li>
                <li class="active">
                    <a href="..\GDXL\index.aspx"><i class="fa fa-industry"></i> <span class="nav-label">GD XL</span> <span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level">
                         <li><a href="..\GDXL\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li class="active"><a href="..\GDXL\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\GDXL\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\GDXL\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\GDXL\targets.html"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>
                <li>
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">GD</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level collapse">
                         <li><a href="..\GD\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\GD\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\GD\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\GD\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\GD\targets.html"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>
                                <li>
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">FOCKE</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level collapse">
                         <li><a href="..\FOCKE\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\FOCKE\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\FOCKE\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\FOCKE\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\FOCKE\targets.html"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>
                <li>
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">BEVEL</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level collapse">
                         <li><a href="..\BEVEL\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\BEVEL\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\BEVEL\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\BEVEL\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\BEVEL\targets.html"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>
                <li>
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">SLIDE & SHELL</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level collapse">
                         <li><a href="..\SLIDESHELL\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\SLIDESHELL\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\SLIDESHELL\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\SLIDESHELL\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\SLIDESHELL\targets.html"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>
                <li>
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">SIDE PACK</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level collapse">
                         <li><a href="..\SIDEPACK\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\SIDEPACK\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\SIDEPACK\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\SIDEPACK\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\SIDEPACK\targets.html"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>

            </ul>

        </div>
    </nav>

    <div id="page-wrapper" class="gray-bg dashbard-1">
        <div class="wrapper wrapper-content animated fadeInRight">
            <div class="row">
                <div class="col-md-12">
                    <div class="ibox ">
                        <div class="ibox-title" style="height:100px;">
                            <h5>Dashboard GD XL [L3] - Base de Datos</h5>
                            <div class="float-right">
                                <div class="form-inline text-center d-flex justify-content-center">
                                    <h5 style="margin-right:20px;"><label class="">Fecha:</label>
                                        <input type="week" class="form-control" runat="server" id="date1" onchange="obtenerDatos()" onkeydown="return false">
                                    </h5>
                                </div>
                            </div>
                        </div>
                        
                        <div class="ibox-content">
                            <div class="row">
                                <div class="table-responsive">
                                    <table id="t01">
                                        <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                                    </table>
                                </div>
                            </div>
                            
<%--                            <div class="row" style="height:30px"></div>
                            <div class="row">
                                <div class="col-md-12">
                                    <table id="t01">
                                        <asp:Panel ID="Panel2" runat="server"></asp:Panel>
                                    </table>
                                </div>
                            </div>
                        </div>--%>
                    </div>
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

        <!-- Page-Level Scripts -->
    <script>
        $parent.find('button[name=download]').click(function () {
            window.location.href = '"~/EnerCon_Dashboard3_0.xlsx"';
        });
    </script>

    <script>
        function obtenerDatos() {
            location.href = './bd.aspx?fecha=' + $('#date1').val();
        }

    </script>
<%--</asp:Content>--%>
</body>
</html>