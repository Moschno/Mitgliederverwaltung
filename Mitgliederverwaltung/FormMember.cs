using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Mitgliederverwaltung.Database;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;

namespace Mitgliederverwaltung {
    public partial class FormMember : DevExpress.XtraBars.Ribbon.RibbonForm {
        private MitgliederverwaltungTestdatenDbContext dbContext;
        private List<object> colFunctionsCellValues = new List<object>();
        private string colFuntionsIdSeperator = ", ";

        public FormMember() {
            InitializeComponent();

            dbContext = new MitgliederverwaltungTestdatenDbContext();
            memberBindingSource.DataSource = dbContext.Members.ToList<Member>();
            genderBindingSource.DataSource = dbContext.Genders.ToList<Gender>();
            cityBindingSource.DataSource = dbContext.Cities.ToList<City>();
            classBindingSource.DataSource = dbContext.Classes.ToList<Class>();
            functionBindingSource.DataSource = dbContext.Functions.ToList<Function>();
            memberFunctionBindingSource.DataSource = dbContext.MemberFunctions.ToList<MemberFunction>();

            foreach (Member member in dbContext.Members.Local.ToList<Member>()) {
                StringBuilder functions;
                GetMemberFunctionIds(member, out functions);
                colFunctionsCellValues.Add(functions as object);
            }
        }

        private bool GetMemberFunctionIds(Member member, out StringBuilder functions) {
            if (member.MemberFunctions.Count > 0) {
                functions = new StringBuilder(member.MemberFunctions.Count * 3, member.MemberFunctions.Count * 3);
                List<int> functionIds = new List<int>();
                foreach (MemberFunction function in member.MemberFunctions) {
                    functionIds.Add(function.FunctionID.Value); 
                }
                functionIds.Sort();
                foreach (int id in functionIds) {
                    functions.Append(id + colFuntionsIdSeperator);
                }
                functions.Length = functions.Length - 2;
                return true;
            }

            functions = new StringBuilder();
            return false;
        }

        private void ribbon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (e.Item == btnSaveChanges) {
                SaveAllData();
                ShowSaveDialog();
            }
            else if (e.Item == btnCancelEdit) {
                dbContext = new MitgliederverwaltungTestdatenDbContext();
                memberBindingSource.DataSource = dbContext.Members.ToList<Member>();
            }
            else if (e.Item == btnAddMember) {
                if (dbContext.Members.Local.Count == dbContext.Members.Count()) {
                    colFunctionsCellValues.Add("" as object);
                    dbContext.Members.Local.Add(new Member());
                    memberBindingSource.DataSource = dbContext.Members.Local.ToList<Member>();
                }
            }
            else if (e.Item == btnAddCity) {
                string userInput;
                if (GetStringFromUser(out userInput, FormInput.InputType.City)) {
                    dbContext.Cities.Local.Add(new City() { Name = userInput });
                    dbContext.SaveChanges();
                    cityBindingSource.DataSource = dbContext.Cities.Local.ToList<City>();
                }
            }
            else if (e.Item == btnAddClass) {
                string userInput;
                if (GetStringFromUser(out userInput, FormInput.InputType.Class)) {
                    dbContext.Classes.Local.Add(new Class() { Description = userInput });
                    dbContext.SaveChanges();
                    classBindingSource.DataSource = dbContext.Classes.Local.ToList<Class>();
                }
            }
            else if (e.Item == btnAddFunction) {
                string userInput;
                if (GetStringFromUser(out userInput, FormInput.InputType.Function)) {
                    dbContext.Functions.Local.Add(new Function() { Description = userInput });
                    functionBindingSource.DataSource = dbContext.Functions.Local.ToList<Function>();
                    dbContext.SaveChanges();
                }
            }
            else if (e.Item == btnDeleteMember) {
                DialogResult result = XtraMessageBox.Show("Möchten Sie das Mitglied endgültig löschen?", "Bestätigung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.OK) {
                    Member member;
                    if (GetMemberFromFocusedRow(out member)) {
                        colFunctionsCellValues.RemoveAt(dbContext.Members.Local.IndexOf(member));
                        RemoveMemberFunctionsFromLocalDbContext(member);
                        dbContext.Members.Local.Remove(member);
                        memberBindingSource.DataSource = dbContext.Members.Local.ToList<Member>();
                        SaveAllData();
                    }
                }
            }
            else if (e.Item == btnDeleteCity) {
                DialogResult result = XtraMessageBox.Show("Möchten Sie die Stadt endgültig löschen?", "Bestätigung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.OK) {
                    City city;
                    if (GetCityFromFocusedRow(out city)) {
                        dbContext.Cities.Local.Remove(city);
                        dbContext.SaveChanges();
                        cityBindingSource.DataSource = dbContext.Cities.Local.ToList<City>();
                    }
                }
            }
            else if (e.Item == btnDeleteClass) {
                DialogResult result = XtraMessageBox.Show("Möchten Sie die Klasse endgültig löschen?", "Bestätigung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.OK) {
                    Class classs;
                    if (GetClassFromFocusedRow(out classs)) {
                        dbContext.Classes.Local.Remove(classs);
                        dbContext.SaveChanges();
                        classBindingSource.DataSource = dbContext.Classes.Local.ToList<Class>();
                    }
                }
            }
            else if (e.Item == btnDeleteFunction) {
                DialogResult result = XtraMessageBox.Show("Möchten Sie die Funktion endgültig löschen?", "Bestätigung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.OK) {
                    Function function;
                    if (GetFunctionFromFocusedRow(out function)) {
                        List<MemberFunction> invalidFunctions = (from a in dbContext.MemberFunctions.Local
                                                                 where a.FunctionID == function.ID
                                                                 select a).ToList<MemberFunction>();
                        foreach (MemberFunction func in invalidFunctions) {
                            dbContext.MemberFunctions.Local.Remove(func);
                        }
                        dbContext.Functions.Local.Remove(function);
                        dbContext.SaveChanges();
                        functionBindingSource.DataSource = dbContext.Functions.Local.ToList<Function>();
                    }
                }
            }
        }

