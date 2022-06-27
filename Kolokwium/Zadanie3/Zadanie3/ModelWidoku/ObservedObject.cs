using System.ComponentModel;

public abstract class ObservedObject : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;
    protected void onPropertyChanged(params string[] własności)
    {
        if (PropertyChanged != null)
        {
            foreach (string nazwa in własności)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nazwa));
            }
        }
    }
}

