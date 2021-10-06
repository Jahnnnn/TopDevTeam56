let estadoValorNombreCompletoEmpleado = false,
    estadoValorSueldoBrutoEmpleado = false;

function activarBotonesEmpleado() {

    if (estadoValorNombreCompletoEmpleado && estadoValorSueldoBrutoEmpleado) {

        $("#CrearEmpleado").prop('disabled', false);
        $("#ActualizarEmpleado").prop('disabled', false);
    }
    else {

        $("#CrearEmpleado").prop('disabled', true);
        $("#ActualizarEmpleado").prop('disabled', true);
    }
}

$(document).ready(function() {

    let idEmpleado = $("#IdEmpleado").val();

    if(idEmpleado == undefined) {

        estadoValorNombreCompletoEmpleado = false;
        estadoValorSueldoBrutoEmpleado = false;

    }
    else {

        estadoValorNombreCompletoEmpleado = true;
        estadoValorSueldoBrutoEmpleado = true;

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

    $("#FechaNacimientoEmpleadoC").val(date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + day);
});



$(document).ready(function () {

    $("#NombreCompletoEmpleado").keyup(function () {

        let valueInputNombreCompletoEmpleado = $("#NombreCompletoEmpleado").val();

        if ((/^([\s])*$/.test(valueInputNombreCompletoEmpleado))) {

            $("#NombreCompletoEmpleado").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoNombreCompletoEmpleado").html("El campo Nombre Completo no puede estar vacío.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

            estadoValorNombreCompletoEmpleado = false;
            activarBotonesEmpleado();

        }
        else if (!(/^([a-zA-ZñÑáÁéÉíÍóÓúÚ\s])*$/.test(valueInputNombreCompletoEmpleado))) {

            $("#NombreCompletoEmpleado").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoNombreCompletoEmpleado").html("El valor ingresado no es válido.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

            estadoValorNombreCompletoEmpleado = false;
            activarBotonesEmpleado();

        }
        else {

            $("#NombreCompletoEmpleado").removeClass("is-invalid")
                .addClass("is-valid");

            $("#MensajeValidacionCampoNombreCompletoEmpleado").html("El valor ingresado es válido.")
                .removeClass("invalid-feedback")
                .addClass("valid-feedback");

            estadoValorNombreCompletoEmpleado = true;
            activarBotonesEmpleado();

        }

    });

});


$(document).ready(function () {

    $("#SueldoBrutoEmpleado").keyup(function () {

        let valueInputSueldoBrutoEmpleado = $("#SueldoBrutoEmpleado").val();

        if ((/^([\s])*$/.test(valueInputSueldoBrutoEmpleado))) {

            $("#SueldoBrutoEmpleado").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoSueldoBrutoEmpleado").html("El campo Sueldo Bruto no puede estar vacío.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

            estadoValorSueldoBrutoEmpleado = false;
            activarBotonesEmpleado();

        }
        else if (!(/^([0-9])*$/.test(valueInputSueldoBrutoEmpleado))) {

            $("#SueldoBrutoEmpleado").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoSueldoBrutoEmpleado").html("El valor ingresado no es válido.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

            estadoValorSueldoBrutoEmpleado = false;
            activarBotonesEmpleado();

        }
        else {

            $("#SueldoBrutoEmpleado").removeClass("is-invalid")
                .addClass("is-valid");

            $("#MensajeValidacionCampoSueldoBrutoEmpleado").html("El valor ingresado es válido.")
                .removeClass("invalid-feedback")
                .addClass("valid-feedback");

            estadoValorSueldoBrutoEmpleado = true;
            activarBotonesEmpleado();

        }

    });

});

