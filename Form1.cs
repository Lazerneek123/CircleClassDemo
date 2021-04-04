using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДодатковеЗавдання
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        
        private PictureBox[] pictureBox = new PictureBox[1];        
        
        private int k = 0;
        private CEmblem cEmblem;


        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;     // забороняє натискання кнопки "розгорнути"
            cEmblem = new CEmblem();                        
        }

        private Random random = new Random();

        private void createObject_Click(object sender, EventArgs e)
        {

            pictureBox[k] = cEmblem.CreateFigure(pictureBox[k]);
            Controls.Add(pictureBox[k]);
            pictureBox[k].BringToFront();  // ставить фігуру на передній план

            listObjekt.Items.Add("Фігура №" + (k + 1));
            
            k++;
            Array.Resize(ref pictureBox, k + 1);
        }

        private string messageBox = "Виберіть фігуру!";

        private void hideObject_Click(object sender, EventArgs e)
        {
            if (listObjekt.Text == "")
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                pictureBox[listObjekt.SelectedIndex].Visible = false;
               
            }
        }

        private void showObject_Click(object sender, EventArgs e)
        {
            if (listObjekt.Text == "")
            {
                MessageBox.Show(messageBox);
            }
            else
            {                
                pictureBox[listObjekt.SelectedIndex].Visible = true;
            }
        }
        
        private void buttonMagnification_Click(object sender, EventArgs e)
        {
            if (listObjekt.Text == "")
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                pictureBox[listObjekt.SelectedIndex] = cEmblem.ChangeFigureIncrement(pictureBox[listObjekt.SelectedIndex]);               

            }
        }

        private void buttonReduction_Click(object sender, EventArgs e)
        {
            if (listObjekt.Text == "")
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                pictureBox[listObjekt.SelectedIndex] = cEmblem.ChangeFigureDecrement(pictureBox[listObjekt.SelectedIndex]);
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (listObjekt.Text == "")
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                pictureBox[listObjekt.SelectedIndex] = cEmblem.moveUp(pictureBox[listObjekt.SelectedIndex]);
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (listObjekt.Text == "")
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                pictureBox[listObjekt.SelectedIndex] = cEmblem.moveRight(pictureBox[listObjekt.SelectedIndex]);
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (listObjekt.Text == "")
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                pictureBox[listObjekt.SelectedIndex] = cEmblem.moveDown(pictureBox[listObjekt.SelectedIndex]);
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (listObjekt.Text == "")
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                pictureBox[listObjekt.SelectedIndex] = cEmblem.moveLeft(pictureBox[listObjekt.SelectedIndex]);
            }
        }

        private void buttonTurnRight_Click(object sender, EventArgs e)
        {
            if (listObjekt.Text == "")
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                pictureBox[listObjekt.SelectedIndex] = cEmblem.rotateRight(pictureBox[listObjekt.SelectedIndex]);
            }
        }

        private void buttonTurnLeft_Click(object sender, EventArgs e)
        {
            if (listObjekt.Text == "")
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                pictureBox[listObjekt.SelectedIndex] = cEmblem.rotateLeft(pictureBox[listObjekt.SelectedIndex]);                
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (listObjekt.Text == "")
            {
                MessageBox.Show(messageBox);
            }
            else
            {
                colorDialog1.ShowDialog();
                pictureBox[listObjekt.SelectedIndex] = cEmblem.changeColorFigure(pictureBox[listObjekt.SelectedIndex], colorDialog1.Color);
            }            
        }

        private void buttonFront_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox[listObjekt.SelectedIndex].BringToFront();
            }
            catch
            {
                MessageBox.Show(messageBox);
            }
            
        }
    }
}
