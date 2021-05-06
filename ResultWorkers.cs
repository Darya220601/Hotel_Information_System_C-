using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class ResultWorkers : Form
    {
        List<Workers> workerData;
        public ResultWorkers(List<Workers> workers)
        {
            InitializeComponent();
            workerData = workers;
        }

        private void ResultWorkers_Load(object sender, EventArgs e)
        {
            
          
            workersBindingSource.DataSource = workerData;
            decimal sum = 0;
            String countOfWorkers = (dataGridView1.Rows.Count).ToString();
            foreach (Workers w in workerData)
            {
                sum += w;
            }
            labelSalaryExpenses.Text = "Расходы на зарплату " + countOfWorkers+" workers = " + sum.ToString() + "$";
            labelAllExpenses.Text = "Совокупные расходы = " + (sum+ Workers.otherExpenses).ToString() + "$";
            



        }
    }
}
