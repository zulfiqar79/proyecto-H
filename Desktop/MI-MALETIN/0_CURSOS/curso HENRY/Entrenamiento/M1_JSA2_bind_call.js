var persona = {
    nombre:'Oliver',
    apellido:'Khan'
}

var logNombre = function(){
    console.log(this.nombre)
    // return "completado"
}

// this no llama a nombre de persona, 
// llama a this global
// arreglo con bind

var logNombrePersona = logNombre.bind(persona) //this ahora es persona
logNombrePersona(); //Oliver

// esto de arriba lognombrepersona simplifica asi = 
logNombre.call(persona) //Oliver    // hace bind y ejecuta en 1 solo paso

// con mas argumentos

var logNombre = function(arg1, arg2){
    console.log(arg1 + ' '+ this.nombre + ' '+ arg2 )
}

logNombre.call(persona, 'Hola', ', Como estas?') // Hola Oliver como estas