
namespace PhoneBook_entity
{
    public partial class Form1 : Form
    {

        int x = -1;
        public Form1()
        {
            InitializeComponent();


            using (MyApplicationContext context = new MyApplicationContext())
            {
                int y = 0;
                foreach (Abonent abon in context.Abonents)
                {
                    var item = new UserControllAbon(abon);
                    item.Location = new Point(0, y);
                    this.panel1.Controls.Add(item);
                    y += item.Height - 40;
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            panel1.Controls.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(x);
            newForm.Show();
            panel1.Controls.Clear();
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x > 0)
                using (MyApplicationContext context = new MyApplicationContext())
                {

                    int idForRemove = x;
                    context.Abonents.Remove(context.Abonents.FirstOrDefault(z => z.Id.Equals(idForRemove)));
                    context.SaveChanges();
                    panel1.Controls.Clear();
                    MessageBox.Show("Abonent is deleted");
                    textBox2.Clear();
                }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.ToString() != string.Empty)
            {
                try
                {
                    x = int.Parse(textBox1.Text.ToString());
                }
                catch
                {
                    MessageBox.Show("Only Number");
                    textBox1.Clear();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.ToString() != string.Empty)
            {
                try
                {
                    x = int.Parse(textBox2.Text.ToString());
                }
                catch
                {
                    MessageBox.Show("Only Number");
                    textBox2.Clear();
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            using (MyApplicationContext context = new MyApplicationContext())
            {
                int y = 0;
                foreach (Abonent abon in context.Abonents)
                {
                    var item = new UserControllAbon(abon);
                    item.Location = new Point(0, y);
                    this.panel1.Controls.Add(item);
                    y += item.Height - 40;
                }

            }
        }
    }
}