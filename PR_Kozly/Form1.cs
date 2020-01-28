using System;
using System.Windows.Forms; 
using Tekla.Structures.Model;
using Tekla.Structures.Model.Operations;
 
namespace PR_Kozly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Model model= new Model();
            if (!model.GetConnectionStatus())
            {
                MessageBox.Show("Tekla nie uruchomiona");
                return;
            }

            ModelInfo modelInfo = model.GetInfo();
            string name = modelInfo.ModelName;
            MessageBox.Show(string.Format("Nazwa modelu: {0}", name));
            Operation.DisplayPrompt(string.Format("Bieżący model: {0}", name));
        }
    }
}
