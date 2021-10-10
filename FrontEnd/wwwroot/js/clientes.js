let estadoValorNombreCompletoCliente = false,
    estadoValorTelefonoCliente = false;

function activarBotonesCrearEditarCliente() {

    if (estadoValorNombreCompletoCliente && estadoValorTelefonoCliente) {

        $("#CrearCliente").prop('disabled', false);
        $("#ActualizarCliente").prop('disabled', false);
    }
    else {

        $("#CrearCliente").prop('disabled', true);
        $("#ActualizarCliente").prop('disabled', true);
    }
}

$(document).ready(function() {

    let idCliente = $("#IdCliente").val();

    if(idCliente == undefined) {

        estadoValorNombreCompletoCliente = false;
        estadoValorTelefonoCliente = false;

    }
    else {

        estadoValorNombreCompletoCliente = true;
        estadoValorTelefonoCliente = true;

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

    $("#FechaNacimientoClienteC").val(date.getFullYear() + "-" + (date.getMonth() + 1) + "-" + day);
});


$(document).ready(function () {

    $("#NombreCompletoCliente").keyup(function () {

        let valueInputNombreCompletoCliente = $("#NombreCompletoCliente").val();

        if ((/^([\s])*$/.test(valueInputNombreCompletoCliente))) {

            $("#NombreCompletoCliente").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoNombreCompletoCliente").html("El campo Nombre Completo no puede estar vacío.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

                estadoValorNombreCompletoCliente = false;

        }
        else if (!(/^([a-zA-ZñÑáÁéÉíÍóÓúÚ\s])*$/.test(valueInputNombreCompletoCliente))) {

            $("#NombreCompletoCliente").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoNombreCompletoCliente").html("El valor ingresado no es válido.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

                estadoValorNombreCompletoCliente = false;

        }
        else {

            $("#NombreCompletoCliente").removeClass("is-invalid")
                .addClass("is-valid");

            $("#MensajeValidacionCampoNombreCompletoCliente").html("El valor ingresado es válido.")
                .removeClass("invalid-feedback")
                .addClass("valid-feedback");

                estadoValorNombreCompletoCliente = true;

        }

        activarBotonesCrearEditarCliente();

    });

});


$(document).ready(function () {

    $("#TelefonoCliente").keyup(function () {

        let valueInputTelefonoCliente = $("#TelefonoCliente").val();

        if ((/^([\s])*$/.test(valueInputTelefonoCliente))) {

            $("#TelefonoCliente").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoTelefonoCliente").html("El campo Teléfono no puede estar vacío.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

                estadoValorTelefonoCliente = false;

        }
        else if (!(/^([0-9])*$/.test(valueInputTelefonoCliente))) {

            $("#TelefonoCliente").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoTelefonoCliente").html("El valor ingresado no es válido.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

                estadoValorTelefonoCliente = false;

        }
        else {

            $("#TelefonoCliente").removeClass("is-invalid")
                .addClass("is-valid");

            $("#MensajeValidacionCampoTelefonoCliente").html("El valor ingresado es válido.")
                .removeClass("invalid-feedback")
                .addClass("valid-feedback");

                estadoValorTelefonoCliente = true;

        }

        activarBotonesCrearEditarCliente();

    });

});