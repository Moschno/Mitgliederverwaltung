using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Mitgliederverwaltung {
    public partial class FormInput : DevExpress.XtraBars.Ribbon.RibbonForm {
        public enum InputType {City, Class, Function};
        public string InputString { get; set; }

        public FormInput() {
            InitializeComponent();
        }

        public FormInput(InputType type) {
            InitializeComponent();
            SetFormCaption(type);
        }

        public FormInput(InputType type, string value) {
            InitializeComponent();
            SetFormCaption(type);
            textEditInput.Text = value;
        }

        private void textEditInput_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == Keys.Enter) {
                InputString = textEditInput.Text;
                this.Close();
            }
            else if (e.KeyData == Keys.Escape) {
                this.Close();
            }
        }

        private void SetFormCaption(InputType type) {
            if (type == InputType.City) {
                this.Text = "Neuer Stadtname";
            }
            else if (type == InputType.Class) {
                this.Text = "Neue Klassebezeichnung";
            }
            else if (type == InputType.Function) {
                this.Text = "Neue Funktionsbezeichnung";
            }
        }
    }
}