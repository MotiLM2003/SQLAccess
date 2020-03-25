using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLAccess
{
    public partial class FormUI : Form
    {
        List<Person> people = new List<Person>();
        public FormUI()
        {
            InitializeComponent();

        }


        private void WireupLists()
        {
            this.lstPeople.DataSource = null;
            this.lstPeople.DataSource = this.people;
            this.lstPeople.DisplayMember = "FullInfo";

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            people = db.GetPeople(this.txbLasTName.Text);

            this.WireupLists();

        }

        private void btnCreatePeople_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            Person p = new Person()
            {
                FirstName = this.txbFirstName.Text,
                LastName = this.txbLastName2.Text,
                PhoneNumber = this.txbPhoneNumber.Text,
                EmailAddress = this.txbEmaillAddress.Text
            };

            db.InsertPerson(p);
        }
    }
}
