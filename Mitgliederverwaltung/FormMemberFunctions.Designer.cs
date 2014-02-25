namespace Mitgliederverwaltung
{
    partial class FormMemberFunctions
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
            this.clbFunctions = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.functionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clbFunctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clbFunctions
            // 
            this.clbFunctions.DataSource = this.functionBindingSource;
            this.clbFunctions.DisplayMember = "Description";
            this.clbFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbFunctions.Location = new System.Drawing.Point(0, 0);
            this.clbFunctions.Name = "clbFunctions";
            this.clbFunctions.Size = new System.Drawing.Size(284, 262);
            this.clbFunctions.TabIndex = 0;
            this.clbFunctions.ValueMember = "ID";
            // 
            // functionBindingSource
            // 
            this.functionBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.Function);
            // 
            // FormMemberFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.clbFunctions);
            this.Name = "FormMemberFunctions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMemberFunctions";
            this.Load += new System.EventHandler(this.FormMemberFunctions_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMemberFunctions_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.clbFunctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckedListBoxControl clbFunctions;
        private System.Windows.Forms.BindingSource functionBindingSource;
    }
}