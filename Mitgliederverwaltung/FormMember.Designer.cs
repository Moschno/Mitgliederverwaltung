namespace Mitgliederverwaltung
{
    partial class FormMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageMember = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridMember = new DevExpress.XtraGrid.GridControl();
            this.viewMember = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colForeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colGenderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leGenders = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colStreet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leCities = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTelefonNumber1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonNumber2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonNumber3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHealthInsuranceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfClubEntry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClassID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.leClasses = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colClass2ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClass1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMemberFunctions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunctions = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ccbeFunctions = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.functionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.beFunctions = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.naviGridMember = new DevExpress.XtraEditors.ControlNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leGenders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbeFunctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFunctions)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 6;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageMember});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl.Size = new System.Drawing.Size(808, 147);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPageMember
            // 
            this.ribbonPageMember.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPageMember.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageMember.Image")));
            this.ribbonPageMember.Name = "ribbonPageMember";
            this.ribbonPageMember.Text = "Stammdaten";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.Member);
            // 
            // gridMember
            // 
            this.gridMember.DataSource = this.memberBindingSource;
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMember.Location = new System.Drawing.Point(0, 147);
            this.gridMember.MainView = this.viewMember;
            this.gridMember.MenuManager = this.ribbonControl;
            this.gridMember.Name = "gridMember";
            this.gridMember.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.leGenders,
            this.leCities,
            this.leClasses,
            this.deDate,
            this.beFunctions,
            this.ccbeFunctions});
            this.gridMember.Size = new System.Drawing.Size(808, 343);
            this.gridMember.TabIndex = 2;
            this.gridMember.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewMember});
            // 
            // viewMember
            // 
            this.viewMember.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colLastName,
            this.colForeName,
            this.colDateOfBirth,
            this.colGenderID,
            this.colStreet,
            this.colPostCode,
            this.colCityID,
            this.colTelefonNumber1,
            this.colTelefonNumber2,
            this.colTelefonNumber3,
            this.colEMail,
            this.colHealthInsuranceNumber,
            this.colDateOfClubEntry,
            this.colClassID,
            this.colClass2ID,
            this.colNote,
            this.colCity,
            this.colClass,
            this.colClass1,
            this.colGender,
            this.colMemberFunctions,
            this.colFunctions});
            this.viewMember.GridControl = this.gridMember;
            this.viewMember.Name = "viewMember";
            this.viewMember.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.viewMember_CustomUnboundColumnData);
            this.viewMember.DataSourceChanged += new System.EventHandler(this.viewMember_DataSourceChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 31;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 1;
            this.colLastName.Width = 41;
            // 
            // colForeName
            // 
            this.colForeName.FieldName = "ForeName";
            this.colForeName.Name = "colForeName";
            this.colForeName.Visible = true;
            this.colForeName.VisibleIndex = 2;
            this.colForeName.Width = 41;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.ColumnEdit = this.deDate;
            this.colDateOfBirth.FieldName = "DateOfBirth";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.Visible = true;
            this.colDateOfBirth.VisibleIndex = 3;
            this.colDateOfBirth.Width = 41;
            // 
            // deDate
            // 
            this.deDate.AutoHeight = false;
            this.deDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Name = "deDate";
            this.deDate.NullText = "<Bitte Datum wählen>";
            this.deDate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colGenderID
            // 
            this.colGenderID.ColumnEdit = this.leGenders;
            this.colGenderID.FieldName = "GenderID";
            this.colGenderID.Name = "colGenderID";
            this.colGenderID.Visible = true;
            this.colGenderID.VisibleIndex = 4;
            this.colGenderID.Width = 41;
            // 
            // leGenders
            // 
            this.leGenders.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.leGenders.AutoHeight = false;
            this.leGenders.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leGenders.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Members", "Members", 53, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.leGenders.DataSource = this.genderBindingSource;
            this.leGenders.DisplayMember = "Description";
            this.leGenders.Name = "leGenders";
            this.leGenders.NullText = "<Bitte Geschlecht wählen>";
            this.leGenders.ValueMember = "ID";
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.Gender);
            // 
            // colStreet
            // 
            this.colStreet.FieldName = "Street";
            this.colStreet.Name = "colStreet";
            this.colStreet.Visible = true;
            this.colStreet.VisibleIndex = 5;
            this.colStreet.Width = 40;
            // 
            // colPostCode
            // 
            this.colPostCode.FieldName = "PostCode";
            this.colPostCode.Name = "colPostCode";
            this.colPostCode.Visible = true;
            this.colPostCode.VisibleIndex = 6;
            this.colPostCode.Width = 40;
            // 
            // colCityID
            // 
            this.colCityID.ColumnEdit = this.leCities;
            this.colCityID.FieldName = "CityID";
            this.colCityID.Name = "colCityID";
            this.colCityID.Visible = true;
            this.colCityID.VisibleIndex = 7;
            this.colCityID.Width = 40;
            // 
            // leCities
            // 
            this.leCities.AutoHeight = false;
            this.leCities.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leCities.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 33, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Members", "Members", 53, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.leCities.DataSource = this.cityBindingSource;
            this.leCities.DisplayMember = "Name";
            this.leCities.Name = "leCities";
            this.leCities.NullText = "<Bitte Stadt wählen>";
            this.leCities.ValueMember = "Id";
            this.leCities.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.leCities_EditValueChanging);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.City);
            // 
            // colTelefonNumber1
            // 
            this.colTelefonNumber1.FieldName = "TelefonNumber1";
            this.colTelefonNumber1.Name = "colTelefonNumber1";
            this.colTelefonNumber1.Visible = true;
            this.colTelefonNumber1.VisibleIndex = 8;
            this.colTelefonNumber1.Width = 40;
            // 
            // colTelefonNumber2
            // 
            this.colTelefonNumber2.FieldName = "TelefonNumber2";
            this.colTelefonNumber2.Name = "colTelefonNumber2";
            this.colTelefonNumber2.Visible = true;
            this.colTelefonNumber2.VisibleIndex = 9;
            this.colTelefonNumber2.Width = 40;
            // 
            // colTelefonNumber3
            // 
            this.colTelefonNumber3.FieldName = "TelefonNumber3";
            this.colTelefonNumber3.Name = "colTelefonNumber3";
            this.colTelefonNumber3.Visible = true;
            this.colTelefonNumber3.VisibleIndex = 10;
            this.colTelefonNumber3.Width = 40;
            // 
            // colEMail
            // 
            this.colEMail.FieldName = "EMail";
            this.colEMail.Name = "colEMail";
            this.colEMail.Visible = true;
            this.colEMail.VisibleIndex = 11;
            this.colEMail.Width = 40;
            // 
            // colHealthInsuranceNumber
            // 
            this.colHealthInsuranceNumber.FieldName = "HealthInsuranceNumber";
            this.colHealthInsuranceNumber.Name = "colHealthInsuranceNumber";
            this.colHealthInsuranceNumber.Visible = true;
            this.colHealthInsuranceNumber.VisibleIndex = 12;
            this.colHealthInsuranceNumber.Width = 40;
            // 
            // colDateOfClubEntry
            // 
            this.colDateOfClubEntry.ColumnEdit = this.deDate;
            this.colDateOfClubEntry.FieldName = "DateOfClubEntry";
            this.colDateOfClubEntry.Name = "colDateOfClubEntry";
            this.colDateOfClubEntry.Visible = true;
            this.colDateOfClubEntry.VisibleIndex = 13;
            this.colDateOfClubEntry.Width = 40;
            // 
            // colClassID
            // 
            this.colClassID.ColumnEdit = this.leClasses;
            this.colClassID.FieldName = "ClassID";
            this.colClassID.Name = "colClassID";
            this.colClassID.Visible = true;
            this.colClassID.VisibleIndex = 14;
            this.colClassID.Width = 40;
            // 
            // leClasses
            // 
            this.leClasses.AutoHeight = false;
            this.leClasses.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leClasses.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Number", "Number", 47, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Members", "Members", 53, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Members1", "Members1", 59, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.leClasses.DataSource = this.classBindingSource;
            this.leClasses.DisplayMember = "Number";
            this.leClasses.Name = "leClasses";
            this.leClasses.NullText = "<Bitte Klasse wählen>";
            this.leClasses.ValueMember = "ID";
            this.leClasses.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.leClasses_EditValueChanging);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.Class);
            // 
            // colClass2ID
            // 
            this.colClass2ID.ColumnEdit = this.leClasses;
            this.colClass2ID.FieldName = "Class2ID";
            this.colClass2ID.Name = "colClass2ID";
            this.colClass2ID.Visible = true;
            this.colClass2ID.VisibleIndex = 15;
            this.colClass2ID.Width = 40;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 16;
            this.colNote.Width = 41;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            // 
            // colClass
            // 
            this.colClass.FieldName = "Class";
            this.colClass.Name = "colClass";
            // 
            // colClass1
            // 
            this.colClass1.FieldName = "Class1";
            this.colClass1.Name = "colClass1";
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            // 
            // colMemberFunctions
            // 
            this.colMemberFunctions.FieldName = "MemberFunctions";
            this.colMemberFunctions.Name = "colMemberFunctions";
            // 
            // colFunctions
            // 
            this.colFunctions.Caption = "Funktion(en)";
            this.colFunctions.ColumnEdit = this.ccbeFunctions;
            this.colFunctions.FieldName = "colFunctions";
            this.colFunctions.Name = "colFunctions";
            this.colFunctions.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colFunctions.Visible = true;
            this.colFunctions.VisibleIndex = 17;
            this.colFunctions.Width = 114;
            // 
            // ccbeFunctions
            // 
            this.ccbeFunctions.AutoHeight = false;
            this.ccbeFunctions.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbeFunctions.DataSource = this.functionBindingSource;
            this.ccbeFunctions.DisplayMember = "Description";
            this.ccbeFunctions.Name = "ccbeFunctions";
            this.ccbeFunctions.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ccbeFunctions.ValueMember = "ID";
            // 
            // functionBindingSource
            // 
            this.functionBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.Function);
            // 
            // beFunctions
            // 
            this.beFunctions.AutoHeight = false;
            this.beFunctions.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beFunctions.Name = "beFunctions";
            this.beFunctions.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.beFunctions_ButtonClick);
            // 
            // naviGridMember
            // 
            this.naviGridMember.Location = new System.Drawing.Point(0, 471);
            this.naviGridMember.Name = "naviGridMember";
            this.naviGridMember.NavigatableControl = this.gridMember;
            this.naviGridMember.Size = new System.Drawing.Size(268, 19);
            this.naviGridMember.TabIndex = 3;
            this.naviGridMember.Text = "controlNavigator1";
            this.naviGridMember.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center;
            this.naviGridMember.TextStringFormat = "Mitglied {0} von {1}";
            this.naviGridMember.ToolTip = "Änderungen gespeichert";
            this.naviGridMember.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.naviGridMember.ToolTipTitle = "Bla";
            this.naviGridMember.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.naviGridMember_ButtonClick);
            // 
            // FormMember
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 490);
            this.Controls.Add(this.naviGridMember);
            this.Controls.Add(this.gridMember);
            this.Controls.Add(this.ribbonControl);
            this.Name = "FormMember";
            this.Ribbon = this.ribbonControl;
            this.Text = "Stammdaten";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leGenders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbeFunctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beFunctions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageMember;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private DevExpress.XtraGrid.GridControl gridMember;
        private DevExpress.XtraGrid.Views.Grid.GridView viewMember;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colForeName;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colGenderID;
        private DevExpress.XtraGrid.Columns.GridColumn colStreet;
        private DevExpress.XtraGrid.Columns.GridColumn colPostCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCityID;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonNumber1;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonNumber2;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonNumber3;
        private DevExpress.XtraGrid.Columns.GridColumn colEMail;
        private DevExpress.XtraGrid.Columns.GridColumn colHealthInsuranceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfClubEntry;
        private DevExpress.XtraGrid.Columns.GridColumn colClassID;
        private DevExpress.XtraGrid.Columns.GridColumn colClass2ID;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colClass;
        private DevExpress.XtraGrid.Columns.GridColumn colClass1;
        private DevExpress.XtraGrid.Columns.GridColumn colGender;
        private DevExpress.XtraGrid.Columns.GridColumn colMemberFunctions;
        private DevExpress.XtraEditors.ControlNavigator naviGridMember;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leGenders;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leCities;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leClasses;
        private System.Windows.Forms.BindingSource classBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit deDate;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.Columns.GridColumn colFunctions;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit beFunctions;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit ccbeFunctions;
        private System.Windows.Forms.BindingSource functionBindingSource;
    }
}

