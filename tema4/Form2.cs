using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int[] salaries = new int[] { 1600, 1800, 2400, 1200, 2600, 3000, 4500, 6000 };
            int maxs= salaries[0], mins =salaries[0],sum=salaries[0];
            for(int i= 1;i< salaries.Length; i++)
            {
                if (salaries[i] < mins)
                    mins = salaries[i];
                if (salaries[i] > maxs)
                    maxs = salaries[i];
                sum += salaries[i];
            }
            Console.WriteLine("Min: "+ mins);
            Console.WriteLine("Max: "+ maxs);
            Console.WriteLine("Total salaries:" + sum);
            Console.WriteLine("Average:" +(double)(sum / salaries.Length));

        }
    }
}
