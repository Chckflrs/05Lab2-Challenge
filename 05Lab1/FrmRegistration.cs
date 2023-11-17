using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _05Lab1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            String[] data =
            {
                $"Student Number: {studNo.Text}",
                $"Full Name: {lname.Text}, {fname.Text} {mi.Text}",
                $"Program: {program.Text}",
                $"Gender: {gender.Text}",
                $"Age: {age.Text}",
                $"Birthday: {bday.Value}",
                $"Contact Number: {cnum.Text}"
            };
            using (StreamWriter write = new StreamWriter($"{path}\\{studNo.Text}.txt"))
            {
                foreach (var item in data)
                {
                    write.WriteLine(item);
                }
            }
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord record = new FrmStudentRecord();
            record.ShowDialog();
        }
    }
}
