using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace GitHubActionsWpfDemo
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private readonly Model model;

        private int _Input = 5;
        public int Input
        {
            get => _Input;
            set
            {
                if (_Input == value)
                    return;
                _Input = value;
                RaisePropertyChanged();
                RaisePropertyChanged(nameof(Output));
            }
        }

        public int Output => model.Calc(Input);

        public MainWindowViewModel() : this(App.Services.GetService<Model>()!) { }
        public MainWindowViewModel(Model model)
        {
            this.model = model;
        }
    }
}
