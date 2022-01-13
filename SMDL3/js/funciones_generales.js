var urlContext = $(location).attr('protocol') + '//' + $(location).attr('hostname') + (location.port === '' ? '' : ':' + location.port) ;
var getApi = urlContext + "/api/datos/";

function llenarSelect(select,valor,texto,json){
  if($(select).is(':empty')){
    $(select).append($('<option>', {
      value: "",
      text: ""
    }));
  }
  for (i = 0; i < json.length; i++) {
    $(select).append($('<option>', {
      value: json[i][valor],
      text: json[i][texto]
    }));
  }
}

function toFloat(valor, decimal) {
    return (Math.round(valor * 100) / 100).toFixed(decimal).toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",")
}

async function getCurrentWeek(campo, api) {
    var result = await conexion("GET", api + "currentWeek/", "");
    $(campo).val(result);
}

function conexion(method, url, params) {
    return new Promise(function (resolve, reject) {
        let xhttp = new XMLHttpRequest();
        xhttp.withCredentials = true;
        xhttp.open(method, url, true);
        xhttp.setRequestHeader("Content-type", "application/json;charset=UTF-8");
        //xhttp.setRequestHeader("Authorization", "basic " + btoa(localStorage['usuario'] + ":" + localStorage['contrasena'] + ":" + localStorage['dominio']));
        xhttp.onload = function () {
            if (this.readyState == 4 && this.status == 200) {
                resolve(xhttp.response);
            } else {
                reject({
                    status: this.status,
                    statusText: xhttp.statusText
                });
            }
        };
        xhttp.onerror = function () {
            reject({
                status: this.status,
                statusText: xhttp.statusText
            });
        };
        xhttp.send(params);
    });
}
toastr.options = {
    closeButton: true,
    progressBar: true,
    showMethod: 'slideDown',
    timeOut: 4000
};
async function CargarTargets(id) {
    try {
        var url = getApi + 'targets/?id=' + id;
        var result = await conexion("GET", url, "");
        var parsed = JSON.parse(result);
        if (parsed.length > 0)
            llenarDiv(parsed);
    } catch (e) {
        toastr.error(e);
    }
}
function activaBoton(idButon) {
    desactivaBotones();
    $('#' + idButon).removeAttr('hidden');
}
function desactivaBotones() {
    $("#contenido :button").attr("hidden", true);
}
async function actualizarCampo(id, campoId, boton) {
    var obj = new Object();
    obj.tipo = 'targets';
    obj.id = id;
    obj.valor = $('#' + campoId).val();
    var l = $(boton).ladda();
    try {
        l.ladda('start');
        var url = getApi + 'guardarTarget';
        await conexion("POST", url, JSON.stringify(obj));
        desactivaBotones();
        toastr.success('Dato guardado correctamente');
    } catch (e) {
        alert(e);
        toastr.error(e);
    } finally {
        l.ladda('stop');
    }

    //alert(id + '  valor:' + $('#' + campoId).val())
}
function llenarDiv(json) {
    var tipo = json[0].Area;
    var content = '<div class="row"><div class="col-lg-4" ><div class="ibox "><div class="ibox-title"><h5>' + tipo + '</h5></div><div class="ibox-content">';
    var a = 1;
    for (var x = 0; x < json.length; x++) {
        if (tipo !== json[x].Area) {
            tipo = json[x].Area;
            if (a % 3 == 0)
                content += '</div></div></div></div><div class="row"><div class="col-lg-4"><div class="ibox "><div class="ibox-title"><h5>' + tipo + '</h5></div><div class="ibox-content">';
            else
                content += '</div></div></div><div class="col-lg-4"><div class="ibox "><div class="ibox-title"><h5>' + tipo + '</h5></div><div class="ibox-content">';
            a++;
        }
        content += '<div class="row text-center"><h5 class="col-md-12"> ' + json[x].Nombre +
            '</h5><div class="col-md-12 d-flex justify-content-center text-center" style="margin-bottom:10px;">' +
            '<input type="number" class="form-control b-r-xl" value="' + json[x].Value + '" id="campo' + json[x].IndicadorId + '" onclick="activaBoton(\'boton' + json[x].IndicadorId + '\')">' +
            '<button class="ladda-button btn btn-primary b-r-xl" style="margin-left:5px;" id="boton' + json[x].IndicadorId + '" onclick="actualizarCampo(\'' + json[x].IndicadorId + '\',\'campo' + json[x].IndicadorId + '\',this);" data-style="zoom-in" hidden><span class="fa fa-save"></span></button>' +
            '</div></div>';
    }
    content += '</div></div>';
    console.log(content);
    $('#contenido').append(content);
}

function setSelectedValue(selectObj, valueToSet) {
    for (var i = 0; i < selectObj.options.length; i++) {
        if (selectObj.options[i].text.includes(valueToSet)) {
            selectObj.options[i].selected = true;
            return;
        }
    }
}
