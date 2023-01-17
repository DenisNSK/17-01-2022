using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 6;
            dataGridView1[0, 0].Value = " Версия Windows";
            dataGridView1[0, 1].Value = " 64 Bit операционная система";
            dataGridView1[0, 2].Value = "  Имя компьютера";
            dataGridView1[0, 3].Value = " Число процессоров";
            dataGridView1[0, 4].Value = " Системную папка";
            dataGridView1[0, 5].Value = " Логические диски";

            
            dataGridView1[1, 0].Value =Environment.OSVersion.ToString();
            dataGridView1[1, 1].Value = Environment.Is64BitOperatingSystem.ToString();
            dataGridView1[1, 2].Value = Environment.MachineName.ToString();
            dataGridView1[1, 3].Value = Environment.ProcessorCount.ToString();
            dataGridView1[1, 4].Value = Environment.SystemDirectory.ToString();
           

            string [] s = Environment.GetLogicalDrives();
            string str = "";
            for (int i = 0; i < s.Length; i++)

            {
                str += s[i] + " ";
            }
            dataGridView1[1, 5].Value = str;
            


        }
    }
}
