//    Copyright 2008 Wii Device Library authors
//
//    This file is part of Wii Device Library.
//
//    Wii Device Library is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    Wii Device Library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with Wii Device Library.  If not, see <http://www.gnu.org/licenses/>.

using System;
using WiiDeviceLibrary.Extensions;

namespace LinuxGUITest
{
	public partial class NunchukInformation : Gtk.Bin, IExtensionInformation
	{
		private NunchukExtension _Extension = null;
		
		public NunchukInformation(NunchukExtension extension)
		{
			_Extension = extension;
			this.Build();
		}
		
		public void Update()
		{
			// buttons
			entry1.Text = _Extension.Buttons.ToString();
			
			// analog stick
			entry2.Text = _Extension.Stick.Calibrated.X.ToString();
			entry3.Text = _Extension.Stick.Calibrated.Y.ToString();
			
			// accelerometers
			entryX.Text = _Extension.Accelerometer.Calibrated.X.ToString();
			entryY.Text = _Extension.Accelerometer.Calibrated.Y.ToString();
			entryZ.Text = _Extension.Accelerometer.Calibrated.Z.ToString();
		}
		
		public Gtk.Widget Widget
		{
			get { return this; }
		}
	}
}