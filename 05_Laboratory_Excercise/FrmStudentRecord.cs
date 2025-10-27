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
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void bntUpload_Click(object sender, EventArgs e)
        {
            lvShowText.Items.Clear();
            MessageBox.Show("Successfully Uploaded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bntregister_Click(object sender, EventArgs e)
        {
            FrmRegistration registrationForm = new FrmRegistration();
            registrationForm.Show();
            this.Hide();

        }
        private void bntFind_Click(object sender, EventArgs e)
        {
            lvShowText.Items.Clear();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Find Student Record File";
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

              
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        var studentItems = System.IO.File.ReadLines(filePath)
                          
                            .Select(line => line.Split(',')) 
                            .Where(parts => parts.Length > 0 && !string.IsNullOrWhiteSpace(parts[0])) 
                            .Select(parts =>
                            {
                               
                                ListViewItem item = new ListViewItem(parts[0].Trim());

                                for (int i = 1; i < parts.Length; i++)
                                {
                                    item.SubItems.Add(parts[i].Trim());
                                }
                                return item; 
                            });

                        
                        lvShowText.Items.AddRange(studentItems.ToArray());

                        MessageBox.Show("File found and data loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Error reading file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        
                        MessageBox.Show("An unexpected error occurred (Check file format!): " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("File search cancelled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
    

