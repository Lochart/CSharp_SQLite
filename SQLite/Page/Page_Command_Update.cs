using System;

using Xamarin.Forms;

namespace SQLite
{
    public class Page_Command_Update : ContentPage
    {
        private Entry entry;
        private int id;

        public Page_Command_Update(int id, string name)
        {
            this.id = id;

            var view = new StackLayout();
            view.Padding = new Thickness(5, 20, 5, 20);
            view.Spacing = 10;

            entry = new Entry
            {
                Text = name,
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 14
            };

            var update_S = Structure_Button.Custom_Button("Обновить");
            update_S.Clicked += Update_S;

            view.Children.Add(entry);
            view.Children.Add(update_S);

            Content = view;
        }

        private void Update_S(object sender, EventArgs e)
        {
            var anime = new Anime();

            if (!string.IsNullOrEmpty(entry.Text))
            {
                anime.Name = entry.Text;
                anime.Id = id;


                /*
                * <summury>
                * Стандартная команда обвноление таблицы Update_Standart
                * SQL команда обвноление таблицы Update_SQL
                * Стандартная команда запрос вытаскивание данных Select_Standart
                * SQL команда запрос вытаскивание данных Select_SQL
                * </summur>
                */

                //App.Database.Update_Standart(anime);
                App.Database.Update_SQL(anime);

                //Main_Page.listview.ItemsSource = App.Database.Select_Standart();
                Main_Page.listview.ItemsSource = App.Database.Select_SQL();
            }

            this.Navigation.PopAsync();
        }
    }
}

