using System;
using Xamarin.Forms;

namespace SQLite
{
    public static class Structure_ListView
    {
        /*
         * Стандартная UI элемент список
         */

        public static ListView Custom_ListView(Type cell)
        {
            var listview = new ListView {
                BackgroundColor = Color.White,
                SeparatorColor = Color.Gray,
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(cell)
            };

            return listview;
        }
    }
}

