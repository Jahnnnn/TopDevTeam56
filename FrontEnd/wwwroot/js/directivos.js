let estadoValorNombreCompletoDirectivo = false,
    estadoValorSueldoBrutoDirectivo = false;

function activarBotonesCrearEditarDirectivo() {

    if (estadoValorNombreCompletoDirectivo && estadoValorSueldoBrutoDirectivo) {

        $("#CrearDirectivo").prop('disabled', false);
        $("#ActualizarDirectivo").prop('disabled', false);
    }
    else {

        $("#CrearDirectivo").prop('disabled', true);
        $("#ActualizarDirectivo").prop('disabled', true);
    }
}

$(document).ready(function() {

    let idDirectivo = $("#IdDirectivo").val();

    if(idDirectivo == undefined) {

        estadoValorNombreCompletoDirectivo = false;
        estadoValorSueldoBrutoDirectivo = false;

    }
    else {

        estadoValorNombreCompletoDirectivo = true;
        estadoValorSueldoBrutoDirectivo = true;

    }

});

$(document).ready(function () {

    let date = new Date();
    let day;

    if (date.getDate() <= 9) {
        day = "0" + date.getDate();
    }
    else {
        day = date.getDate();
    }

    $("#FechaNacimientoDirectivoC").val(date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + day);
});


$(document).ready(function () {

    $("#NombreCompletoDirectivo").keyup(function () {

        let valueInputNombreCompletoDirectivo = $("#NombreCompletoDirectivo").val();

        if ((/^([\s])*$/.test(valueInputNombreCompletoDirectivo))) {

            $("#NombreCompletoDirectivo").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoNombreCompletoDirectivo").html("El campo Nombre Completo no puede estar vacío.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

                estadoValorNombreCompletoDirectivo = false;

        }
        else if (!(/^([a-zA-ZñÑáÁéÉíÍóÓúÚ\s])*$/.test(valueInputNombreCompletoDirectivo))) {

            $("#NombreCompletoDirectivo").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoNombreCompletoDirectivo").html("El valor ingresado no es válido.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

                estadoValorNombreCompletoDirectivo = false;

        }
        else {

            $("#NombreCompletoDirectivo").removeClass("is-invalid")
                .addClass("is-valid");

            $("#MensajeValidacionCampoNombreCompletoDirectivo").html("El valor ingresado es válido.")
                .removeClass("invalid-feedback")
                .addClass("valid-feedback");

                estadoValorNombreCompletoDirectivo = true;

        }

        activarBotonesCrearEditarDirectivo();

    });

});


$(document).ready(function () {

    $("#SueldoBrutoDirectivo").keyup(function () {

        let valueInputSueldoBrutoDirectivo = $("#SueldoBrutoDirectivo").val();

        if ((/^([\s])*$/.test(valueInputSueldoBrutoDirectivo))) {

            $("#SueldoBrutoDirectivo").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoSueldoBrutoDirectivo").html("El campo Sueldo Bruto no puede estar vacío.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

                estadoValorSueldoBrutoDirectivo = false;

        }
        else if (!(/^([0-9])*$/.test(valueInputSueldoBrutoDirectivo))) {

            $("#SueldoBrutoDirectivo").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoSueldoBrutoDirectivo").html("El valor ingresado no es válido.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

                estadoValorSueldoBrutoDirectivo = false;

        }
        else {

            $("#SueldoBrutoDirectivo").removeClass("is-invalid")
                .addClass("is-valid");

            $("#MensajeValidacionCampoSueldoBrutoDirectivo").html("El valor ingresado es válido.")
                .removeClass("invalid-feedback")
                .addClass("valid-feedback");

                estadoValorSueldoBrutoDirectivo = true;

        }

        activarBotonesCrearEditarDirectivo();

    });

});