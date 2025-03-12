using CalculatorModel;
using Button = System.Windows.Forms.Button;

namespace GraphicalCalculator
{
    public partial class FormsView : Form
    {

        public delegate void ArgumentsHandler(string args);
        public event ArgumentsHandler ArgumentsPressed;

        public delegate void ResultHandler(string result);
        public event ResultHandler ResultPressed;

        public FormsView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            var calcOperations = new CalculatorOperations();
            comboBoxOp.DataSource = calcOperations.operations.Operations.Keys.ToList();

            if (comboBoxOp.Items.Count > 0)
                comboBoxOp.SelectedIndex = 0;

            comboBoxOp.SelectedIndexChanged += comboBoxOp_SelectedIndexChanged;

            AssignButtonHandlers();

        }

        public string Operation
        {
            get => comboBoxOp.SelectedItem.ToString();
        }

        public string Arguments
        {
            get => tbArgs.Text;
            set => tbArgs.Text += value;
        }

        public void AssignButtonHandlers()
        {

            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Tag?.ToString() == "Arg")
                {
                    string arg = btn.Text;
                    btn.Click += (sender, e) => ArgumentsPressed?.Invoke(arg);
                }

            }

            btnDelete.Click += DeleteClick;
            btnResult.Click += (sender, e) => ResultPressed?.Invoke("");
        }

        public void DeleteClick(object sender, EventArgs e)
        {
            tbArgs.Clear();
        }

        public void DisplayResult(double result)
        {
            tbResult.Text = result.ToString();
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBoxOp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBoxOp.SelectedItem.ToString();

        }
    }
}
