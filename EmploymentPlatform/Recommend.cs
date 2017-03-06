using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploymentPlatform {
    public partial class Recommend : Form {
        public Recommend(List<User> sorted_users, double[] sorted_points) {
            InitializeComponent();
            for(int i = 0; i < sorted_users.Count; i++) {
                if (sorted_points[i] > 0.0) {
                    userListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                    userListPanel.Controls.Add(new Label() { Name = "jobLabel" + i, Text = sorted_users[i].name + " - " + sorted_users[i].email + " - " + sorted_points[i], AutoSize = true, MaximumSize = new Size(350, 30) });
                    userListPanel.RowCount = userListPanel.RowCount + 1;
                }
                else
                    break;
            }
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
