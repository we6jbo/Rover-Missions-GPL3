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
echo '<br>';
sleep(5);
$content = file_get_contents("http://we6jbobbsdotorg.duckdns.org/RoverMissionsGPL3-pi/camera/small.php");


if (isset($_GET['goingforward'])) {
file_get_contents("http://we6jbobbsdotorg.duckdns.org/RoverMissionsGPL3-pi/gpio/goforwards.php");
//Store in the filesystem.
$fp = fopen("small.jpg", "w");
fwrite($fp, $content);
fclose($fp);
}
else if (isset($_GET['goingbackwards'])) {
file_get_contents("http://we6jbobbsdotorg.duckdns.org/RoverMissionsGPL3-pi/gpio/gobackwards.php");
//Store in the filesystem.
$fp = fopen("small.jpg", "w");
fwrite($fp, $content);
fclose($fp);
}
else if (isset($_GET['goingbackwards'])) {
echo "<b>You are not over a mining source!</b>";
}
echo '<br>
<br>
<button onclick="goingForward()">[Forward]</button>
<button onclick="goingBack()">[Reverse]</button>
<button onclick="goingForward()">[ Left ]</button>
<button onclick="goingBack()">[ Right ]</button>
<button onclick="analyze()">[Analyze]</button>
';

?>



<script type="text/javascript">
function goingForward() {
    location.href='RoverMissionsGPL3-controls.php?goingforward=1'
}
function goingBack() {
    location.href='RoverMissionsGPL3-controls.php?goingbackwards=1'
}
function analyze() {
    location.href='RoverMissionsGPL3-controls.php?analyze=1'
}
</script>

</html>
</body>
