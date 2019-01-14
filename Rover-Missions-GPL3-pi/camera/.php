<?php
//get the last used number for naming file

shell_exec("cp /var/www/novnc/camera/index.php /var/www/novnc/camera/" . htmlspecialchars($_GET["random"])  . ".php");

echo "cp /var/www/novnc/camera/index.php /var/www/novnc/camera/" . htmlspecialchars($_GET["random"])  . ".php";

shell_exec("raspistill -w 300 -h 300 -t 1000 -o /var/www/novnc/camera/img/photo.jpg");
// phpinfo();

header("Content-type: image/jpeg");
$im = imagecreatefromjpeg("/var/www/novnc/camera/img/photo.jpg");
imagejpeg($im);
imagedestroy($im);

exit(0);
?>
