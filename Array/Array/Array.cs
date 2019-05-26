using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Array : Form
    {
        int index=0;
        const int size = 10;
        int[] number = new int[size];

            //number[0] = 3;
            //number[5] = 4;
            //number[9] = 5;

        public Array()
        {
            InitializeComponent();


           
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int[] number = new int[size];

            //number[0] = 3;
            //number[5] = 4;
            //number[9] = 5;

            //string message = " ";

            //for (int index = 0; index < size; index++)
            //{
            //    if (number[index] != 0)

            //        message = message + "Value at Index " + index + " is: " + number[index].ToString() + "\n";

            //}
            
            showRichTextBox.Text = Sh(); 

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           

            number[index] = Convert.ToInt32(addTextBox.Text);
            index++;

            //string message = " ";

            //for (int index = 0; index < size; index++)
            //{
            //    if (number[index] != 0)

            //        message = message + "Value at Index " + index + " is: " + number[index].ToString() + "\n";

            //}
           
            showRichTextBox.Text = Sh(); 


        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
           
            string message = " ";
            for (int index = 9; index >=0; index--)
            {
                if (number[index] != 0)

                    message = message + "Value at Index " + index + " is: " + number[index].ToString() + "\n";

            }
            showRichTextBox.Text =Sh()+ message;
        }

        private string Sh()
        {
            string message = " ";
            for (int index = 0; index < size; index++)
            {
                if (number[index] != 0)

                    message = message + "Value at Index " + index + " is: " + number[index].ToString() + "\n";

            }

            return message;
        }
    }
}
