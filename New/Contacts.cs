using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New
{
    public partial class Create_contact : Form
    {
        contactDbConn mysqlConn;
        public Create_contact()
        {
            InitializeComponent();
            mysqlConn = new contactDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            {
                contactTable.DataSource = mysqlConn.qry("SELECT * FROM `contacts`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void ContactType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Create_contact_Load(object sender, EventArgs e)
        {

        }

        private void CreateBut_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.createContact(conFName.Text, conLName.Text, conEmail.Text, conTelNum.Text, conAddr.Text, conCity.Text, conPostCode.Text, conType.Text) ;
                contactTable.DataSource = mysqlConn.qry("SELECT * FROM `contacts`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void ContactTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contactTable.SelectedRows.Count > 0)
            {
                conID.Text = contactTable.SelectedRows[0].Cells[0].Value.ToString();
                conFName.Text = contactTable.SelectedRows[0].Cells[1].Value.ToString();
                conLName.Text = contactTable.SelectedRows[0].Cells[2].Value.ToString();
                conEmail.Text = contactTable.SelectedRows[0].Cells[3].Value.ToString();
                conTelNum.Text = contactTable.SelectedRows[0].Cells[4].Value.ToString();
                conAddr.Text = contactTable.SelectedRows[0].Cells[5].Value.ToString();
                conCity.Text = contactTable.SelectedRows[0].Cells[6].Value.ToString();
                conPostCode.Text = contactTable.SelectedRows[0].Cells[7].Value.ToString();
                conType.Text = contactTable.SelectedRows[0].Cells[8].Value.ToString();
            }
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.deleteContact(conID.Text);
                    contactTable.DataSource = mysqlConn.qry("SELECT * FROM `contacts`").Tables[0];
                }
                mysqlConn.connClose();
            }
        }

        private void UpdateBut_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.updateContact(conID.Text, conFName.Text, conLName.Text, conEmail.Text, conTelNum.Text, conAddr.Text, conCity.Text, conPostCode.Text, conType.Text);
                contactTable.DataSource = mysqlConn.qry("SELECT * FROM `contacts`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void PerSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                contactTable.DataSource = mysqlConn.qry("SELECT * FROM `contacts` WHERE conType='Personal'").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void BusSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                contactTable.DataSource = mysqlConn.qry("SELECT * FROM `contacts` WHERE conType='Business'").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void AllSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                contactTable.DataSource = mysqlConn.qry("SELECT * FROM `contacts`").Tables[0];
            }
            mysqlConn.connClose();
        }
    }
}
