let estadoValorNombreCompletoEmpleado = false,
    estadoValorSueldoBrutoEmpleado = false;

$(document).ready(function () {

    let date = new Date();
    let day;

    if (date.getDate() <= 9) {
        day = "0" + date.getDate();
    }
    else {
        day = date.getDate();
    }

    $("#FechaNacimientoEmpleado").val(date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + day);
});



$(document).ready(function () {

    $("#NombreCompletoEmpleado").change(function() {

        let valueInputNombreCompletoEmpleado = $("#NombreCompletoEmpleado").val();

        if ((/^([\s])*$/.test(valueInputNombreCompletoEmpleado))) {

            $("#NombreCompletoEmpleado").removeClass("is-valid")
                                        .addClass("is-invalid");
            
            $("#MensajeValidacionCampoNombreCompletoEmpleado").html("El campo Nombre Completo no puede estar vacío.")
                                                              .removeClass("valid-feedback")
                                                              .addClass("invalid-feedback");

            estadoValorNombreCompletoEmpleado = false;
            activarBotonCrear();

        }
        else if (!(/^([a-zA-ZñÑáÁéÉíÍóÓúÚ\s])*$/.test(valueInputNombreCompletoEmpleado))) {

            $("#NombreCompletoEmpleado").removeClass("is-valid")
                                        .addClass("is-invalid");

            $("#MensajeValidacionCampoNombreCompletoEmpleado").html("El valor ingresado no es válido.")
                                                              .removeClass("valid-feedback")
                                                              .addClass("invalid-feedback");

            estadoValorNombreCompletoEmpleado = false;
            activarBotonCrear();

        }
        else {

            $("#NombreCompletoEmpleado").removeClass("is-invalid")
                                        .addClass("is-valid");

            $("#MensajeValidacionCampoNombreCompletoEmpleado").html("El valor ingresado es válido.")
                                                              .removeClass("invalid-feedback")
                                                              .addClass("valid-feedback");

            estadoValorNombreCompletoEmpleado = true;
            activarBotonCrear();

        }
    });

});


$(document).ready(function () {

    $("#SueldoBrutoEmpleado").change(function() {

        let valueInputSueldoBrutoEmpleado = $("#SueldoBrutoEmpleado").val();

        if ((/^([\s])*$/.test(valueInputSueldoBrutoEmpleado))) {

            $("#SueldoBrutoEmpleado").removeClass("is-valid")
                                     .addClass("is-invalid");

            $("#MensajeValidacionCampoSueldoBrutoEmpleado").html("El campo Sueldo Bruto no puede estar vacío.")
                                                           .removeClass("valid-feedback")
                                                           .addClass("invalid-feedback");

            estadoValorSueldoBrutoEmpleado = false;
            activarBotonCrear();

        }
        else if (!(/^([0-9])*$/.test(valueInputSueldoBrutoEmpleado))) {

            $("#SueldoBrutoEmpleado").removeClass("is-valid")
                                     .addClass("is-invalid");

            $("#MensajeValidacionCampoSueldoBrutoEmpleado").html("El valor ingresado no es válido.")
                                                           .removeClass("valid-feedback")
                                                           .addClass("invalid-feedback");

            estadoValorSueldoBrutoEmpleado = false;
            activarBotonCrear();

        }
        else {

            $("#SueldoBrutoEmpleado").removeClass("is-invalid")
                                     .addClass("is-valid");

            $("#MensajeValidacionCampoSueldoBrutoEmpleado").html("El valor ingresado es válido.")
                                                           .removeClass("invalid-feedback")
                                                           .addClass("valid-feedback");

            estadoValorSueldoBrutoEmpleado = true;
            activarBotonCrear();

        }

    });

});

function activarBotonCrear() {

    if (estadoValorNombreCompletoEmpleado && estadoValorSueldoBrutoEmpleado) {

        $("#CrearEmpleado").prop('disabled', false);

    }
    else {

        $("#CrearEmpleado").prop('disabled', true);

    }
}