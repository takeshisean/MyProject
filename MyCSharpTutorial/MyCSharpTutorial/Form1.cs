using MyCSharpTutorial.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCSharpTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ExecMySortedList();
        }

        public void ExecMySortedList()
        {
            MySortedList list = new MySortedList();
            list.Add(13);
            list.Add(81);
            list.Add(25);
            list.Add(9);
            list.Add(33);
            list.Add(46);
            list.Add(1);
            foreach (int v in list.Items)
            {
                Console.WriteLine(v);
            }
            Console.ReadLine();
        }
    }
}
