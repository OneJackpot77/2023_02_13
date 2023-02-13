using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kod_btn_Click(object sender, EventArgs e)
        {
            int seged = 3;
            string[] adatok;
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\hege.aron.VEREBELY\\source\\repos\\WinFormsApp1\\WinFormsApp1\\src\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    StreamReader reader = new StreamReader(fileStream);
                    while (!reader.EndOfStream)
                    {                        
                        fileContent = reader.ReadLine();
                       
                        label3.Text = fileContent;
                        seged++;
                        if (seged==4)
                        {
                            label4.Text = fileContent;
                        }
                        if (seged == 5)
                        {
                            label5.Text = fileContent;
                        }
                        if (seged == 6)
                        {
                            label6.Text = fileContent;
                        }
                        if (seged == 7)
                        {
                            label7.Text = fileContent;
                        }
                        if (seged == 8)
                        {
                            label8.Text = fileContent;
                        }
                    }
                    reader.Close();
                    list_list.Items.Add("Füstöl a mátrix");



                }
            }
            









        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }

        private void list_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}