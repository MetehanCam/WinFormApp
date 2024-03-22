namespace TugbaWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            cmbEklenenler.Items.Add(txtGirilen.Text.Trim());
            listEklenenler.Items.Add(txtGirilen.Text.Trim());
            txtGirilen.Text = String.Empty;
        }

        private void listEklenenler_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show($"Listeden seçilen eleman: {listEklenenler.Text}");
        }

        private void cmbEklenenler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEklenenler.SelectedIndex != -1)
            {
                MessageBox.Show($"ComboBox'tan seçilen eleman: {cmbEklenenler.Text}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbEklenenler.SelectedIndex = -1;
            listEklenenler.SelectedIndex = -1;
            MessageBox.Show("Seçim temizlendi");
        }
    }
}