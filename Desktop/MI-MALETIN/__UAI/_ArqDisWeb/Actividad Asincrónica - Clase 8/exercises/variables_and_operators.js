// c) crear 2 var string y sumar largo cada variable (cant letras string)
// guardar resultado suma en 3er var (usar length)

function handleClick(){
    alert('Boton tocado')
}

// document.addEventListener('DOMContentLoaded',(event)=> {
//     const button = document.getElementById('miBoton');
//     button.addEventListener('click',handleClick)
// })

var fisrtword, secondword, thirdword
fisrtword = "Hello";
secondword ="World"
thirdword = fisrtword.length + secondword.length
console.log(thirdword)

// 2) string
// crear var string con min 10 caract y convertir texto en mayuscula
// usar toUpperCase

var text;
text="One of the best";
text.toUpperCase();
console.log(text.toUpperCase())
