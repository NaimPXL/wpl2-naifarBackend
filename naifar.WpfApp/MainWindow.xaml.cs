using naifar.Application.Framework;
using naifar.Application.Services;
using naifar.Domain;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace naifar.WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string _connectionString;

        public MainWindow()
        {
            InitializeComponent();

            var dir = Environment.CurrentDirectory;
            var file = "ConnectionString.txt";
            var fileName = System.IO.Path.Combine(dir, file);
            if (File.Exists(fileName))
            {
                _connectionString = File.ReadAllText(fileName);
                StudentService studentService = new StudentService(_connectionString);
                SelectResult<Student> selectResult = studentService.GetStudents();
                if (selectResult.Errors.Count > 0)
                {
                    foreach (string error in selectResult.Errors)
                    {
                        MessageBox.Show(error);
                    }
                }

                else
                {
                    studentsListBox.ItemsSource = selectResult.Rows;
                }
            }


        }
    }
}