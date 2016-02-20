using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyManagment
{
    public partial class ViewNoteDataForm : Form
    {
        public Note note;
        DataGridView DGV;
        public ViewNoteDataForm(Note n,DataGridView dgv)
        {
            InitializeComponent();
            note = n;
            DGV = dgv;
            txt_WrittenBy.Text = n.WrittenBy;
            txt_Text.Text = n.Text;
            lbl_DatePosted.Text = n.CreationDate.ToString("ddMMMyyyy");
        }

        private void btn_Post_Click(object sender, EventArgs e)
        {
            if (txt_Text.Text.Length > 0 && txt_WrittenBy.Text.Length > 0)
            {
                note.WrittenBy = txt_WrittenBy.Text;
                note.Text = txt_Text.Text;
                note.CreationDate = DateTime.Today;
                DialogResult = DialogResult.OK;
            }
        }
    }
}