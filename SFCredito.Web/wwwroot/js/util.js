

/************************************* 
APRESENTAR MENSAGEM DE NOTIFICAÇÂO
FONT: https://github.com/CodeSeven/toastr
PARAMETROS: options (JSON PARAMETROS)  
EX:
    showNotification({
        title: "Aviso",
        text: "Cadastrado com Sucesso!",
        // Tipo da notificação:
        // TypeNotify.INFO, TypeNotify.SUCCESS, TypeNotify.WARNING, TypeNotify.ERROR
        type: TypeNotify.INFO,
        hideAuto: true   
    });
*************************************/

//const { debug } = require("util");

//Tipo de Notificações. "info", "success", "warning" or "error".
var TypeNotify = {};
TypeNotify.INFO = "info";
TypeNotify.SUCCESS = "success";
TypeNotify.WARNING = "warning";
TypeNotify.ERROR = "error";

function showNotification(options) {
    
   
    var defaults = {
        title: "Aviso",
        text: "",
        type: TypeNotify.INFO,
        hideAuto: true
    };
    //fundir o 'defaults' e 'options'.
    var settings = $.extend({}, defaults, options);

    // Se colocar as opções ("timeOut" e "extendedTimeOut") como "0"
    // evita que a Notificações fecha automaticamente.
    var timeOut = "0";
    var extendedTimeOut = "0";
    if (settings.hideAuto === true) {
        timeOut = "9000";
        extendedTimeOut = "1000";
    }

    // Opções padrões de notificação
    toastr.options = {
        "closeButton": true,
        "debug": false,
        "newestOnTop": false,
        "progressBar": true,
        "positionClass": "toast-top-right",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": timeOut,
        "extendedTimeOut": extendedTimeOut,
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }

    var type = options.type;
    switch (type) {

        case "modelState":

            console.log(options.text);

            $("#myform").html(options.text); //change here...
            break;

        case "info":
            toastr.info(options.text, options.title);
            break;
        case "success":
            toastr.success(options.text, options.title);
            break;
        case "warning":
            toastr.warning(options.text, options.title);
            break
        case "error":
            toastr.error(options.text, options.title);
            break;
    }
}


