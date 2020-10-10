<?php
function multiplo($n){
if($n%6==0){
echo($n." es mmultiplo");
}else{
    echo($n." no es mmultiplo");
}

}
echo("ingrese numero");
$num=trim(fgets(STDIN));
multiplo($num);
?>