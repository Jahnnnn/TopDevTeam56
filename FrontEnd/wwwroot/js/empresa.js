let estadoValorNombreEmpresa = false,
	estadoValorNITEmpresa = false;

function activarBotonCrear() {
	if (estadoValorNombreEmpresa && estadoValorNITEmpresa) {
		$('#CrearEmpresa').prop('disabled', false);
		$('#ActualizarEmpresa').prop('disabled', false);
	} else {
		$('#CrearEmpresa').prop('disabled', true);
		$('#ActualizarEmpresa').prop('disabled', true);
	}
}

$(document).ready(function() {
	let idEmpresa = $('#IdEmpresa').val();

	if (idEmpresa == undefined) {
		estadoValorNombreEmpresa = false;
		estadoValorNITEmpresa = false;
	} else {
		estadoValorNombreEmpresa = true;
		estadoValorNITEmpresa = true;
	}
});

$(document).ready(function() {
	let date = new Date();
	let day;

	if (date.getDate() <= 9) {
		day = '0' + date.getDate();
	} else {
		day = date.getDate();
	}

	$('#FechaNacimientoEmpleadoC').val(date.getFullYear() + '-' + (date.getMonth() + 1) + '-' + day);
});

$(document).ready(function() {
	$('#NombreEmpresa').keyup(function() {
		let valueInputNombreEmpresa = $('#NombreEmpresa').val();

		if (/^([\s])*$/.test(valueInputNombreEmpresa)) {
			$('#NombreEmpresa').removeClass('is-valid').addClass('is-invalid');

			$('#MensajeValidacionCampoNombreEmpresa')
				.html('Campo Nombre de Empresa Requerido.')
				.removeClass('valid-feedback')
				.addClass('invalid-feedback');

			estadoValorNombreEmpresa = false;
			activarBotonCrear();
		} else if (!/^([a-zA-ZñÑáÁéÉíÍóÓúÚ\s])*$/.test(valueInputNombreEmpresa)) {
			$('#NombreEmpresa').removeClass('is-valid').addClass('is-invalid');

			$('#MensajeValidacionCampoNombreEmpresa')
				.html('El valor ingresado no es válido.')
				.removeClass('valid-feedback')
				.addClass('invalid-feedback');

			estadoValorNombreEmpresa = false;
			activarBotonCrear();
		} else {
			$('#NombreEmpresa').removeClass('is-invalid').addClass('is-valid');

			$('#MensajeValidacionCampoNombreEmpresa')
				.html('El valor ingresado es válido.')
				.removeClass('invalid-feedback')
				.addClass('valid-feedback');

			estadoValorNombreEmpresa = true;
			activarBotonCrear();
		}
	});
});

$(document).ready(function() {
	$('#NITEmpresa').keyup(function() {
		let valueInputNITEmpresa = $('#NITEmpresa').val();

		if (/^([\s])*$/.test(valueInputNITEmpresa)) {
			$('#NITEmpresa').removeClass('is-valid').addClass('is-invalid');

			$('#MensajeValidacionCampoNITEmpresa')
				.html('El campo NIT de Empresa no puede estar vacío.')
				.removeClass('valid-feedback')
				.addClass('invalid-feedback');

			estadoValorNITEmpresa = false;
			activarBotonCrear();
		} else if (!/^([a-zA-ZñÑáÁéÉíÍóÓúÚ\s])*$/.test(valueInputNITEmpresa)) {
			$('#NITEmpresa').removeClass('is-valid').addClass('is-invalid');

			$('#MensajeValidacionCampoNITEmpresa')
				.html('El valor ingresado no es válido.')
				.removeClass('valid-feedback')
				.addClass('invalid-feedback');

			estadoValorNITEmpresa = false;
			activarBotonCrear();
		} else {
			$('#NITEmpresa').removeClass('is-invalid').addClass('is-valid');

			$('#MensajeValidacionCampoNITEmpresa')
				.html('El valor ingresado es válido.')
				.removeClass('invalid-feedback')
				.addClass('valid-feedback');

			estadoValorNITEmpresa = true;
			activarBotonCrear();
		}
	});
});
