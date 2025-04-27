using NeuroBuddy.Core;
using NeuroBuddy.Interfaces;

namespace NeuroBuddy.Views
{
    public partial class Form1 : Form
    {
        ICategoryManager catMan;

        public Form1(ICategoryManager catMan)
        {
            InitializeComponent();

            this.catMan = catMan;

            UpdateCategoryList();
        }

        TreeNode MakeNode(NeuroCategory category)
        {
            var node = new TreeNode(category.Name);
            foreach (var cat in category.Children)
                node.Nodes.Add(MakeNode(cat));

            return node;
        }

        void UpdateCategoryList()
        {
            treeView1.Nodes.Clear();
            var rootCategories = catMan.GetAllCategories().Where(x => x.Root == null);

            foreach (var cat in rootCategories)
                treeView1.Nodes.Add(MakeNode(cat));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var view = new NewCategoryView(catMan);
            if (view.ShowDialog() == DialogResult.OK)
            {
                catMan.Add(view.NewCategory);
                UpdateCategoryList();
            }
        }
    }
}
