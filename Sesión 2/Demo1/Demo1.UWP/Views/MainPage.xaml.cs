using Demo1.Portable.Models;
using Demo1.Portable.ViewModels;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Demo1.UWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private PrimerViewModel vm;

        public MainPage()
        {
            this.InitializeComponent();
            vm = new PrimerViewModel();
        }

        private void PersonaBtn_Click(object sender, RoutedEventArgs e)
        {
            Persona p = vm.GetPerson();
            NombreTxt.Text = p.Nombre;
            EdadTxt.Text = p.Edad.ToString();
        }
    }
}