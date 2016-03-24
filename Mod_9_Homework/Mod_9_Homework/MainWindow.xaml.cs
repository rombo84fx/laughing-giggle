using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = null;
        int index = 0;

        public MainWindow()
        {
            InitializeComponent();
            this.students = new List<Student>();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student(txtFirstName.Text, txtLastName.Text, txtCity.Text);
            this.students.Add(student);
            this.index = this.students.Count;
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            MessageBox.Show("Student created");
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (this.students.Count != 0)
            {
                if (this.index == 0)
                {
                    this.index = this.students.Count - 1;
                }
                else
                {
                    this.index--;
                }
                populateTextBoxes(this.students[this.index]);
            }
            else
            {
                MessageBox.Show("There are no students in the collection.");
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (students.Count != 0)
            {
                if (this.index >= this.students.Count - 1)
                {
                    this.index = 0;
                }
                else
                {
                    this.index++;
                }
                populateTextBoxes(this.students[this.index]);
            }
            else
            {
                MessageBox.Show("There are no students in the collection.");
            }
        }

        private void populateTextBoxes(Student student)
        {
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtCity.Text = student.City;
        }
    }
}