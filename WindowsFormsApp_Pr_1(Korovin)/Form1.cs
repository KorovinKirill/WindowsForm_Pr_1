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

            if (String.IsNullOrEmpty(numberOfPatients.Text))
            {
                errorProvider.SetError(numberOfPatients, "Поле не должно быть пустым");
                await Task.Delay(2222); // Delay нужен для того, чтобы через определённое время удалялось сообщение об ошибке // await - это оператор, который используется внутри асинхронных методов для ожидания завершения асинхронных операций.
                errorProvider.SetError(numberOfPatients, "");
            }
            else if (Int32.TryParse(numberOfPatients.Text, out int a))
            {
                if (a < 0 || a > 120)
                {
                    errorProvider.SetError(numberOfPatients, "Введите адекватное число (в диапазоне от 0 до 120).");
                    await Task.Delay(2222);
                    errorProvider.SetError(numberOfPatients, "");
                }
                else
                {
                    medicalInstitution.MedicalInstitution1(a);
                    int accept = medicalInstitution.MakeAnAppointment(a);
                    int notAccept = medicalInstitution.DoNotMakeAnAppointment(a);
                    this.accept.Text = $"{accept}";
                    this.notAccept.Text = $"{notAccept}";
                }
            }
            else
            {
                errorProvider.SetError(numberOfPatients, "Введите целое число");
                await Task.Delay(2222);
                errorProvider.SetError(numberOfPatients, "");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            accept.Clear();
            notAccept.Clear();
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
            numberOfPatients.Clear();
            accept.Clear();
            notAccept.Clear();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accept.Clear();
            notAccept.Clear();
            Calc();
        }
    }
}
