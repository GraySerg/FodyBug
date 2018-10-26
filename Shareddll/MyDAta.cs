using System;

namespace Shareddll
{
    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class MyData
    {
        public string Name { get; set; }
    }
}
