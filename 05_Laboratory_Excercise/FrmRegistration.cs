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

namespace _05_Laboratory_Excercise
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmStudentRecord studentRecordForm = new FrmStudentRecord();
            studentRecordForm.Show();
        }

        private void w_Click(object sender, EventArgs e)
        {
            
            string studentNo = txtStudentNumber.Text.Trim(); 
            string program = cmbProgram.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string mi = txtMI.Text.Trim();
            string age = txtAge.Text.Trim();
            string gender = cmbGender.Text.Trim();
            string birthday = dtpBirthday.Value.ToShortDateString();
            string contactNo = txtContactNo.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(studentNo))
            {
                MessageBox.Show("Student Number cannot be empty. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStudentNumber.Focus();
                return;
            }

           
            string dataLine = $"{studentNo},{lastName},{firstName},{mi},{age},{gender},{program},{birthday},{contactNo}";

            try
            {
                string folderName = "StudentRecords";

                string folderPath = Path.Combine(Application.StartupPath, folderName);
                string fileName = $"{studentNo}.txt";
                string fullPath = Path.Combine(folderPath, fileName);

                
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

              
                File.WriteAllText(fullPath, dataLine);

               
                MessageBox.Show($"Student Record SAVED successfully!\nFile Path: {fullPath}",
                                 "Success",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Error saving record: {ex.Message}",
                                 "Error",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}
    

