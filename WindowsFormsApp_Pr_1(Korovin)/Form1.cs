using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Pr_1_Korovin_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод проверяет значения и создаёт экземпляр класса
        /// Обязательная переменная конструктора.
        /// </summary>
        public async void Calc()  // async - это модификатор метода, который указывает, что метод содержит асинхронный код.
        {

            ErrorProvider errorProvider = new ErrorProvider();
            MedicalInstitution medicalInstitution = new MedicalInstitution();

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider.SetError(textBox1, "Поле не должно быть пустым");
                await Task.Delay(2222); // Делей нужен для того, чтобы через определённое время удалялось сообщение об ошибке // await - это оператор, который используется внутри асинхронных методов для ожидания завершения асинхронных операций.
                errorProvider.SetError(textBox1, "");
            }
            else if (Int32.TryParse(textBox1.Text, out int a))
            {
                if (a < 0 || a >= 120)
                {
                    errorProvider.SetError(textBox1, "Введите адекватное число.");
                    await Task.Delay(2222);
                    errorProvider.SetError(textBox1, "");
                }
                else
                {
                    medicalInstitution.MedicalInstitution1(a);
                    int accept = medicalInstitution.MakeAnAppointment(a);
                    int notAccept = medicalInstitution.DoNotMakeAnAppointment(a);
                    textBox2.Text = $"{accept}";
                    textBox3.Text = $"{notAccept}";
                }
            }
            else
            {
                errorProvider.SetError(textBox1, "Введите целое число");
                await Task.Delay(2222);
                errorProvider.SetError(textBox1, "");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            Calc();
        }

        private void AboutProgrammMenuTools_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void ExitMenuTools_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeleteMenuTools_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            Calc();
        }
    }
}
