using FirstAppliXamarinForm.classes;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstAppliXamarinForm.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EtudiantPage : ContentPage
    {
        public ObservableCollection<Etudiant> Items { get; set; }

        public EtudiantPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<Etudiant>
            {
                new Etudiant { Nom = "AUGER", Prenom = "Gwenaël", Specialite = "SLAM" },
                new Etudiant { Nom = "BAUDY", Prenom = "Camille", Specialite = "SLAM" },
                new Etudiant { Nom = "CHATEIGNER", Prenom = "Antonin", Specialite = "SLAM" },
                new Etudiant { Nom = "CHIPAUX", Prenom = "Laurent", Specialite = "SLAM" },
                new Etudiant { Nom = "DESSEIGNE", Prenom = "Yannis", Specialite = "SISR" },
                new Etudiant { Nom = "DUBUSSET", Prenom = "Fabio", Specialite = "SISR" },
                new Etudiant { Nom = "GALLICE", Prenom = "Matthieu", Specialite = "SLAM" },
                new Etudiant { Nom = "GARREAU", Prenom = "Enzo", Specialite = "SISR" },
                new Etudiant { Nom = "GUIGNARD", Prenom = "Alexandre", Specialite = "SLAM" },
                new Etudiant { Nom = "JEANNETTE", Prenom = "David", Specialite = "SLAM" },
                new Etudiant { Nom = "JOUANIN", Prenom = "Hugo", Specialite = "SISR" },
                new Etudiant { Nom = "NUNES", Prenom = "Quentin", Specialite = "SISR" },
                new Etudiant { Nom = "PAGE", Prenom = "Antoine", Specialite = "SISR" },
                new Etudiant { Nom = "PHILIPPE SAINT ANTOINE", Prenom = "Siméon", Specialite = "SLAM" },
                new Etudiant { Nom = "ROBIN", Prenom = "Melvin", Specialite = "SISR" },
                new Etudiant { Nom = "SABIR", Prenom = "Sofian", Specialite = "SISR" }
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            Etudiant Item = e.Item as Etudiant;

            await DisplayAlert(Item.Prenom + " " + Item.Nom, "Choix de sa spécialité " + Item.Specialite, "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
