using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XStudentsChipApp
{
    public partial class RadiUpdate : UserControl
    {
        public RadiUpdate()
        {
            InitializeComponent();
            
            Dictionary<int, List<string>> myDictionary = new Dictionary<int, List<string>>
            {
                { 1213, new List<string> { "Име" , "Презиме", "Фамилия" } },
                { 2234, new List<string> { "Cherry", "Date" } },
                { 3234, new List<string> { "Elderberry", "Fig", "Grapes" } }
            };


            
           

            dataGridView1.DataSource = myDictionary;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {

        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RadiUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
