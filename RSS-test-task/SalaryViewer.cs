using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace RSS_test_task
{
    public partial class SalaryViewer : Form
    {
        protected bool showDismissed = false;
        protected string searchString = string.Empty;

        public SalaryViewer()
        {
            InitializeComponent();
        }

        private void SalaryViewer_Load(object sender, EventArgs e)
        {
            comboBoxSalary.SelectedIndex = 0;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void checkBoxInactive_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            searchString = textBoxName.Text;
            UpdateTable();
        }

        private void comboBoxSalary_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    UpdateTable();
        }

        private void UpdateTable()
        {
            Query();
            ColorTheBloodyTable();
        }

        private void ColorTheBloodyTable()
        {
            var rows = dataGridViewFinal.Rows.OfType<DataGridViewRow>();
            var highlightedRows = rows.Where(r => (Convert.ToDecimal(r.Cells["Salary"].Value.ToString()) < 20000));
            foreach (var r in highlightedRows)
                r.DefaultCellStyle.BackColor = Color.Orange;
            foreach (var r in rows.Except(highlightedRows))
                r.DefaultCellStyle.BackColor = Color.White;
        }

        private void Query()
        {
            showDismissed = checkBoxInactive.Checked;
            using (var context = new RSSEntities())
            {
                var getEmployees = from e in context.Employees
                                   where (e.Active == true || e.Active == !showDismissed) && e.Name.Contains(searchString)
                                   select new
                                   {
                                       e.Id,
                                       e.Name
                                   };

                var getWages = from w in context.Wages
                               where w.Datetime.Month == DateTime.Now.Month
                               select new
                               {
                                   w.EmployeeId,
                                   w.Salary
                               };

                var query = from e in getEmployees
                            join w in getWages on e.Id equals w.EmployeeId into ews
                            from ew in ews.DefaultIfEmpty()
                            select new
                            {
                                e.Name,
                                Salary = ew == null ? 0 : ew.Salary
                            };

                var result = from q in query
                             group q by q.Name into qGroup
                             orderby qGroup.Max(x => x.Salary) descending
                             select new
                             {
                                 Name = qGroup.Key,
                                 Salary = comboBoxSalary.SelectedIndex == 0 ?
                                 qGroup.Average(x => x.Salary) : qGroup.Max(x => x.Salary)
                             };

                var bindingSource = new BindingSource();
                bindingSource.DataSource = result.ToList();
                dataGridViewFinal.DataSource = bindingSource;
                dataGridViewFinal.Refresh();
            }
        }

        //Query has to have a few variations/options:
        //Search by name will filter by name with a LIKE statement (UPD) string.contains +
        //Show dismissed will add/remove a filter by Employee.Active = true +
        //Maximum/average will change how the salary shows +

        //Task:
        //Create a new table out of two tables, either using FULL JOIN or TEMP TABLE +
        //Render it onto the DataGridView +
        //Make changes when the Show button is pressed +

        //Bonus points:
        //Make dynamic changes when appropriate +
        //DB editor for convenience
    }
}
