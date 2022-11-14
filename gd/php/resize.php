<?php 

$input_image = "img/th.webp";
$output_image = "img/th_salida.webp";
$width = 1920;
$height = 1080;

$org_info = getimagesize($input_image);

echo $org_info[3].'<br><br>';

$resource_org = imagecreatefromwebp($input_image);

$scaled = imagescale($resource_org,$width,$height);

imagewebp($scaled,$output_image);
imagedestroy($resource_org);
imagedestroy($scaled);



