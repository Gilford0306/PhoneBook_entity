

namespace PhoneBook_entity
{
    public partial class Form2 : Form
    {
        private int x = -1 ;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int x)
        {
            InitializeComponent();
            this.x = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x == -1)
            {
                using (MyApplicationContext context = new MyApplicationContext())
                {
                    context.Abonents.Add(new Abonent() { Name = textBox1.Text.ToString(), Lastname = textBox2.Text.ToString(), Phone = textBox3.Text.ToString() });
                    context.SaveChanges();
                    MessageBox.Show("Abonent is adding");
                    this.Close();

                }
            }
            else
            {
                using (MyApplicationContext context = new MyApplicationContext())
                {

                    var oldData = context.Abonents.FirstOrDefault(y => y.Id == x);
                    oldData.Name = textBox1.Text.ToString();
                    oldData.Lastname = textBox2.Text.ToString();
                    oldData.Phone = textBox3.Text.ToString();
                    context.Abonents.Update(oldData);
                    context.SaveChanges();
                    MessageBox.Show("Abonent is updating");
                    this.Close();
                }
            }

        }
    }
}
