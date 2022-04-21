namespace WinFormsApp2Project1
{
    public partial class Form1 : Form
    {
        private string[] data;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addRow(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void addRow(string text1, string text2, string text3, string text4)
        {
            //throw new NotImplementedException();

            String[] row = {textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text};
            dataGridView1.Rows.Add(row);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                {
                    openFileDialog1.ShowDialog();
                    string file = openFileDialog1.FileName;
                    loadProductFromFile(file);
                }
            }
        }
        private void loadProductFromFile(string Npath)
        {
            string[] lines = System.IO.File.ReadAllLines(Npath);
            if (lines.Length > 0)
            {

                for (int i = 1; i < lines.Length; i++)
                {
                    data = lines[i].Split(',');
                    dataGridView1.Rows.Add(data[0], data[1], data[2], data[3], data[4]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 p = new Form2();
            p.ShowDialog();
        }
    }
}