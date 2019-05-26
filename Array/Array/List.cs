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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            string message = "";

            message = message + "ForEach\n";
            foreach (int number in numbers)
            {
                message = message + number +"\n";
            }

            showRichTextBox.Text = message;
            
            message = message + "For\n";
            for (int i=0; i<numbers.Count;i++)
            {
                message = message + numbers[i].ToString()+"\n";
            }
            showRichTextBox.Text = message;
        }
    }
}
