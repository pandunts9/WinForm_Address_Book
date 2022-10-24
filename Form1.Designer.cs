
namespace Address_Book
{
    partial class addressBook_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.firstName_lbl = new System.Windows.Forms.Label();
            this.firstName_tb = new System.Windows.Forms.TextBox();
            this.addressBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDate = new Address_Book.MyDate();
            this.lastName_tb = new System.Windows.Forms.TextBox();
            this.lastName_lbl = new System.Windows.Forms.Label();
            this.phoneNumber_tb = new System.Windows.Forms.TextBox();
            this.phone_lbl = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.address_tb = new System.Windows.Forms.TextBox();
            this.book_grid = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delet_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.create_btn = new System.Windows.Forms.Button();
            this.email_lbl = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.Label();
            this.tittle_lb = new System.Windows.Forms.Label();
            this.addressBookTableAdapter = new Address_Book.MyDateTableAdapters.AddressBookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName_lbl
            // 
            this.firstName_lbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.firstName_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.firstName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_lbl.Location = new System.Drawing.Point(25, 80);
            this.firstName_lbl.Name = "firstName_lbl";
            this.firstName_lbl.Size = new System.Drawing.Size(120, 17);
            this.firstName_lbl.TabIndex = 0;
            this.firstName_lbl.Text = "First Name";
            // 
            // firstName_tb
            // 
            this.firstName_tb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.firstName_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "FirstName", true));
            this.firstName_tb.Location = new System.Drawing.Point(153, 79);
            this.firstName_tb.Name = "firstName_tb";
            this.firstName_tb.Size = new System.Drawing.Size(193, 20);
            this.firstName_tb.TabIndex = 1;
            // 
            // addressBookBindingSource
            // 
            this.addressBookBindingSource.DataMember = "AddressBook";
            this.addressBookBindingSource.DataSource = this.myDate;
            // 
            // myDate
            // 
            this.myDate.DataSetName = "MyDate";
            this.myDate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lastName_tb
            // 
            this.lastName_tb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lastName_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "LastName", true));
            this.lastName_tb.Location = new System.Drawing.Point(153, 109);
            this.lastName_tb.Name = "lastName_tb";
            this.lastName_tb.Size = new System.Drawing.Size(193, 20);
            this.lastName_tb.TabIndex = 3;
            // 
            // lastName_lbl
            // 
            this.lastName_lbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lastName_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_lbl.Location = new System.Drawing.Point(25, 110);
            this.lastName_lbl.Name = "lastName_lbl";
            this.lastName_lbl.Size = new System.Drawing.Size(120, 17);
            this.lastName_lbl.TabIndex = 2;
            this.lastName_lbl.Text = "Last Name";
            // 
            // phoneNumber_tb
            // 
            this.phoneNumber_tb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.phoneNumber_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "Phone", true));
            this.phoneNumber_tb.Location = new System.Drawing.Point(153, 139);
            this.phoneNumber_tb.Name = "phoneNumber_tb";
            this.phoneNumber_tb.Size = new System.Drawing.Size(193, 20);
            this.phoneNumber_tb.TabIndex = 5;
            // 
            // phone_lbl
            // 
            this.phone_lbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.phone_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phone_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_lbl.Location = new System.Drawing.Point(25, 140);
            this.phone_lbl.Name = "phone_lbl";
            this.phone_lbl.Size = new System.Drawing.Size(120, 17);
            this.phone_lbl.TabIndex = 4;
            this.phone_lbl.Text = "Phone Number";
            // 
            // email_tb
            // 
            this.email_tb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.email_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "Email", true));
            this.email_tb.Location = new System.Drawing.Point(580, 79);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(244, 20);
            this.email_tb.TabIndex = 7;
            // 
            // address_tb
            // 
            this.address_tb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.address_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.addressBookBindingSource, "Address", true));
            this.address_tb.Location = new System.Drawing.Point(580, 109);
            this.address_tb.Name = "address_tb";
            this.address_tb.Size = new System.Drawing.Size(244, 20);
            this.address_tb.TabIndex = 9;
            // 
            // book_grid
            // 
            this.book_grid.AutoGenerateColumns = false;
            this.book_grid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.book_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.book_grid.DataSource = this.addressBookBindingSource;
            this.book_grid.Location = new System.Drawing.Point(25, 204);
            this.book_grid.Name = "book_grid";
            this.book_grid.ReadOnly = true;
            this.book_grid.Size = new System.Drawing.Size(799, 208);
            this.book_grid.TabIndex = 10;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 120;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 140;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 250;
            // 
            // delet_btn
            // 
            this.delet_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.delet_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delet_btn.Location = new System.Drawing.Point(755, 160);
            this.delet_btn.Name = "delet_btn";
            this.delet_btn.Size = new System.Drawing.Size(70, 38);
            this.delet_btn.TabIndex = 11;
            this.delet_btn.Text = "EDIT";
            this.delet_btn.UseVisualStyleBackColor = false;
            this.delet_btn.Click += new System.EventHandler(this.delet_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(675, 160);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(70, 38);
            this.delete_btn.TabIndex = 12;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(595, 161);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(70, 38);
            this.save_btn.TabIndex = 13;
            this.save_btn.Text = "SAVE";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.Location = new System.Drawing.Point(515, 160);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(70, 38);
            this.create_btn.TabIndex = 14;
            this.create_btn.Text = "CREATE";
            this.create_btn.UseVisualStyleBackColor = false;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // email_lbl
            // 
            this.email_lbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.email_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.email_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(450, 80);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(120, 17);
            this.email_lbl.TabIndex = 15;
            this.email_lbl.Text = "E-Mail";
            // 
            // address_lbl
            // 
            this.address_lbl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.address_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.address_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_lbl.Location = new System.Drawing.Point(450, 110);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(120, 17);
            this.address_lbl.TabIndex = 16;
            this.address_lbl.Text = "Physical Address";
            // 
            // tittle_lb
            // 
            this.tittle_lb.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tittle_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle_lb.Location = new System.Drawing.Point(22, 9);
            this.tittle_lb.Name = "tittle_lb";
            this.tittle_lb.Size = new System.Drawing.Size(802, 57);
            this.tittle_lb.TabIndex = 17;
            this.tittle_lb.Text = "ADDRESS BOOK";
            this.tittle_lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addressBookTableAdapter
            // 
            this.addressBookTableAdapter.ClearBeforeFill = true;
            // 
            // addressBook_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(890, 413);
            this.Controls.Add(this.tittle_lb);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.email_lbl);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.delet_btn);
            this.Controls.Add(this.book_grid);
            this.Controls.Add(this.address_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.phoneNumber_tb);
            this.Controls.Add(this.phone_lbl);
            this.Controls.Add(this.lastName_tb);
            this.Controls.Add(this.lastName_lbl);
            this.Controls.Add(this.firstName_tb);
            this.Controls.Add(this.firstName_lbl);
            this.Name = "addressBook_form";
            this.Text = "ADDRESS BOOK";
            this.Load += new System.EventHandler(this.addressBook_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName_lbl;
        private System.Windows.Forms.TextBox firstName_tb;
        private System.Windows.Forms.TextBox lastName_tb;
        private System.Windows.Forms.Label lastName_lbl;
        private System.Windows.Forms.TextBox phoneNumber_tb;
        private System.Windows.Forms.Label phone_lbl;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox address_tb;
        private System.Windows.Forms.DataGridView book_grid;
        private System.Windows.Forms.Button delet_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label address_lbl;
        private System.Windows.Forms.Label tittle_lb;
        private MyDate myDate;
        private System.Windows.Forms.BindingSource addressBookBindingSource;
        private MyDateTableAdapters.AddressBookTableAdapter addressBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}

