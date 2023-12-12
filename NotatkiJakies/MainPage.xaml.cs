using NotatkiJakies.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NotatkiJakies
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<NoteModel> noteList= new ObservableCollection<NoteModel>();
        public MainPage()
        {
            InitializeComponent();
            noteList.Add(new NoteModel()
            {
                ID=Guid.NewGuid(),
                Title="cos1",
                Description="opis1",
            });
            noteList.Add(new NoteModel()
            {
                ID = Guid.NewGuid(),
                Title = "cos2",
                Description = "opis2",
            });
            NoteListXAML.ItemsSource=noteList;
        }

        private void Add_Clicked(object sender, EventArgs e)
        {

        }

        private void Delete_Clicked(object sender, EventArgs e)
        {

        }

        private void Edit_Clicked(object sender, EventArgs e)
        {

        }
    }
}
