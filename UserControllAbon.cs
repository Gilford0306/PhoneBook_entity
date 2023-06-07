
namespace PhoneBook_entity
{
    public partial class UserControllAbon : UserControl
    {
        public UserControllAbon()
        {
            InitializeComponent();
        }
        public UserControllAbon(Abonent abon) : this()
        {
            this.label1.Text = abon.Id.ToString();
            this.label2.Text = abon.Name.ToString();
            this.label3.Text = abon.Lastname.ToString();
            this.label4.Text = abon.Phone.ToString();
        }
    }
}
