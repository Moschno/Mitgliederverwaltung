﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Mitgliederverwaltung.Database;

namespace Mitgliederverwaltung {
    public partial class FormMember : DevExpress.XtraBars.Ribbon.RibbonForm {
        private MitgliederverwaltungTestdatenDbContext dbContext;
        private List<object> colFunctionsCellValues = new List<object>();

        public FormMember() {
            InitializeComponent();

            dbContext = new MitgliederverwaltungTestdatenDbContext();
            memberBindingSource.DataSource = dbContext.Members.ToList<Member>();
            genderBindingSource.DataSource = dbContext.Genders.ToList<Gender>();
            cityBindingSource.DataSource = dbContext.Cities.ToList<City>();
            classBindingSource.DataSource = dbContext.Classes.ToList<Class>();
            functionBindingSource.DataSource = dbContext.Functions.ToList<Function>();

            cityBindingSource.Insert(0, new City { Id = -1, Name = "<Neue Stadt anlegen..>" });
            classBindingSource.Insert(0, new Class { ID = -1, Description = "<Neue Klasse anlegen..>" });

            foreach (Member member in dbContext.Members.Local.ToList<Member>()) {
                StringBuilder functions;
                if (!GetMemberFunctionIds(member, out functions)) {
                    //functions.Append("<Bitte Funktion(en) angeben>");
                }
                colFunctionsCellValues.Add(functions as object);
            }
        }

        private bool GetMemberFunctionIds(Member member, out StringBuilder functions) {
            if (member.MemberFunctions.Count < 0) {
                functions = new StringBuilder(member.MemberFunctions.Count * 3, member.MemberFunctions.Count * 3);
                List<int> functionIds = new List<int>();
                foreach (MemberFunction function in member.MemberFunctions) {
                    functionIds.Add(function.FunctionID.Value);
                }
                functionIds.Sort();
                foreach (int id in functionIds) {
                    functions.Append(id + ", ");
                }
                functions.Length = functions.Length - 2;
                return true;
            }

            functions = new StringBuilder();
            return false;
        }

        private void leCities_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e) {
            if (e.NewValue as int? == -1) {
                e.Cancel = true;
                //todo: Städteverwaltung öffnen 
            }
        }

        private void leClasses_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e) {
            if (e.NewValue as int? == -1) {
                e.Cancel = true;
                //todo: Klassenverwaltung öffnen 
            }
        }

        private void naviGridMember_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e) {
            if (e.Button == naviGridMember.Buttons.EndEdit) {
                e.Handled = true;
                SaveDataToDb();
                UpdateNaviButtonState(e.Button);
            }
            else if (e.Button == naviGridMember.Buttons.CancelEdit) {
                e.Handled = true;
                dbContext = new MitgliederverwaltungTestdatenDbContext();
                memberBindingSource.DataSource = dbContext.Members.ToList<Member>();
                UpdateNaviButtonState(e.Button);
            }
            else if (e.Button == naviGridMember.Buttons.Append) {
                e.Handled = true;
                dbContext.Members.Local.Add(new Member());
                memberBindingSource.DataSource = dbContext.Members.Local.ToList<Member>();
                UpdateNaviButtonState(e.Button);
            }
            else if (e.Button == naviGridMember.Buttons.Remove) {
                e.Handled = true;
                DialogResult result = XtraMessageBox.Show("Möchtest du das Mitglied endgültig löschen?", "Bestätigung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.OK) {
                    Member member;
                    if (GetMemberFromFocusedRow(out member)) {
                        dbContext.Members.Local.Remove(member);
                        memberBindingSource.DataSource = dbContext.Members.Local.ToList<Member>();
                        SaveDataToDb();
                        UpdateNaviButtonState(e.Button);
                    }
                }
            }
        }

        private bool GetMemberFromFocusedRow(out Member member) {
            int? memberID = (int?)viewMember.GetFocusedRowCellValue(colID);
            if (memberID != null) {
                member = (from a in dbContext.Members.Local.ToList<Member>()
                          where a.ID == memberID
                          select a).SingleOrDefault();
                if (member != null) {
                    return true;
                }
            }

            member = new Member();
            return false;
        }

        private void UpdateNaviButtonState(NavigatorButtonBase clickedButton) {
            if (clickedButton == naviGridMember.Buttons.EndEdit ||
                clickedButton == naviGridMember.Buttons.Remove) {
                naviGridMember.Buttons.EndEdit.Enabled = false;
                naviGridMember.Buttons.CancelEdit.Enabled = false;
                naviGridMember.Buttons.Append.Enabled = true;
            }
            else if (clickedButton == naviGridMember.Buttons.CancelEdit) {
                naviGridMember.Buttons.EndEdit.Enabled = true;
                naviGridMember.Buttons.CancelEdit.Enabled = true;
                naviGridMember.Buttons.Append.Enabled = true;
            }
            else if (clickedButton == naviGridMember.Buttons.Append) {
                naviGridMember.Buttons.Append.Enabled = false;
            }
        }

        private void SaveDataToDb() {
            viewMember.CloseEditor();
            dbContext.SaveChanges();
        }

        private void beFunctions_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            Member member;
            if (GetMemberFromFocusedRow(out member)) {
                FormMemberFunctions formMemberFunctions = new FormMemberFunctions(member, dbContext);
                formMemberFunctions.ShowInTaskbar = false;
                formMemberFunctions.ShowIcon = false;
                formMemberFunctions.Show(this);
            }
        }

        private void viewMember_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if (e.Column == colFunctions) {
                if (e.IsSetData) {
                    colFunctionsCellValues[e.ListSourceRowIndex] = e.Value;
                }
                else {
                    e.Value = colFunctionsCellValues[e.ListSourceRowIndex];
                }
            }
        }

        private void Repository_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e) {
            if (sender == deDate) {
                if (string.IsNullOrEmpty(e.DisplayText)) {
                    e.DisplayText = "<Bitte Datum wählen>";
                } 
            }
            else if (sender == leGenders) {
                if (string.IsNullOrEmpty(e.DisplayText)) {
                    e.DisplayText = "<Bitte Geschlecht wählen>";
                }
            }
            else if (sender == leCities) {
                if (string.IsNullOrEmpty(e.DisplayText)) {
                    e.DisplayText = "<Bitte Stadt wählen>";
                }
            }
            else if (sender == leClasses) {
                if (string.IsNullOrEmpty(e.DisplayText)) {
                    e.DisplayText = "<Bitte Klasse wählen>";
                }
            }
            else if (sender == ccbeFunctions) {
                if (string.IsNullOrEmpty(e.DisplayText)) {
                    e.DisplayText = "<Bitte Funktion(en) wählen>";
                }
            }
        }
    }
}
