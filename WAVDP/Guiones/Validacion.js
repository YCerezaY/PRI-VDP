function Numeros(e) {
    var tecla = e.which || e.keyCode;
    if (tecla > 31 && (tecla < 48 || tecla > 57)) {
        return false;
    }
    return true;
}
function Letras(e) {
    var tecla = e.which || e.keyCode;
    if ((tecla > 64 && tecla < 91) || (tecla > 96 && tecla < 123) || tecla === 241 || tecla === 209 || (tecla >= 193 && tecla <= 218) || (tecla >= 225 && tecla <= 252)) {
        return true;
    }
    else {
        return false;
    }
}
function LetrasYNumeros(e) {
    var tecla = e.which || e.keyCode;
    if ((tecla > 64 && tecla < 91) ||         
        (tecla > 96 && tecla < 123) ||         
        (tecla > 47 && tecla < 58) ||          
        (tecla === 241) || (tecla === 209) ||  
        (tecla >= 225 && tecla <= 252) ||     
        (tecla >= 193 && tecla <= 218)) {     
        return true;
    } else {
        return false;
    }
}
function Decimales(e) {
    var tecla = e.which || e.keyCode;
    if ((tecla >= 48 && tecla <= 57) || tecla === 46) {
        if (tecla === 46 && e.target.value.includes('.')) {
            return false;
        }
        return true;
    } else {
        return false;
    }
}