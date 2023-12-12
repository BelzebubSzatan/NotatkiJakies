using NotatkiJakies.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NotatkiJakies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEditPage : ContentPage
    {
        ObservableCollection<NoteModel> noteList = new ObservableCollection<NoteModel>();
        NoteModel noteModel=new NoteModel();

        public AddEditPage(ObservableCollection<NoteModel> list)
        {
            InitializeComponent();
            noteList = list;
        }
        public AddEditPage(ObservableCollection<NoteModel> list,NoteModel model)
        {
            InitializeComponent();
            noteList=list;
            noteModel = model;
            TitleEntry.Text = noteModel.Title;
            DescriptionEntry.Text = noteModel.Description;
            Add.Clicked -= Add_Clicked;
            Add.Clicked += Edit_Clicked;
            Add.Text = "Edytuj";

        }
        private async void Edit_Clicked(object sender, EventArgs e)
        {
            noteModel.Title = TitleEntry.Text;
            noteModel.Description = DescriptionEntry.Text;
            int id=noteList.IndexOf(noteModel);
            noteList[id] = noteModel;
            await Navigation.PopToRootAsync();

        }
        private void Add_Clicked(object sender, EventArgs e)
        {
            NoteModel note = new NoteModel();
            note.ID=Guid.NewGuid();
            note.Title = TitleEntry.Text;
            note.Description = DescriptionEntry.Text;
            noteList.Add(note);
            Navigation.PopToRootAsync();

        }
    }
}