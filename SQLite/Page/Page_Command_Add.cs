using System;

using Xamarin.Forms;

namespace SQLite
{
    public class Page_Command_Add : ContentPage
    {
        private Entry entry;

        public Page_Command_Add()
        {
            var view = new StackLayout();
            view.Padding = new Thickness (5, 20, 5, 20);
            view.Spacing = 10;

            entry = new Entry
            {
                TextColor = Color.Black,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 14
            };

            var add_S = Structure_Button.Custom_Button("Добавить");
            add_S.Clicked += Add_S;

            view.Children.Add(entry);
            view.Children.Add(add_S);

            Content = view;
        }

        private void Add_S(object sender, EventArgs e)
        {
            var anime = (Anime)BindingContext;

            if (!string.IsNullOrEmpty(entry.Text))
            {
                anime.Name = entry.Text;
                App.Database.Insert_Standart(anime);

                /*
                * <summury>
                * Стандартная команда добавление в таблицу Insert_Standart
                * Стандартная команда запрос вытаскивание данных Select_Standart
                * SQL команда запрос вытаскивание данных Select_SQL
                * </summur>
                */

                //Main_Page.listview.ItemsSource = App.Database.Select_Standart();
                Main_Page.listview.ItemsSource = App.Database.Select_SQL();
            }

            this.Navigation.PopAsync();
        }
    }
}

