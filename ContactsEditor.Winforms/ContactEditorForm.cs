using System;
using System.Linq;
using System.Windows.Forms;
using Jarai.CSharp.EntityFrameworkCore.CodeFirst;

namespace Jarai.CSharp.EntityFrameworkCore.CodeFirst
{
    public partial class ContactEditorForm : Form
    {
        private readonly DatabaseContext _db = new();

        public ContactEditorForm()
        {
            InitializeComponent();
            LoadContacts();
        }

        private void LoadContacts()
        {
            dataGridView1.DataSource = _db.Contacts.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var contact = new Contact { Name = "New Contact", Created = DateTime.Now };
            _db.Contacts.Add(contact);
            _db.SaveChanges();
            LoadContacts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Contact contact)
            {
                _db.Contacts.Remove(contact);
                _db.SaveChanges();
                LoadContacts();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _db.SaveChanges();
            LoadContacts();
        }
    }
}