/*************************************
Ajax generico para uso no sistema. O destino é substituído pelo resultado.
Parametros: tipo (Tipo da requisição)
            url (Caminho)
            dados (dados a serem enviados)
            destino (Local para renderizar o resultado)
            event (Evento)
Ex.:
    ajaxGeral('GET', 'Controller/Action', 'id:0', 'partial', event);
*************************************/
function ajaxGeral(tipo, url, dados, destino, event) {

  
    if (event != null) {
        event.preventDefault();
    }
    var divDestino = "#" + destino;

    $.ajax({
        cache: false,
        type: tipo,
        url: url,
        data: dados,
        success: function (partial) {
          
            if (partial != "") {
                $(divDestino).html(partial);
                $("#loading-partial").hide();
             
            }
            else {
                $("#loading-partial").hide();
                location.reload();
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            $("#loading-partial").hide();
            errorNotification(jqXHR, textStatus, errorThrown);
        }
    });
}


//*********************Exibir Notificações******************

function ExibirNotificacoesAjax(result)
{
    retorno = result;
    if (result != "") {

        var mensagem = retorno.message;
        var erro = retorno.erro;
        var title = retorno.title;
        var redirect = retorno.redirect;
        var notificacao = retorno.notificacao;


        if (notificacao) {
            if (erro) {
                showNotification({ title: title, text: mensagem, type: retorno.tipoMensagem });
            } else {
                showNotification({ title: title, text: mensagem, type: retorno.tipoMensagem });
            }
        }
        if (redirect) {
            var url = '/' + retorno.controller + '/' + retorno.action + '';

            setTimeout(function () {
                window.location.href = url
            }, 9000);

        }
    }
}

/**************************************/


/*************************************
Ajax generico para submits em formularios
Parametros: div (Local para renderizar o resultado)
            event (Evento)
Ex.:
    formSubmit('partial', event);
*************************************/
function formSubmit(event, div) {
    event.preventDefault();

    

    $("#loading-partial").css("display", "block !important");
    $("#loading-partial").show();

    var elementForm;

    if (event.target != 'undefined') {
        elementForm = event.target;
    }
    else {
        elementForm = event.currentTarget;
    }

    var url = $(elementForm).attr("action");
    var dados = $(elementForm).serialize();
    var tipo = $(elementForm).attr("method");
    var retorno;
    $.ajax({
        cache: false,
        type: tipo,
        url: url,
        data: dados,
        success: function (result, status, xhr) {
            retorno = result;
            if (result != "") {
              
                var ct = xhr.getResponseHeader("content-type") || "";
                var mensagem = retorno.message;
                var erro = retorno.erro;
                var tipoMensagem = retorno.tipoMensagem;
                var title = retorno.title;
                var redirect = retorno.redirect;
                var notificacao = retorno.notificacao;


                if (notificacao) {
                    if (erro) {
                        showNotification({ title: title, text: mensagem, type: retorno.tipoMensagem });
                    } else {
                        showNotification({ title: title, text: mensagem, type: retorno.tipoMensagem });
                    }
                }
                if (redirect) {
                    var url = '/' + retorno.controller + '/' + retorno.action + '';

                    setTimeout(function () {
                        window.location.href = url
                    }, 9000);

                }
            }
          
        },
        error: function (jqXHR, textStatus, errorThrown) {
          
            $("#loading-partial").hide();
            errorNotification(jqXHR, textStatus, errorThrown);
        }
    });
}


/************************************* 
Trata os erro de reqisições Ajax
Parametros: jqXHR (Objeto de Erro)
            textStatus (Status do Erro)
            errorThrown (Mensagem genérica do erro do servidor) 
*************************************/
function errorNotification(jqXHR, textStatus, errorThrown) {
    var error = jqXHR.responseJSON;
    showNotification({
        title: "Houve um Problema!",
        text: error.message,
        type: TypeNotify.ERROR,
        hideAuto: false
    });
}

function inicializarMascaras() {

  
    $('.dateMask').mask('00/00/0000');
    $('.timeMask').mask('00:00:00');
    $('.dateTimeMask').mask('00/00/0000 00:00:00');
    $('.competenciaMask').mask('00/0000');
    $('.cepMask').mask('00000-000');
    $('.dddMask').mask('00');
    $('.numMask').mask('0000000000');
    $('.ufMask').mask('SS');
    $('.phoneMask').mask('(00) 00000 - 0000');
    $('.cpfMask').mask('000.000.000-00', { reverse: true });
    $('.cnpjMask').mask('00.000.000/0000-00', { reverse: true });
    $('.dinheiroMask').mask('000.000.000.000.000,00', { reverse: true });
    $('.dinheiroMask2').mask("#.##0,00", { reverse: true });
    $('.percentMask').mask('##0,00', { reverse: true })
    $('.cardMask').mask('0000 0000 0000 0000');
}

function addHidden(idformulario, nomeObjeto, dado) {
    var novoHidden = document.createElement('input');
    $(novoHidden).attr('type', 'hidden')
        .attr('name', nomeObjeto)
        .attr('id', nomeObjeto.replace(/([.\]\[])/g, '_'))
        .val(dado);

    $('#' + idformulario).prepend($(novoHidden));

}



function popularComboSelectListItemPropriedadesSelecionarItem(lista, idControle, criarItemDefault, descricaoItemDefault, value, propriedadeValue, propriedadeText) {
    var options = '';

    if (criarItemDefault)
        options += '<option value="">' + descricaoItemDefault + '</option>';

    for (var i = 0; i < lista.length; i++)
        options += '<option value="' + eval("lista[" + i + "]." + propriedadeValue + "") + '">' + eval("lista[" + i + "]." + propriedadeText + "") + '</option>';

    $(idControle).html(options).show();
    $(idControle).val(value);
}

function popularComboSelectListItemPropriedadesArray(lista, idControle, criarItemDefault, descricaoItemDefault, propriedadesValue, propriedadeText, arraySeparator) {
    var options = '';
    var itensValue = propriedadesValue.split(",");
    var value = '';

    if (criarItemDefault)
        options += '<option value="">' + descricaoItemDefault + '</option>';

    for (var i = 0; i < itensValue.length; i++) {
        value += "lista[####]." + itensValue[i] + (i < itensValue.length - 1 ? " + '" + arraySeparator + "' + " : "");
    }

    for (var i = 0; i < lista.length; i++) {

        if (lista[i].Selected)
            options += '<option value="' + eval(value.replace(/####/gi, i)) + '" selected>' + eval("lista[" + i + "]." + propriedadeText + "") + '</option>';
        else
            options += '<option value="' + eval(value.replace(/####/gi, i)) + '">' + eval("lista[" + i + "]." + propriedadeText + "") + '</option>';
    }

    $(idControle).html(options).show();
}

function popularComboSelectListItemPorClasse(lista, classeControle, criarItemDefault, descricaoItemDefault, propriedadeValue, propriedadeText) {
    var options = '';

    if (criarItemDefault)
        options += '<option value="">' + descricaoItemDefault + '</option>';

    if (lista != undefined) {

        for (var i = 0; i < lista.length; i++) {
            if (lista[i].Selected)
                options += '<option value="' + eval("lista[" + i + "]." + propriedadeValue + "") + '" selected>' + eval("lista[" + i + "]." + propriedadeText + "") + '</option>';
            else
                options += '<option value="' + eval("lista[" + i + "]." + propriedadeValue + "") + '">' + eval("lista[" + i + "]." + propriedadeText + "") + '</option>';
        }
    }

    $(classeControle).html(options).show();
}

function carregarScript(url) {
   

    if (url != null)
        while (url.indexOf('//') >= 0)
            url = url.replace('//', '/');

    $.ajax({
        async: false,
        cache: false,
        url: url,
        dataType: "script",
        success: function (data, textStatus) { }
    });
}


function OcutarMenu() {

   
    var grupoacessoId = $("#grupoacessoId").val();

    var _grupoacessoId = $("#_grupoacessoId").val();

    if (grupoacessoId != 1) {

        $('._grupoAcesso_1').hide();
        $('._grupoAcesso_2').show();
    } else {

        $('._grupoAcesso_1').show();
        $('._grupoAcesso_2').show();
    }

    if (_grupoacessoId != 1) {

        $('._grupoAcesso_1').hide();
        $('._grupoAcesso_2').show();
    } else {

        $('._grupoAcesso_1').show();
        $('._grupoAcesso_2').show();
    }
}