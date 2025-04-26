using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroBuddyWinForms
{
    public partial class NewCategoryView : Form
    {
        public NeuroCategory? NewCategory { get; private set; }
        List<NeuroCategory> existingCats;

        public NewCategoryView(ICategoryManager manager)
        {
            InitializeComponent();

            listBox1.SelectedIndex = 0;

            existingCats = manager.GetAllCategories().ToList();
            foreach (var cat in existingCats)
                listBox1.Items.Add(cat.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please type a valid category name");
                return;
            }

            NeuroCategory root = null;
            if (listBox1.SelectedIndex > 0)
                root = existingCats[listBox1.SelectedIndex - 1];

            NewCategory = new NeuroCategory(textBox1.Text, root);

            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
