using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5 {
    public partial class SelectionForm : Form {
        public SelectionForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            FirstTaskForm firstTaskForm = new FirstTaskForm();
            if (!firstTaskForm.IsDisposed) {
                Visible = false;
                firstTaskForm.ShowDialog();
            }
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e) {
            SecondAndForthTaskForm secondTaskForm = new SecondAndForthTaskForm();
            if (!secondTaskForm.IsDisposed) {
                Visible = false;
                secondTaskForm.ShowDialog();
            }
            Visible = true;
        }

        private void button4_Click(object sender, EventArgs e) {
            SecondAndForthTaskForm secondTaskForm = new SecondAndForthTaskForm();
            if (!secondTaskForm.IsDisposed) {
                Visible = false;
                secondTaskForm.ShowDialog();
            }
            Visible = true;
        }

        private void button3_Click(object sender, EventArgs e) {
            ThirdTaskForm thirdTaskForm = new ThirdTaskForm();
            if (!thirdTaskForm.IsDisposed) {
                Visible = false;
                thirdTaskForm.ShowDialog();
            }
            Visible = true;
        }

        private void button5_Click(object sender, EventArgs e) {
            FifthTaskForm fifthTaskForm = new FifthTaskForm();
            if (!fifthTaskForm.IsDisposed) {
                Visible = false;
                fifthTaskForm.ShowDialog();
            }
            Visible = true;
        }
    }
}
