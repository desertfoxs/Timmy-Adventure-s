<?php
function sumados($a, $b){
$suma = $a + $b;
echo " la suma es: ". $suma;
}
function potencia($a,$b){
$potenc=pow($a,$b);
    echo ("\n la potencia es: ".$potenc);
}
function raiz(){
    echo "\n ingrese numero para sacar la raiz";
    $a = trim(fgets(STDIN));
    $rais=sqrt($a);
    echo("la raiz del numero es: ".$rais);
}
//programa principal
echo "ingrese el valor de x?";
$x = trim(fgets(STDIN));
echo "ingrese el valor de z? ";
$z=trim(fgets(STDIN));
//llamo a la funcion
sumados($x, $z);
potencia($x,$z);
raiz();
?>
