<html>
<!--
This controls the survos to go in a direction.    
Copyright (C) 2019 Jeremiah ONeal and Natalie ONeal 

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

<body>
<?php
system("gpio -g mode 2 out");
system("gpio -g mode 4 out");

system("gpio -g write 2 0");
system("gpio -g write 4 0");

sleep(1);
system("gpio -g write 2 1");
system("gpio -g write 4 1");
echo "Done.";
?>
</body>
</html>
