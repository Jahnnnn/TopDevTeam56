const inputFechaNacimientoEmpleado = document.getElementById('FechaNacimientoEmpleado'),
      inputNombreCompletoEmpleado = document.getElementById('NombreCompletoEmpleado'),
      inputSueldoBrutoEmpleado = document.getElementById('SueldoBrutoEmpleado'),
      botonCrearEmpleado = document.getElementById('CrearEmpleado'),
      smallMensajeValidacionNombreCompletoEmpleado = document.getElementById('MensajeValidacionCampoNombreCompletoEmpleado'),
      smallMensajeValidacionSueldoBrutoEmpleado = document.getElementById('MensajeValidacionCampoSueldoBrutoEmpleado');

let estadoValorNombreCompletoEmpleado = false,
    estadoValorSueldoBrutoEmpleado = false;

inputFechaNacimientoEmpleado.valueAsDate = new Date();

inputNombreCompletoEmpleado.addEventListener('change', function() {

    let valueInputNombreCompletoEmpleado = this.value;

    if((/^([\s])*$/.test(valueInputNombreCompletoEmpleado))) {
        this.classList.remove('is-valid');
        this.classList.add('is-invalid');
        smallMensajeValidacionNombreCompletoEmpleado.innerHTML='El campo Nombre Completo no puede estar vacío.';
        smallMensajeValidacionNombreCompletoEmpleado.classList.add('valid-feedback');
        smallMensajeValidacionNombreCompletoEmpleado.classList.add('invalid-feedback');
        estadoValorNombreCompletoEmpleado = false;
        activarBotonCrear();
    }
    else if(!(/^([a-zA-ZñÑáÁéÉíÍóÓúÚ\s])*$/.test(valueInputNombreCompletoEmpleado))) {
        this.classList.remove('is-valid');
        this.classList.add('is-invalid');
        smallMensajeValidacionNombreCompletoEmpleado.innerHTML='El valor ingresado no es válido.';
        smallMensajeValidacionNombreCompletoEmpleado.classList.add('valid-feedback');
        smallMensajeValidacionNombreCompletoEmpleado.classList.add('invalid-feedback');
        estadoValorNombreCompletoEmpleado = false;
        activarBotonCrear();
    }
    else {
        this.classList.remove('is-invalid');
        this.classList.add('is-valid');
        smallMensajeValidacionNombreCompletoEmpleado.innerHTML='El valor ingresado es válido.'
        smallMensajeValidacionNombreCompletoEmpleado.classList.remove('invalid-feedback');
        smallMensajeValidacionNombreCompletoEmpleado.classList.add('valid-feedback');
        estadoValorNombreCompletoEmpleado = true;
        activarBotonCrear();
    }
});

inputSueldoBrutoEmpleado.addEventListener('change', function() {

    let valueInputSueldoBrutoEmpleado = this.value;

    if((/^([\s])*$/.test(valueInputSueldoBrutoEmpleado))) {
        this.classList.remove('is-valid');
        this.classList.add('is-invalid');
        smallMensajeValidacionSueldoBrutoEmpleado.innerHTML='El campo Sueldo Bruto no puede estar vacío.';
        smallMensajeValidacionSueldoBrutoEmpleado.classList.add('valid-feedback');
        smallMensajeValidacionSueldoBrutoEmpleado.classList.add('invalid-feedback');
        estadoValorSueldoBrutoEmpleado = false;
        activarBotonCrear();
    }
    else if(!(/^([0-9])*$/.test(valueInputSueldoBrutoEmpleado))) {
        this.classList.remove('is-valid');
        this.classList.add('is-invalid');
        smallMensajeValidacionSueldoBrutoEmpleado.innerHTML='El valor ingresado no es válido.';
        smallMensajeValidacionSueldoBrutoEmpleado.classList.add('valid-feedback');
        smallMensajeValidacionSueldoBrutoEmpleado.classList.add('invalid-feedback');
        estadoValorSueldoBrutoEmpleado = false;
        activarBotonCrear();
    }
    else {
        this.classList.remove('is-invalid');
        this.classList.add('is-valid');
        smallMensajeValidacionSueldoBrutoEmpleado.innerHTML='El valor ingresado es válido.'
        smallMensajeValidacionSueldoBrutoEmpleado.classList.remove('invalid-feedback');
        smallMensajeValidacionSueldoBrutoEmpleado.classList.add('valid-feedback');
        estadoValorSueldoBrutoEmpleado = true;
        activarBotonCrear();
    }
});

function activarBotonCrear() {
    
    if(estadoValorNombreCompletoEmpleado && estadoValorSueldoBrutoEmpleado) {
        botonCrearEmpleado.disabled = false;
    }
    else {
        botonCrearEmpleado.disabled = true;
    }
}