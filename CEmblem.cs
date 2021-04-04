using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДодатковеЗавдання
{
    class CEmblem
    {
        private int x = 0, y = 0;
        private int[] size = new int[] { 100, 100 };
        private int numberChange = 4;

        private Color backColor = Color.White;
        private Color figure = Color.Blue;
        private Pen pen;

        private Random random = new Random();
        private string messageBox = "Фігура не може знаходитися за межами границь!";

        public CEmblem() { }        

        public PictureBox CreateFigure(PictureBox pictureBox)
        {            
            pen = new Pen(figure, 1);
            Bitmap bmp = new Bitmap(101, 101);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.DrawRectangle(pen, x, y, size[0], size[1]);

            Point[] PointsTriangle = new Point[3];

            PointsTriangle[0] = new Point(x + 50, y);
            PointsTriangle[1] = new Point(x + 15, y + size[1] - 15);
            PointsTriangle[2] = new Point(x + size[0] - 15, y + size[1] - 15);

            graphics.DrawPolygon(pen, PointsTriangle);            

            graphics.DrawEllipse(pen, x, y, 100, 100);

            pictureBox = new PictureBox();
            pictureBox.Location = new Point(random.Next(15, 485), random.Next(15, 545));
            pictureBox.Size = new Size(101, 101);
            pictureBox.BackColor = backColor;
            pictureBox.Image = bmp;
            return pictureBox;
        }


        public PictureBox ChangeFigureIncrement(PictureBox pictureBox)
        {
            if (pictureBox.Location.X + pictureBox.Size.Width + numberChange <= 481 + 90 && pictureBox.Location.Y + pictureBox.Size.Height + numberChange <= 541 + 90)
            {
                pen = new Pen(figure, 1);
                Bitmap bmp = new Bitmap(pictureBox.Size.Width + numberChange, pictureBox.Size.Height + numberChange);
                Graphics graphics = Graphics.FromImage(bmp);
                graphics.DrawRectangle(pen, x, y, pictureBox.Size.Width + numberChange - 1, pictureBox.Size.Height + numberChange - 1);

                Point[] PointsTriangle = new Point[3];

                PointsTriangle[0] = new Point(x + (pictureBox.Size.Width / 2) + 2, y + 1);
                PointsTriangle[1] = new Point(x + pictureBox.Size.Width / 7 + numberChange, y + pictureBox.Size.Height - (pictureBox.Size.Height / 7 + 1) + numberChange);
                PointsTriangle[2] = new Point(x + pictureBox.Size.Width - (pictureBox.Size.Width / 7), y + pictureBox.Size.Height - (pictureBox.Size.Height / 7 + 1) + numberChange);

                graphics.DrawPolygon(pen, PointsTriangle);

                graphics.DrawEllipse(pen, x, y, pictureBox.Size.Width + numberChange - 1, pictureBox.Size.Height + numberChange - 1);

                pictureBox.Size = new Size(pictureBox.Size.Width + numberChange, pictureBox.Size.Height + numberChange);
                pictureBox.BackColor = backColor;
                pictureBox.Image = bmp;
            }
            else
            {
                MessageBox.Show(messageBox);
            }

            return pictureBox;
        }

        public PictureBox ChangeFigureDecrement(PictureBox pictureBox)
        {
            try
            {
                pen = new Pen(figure, 1);
                Bitmap bmp = new Bitmap(pictureBox.Size.Width - numberChange, pictureBox.Size.Height - numberChange);
                Graphics graphics = Graphics.FromImage(bmp);
                graphics.DrawRectangle(pen, x, y, pictureBox.Size.Width - numberChange - 1, pictureBox.Size.Height - numberChange - 1);

                Point[] PointsTriangle = new Point[3];

                PointsTriangle[0] = new Point(x + (pictureBox.Size.Width / 2) - 2, y + 1);
                PointsTriangle[1] = new Point(x + pictureBox.Size.Width / 7 + 3, y + pictureBox.Size.Height - (pictureBox.Size.Height / 7 + 1));
                PointsTriangle[2] = new Point(x + pictureBox.Size.Width - (pictureBox.Size.Width / 7) - numberChange - 3, pictureBox.Size.Height - (pictureBox.Size.Height / 7 + 1));

                graphics.DrawPolygon(pen, PointsTriangle);

                graphics.DrawEllipse(pen, x, y, pictureBox.Size.Width - numberChange, pictureBox.Size.Height - numberChange);

                pictureBox.Size = new Size(pictureBox.Size.Width - numberChange, pictureBox.Size.Height - numberChange);
                pictureBox.BackColor = backColor;
                pictureBox.Image = bmp;
            }
            catch
            {
                MessageBox.Show("Зменшувати фігуру більше не можна!");
            }
            
            return pictureBox;
        }

        public PictureBox moveUp(PictureBox pictureBox)
        {
            if (pictureBox.Location.Y >= 19)
            {
                pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y - numberChange);
            }
            else
            {
                MessageBox.Show(messageBox);
            }
            
            return pictureBox;
        }

        public PictureBox moveDown(PictureBox pictureBox)
        {
            if (pictureBox.Location.Y + pictureBox.Size.Height <= 541 + 90)
            {
                pictureBox.Location = new Point(pictureBox.Location.X, pictureBox.Location.Y + numberChange);
            }
            else
            {
                MessageBox.Show(messageBox);
            }
    
            return pictureBox;
        }

        public PictureBox moveLeft(PictureBox pictureBox)
        {
            if (pictureBox.Location.X >= 19)
            {
                pictureBox.Location = new Point(pictureBox.Location.X - numberChange, pictureBox.Location.Y);
            }
            else
            {
                MessageBox.Show(messageBox);
            }
            
            return pictureBox;
        }

        public PictureBox moveRight(PictureBox pictureBox)
        {
            if (pictureBox.Location.X + pictureBox.Width <= 481 + 90)
            {
                pictureBox.Location = new Point(pictureBox.Location.X + numberChange, pictureBox.Location.Y);
            }
            else
            {
                MessageBox.Show(messageBox);
            }
            
            return pictureBox;
        }

        public PictureBox rotateLeft(PictureBox pictureBox)
        {
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox.Refresh();
            return pictureBox;
        }

        public PictureBox rotateRight(PictureBox pictureBox)
        {
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox.Refresh();
            return pictureBox;
        }

        public PictureBox changeColorFigure(PictureBox pictureBox, Color color)
        {            
            pen = new Pen(color, 1);
            Bitmap bmp = new Bitmap(pictureBox.Size.Height, pictureBox.Size.Width);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.DrawRectangle(pen, x, y, pictureBox.Size.Height - 1, pictureBox.Size.Width - 1);

            Point[] PointsTriangle = new Point[3];

            PointsTriangle[0] = new Point(x + (pictureBox.Size.Width / 2) - 1, y + 1);
            PointsTriangle[1] = new Point(x + pictureBox.Size.Width / 7 + 1, y + pictureBox.Size.Height - (pictureBox.Size.Height / 7) - 1);
            PointsTriangle[2] = new Point(x + pictureBox.Size.Width - (pictureBox.Size.Width / 7) - 2, pictureBox.Size.Height - (pictureBox.Size.Height / 7) - 1);

            graphics.DrawPolygon(pen, PointsTriangle);

            graphics.DrawEllipse(pen, x, y, pictureBox.Size.Height - 1, pictureBox.Size.Width - 1);

            pictureBox.Size = new Size(pictureBox.Size.Height, pictureBox.Size.Width);
            pictureBox.BackColor = backColor;
            pictureBox.Image = bmp;

            return pictureBox;
        }
    }
}
