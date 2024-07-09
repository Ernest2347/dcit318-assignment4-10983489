using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address_Book
{
    public partial class Form1 : Form
    {
        private List<Person> addressBook = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Name = nameTxt.Text,
                Email = emailTxt.Text,
                Phone = phoneNumberTxt.Text
            };
            addressBook.Add(person);
            MessageBox.Show("Entry saved successfully!");
            nameTxt.Clear();
            emailTxt.Clear();
            phoneNumberTxt.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
