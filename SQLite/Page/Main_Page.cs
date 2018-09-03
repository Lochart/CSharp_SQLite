using Xamarin.Forms;

namespace SQLite
{
    public class Main_Page : ContentPage
    {
        public static ListView listview;

        public Main_Page()
        {
            var view = new StackLayout();

            listview = Structure_ListView.Custom_ListView(typeof(Anime_Cell));
            listview.ItemTapped += Item_Tapped;
            listview.ItemsSource = App.Database.Select_Standart();

            view.Children.Add(listview);

            var command = new ToolbarItem { 
                Text = "Добавить",
                Command = new Command(() => Add())
            };

            ToolbarItems.Add(command);
            Content = view;
        }

        /*
         * Выбранная ячейка
         */

        private void Item_Tapped(object sender, ItemTappedEventArgs e)
        {
            var source = e.Item as Anime;
            if (source == null)
                return;

            var page = new Page_Command_Update(source.Id, source.Name);

            Navigation.PushAsync(page);
        }

        /*
         * Страница добавление данных
         */

        private void Add()
        {
            var anime = new Anime();

            var command_Page = new Page_Command_Add();
            command_Page.BindingContext = anime;

            Navigation.PushAsync(command_Page);
        }
    }
}

