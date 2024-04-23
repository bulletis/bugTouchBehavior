using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bugTouchBehavior
{
    public class DebugObservableCollection<T> : ObservableCollection<T> where T : class
    {
        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine($"<===========Collection Count Changed: {this.Count}==============>");
            base.OnCollectionChanged(e);
        }
    }
}
