using Xamarin.Forms;

namespace SQLite
{
    public class Structure_Button
    {
        /*
         * Стандартная UI элемент кнопка
         */

        public static Button Custom_Button(string text)
        {
            var button = new Button{
                Text = text,
                TextColor = Color.White,
                BackgroundColor = Color.Black,
                CornerRadius = 25
            };

            return button;
        }
    }
}

