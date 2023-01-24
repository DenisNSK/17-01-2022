using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.SelectedItem.ToString();
            string z = "";
            if (a == "Процессор")
            {
                z = z+ "Win32_Processor";
            }
            else if (a == "Видеокарта")
            {
                z = z + "Win32_VideoController";
            }
            else if (a == "Чипсет")
            {
                z = z + "Win32_IDEController";
            }
            else if (a == "Батарея")
            {
                z =
                    z + "Win32_Battery";
            }
            else if (a == "Биос")
            {
                z = z + "Win32_BIOS";
            }
            else if (a == "Оперативная память")
            {
                z = z + "Win32_PhysicalMemory";
            }
            else if (a == "Кэш")
            {
                z = z + " Win32_CacheMemory";
            }
            else if (a == "USB")
            {
                z = z + "Win32_USBController";
            }
            else if (a == "Диск")
            {
                z = z + "Win32_DiskDrive ";
            }
            else if (a == "Логические диски")
            {
                z = z + "Win32_LogicalDisk";
            }
            else if (a == "Клавиатура")
            {
                z = z + "Win32_Keyboard";
            }
            else if (a == "Сеть")
            {
                z = z + "Win32_NetworkAdapter";
            }
           else if (a == "Пользователи")
          {
               z = z + "Win32_Account";
          }
            dataGridView1.Rows.Clear(); ;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(" SELECT * FROM " +z);
            foreach (ManagementObject obj in searcher.Get())
            {
                foreach (PropertyData dat in obj.Properties)
                { 
                dataGridView1.RowCount +=1;
                dataGridView1[0, dataGridView1.RowCount-1].Value = dat.Name;
                dataGridView1[1, dataGridView1.RowCount-1].Value = dat.Value;

                }
            }
        }
    }
}
