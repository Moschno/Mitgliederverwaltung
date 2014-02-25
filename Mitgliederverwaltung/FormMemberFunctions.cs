using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Mitgliederverwaltung.Database;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Mitgliederverwaltung
{
    public partial class FormMemberFunctions : DevExpress.XtraEditors.XtraForm
    {
        private ICollection<MemberFunction> memberFunctions;
        public FormMemberFunctions(Member member, MitgliederverwaltungTestdatenDbContext dbContext)
        {
            InitializeComponent();
            this.memberFunctions = member.MemberFunctions;
            functionBindingSource.DataSource = dbContext.Functions.Local.Count != 0 ?
                dbContext.Functions.Local.ToList<Function>() :
                dbContext.Functions.ToList<Function>();
        }

        private void FormMemberFunctions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter ||
                e.KeyCode == Keys.Escape)
	        {
		        
	        }
        }

        private void FormMemberFunctions_Load(object sender, EventArgs e)
        {
            foreach (MemberFunction function in memberFunctions)
            {
                clbFunctions.SetItemChecked(function.FunctionID.Value - 1, true);
            }
        }
    }
}