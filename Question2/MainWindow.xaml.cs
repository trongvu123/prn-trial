using Question2.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Question2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Prn212TrialContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new Prn212TrialContext();
        }

        private void DgData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(DgData.SelectedItem is Employee employee)
            {
                txtId.Text = employee.Id.ToString();
                txtName.Text = employee.Name;
                txtPhone.Text = employee.Phone; 
                txtDb.Text = employee.Dob.ToString();
                txtIdNum.Text = employee.Idnumber;
                if (employee.Gender.ToLower() == "male")
                {
                    trdMale.IsChecked = true;
                    trdFemale.IsChecked = false;
                }
                else if (employee.Gender.ToLower() == "female")
                {
                    trdMale.IsChecked = false;
                    trdFemale.IsChecked = true;
                }

            }
        }

        private void DgData_Loaded(object sender, RoutedEventArgs e)
        {
            var listEmployee = _context.Employees.ToList();
            DgData.ItemsSource = listEmployee;  
        }
        public void LoadData()
        {
            var listEmployee = _context.Employees.ToList();
            DgData.ItemsSource = listEmployee;
        }
        private void ReFreshBtn_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtIdNum.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtDb.Text = string.Empty;
            trdMale.IsChecked = true;
            trdFemale.IsChecked = false;
        }

        private void AddBtn(object sender, RoutedEventArgs e)
        {
            var employee = new Employee
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Gender = trdMale.IsChecked == true ? "Male" : "Female",
                Dob = DateOnly.Parse(txtDb.Text),
                Idnumber = txtIdNum.Text,
            };
            _context.Employees.Add(employee);   
            _context.SaveChanges();
            LoadData();
        }

        private void EditBtn(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtId.Text.Length>0)
                {
                    var employee = _context.Employees.Where(e=>e.Id == int.Parse(txtId.Text)).FirstOrDefault();
                    if (employee != null)
                    {
                        employee.Name = txtName.Text;
                        employee.Phone = txtPhone.Text;
                        employee.Gender = trdMale.IsChecked == true ? "Male" : "Female";
                        employee.Dob = DateOnly.Parse(txtDb.Text);
                        employee.Idnumber = txtIdNum.Text;
                        _context.Employees.Update(employee);
                        _context.SaveChanges();
                        LoadData();
                    }
                }
            }catch (Exception ex)
            {

            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                if(txtId.Text.Length>0)
                {
                    var employee = _context.Employees.Where(e => e.Id == int.Parse(txtId.Text)).FirstOrDefault();
                    _context.Employees.Remove(employee);
                    _context.SaveChanges();
                    LoadData();
                }
            }catch(Exception ex)
            {

            }

        }
    }
}