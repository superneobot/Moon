using System.Drawing;
using System.Windows.Forms;

namespace Lib
{
    public class MoonPlayList : ListBox
    {
        //вспомогательные переменные для отрисовки
        int x, y, itemWidth, itemHeight;
        public MoonPlayList()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ItemHeight = 32;
            this.Font = new Font("Motiva Sans", 8);
            this.ForeColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
        }


        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            //если это элемент
            if (e.Index > -1)
            {
                //задаем высоту
                e.ItemHeight = 50;
                //ширину
                e.ItemWidth = Width;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(new Pen(Brushes.Red), ClientRectangle.Width, ClientRectangle.Height, Width - 5, Height - 5);
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (e.Index <= -1 || this.Items.Count == 0)
                return;

            string item_text = Items[e.Index].ToString();

            //формат строки для рисования текста
            StringFormat sf = new StringFormat();
            //формат выставляем по центру
            sf.Alignment = StringAlignment.Near;
            sf.FormatFlags = StringFormatFlags.DisplayFormatControl;

            //создаем обычную кисть с заданным цветом
            Brush textBrush = new SolidBrush(Color.Black);
            Brush bgBrush = new SolidBrush(Color.FromArgb(30, 30, 30));

            //определяем координаты элемента в списке
            //т.к. для каждого элемента они разные
            x = e.Bounds.X;
            y = e.Bounds.Y;

            //также определяем его ширину и высоту
            itemWidth = e.Bounds.Width;
            itemHeight = e.Bounds.Height;

            if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)//если активный
            {
                //рисуем выбранный элемент
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(60, 60, 60)), x + 1, y + 1,
                    itemWidth - 1, itemHeight - 1);

                //рисуем текст элемента
                e.Graphics.DrawString(item_text, Font, new SolidBrush(Color.WhiteSmoke),
                    new Rectangle(5, y + 15, itemWidth, 20), sf);
            }
            else // если не активный
            {
                //заполняем прямоугольник выбранным цветом
                e.Graphics.FillRectangle(bgBrush, x, y, itemWidth, itemHeight + 1);

                //пишем текст
                e.Graphics.DrawString(item_text, Font, textBrush,
                    new Rectangle(5, y + 15, itemWidth, 20), sf);
            }
        }

        public class Mp3File
        {
            string Title { get; set; }
            string Artist { get; set; }
            Image Poster { get; set; }
            string Duration { get; set; }
            public Mp3File()
            {
                this.Title = Title;
                this.Artist = Artist;
                this.Duration = Duration;
                this.Poster = Poster;
            }
        }
    }
}