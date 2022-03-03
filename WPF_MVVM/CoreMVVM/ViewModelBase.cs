using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPF_MVVM.CoreMVVM
{
    public abstract class ViewModelBase : INotifyPropertyChanging, INotifyPropertyChanged
    {
        public event PropertyChangingEventHandler? PropertyChanging;
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanging([CallerMemberName] string propertyName = "")
        {
            //if (PropertyChanging != null)
            //{
            //    PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
            //}
            //PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

            PropertyChanging(this, new PropertyChangingEventArgs(propertyName));

        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            //if(PropertyChanged != null)
            //{
            //    //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            //}
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
