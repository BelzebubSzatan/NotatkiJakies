﻿using NotatkiJakies.Model;
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

        public AddEditPage(ObservableCollection<NoteModel> list)
        {
            InitializeComponent();
            noteList = list;
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