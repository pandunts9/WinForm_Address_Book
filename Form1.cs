using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Address_Book
{
    public partial class addressBook_form : Form
    {
        public addressBook_form()
        {
            InitializeComponent();
        }
        private bool IsCompleted()
        {
            if (firstName_tb.Text.Length > 0 && lastName_tb.Text.Length > 0 && email_tb.Text.Length > 0 &&
                address_tb.Text.Length > 0 && phoneNumber_tb.Text.Length > 0 && phoneNumber_tb.Text.Length < 12)
            {
                return true;
            }
            return false;
        }
        private void addressBook_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDate.AddressBook' table. You can move, or remove it, as needed.
            this.addressBookTableAdapter.Fill(this.myDate.AddressBook);
            book_grid.ReadOnly = true;
            Edit(false);
        }
        private void Edit(bool value)
        {
            firstName_tb.Enabled = value;
            lastName_tb.Enabled = value;
            phoneNumber_tb.Enabled = value;
            email_tb.Enabled = value;
            address_tb.Enabled = value;
        }
        private void Clear()
        {
            firstName_tb.Clear();
            lastName_tb.Clear();
            phoneNumber_tb.Clear();
            email_tb.Clear();
            address_tb.Clear();
        }


        private void delet_btn_Click(object sender, EventArgs e)
        {
            Edit(true);
            phoneNumber_tb.Focus();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsCompleted())
                {
                    book_grid.ReadOnly = false;
                    Edit(false);
                    addressBookBindingSource.MoveLast();
                    addressBookBindingSource.EndEdit();
                    addressBookTableAdapter.Update(myDate.AddressBook);
                    book_grid.Refresh();
                    book_grid.ReadOnly = true;
                    phoneNumber_tb.Focus();
                    MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myDate.AddressBook.RejectChanges();
            }
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            try
            {
                addressBookBindingSource.MoveLast();
                addressBookBindingSource.EndEdit();
                Edit(true);
                myDate.AddressBook.AddAddressBookRow(myDate.AddressBook.NewAddressBookRow());
                book_grid.ReadOnly = true;
                Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                myDate.AddressBook.RejectChanges();
            }
        }
    }
}
