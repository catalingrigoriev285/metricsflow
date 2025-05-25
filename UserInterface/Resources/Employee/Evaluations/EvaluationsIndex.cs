using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Resources.Employee.Evaluations
{
    public partial class EvaluationsIndex : Form
    {
        public EvaluationsIndex()
        {
            InitializeComponent();
        }

        private void EvaluationsIndex_Load(object sender, EventArgs e)
        {
            DatabaseManagement.FileSystem.EvaluationInterface evaluationInterface = new DatabaseManagement.FileSystem.EvaluationInterface();
            List<Models.Evaluation> evaluations = new List<Models.Evaluation>();

            evaluations = evaluationInterface.loadEvaluations();
            evaluations = evaluations.Where(e => e.user_id == UserInterface.globals._sessionUser.id).ToList();

            if(evaluations.Count() >= 1)
            {
                dataGridView_local_user_evaluations.DataSource = evaluations;
            } else
            {
                MessageBox.Show("You have no evaluations yet.", "My Evaluations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
