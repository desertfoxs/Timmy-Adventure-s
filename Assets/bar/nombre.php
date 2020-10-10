<?php
function sumados($a, $b){
$suma = $a + $b;
echo " la suma es: ". $suma;
}
function potencia($a,$b){
    $potencia=pow(a,b);
    echo " la potencia es: ". $$potencia;
}
//programa principal
echo "ingrese el valor de x?";
$x = trim(fgets(STDIN));
echo "ingrese el valor de z? ";
$z=trim(fgets(STDIN));
//llamo a la funcion
sumados($x, $z);
potencia($x,$z)
?>
