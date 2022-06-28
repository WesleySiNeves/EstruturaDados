using _3.AlocacaoHeap;

namespace Demos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void stringsEConstantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Demostracao demo = new Demostracao();

            var result = demo.DemoStringsEConstantes();
        }
    }
}