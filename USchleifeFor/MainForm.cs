namespace USchleifeFor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            
            LblOutput.Text = $"";
            for (double x = 35.0; x >= 20; x -= 2.5)
            {
                LblOutput.Text += $"{x}\n";
            }
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double mittelwert = 0, summe = 0, count = 0;
            LblOutput.Text = $"";
            for (double x = 35.0; x >= 20; x -= 2.5)
            {
                LblOutput.Text += $"{x}\n";
                summe += x;
                count++;
            }
            mittelwert = summe / count;
            LblOutput.Text += $"arithmetisches Mittel: {mittelwert}\n" +
                $"Summe : {summe}";
        }
    }
}