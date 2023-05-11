namespace EletjatekGUI
{
    public partial class Form1 : Form
    {
        CheckBox[,] cbs = new CheckBox[0, 0];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 5; i < 21; i++)
            {
                cbSor.Items.Add(i.ToString());
                cbOszlop.Items.Add(i.ToString());
            }

            cbSor.SelectedItem = 20.ToString();
            cbOszlop.SelectedItem = 20.ToString();
        }

        private void btnUj_Click(object sender, EventArgs e)
        {
            int oszlop = cbSor.SelectedIndex + 5;
            int sor = cbOszlop.SelectedIndex + 5;

            foreach (CheckBox cb in cbs)
            {
                cb.Dispose();
            }

            cbs = new CheckBox[sor, oszlop];

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    CheckBox cb = new();
                    cb.Size = new(17, 17);
                    cb.Location = new(12 + i * 17, 81 + j * 17);
                    Controls.Add(cb);
                    cbs[i, j] = cb;
                }
            }
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            using StreamWriter sw = new($"Eletjatek_{cbs.GetLength(1)}x{cbs.GetLength(0)}.txt");
            for (int i = 0; i < cbs.GetLength(1); i++)
            {
                for (int j = 0; j < cbs.GetLength(0); j++)
                {
                    sw.Write(cbs[j, i].Checked ? '1' : '0');
                }
                sw.WriteLine();
            }
        }
    }
}