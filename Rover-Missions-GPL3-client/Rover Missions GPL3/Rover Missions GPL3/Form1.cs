using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
/*
 Source code: https://github.com/we6jbo/Rover-Missions-GPL3
Rover Missions GPL3 - This is the client side of the Rover Missions interface. The interface that allows the user to move the rover around and to perform missions.
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
*/

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rover_Missions_GPL3
{
    public partial class RoverMissionsGPL3 : Form
    {
        public RoverMissionsGPL3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openLicense_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Source code: https://github.com/we6jbo/Rover-Missions-GPL3\nRover Missions GPL3 - This is the client side of the Rover Missions interface. The interface that allows the user to move the rover around and to perform missions.\nCopyright(C) 2019  Jeremiah O'Neal and Natalie O'Neal\n\nThis program is free software: you can redistribute it and/or modify\nit under the terms of the GNU General Public License as published by\nthe Free Software Foundation, either version 3 of the License, or\n(at your option) any later version.\n\nThis program is distributed in the hope that it will be useful,\nbut WITHOUT ANY WARRANTY; without even the implied warranty of\nMERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the\nGNU General Public License for more details.\n\nYou should have received a copy of the GNU General Public License\nalong with this program.If not, see<https://www.gnu.org/licenses/>.");
        }
    }
}
