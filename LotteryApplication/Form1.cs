using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryApplication
{
    public partial class mainForm : Form
    {
        private string defaultFilePath;
        private List<EmployeeData> listEmployeeData = new List<EmployeeData>();
        private Timer shuffleTimer = new Timer();
        private Random random = new Random();

        public mainForm()
        {
            InitializeComponent();

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            defaultFilePath = Path.Combine(appDirectory, "FileData", "employee_list.xlsx");

            // Configure the timer
            shuffleTimer.Interval = 30;  // Set the interval in milliseconds (adjust as needed)
            shuffleTimer.Tick += ShuffleTimer_Tick;
        }

        private void ShuffleTimer_Tick(object sender, EventArgs e)
        {
            // Shuffle the list
            ShuffleList(listEmployeeData);

            if (listEmployeeData.Count > 0)
            {
                txt_employee_no.Text = listEmployeeData[0].EmployeeNumber;
                txt_employee_name.Text = listEmployeeData[0].EmployeeName;
                txt_department.Text = listEmployeeData[0].Department;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            LoadEmployeeNumbers();

            // Start the timer to simulate shuffling
            shuffleTimer.Start();

            btn_select_winner.Enabled = true;
        }

        private void LoadEmployeeNumbers()
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(defaultFilePath)))
            {
                var worksheet = package.Workbook.Worksheets[0];
                var startCell = worksheet.Cells["A2"];
                var endCell = worksheet.Dimension.End;

                listEmployeeData = new List<EmployeeData>();

                for (int row = startCell.Start.Row; row <= endCell.Row; row++)
                {
                    var employeeNumber = worksheet.Cells[row, 1].Text;
                    var employeeName = worksheet.Cells[row, 2].Text;
                    var department = worksheet.Cells[row, 3].Text;
                    var status = worksheet.Cells[row, 4].Text;

                    if (!string.IsNullOrEmpty(employeeName) && !string.IsNullOrEmpty(department))
                    {
                        if (status != "Selected")
                        {
                            listEmployeeData.Add(new EmployeeData
                            {
                                EmployeeNumber = employeeNumber,
                                EmployeeName = employeeName,
                                Department = department
                            });
                        }
                    }
                }
               
            }
        }

        private void btn_select_winner_Click(object sender, EventArgs e)
        {
            if (listEmployeeData != null && listEmployeeData.Count > 0)
            {
                // Stop the shuffling timer
                shuffleTimer.Stop();

                // Randomly select an employee
                int randomIndex = random.Next(0, listEmployeeData.Count);
                EmployeeData selectedEmployee = listEmployeeData[randomIndex];

                using (var newPackage = new ExcelPackage(new FileInfo(defaultFilePath)))
                {
                    var worksheet = newPackage.Workbook.Worksheets[0];
                    if (worksheet != null)
                    {
                        var startCell = worksheet.Cells["A2"];

                        // Update the status in the Excel file
                        var rowToUpdate = worksheet.Cells["A:A"].FirstOrDefault(cell => cell.Text == selectedEmployee.EmployeeNumber)?.Start.Row;

                        if (rowToUpdate != null)
                        {
                            worksheet.Cells[rowToUpdate.Value, 4].Value = "Selected";

                            // Save the changes to the file
                            newPackage.Save();

                            // Display the selected employee's data
                            txt_employee_no.Text = selectedEmployee.EmployeeNumber;
                            txt_employee_name.Text = selectedEmployee.EmployeeName;
                            txt_department.Text = selectedEmployee.Department;

                            btn_select_winner.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Employee not found in the worksheet.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Worksheet is null.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No employee data available.");
            }
        }

        private void ShuffleList<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public class EmployeeData
        {
            public string EmployeeNumber { get; set; }
            public string EmployeeName { get; set; }
            public string Department { get; set; }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
