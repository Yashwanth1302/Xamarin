using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace listviewJson
{
    public partial class Startpage : ContentPage
    {
        StarterPageViewModel viewModel;
        public Startpage()
        {
            InitializeComponent();
            viewModel = new StarterPageViewModel();
            BindingContext = viewModel;

            UpdateList.Clicked += UpdateListView;
        }

        private async void UpdateListView(object sender, EventArgs e)
        {
            var remoteClient = new ListJson();
            viewModel.Studentlist = await remoteClient.GetConferences().ConfigureAwait(false);
        }
    }
}
