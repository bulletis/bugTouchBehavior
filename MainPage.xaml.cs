using System.Collections.ObjectModel;

namespace bugTouchBehavior
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Person> Persons { get; set; } = new ObservableCollection<Person> { new Person(1), new Person(2), new Person(3), new Person(4), new Person(5), new Person(6) };
        public DebugObservableCollection<object> SelectedPersons { get; set; } = new DebugObservableCollection<object>() { };

        public MainPage()
        {
            this.BindingContext = this;

            InitializeComponent();
        }

    }

    public record Person(int Id);
}
