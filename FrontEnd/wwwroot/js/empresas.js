let estadoValorNombreEmpresa = false,
	estadoValorNITEmpresa = false;

function activarBotonesCrearEditarEmpresa() {

	if (estadoValorNombreEmpresa && estadoValorNITEmpresa) {

        $("#CrearEmpresa").prop('disabled', false);
        $("#ActualizarEmpresa").prop('disabled', false);
    }
    else {

        $("#CrearEmpresa").prop('disabled', true);
        $("#ActualizarEmpresa").prop('disabled', true);
    }
}

$(document).ready(function() {

    let idEmpresa = $("#IdEmpresa").val();

    if(idEmpresa == undefined) {

        estadoValorNombreEmpresa = false;
        estadoValorNITEmpresa = false;

    }
    else {

        estadoValorNombreEmpresa = true;
        estadoValorNITEmpresa = true;

    }

    console.log(idEmpresa)

});

$(document).ready(function () {

    $("#NombreEmpresa").keyup(function () {

        let valueInputNombreEmpresa = $("#NombreEmpresa").val();
        console.log(valueInputNombreEmpresa);

        if ((/^([\s])*$/.test(valueInputNombreEmpresa))) {

            $("#NombreEmpresa").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoNombreEmpresa").html("El campo Razon Social no puede estar vacío.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

			estadoValorNombreEmpresa = false;

        }
        else if (!(/^([a-zA-ZñÑáÁéÉíÍóÓúÚ\s.])*$/.test(valueInputNombreEmpresa))) {

            $("#NombreEmpresa").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoNombreEmpresa").html("El valor ingresado no es válido.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

			estadoValorNombreEmpresa = false;

        }
        else {

            $("#NombreEmpresa").removeClass("is-invalid")
                .addClass("is-valid");

            $("#MensajeValidacionCampoNombreEmpresa").html("El valor ingresado es válido.")
                .removeClass("invalid-feedback")
                .addClass("valid-feedback");

			estadoValorNombreEmpresa = true;

        }

        activarBotonesCrearEditarEmpresa();

    });

});

$(document).ready(function () {

    $("#NITEmpresa").keyup(function () {

        let valueInputNITEmpresa = $("#NITEmpresa").val();

        if ((/^([\s])*$/.test(valueInputNITEmpresa))) {

            $("#NITEmpresa").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoNITEmpresa").html("El campo NIT no puede estar vacío.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

			estadoValorNITEmpresa = false;

        }
        else if (!(/^([0-9])*$/.test(valueInputNITEmpresa))) {

            $("#NITEmpresa").removeClass("is-valid")
                .addClass("is-invalid");

            $("#MensajeValidacionCampoNITEmpresa").html("El valor ingresado no es válido.")
                .removeClass("valid-feedback")
                .addClass("invalid-feedback");

			estadoValorNITEmpresa = false;

        }
        else {

            $("#NITEmpresa").removeClass("is-invalid")
                .addClass("is-valid");

            $("#MensajeValidacionCampoNITEmpresa").html("El valor ingresado es válido.")
                .removeClass("invalid-feedback")
                .addClass("valid-feedback");

			estadoValorNITEmpresa = true;

        }

        activarBotonesCrearEditarEmpresa();

    });

});
