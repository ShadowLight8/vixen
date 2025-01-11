using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VixenApplication.NodeEditor.Core;

namespace VixenApplication.NodeEditor.ViewModel
{
	internal class ControllerViewModel : ObservableObject
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set 
			{ 
				_name = value;
				OnPropertyChanged();
			}
		}
	}
}
