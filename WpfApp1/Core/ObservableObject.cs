using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1.Core
{

    class ObservableObject : INotifyPropertyChanged, IDisposable
    {
        private bool _disposed;


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            if (!_disposed)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }


        public void Dispose()
        {

            _disposed = true;
        }
    }
}
