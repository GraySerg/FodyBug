using System;

namespace FodyDelete
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class ClientData
    {
        public string Name { get; set; }
    }
}
