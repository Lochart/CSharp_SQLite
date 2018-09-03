using System;
using Xamarin.Forms;

namespace SQLite
{
    public class Anime_Cell : ViewCell
    {
        private StackLayout view;

        public Anime_Cell()
        {
            view = new StackLayout();
            view.Orientation = StackOrientation.Horizontal;
            view.HorizontalOptions = LayoutOptions.FillAndExpand;
            view.VerticalOptions = LayoutOptions.FillAndExpand;
            view.Padding = 16;

            View = view;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                var source = BindingContext as Anime;

                var label = new Label { 
                    Text = source.Name,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    VerticalTextAlignment = TextAlignment.Center,
                    FontSize = 18,
                    TextColor = Color.Black
                };

                var view_Button = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.EndAndExpand,
                    Padding = new Thickness(0, 10, 0, 10)
                };

                var delete = Structure_Button.Custom_Button("Удалить");
                delete.Clicked += Delete_Anime;

                view_Button.Children.Add(delete);

                view.Children.Add(label);
                view.Children.Add(view_Button);
            }
        }

        /*
         * Удаление элемента
         */

        private void Delete_Anime(object sender, EventArgs e)
        {
            var source = (Anime)BindingContext;
            App.Database.Delete_Standart(source.Id);
            Main_Page.listview.ItemsSource = App.Database.Select_Standart();
        }
    }
}

