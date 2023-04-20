using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinForms_homework_05._04._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region ex1
            /*int count = 0;
            string info = null;
            string[] mas = { "Привет, меня зовут Даня", "Мне 18 лет и я учу программирование", "Увлекаюсь спортом и музыкой" };

            for(int i = 0; i < mas.Length; i++) {
                count += mas[i].Length;
                info = (mas.Length - 1 == i) ? $"MessageBox: {i + 1} | Среднее число символов: {count / mas.Length}" : $"MessageBox {i + 1}";
                MessageBox.Show(mas[i], "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            MessageBox.Show("Конец", info);*/
            #endregion

            #region ex2
            //Shown += Ex2;
            #endregion

            #region ex3
            /*this.MouseMove += MyMouseMove;
            this.MouseClick += Ex3;*/
            #endregion
        }

        #region ex2
        /*  private void Ex2(object sender, EventArgs e) {
            DialogResult result;
            int numDialog = 1;
            int max = 2000;
            int num = max / 2;

            MessageBox.Show("Загадайте число от 1 до 2000", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            while (true) {
                result = MessageBox.Show($"{num}", "Вы загадали число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    MessageBox.Show($"Количество запросов {numDialog}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    numDialog = 0;
                    DialogResult result_2 = MessageBox.Show($"Хотите продолжить?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result_2 == DialogResult.No) Close();
                }
                else if (result == DialogResult.No) {
                    result = MessageBox.Show($"Ваше число больше чем {num} ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.No) {
                        num /= 2;
                    }
                    if(result == DialogResult.Yes) {
                        num = num / 2 + num;
                    }
                }
                numDialog++;
            }
        }*/
        #endregion

        
        private void Ex3(object sender, MouseEventArgs e) {
             string text = "";
             if (e.Button == MouseButtons.Left) {
                 if (ModifierKeys == Keys.Control) {
                     Close();
                 }
                 if ((e.X < 10 || e.X > ClientSize.Width - 10) || (e.Y < 10 || e.Y > ClientSize.Height - 10)) {
                     text = "Клик снаружи прямоугольника!";
                 }
                 else if ((e.X == 10 || e.X == ClientSize.Width - 10) || (e.Y == 10 || e.Y == ClientSize.Height - 10)) {
                     text = "Клик на границе прямоугольника!";
                 }
                 else {
                     text = "Клик внутри прямоугольника!";
                 }
                 MessageBox.Show(text, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             if (e.Button == MouseButtons.Right) {
                 Text = $"Размере клиентской области окна! Ширина = {ClientSize.Width}, Высота = {ClientSize.Height}";
                 Thread.Sleep(2000);
             }
         }
         private void MyMouseMove(object sender, MouseEventArgs e) {
             Text = $"X {e.X} - Y {e.Y}";
         }
        

         private void Form1_Load(object sender, EventArgs e)
         {

         }
        
    }
}
