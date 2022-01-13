﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="SMDL3.SIDEPACK.index" %>
<!DOCTYPE html>
<html>

<head><meta charset="utf-8" /><meta name="viewport" content="width=device-width, initial-scale=1.0" /><title>
	Datos
</title>
    <link href="../css/bootstrap.min.css" rel="stylesheet" />
    <link href="../font-awesome/css/font-awesome.css" rel="stylesheet" />
    <link href="../css/plugins/dataTables/datatables.min.css" rel="stylesheet" />
    <link href="../css/animate.css" rel="stylesheet" />
    <link href="../css/style.css" rel="stylesheet" />
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
                <li>
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">BEVEL</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level collapse">
                         <li><a href="..\BEVEL\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\BEVEL\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\BEVEL\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\BEVEL\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\BEVEL\targets.aspx"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
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
                <li class="active">
                    <a href="#"><i class="fa fa-industry"></i> <span class="nav-label">SIDE PACK</span><span class="fa arrow"></span></a>
                    <ul class="nav nav-second-level">
                         <li class="active"><a href="..\SIDEPACK\index.aspx"><i class="fa fa-table"></i> <span class="nav-label">Datos</span></a></li>
                         <li><a href="..\SIDEPACK\bd.aspx?Id=1"><i class="fa fa-area-chart"></i> <span class="nav-label">Indicadores</span></a></li>
                         <li><a href="..\SIDEPACK\dds.aspx?Id=1"><i class="fa fa-tachometer"></i> <span class="nav-label">DDS</span></a></li>
                         <li><a href="..\SIDEPACK\carga.aspx"><i class="fa fa-upload"></i> <span class="nav-label">Carga Manual</span></a></li>
                         <li><a href="..\SIDEPACK\targets.aspx"><i class="fa fa-bullseye"></i> <span class="nav-label">Targets</span></a></li>
                    </ul>
                </li>

            </ul>

        </div>
    </nav>
    

        <div id="page-wrapper" class="gray-bg">
            
    <div class="page-content">
        <div class="wrapper wrapper-content animated fadeInRight">
            <div class="row">
                <div class="col-lg-12">
                <div class="ibox ">
                    <div class="ibox-title">
                        <h2>Dashboard SIDE PACK [L3] -  Datos por Área</h2>
                    </div>
                    <div class="ibox-content">
                        
                    <div class="table-responsive">
                        <table class="table table-striped table-bordered table-hover dataTables-example2" >
                            <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                        </table>
                    </div>

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
    

    <script src="../js/plugins/dataTables/datatables.min.js"></script>
    <script src="../js/plugins/dataTables/dataTables.bootstrap4.min.js"></script>

        <!-- Page-Level Scripts -->
    <script>
        $(document).ready(function () {
            $('.dataTables-example2').DataTable({
                pageLength: 25,
                responsive: true,
                dom: '<"html5buttons"B>lTfgitp',
                buttons: [
                    {
                        extend: 'copy',
                        text: 'Copiar'
                    },
                    { extend: 'csv' },
                    { extend: 'excel', title: 'Datos' }
                ],
                "language": {
                    "decimal": "",
                    "emptyTable": "No hay datos",
                    "info": "Mostrando _START_ a _END_ de _TOTAL_ registros",
                    "infoEmpty": "Mostrando 0 a 0 de 0 registros",
                    "infoFiltered": "(filtrando de _MAX_ registros totales)",
                    "infoPostFix": "",
                    "thousands": ",",
                    "lengthMenu": "Mostrar _MENU_ registros",
                    "loadingRecords": "Cargando...",
                    "processing": "Procesando...",
                    "search": "Buscar:",
                    "zeroRecords": "No se encontraron registros",
                    "paginate": {
                        "first": "Primero",
                        "last": "Último",
                        "next": "Siguiente",
                        "previous": "Anterior"
                    },
                    "aria": {
                        "sortAscending": ": activar para ordenar columna ascendente",
                        "sortDescending": ": activar para ordenar columna descendiente"
                    },
                    buttons: {
                        copySuccess: {
                            copyTitle: "Copiar al portapapeles",
                            _: '%d registros copiados',
                            1: '1 registro copiado'
                        }
                    }
                }
            });

        });

    </script>
        <div class="footer">
        <div class="float-right">
                 <strong>British American Tobacco México</strong>
            </div>
        </div>
    </div>
    </div>
    
        

    <!-- Mainly scripts -->
    <script src="../js/jquery-3.1.1.min.js"></script>
    <script src="../js/popper.min.js"></script>
    <script src="../js/bootstrap.js"></script>
    <script src="../js/plugins/metisMenu/jquery.metisMenu.js"></script>
    <script src="../js/plugins/slimscroll/jquery.slimscroll.min.js"></script>

    <script src="../js/plugins/dataTables/datatables.min.js"></script>
    <script src="../js/plugins/dataTables/dataTables.bootstrap4.min.js"></script>

    <!-- Custom and plugin javascript -->
    <script src="../js/inspinia.js"></script>



</body>

</html>