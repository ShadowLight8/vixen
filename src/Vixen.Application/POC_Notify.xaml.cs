using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Nodify;
using Vixen.Module.Controller;
using Vixen.Services;
using Vixen.Sys;
using Vixen.Sys.Output;

namespace VixenApplication
{
	/// <summary>
	/// Interaction logic for POC_Notify.xaml
	/// </summary>
	public partial class POC_Notify : Window
	{
		public POC_Notify()
		{
			InitializeComponent();
		}
	}
		public class DelegateCommand<T> : ICommand
	{
		private readonly Action<T> _action;
		private readonly Func<T, bool>? _condition;

		public event EventHandler? CanExecuteChanged;

		public DelegateCommand(Action<T> action, Func<T, bool>? executeCondition = default)
		{
			_action = action ?? throw new ArgumentNullException(nameof(action));
			_condition = executeCondition;
		}

		public bool CanExecute(object? parameter)
		{
			if (parameter is T value)
			{
				return _condition?.Invoke(value) ?? true;
			}

			return _condition?.Invoke(default!) ?? true;
		}

		public void Execute(object? parameter)
		{
			if (parameter is T value)
			{
				_action(value);
			}
			else
			{
				_action(default!);
			}
		}

		public void RaiseCanExecuteChanged()
			=> CanExecuteChanged?.Invoke(this, new EventArgs());
	}

	public class ConnectionViewModel
	{
		public ConnectionViewModel(ConnectorViewModel source, ConnectorViewModel target)
		{
			Source = source;
			Target = target;

			Source.IsConnected = true;
			Target.IsConnected = true;
		}
		
		public ConnectorViewModel Source { get; set; }
		public ConnectorViewModel Target { get; set; }
	}

	public class ConnectorViewModel : INotifyPropertyChanged
	{
		private System.Windows.Point _anchor;
		public System.Windows.Point Anchor
		{
			set
			{
				_anchor = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Anchor)));
			}
			get => _anchor;
		}

		private bool _isConnected;
		public bool IsConnected
		{
			set
			{
				_isConnected = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsConnected)));
			}
			get => _isConnected;
		}

		public string Title { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
	}

	public class NodeViewModel : INotifyPropertyChanged
	{
		private System.Windows.Point _location;
		public System.Windows.Point Location
		{
			set
			{
				_location = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Location)));
			}
			get => _location;
		}

		public event PropertyChangedEventHandler PropertyChanged;
	
		public string Title { get; set; }

		public ObservableCollection<ConnectorViewModel> Input { get; set; } = new ObservableCollection<ConnectorViewModel>();
		public ObservableCollection<ConnectorViewModel> Output { get; set; } = new ObservableCollection<ConnectorViewModel>();
	}

	public class PendingConnectionViewModel
	{
		private readonly EditorViewModel _editor;
		private ConnectorViewModel _source;

		public PendingConnectionViewModel(EditorViewModel editor)
		{
			_editor = editor;
			StartCommand = new DelegateCommand<ConnectorViewModel>(source => _source = source);
			FinishCommand = new DelegateCommand<ConnectorViewModel>(target =>
			{
				if (target != null)
					_editor.Connect(_source, target);
			});
		}

		public ICommand StartCommand { get; }
		public ICommand FinishCommand { get; }
	}

	public class EditorViewModel
	{
		public PendingConnectionViewModel PendingConnection { get; }
		public ICommand DisconnectConnectorCommand { get; }
		public ObservableCollection<NodeViewModel> Nodes { get; } = new ObservableCollection<NodeViewModel>();
		public ObservableCollection<ConnectionViewModel> Connections { get; } = new ObservableCollection<ConnectionViewModel>();

		public EditorViewModel()
		{
			DisconnectConnectorCommand = new DelegateCommand<ConnectorViewModel>(connector =>
			{
				var connection = Connections.First(x => x.Source == connector || x.Target == connector);
				connection.Source.IsConnected = false;  // This is not correct if there are multiple connections to the same connector
				connection.Target.IsConnected = false;
				Connections.Remove(connection);
			});

			PendingConnection = new PendingConnectionViewModel(this);
			var welcome = new NodeViewModel
			{
				Title = "Welcome",
				Input = new ObservableCollection<ConnectorViewModel>
			{
				new ConnectorViewModel
				{
					Title = "In"
				}
			},
				Output = new ObservableCollection<ConnectorViewModel>
			{
				new ConnectorViewModel
				{
					Title = "Out"
				}
			},
				Location = new System.Windows.Point(10, 10)
			};

			var nodify = new NodeViewModel
			{
				Title = "To Nodify",
				Input = new ObservableCollection<ConnectorViewModel>
			{
				new ConnectorViewModel
				{
					Title = "In"
				}
			},
				Location = new System.Windows.Point(200, 50)
			};

			//Nodes.Add(welcome);
			//Nodes.Add(nodify);

			// Gets the types on controllers
			foreach (KeyValuePair<Guid, string> kvp in ApplicationServices.GetAvailableModules<IControllerModuleInstance>())
			{

			}

			int yOffset = 10;
			foreach (var item in VixenSystem.OutputControllers)
			{
				var controllerNode = new NodeViewModel
				{
					Title = item.Name,
					Output = new ObservableCollection<ConnectorViewModel>
					{
						new ConnectorViewModel
						{
							Title = item.OutputCount.ToString()
						}
					},
					Location = new System.Windows.Point(10, yOffset)
				};
				Nodes.Add(controllerNode);
				yOffset += 60;
			}

			yOffset = 10;
			foreach (ElementNode element in VixenSystem.Nodes.GetRootNodes())
			{
				var rootNode = new NodeViewModel
				{
					Title = element.Name,
					Input = new ObservableCollection<ConnectorViewModel>
					{
						new ConnectorViewModel
						{
							Title = element.Children.Count().ToString()
						}
					},
					Output = new ObservableCollection<ConnectorViewModel>
					{
						new ConnectorViewModel
						{
							Title = "Out"
						}
					},
					Location = new System.Windows.Point(200, yOffset)
				};
				Nodes.Add(rootNode);
				yOffset += 60;
			}

			//Connections.Add(new ConnectionViewModel(welcome.Output[0], nodify.Input[0]));
		}
		public void Connect(ConnectorViewModel source, ConnectorViewModel target)
		{
			Connections.Add(new ConnectionViewModel(source, target));
		}
	}
}