        private bool GetStringFromUser(out string userInput, FormInput.InputType type) {
            FormInput input = new FormInput(type);
            input.ShowDialog(this);
            if (!String.IsNullOrWhiteSpace(input.InputString)) {
                userInput = input.InputString;
                return true;
            }
            else {
                userInput = "";
                return false;
            }
        }

        private void ShowSaveDialog() {
            XtraMessageBox.Show(
                "Daten gespeichert.",
                "Hinweis",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void SaveAllData() {
            UpdateLocalDbContextMemberFunctionsObjects();
            dbContext.SaveChanges();
        }

        private void RemoveMemberFunctionsFromLocalDbContext(Member member) {
            List<MemberFunction> memberFunctions = new List<MemberFunction>();
            foreach (MemberFunction function in member.MemberFunctions) {
                memberFunctions.Add(function);
            }
            foreach (MemberFunction function in memberFunctions) {
                dbContext.MemberFunctions.Local.Remove(function);
            }
        }

        private bool GetMemberFromFocusedRow(out Member member) {
            int? memberID = (int?)viewCoreData.GetFocusedRowCellValue(colID);
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

        private bool GetCityFromFocusedRow(out City city) {
            int? cityId = (int?)gridViewAdministration.GetFocusedRowCellValue(colIdAdmin);
            if (cityId != null) {
                city = (from a in dbContext.Cities.Local.ToList<City>()
                        where a.Id == cityId
                        select a).SingleOrDefault();
                if (city != null) {
                    return true;
                }
            }

            city = new City();
            return false;
        }

        private bool GetClassFromFocusedRow(out Class classs) {
            int? classId = (int?)gridViewAdministration.GetFocusedRowCellValue(colIdAdmin);
            if (classId != null) {
                classs = (from a in dbContext.Classes.Local.ToList<Class>()
                        where a.ID == classId
                        select a).SingleOrDefault();
                if (classs != null) {
                    return true;
                }
            }

            classs = new Class();
            return false;
        }

        private bool GetFunctionFromFocusedRow(out Function function) {
            int? functionId = (int?)gridViewAdministration.GetFocusedRowCellValue(colIdAdmin);
            if (functionId != null) {
                function = (from a in dbContext.Functions.Local.ToList<Function>()
                        where a.ID == functionId
                        select a).SingleOrDefault();
                if (function != null) {
                    return true;
                }
            }

            function = new Function();
            return false;
        }

        private void UpdateLocalDbContextMemberFunctionsObjects() {
            viewCoreData.CloseEditor();

            //Funktionen eines jeden Mitglieds in Datenbank abspeichern
            for (int i = 0; i < dbContext.Members.Local.Count; i++) {
                //Um dieses Mitglied geht es aktuell
                Member member = dbContext.Members.Local[i];

                //Bisherige Funktionen des Mitglieds in Liste schreiben
                List<int> oldFunctionIds = new List<int>();
                foreach (MemberFunction function in member.MemberFunctions) {
                    oldFunctionIds.Add(function.FunctionID.Value);
                }

                //Aktuelle Funktionen des Mitglieds in Listen schreiben
                List<int> newFunctionIds = new List<int>();
                string newFunctionIdsString = colFunctionsCellValues[i].ToString();
                if (!String.IsNullOrEmpty(newFunctionIdsString)) {
                    int seperatorPos = newFunctionIdsString.IndexOf(colFuntionsIdSeperator);
                    while (seperatorPos != -1) {
                        newFunctionIds.Add(Convert.ToInt32(newFunctionIdsString.Substring(0, seperatorPos)));
                        newFunctionIdsString = newFunctionIdsString.Remove(0, seperatorPos + colFuntionsIdSeperator.Length);
                        seperatorPos = newFunctionIdsString.IndexOf(colFuntionsIdSeperator);
                    }
                    newFunctionIds.Add(Convert.ToInt32(newFunctionIdsString));
                }
                newFunctionIdsString = null;

                //Listen aufsteigend sortieren
                oldFunctionIds.Sort();
                newFunctionIds.Sort();

                if (!(oldFunctionIds.Count == 0 && newFunctionIds.Count == 0)) {
                    //Alle bisherigen und aktuellen Funktions-Ids in Liste schreiben, Duplikate entfernen und Liste sortieren
                    List<int> allFunctionIds = new List<int>();
                    allFunctionIds.AddRange(oldFunctionIds);
                    allFunctionIds.AddRange(newFunctionIds);
                    allFunctionIds = allFunctionIds.Distinct().ToList<int>();
                    allFunctionIds.Sort();

                    //Zwei neue ID-Listen erstellen:
                    //  Neue Funktionen des Mitglieds
                    //  Entfernte Funktionen des Mitglieds
                    List<int> memberFunctionsToAdd = new List<int>();
                    List<int> memberFunctionsToDelete = new List<int>();

                    //Listen befüllen
                    while (allFunctionIds.Count > 0) {
                        int id = allFunctionIds.First();
                        if (id != oldFunctionIds.FirstOrDefault()) {
                            memberFunctionsToAdd.Add(id);
                            newFunctionIds.Remove(id);
                        }
                        else if (id != newFunctionIds.FirstOrDefault()) {
                            memberFunctionsToDelete.Add(id);
                            oldFunctionIds.Remove(id);
                        }
                        else {
                            oldFunctionIds.Remove(id);
                            newFunctionIds.Remove(id);
                        }
                        allFunctionIds.Remove(id);
                    }

                    //Ehemalige Funtionen des Mitglieds löschen
                    foreach (int id in memberFunctionsToDelete) {
                        MemberFunction function = (from a in dbContext.MemberFunctions.Local
                                                   where a.MemberID == member.ID &&
                                                         a.FunctionID == id
                                                   select a).SingleOrDefault();
                        dbContext.MemberFunctions.Local.Remove(function);
                    }

                    //Neue Funtionen des Mitglieds hinzufügen
                    foreach (int id in memberFunctionsToAdd) {
                        MemberFunction function = new MemberFunction() {
                            FunctionID = id,
                            MemberID = member.ID
                        };
                        dbContext.MemberFunctions.Local.Add(function);
                    }
                }
            }
        }

        private void view_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if (gridControlCoreData.Enabled) {
                if (e.Column == colFunctions) {
                    if (e.IsSetData) {
                        colFunctionsCellValues[e.ListSourceRowIndex] = e.Value;
                    }
                    else {
                        e.Value = colFunctionsCellValues[e.ListSourceRowIndex];
                    }
                }
                else if (e.Column == colAgeGroup) {
                    e.Value = GetAgeGroup(e.ListSourceRowIndex);
                }
            }
        }

        private string GetAgeGroup(int listSourceRowIndex) {
            DateTime dateOfBirth = Convert.ToDateTime(viewCoreData.GetListSourceRowCellValue(listSourceRowIndex, colDateOfBirth));
            int age = GetAgeFromDate(dateOfBirth);
            if (age >= 0 && age <= 6) {
                return "AK I - bis 6 Jahre";
            }
            else if (age >= 7 && age <= 14) {
                return "AK II - 7-14 Jahre";
            }
            else if (age >= 15 && age <= 18) {
                return "AK III - 15-18 Jahre";
            }
            else if (age >= 19 && age <= 26) {
                return "AK IV - 19-26 Jahre";
            }
            else if (age >= 27 && age <= 40) {
                return "AK V - 27-40 Jahre";
            }
            else if (age >= 41 && age <= 50) {
                return "AK VI - 41-50 Jahre";
            }
            else if (age >= 51 && age <= 60) {
                return "AK VII - 51-60 Jahre";
            }
            else if (age >= 61) {
                return "AK VIII - über 60 Jahre";
            }
            else {
                return "";
            }
            
        }

        private int GetAgeFromDate(DateTime birthday) {
            if (birthday == DateTime.MinValue ||
                birthday.Year >= DateTime.Now.Year &&
                birthday.Month >= DateTime.Now.Month &&
                birthday.Day > DateTime.Now.Day) {
                    return -1;
            }
	        int age = ((DateTime.Now.Year - birthday.Year) * 372 + (DateTime.Now.Month - birthday.Month) * 31 + (DateTime.Now.Day - birthday.Day)) / 372;
            return age; 
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

        private void FormMember_FormClosing(object sender, FormClosingEventArgs e) {
            foreach (Member member in dbContext.Members.Local) {
                if (dbContext.Entry(member).State != System.Data.Entity.EntityState.Unchanged) {
                    DialogResult result = XtraMessageBox.Show(
                        "Einige Änderungen wurden nicht gespeichert. Möchten Sie sie speichern?",
                        "Hinweis",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Information
                    );
                    if (result == DialogResult.Yes) {
                        SaveAllData();
                    }
                    else if (result == DialogResult.Cancel) {
                        e.Cancel = true;
                    }
                    break;
                }
            }
        }

        private void ribbonControl_SelectedPageChanging(object sender, DevExpress.XtraBars.Ribbon.RibbonPageChangingEventArgs e) {
            if (e.Page == ribbonPageCoreData) {
                gridControlCoreData.Enabled = true;
                gridControlCoreData.Visible = true;
                gridControlAdministration.Enabled = false;
                gridControlAdministration.Visible = false;
                gridControlAdministration.DataSource = null;
            }
            else {
                gridControlCoreData.Enabled = false;
                gridControlCoreData.Visible = false;
                gridControlAdministration.Enabled = true;
                gridControlAdministration.Visible = true;
                gridControlAdministration.BeginUpdate();
                if (e.Page == ribbonPageCities) {
                    cityBindingSource.DataSource = dbContext.Cities.ToList<City>();
                    gridControlAdministration.DataSource = cityBindingSource;
                    colIdAdmin.FieldName = "Id";
                    colName.FieldName = "Name";
                }
                else if (e.Page == ribbonPageClasses) {
                    classBindingSource.DataSource = dbContext.Classes.ToList<Class>();
                    gridControlAdministration.DataSource = classBindingSource;
                    colIdAdmin.FieldName = "ID";
                    colName.FieldName = "Description";
                }
                else if (e.Page == ribbonPageFunctions) {
                    functionBindingSource.DataSource = dbContext.Functions.ToList<Function>();
                    gridControlAdministration.DataSource = functionBindingSource;
                    colIdAdmin.FieldName = "ID";
                    colName.FieldName = "Description";
                }
                gridControlAdministration.EndUpdate();
            }
        }
    }
}
