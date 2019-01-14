<html>
<!-- This is the interface between the client and the RPi.
    Copyright (C) 2019  Jeremiah O'Neal and Natalie O'Neal

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
    -->
<meta http-equiv="cache-control" content="max-age=0">
<meta http-equiv="cache-control" content="no-cache">
<meta http-equiv="expires" content="-1">
<meta http-equiv="expires" content="Tue, 01 Jan 1980 11:00:00 GMT">
<meta http-equiv="pragma" content="no-cache">
<body>


<?php
//Get the file

$content = file_get_contents("http://we6jbobbsdotorg.duckdns.org/RoverMissionsGPL3-pi/camera/index.php");

//Store in the filesystem.
$fp = fopen("image1.jpg", "w");
fwrite($fp, $content);
fclose($fp);
echo '<img src="image1.jpg?rnd=' . microtime() . '" width = 1280 height = 720 alt="Rover">';


if (isset($_GET['goingforward'])) {
file_get_contents("http://we6jbobbsdotorg.duckdns.org/RoverMissionsGPL3-pi/gpio/goforwards.php");
}
if (isset($_GET['goingbackwards'])) {
file_get_contents("http://we6jbobbsdotorg.duckdns.org/RoverMissionsGPL3-pi/gpio/gobackwards.php");
}
?>
<br>
<br>
<button onclick="goingForward()">[Forward]</button>
<button onclick="goingBack()">[Reverse]</button>
<button onclick="goingForward()">[ Left ]</button>
<button onclick="goingBack()">[ Right ]</button>
<button onclick="goingForward()">[Analyze]</button>


<script type="text/javascript">
function goingForward() {
    location.href='RoverMissionsGPL3-web.php?goingforward=1'
}
function goingBack() {
    location.href='RoverMissionsGPL3-web.php?goingbackwards=1'
}
</script>

</html>
</body>
