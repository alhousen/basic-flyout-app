using System.ComponentModel;
using Xamarin.Forms;
using yousif_s.ViewModels;

namespace yousif_s.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}