using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Final_exam.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChangeged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        protected virtual bool set<T>(ref T field, T value, [CallerMemberName] string PropertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChangeged(PropertyName);
            return true;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private bool _Disposed;

        protected virtual void Dispose(bool Disposed)
        {
            if (!Disposed || _Disposed) return;
            _Disposed = true;
            // Освобождение Упровляемых Ресурсов
        }
    }
}
