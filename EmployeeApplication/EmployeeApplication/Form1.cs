using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtboxRatePerHour.Text, out double ratePerHour) &&
                    double.TryParse(txtboxTotalHoursWorked.Text, out double totalHoursWorked))
                {
                    PartTimeEmployee employee = new PartTimeEmployee()
                    {
                        FirstName = txtboxFirstName.Text,
                        LastName = txtboxLastName.Text,
                        Department = txtboxDepartment.Text,
                        JobTitle = txtboxJobTitle.Text,
                        RatePerHour = ratePerHour,
                        TotalHoursWorked = totalHoursWorked,
                    };
                    double salary = employee.CalculateSalary();
                    DisplaySalary.Text = $"Salary: {salary.ToString("N2")}";
                    DisplayFirstName.Text = employee.FirstName;
                    DisplayLastName.Text = employee.LastName;
                }
                else
                {
                    MessageBox.Show("Invalid input. Please enter valid numbers for Rate Per Hour and Total Hours Worked.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}