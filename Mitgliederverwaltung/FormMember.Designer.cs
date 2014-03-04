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
            this.sharedImageCollection = new DevExpress.Utils.SharedImageCollection(this.components);
            this.btnAddMember = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteMember = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveChanges = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategoryCoreData = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPageCoreData = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupAddMember = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDeleteMember = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupCancelEdit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupSaveChanges = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCategoryAdministration = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPageCities = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageClasses = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.viewCoreData = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colLastName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colForeName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCity = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colClass = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colClass1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGender = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMemberFunctions = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colGenderID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.leGenders = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colDateOfBirth = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.deDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colStreet = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCityID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.leCities = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colPostCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTelefonNumber1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTelefonNumber2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTelefonNumber3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEMail = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colClassID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.leClasses = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colClass2ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHealthInsuranceNumber = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFunctions = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ccbeFunctions = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.functionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colDateOfClubEntry = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colNote = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.memoEditNote = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPageFunctions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection.ImageSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCoreData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leGenders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbeFunctions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNote)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.AllowMinimizeRibbon = false;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Images = this.sharedImageCollection;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnAddMember,
            this.btnDeleteMember,
            this.btnCancelEdit,
            this.btnSaveChanges});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 5;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategoryCoreData,
            this.ribbonPageCategoryAdministration});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(934, 152);
            // 
            // sharedImageCollection
            // 
            // 
            // 
            // 
            this.sharedImageCollection.ImageSource.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("sharedImageCollection.ImageSource.ImageStream")));
            this.sharedImageCollection.ImageSource.Images.SetKeyName(0, "House_32x32.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(1, "usergroup_32x32.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(2, "Medal_32x32.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(3, "add_32x32.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(4, "clear_32x32.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(5, "doublefirst_32x32.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(6, "apply_32x32.png");
            this.sharedImageCollection.ImageSource.Images.SetKeyName(7, "publicfix_32x32.png");
            this.sharedImageCollection.ParentControl = this;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Id = 1;
            this.btnAddMember.ImageIndex = 3;
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAddMember.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbonCoreData_ItemClick);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Id = 2;
            this.btnDeleteMember.ImageIndex = 4;
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDeleteMember.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbonCoreData_ItemClick);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Id = 3;
            this.btnCancelEdit.ImageIndex = 5;
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCancelEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbonCoreData_ItemClick);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Id = 4;
            this.btnSaveChanges.ImageIndex = 6;
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSaveChanges.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbonCoreData_ItemClick);
            // 
            // ribbonPageCategoryCoreData
            // 
            this.ribbonPageCategoryCoreData.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ribbonPageCategoryCoreData.Name = "ribbonPageCategoryCoreData";
            this.ribbonPageCategoryCoreData.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageCoreData});
            this.ribbonPageCategoryCoreData.Text = "Mitglieder";
            // 
            // ribbonPageCoreData
            // 
            this.ribbonPageCoreData.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupAddMember,
            this.ribbonPageGroupDeleteMember,
            this.ribbonPageGroupCancelEdit,
            this.ribbonPageGroupSaveChanges});
            this.ribbonPageCoreData.ImageIndex = 1;
            this.ribbonPageCoreData.Name = "ribbonPageCoreData";
            this.ribbonPageCoreData.Text = "Stammdaten";
            // 
            // ribbonPageGroupAddMember
            // 
            this.ribbonPageGroupAddMember.ItemLinks.Add(this.btnAddMember);
            this.ribbonPageGroupAddMember.Name = "ribbonPageGroupAddMember";
            this.ribbonPageGroupAddMember.ShowCaptionButton = false;
            this.ribbonPageGroupAddMember.Text = "Mitglied hinzufügen";
            // 
            // ribbonPageGroupDeleteMember
            // 
            this.ribbonPageGroupDeleteMember.ItemLinks.Add(this.btnDeleteMember);
            this.ribbonPageGroupDeleteMember.Name = "ribbonPageGroupDeleteMember";
            this.ribbonPageGroupDeleteMember.ShowCaptionButton = false;
            this.ribbonPageGroupDeleteMember.Text = "Mitglied löschen";
            // 
            // ribbonPageGroupCancelEdit
            // 
            this.ribbonPageGroupCancelEdit.ItemLinks.Add(this.btnCancelEdit);
            this.ribbonPageGroupCancelEdit.Name = "ribbonPageGroupCancelEdit";
            this.ribbonPageGroupCancelEdit.ShowCaptionButton = false;
            this.ribbonPageGroupCancelEdit.Text = "Änderungen verwerfen";
            // 
            // ribbonPageGroupSaveChanges
            // 
            this.ribbonPageGroupSaveChanges.ItemLinks.Add(this.btnSaveChanges);
            this.ribbonPageGroupSaveChanges.Name = "ribbonPageGroupSaveChanges";
            this.ribbonPageGroupSaveChanges.ShowCaptionButton = false;
            this.ribbonPageGroupSaveChanges.Text = "Änderungen speichern";
            // 
            // ribbonPageCategoryAdministration
            // 
            this.ribbonPageCategoryAdministration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ribbonPageCategoryAdministration.Name = "ribbonPageCategoryAdministration";
            this.ribbonPageCategoryAdministration.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageCities,
            this.ribbonPageClasses,
            this.ribbonPageFunctions});
            this.ribbonPageCategoryAdministration.Text = "Verwaltung";
            // 
            // ribbonPageCities
            // 
            this.ribbonPageCities.ImageIndex = 0;
            this.ribbonPageCities.Name = "ribbonPageCities";
            this.ribbonPageCities.Text = "Städte";
            // 
            // ribbonPageClasses
            // 
            this.ribbonPageClasses.ImageIndex = 2;
            this.ribbonPageClasses.Name = "ribbonPageClasses";
            this.ribbonPageClasses.Text = "Klassen";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.Member);
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.memberBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 152);
            this.gridControl.MainView = this.viewCoreData;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.leGenders,
            this.leCities,
            this.leClasses,
            this.deDate,
            this.ccbeFunctions,
            this.memoEditNote});
            this.gridControl.Size = new System.Drawing.Size(934, 336);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewCoreData});
            // 
            // viewCoreData
            // 
            this.viewCoreData.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.gridBand5});
            this.viewCoreData.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
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
            this.viewCoreData.GridControl = this.gridControl;
            this.viewCoreData.Name = "viewCoreData";
            this.viewCoreData.OptionsView.ColumnAutoWidth = true;
            this.viewCoreData.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.view_CustomUnboundColumnData);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Person";
            this.gridBand1.Columns.Add(this.colID);
            this.gridBand1.Columns.Add(this.colLastName);
            this.gridBand1.Columns.Add(this.colForeName);
            this.gridBand1.Columns.Add(this.colCity);
            this.gridBand1.Columns.Add(this.colClass);
            this.gridBand1.Columns.Add(this.colClass1);
            this.gridBand1.Columns.Add(this.colGender);
            this.gridBand1.Columns.Add(this.colMemberFunctions);
            this.gridBand1.Columns.Add(this.colGenderID);
            this.gridBand1.Columns.Add(this.colDateOfBirth);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 167;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 39;
            // 
            // colLastName
            // 
            this.colLastName.Caption = "Nachname";
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.Width = 83;
            // 
            // colForeName
            // 
            this.colForeName.Caption = "Vorname";
            this.colForeName.FieldName = "ForeName";
            this.colForeName.Name = "colForeName";
            this.colForeName.Visible = true;
            this.colForeName.Width = 84;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Width = 39;
            // 
            // colClass
            // 
            this.colClass.FieldName = "Class";
            this.colClass.Name = "colClass";
            this.colClass.Width = 39;
            // 
            // colClass1
            // 
            this.colClass1.FieldName = "Class1";
            this.colClass1.Name = "colClass1";
            this.colClass1.Width = 39;
            // 
            // colGender
            // 
            this.colGender.FieldName = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.Width = 39;
            // 
            // colMemberFunctions
            // 
            this.colMemberFunctions.FieldName = "MemberFunctions";
            this.colMemberFunctions.Name = "colMemberFunctions";
            this.colMemberFunctions.Width = 39;
            // 
            // colGenderID
            // 
            this.colGenderID.Caption = "Geschlecht";
            this.colGenderID.ColumnEdit = this.leGenders;
            this.colGenderID.FieldName = "GenderID";
            this.colGenderID.Name = "colGenderID";
            this.colGenderID.RowIndex = 1;
            this.colGenderID.Visible = true;
            this.colGenderID.Width = 83;
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
            this.leGenders.NullText = "";
            this.leGenders.ValueMember = "ID";
            this.leGenders.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.Repository_CustomDisplayText);
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.Gender);
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.Caption = "Geburtsdatum";
            this.colDateOfBirth.ColumnEdit = this.deDate;
            this.colDateOfBirth.FieldName = "DateOfBirth";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.RowIndex = 1;
            this.colDateOfBirth.Visible = true;
            this.colDateOfBirth.Width = 84;
            // 
            // deDate
            // 
            this.deDate.AutoHeight = false;
            this.deDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Name = "deDate";
            this.deDate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.deDate.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.Repository_CustomDisplayText);
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Wohnsitz";
            this.gridBand2.Columns.Add(this.colStreet);
            this.gridBand2.Columns.Add(this.colCityID);
            this.gridBand2.Columns.Add(this.colPostCode);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 179;
            // 
            // colStreet
            // 
            this.colStreet.Caption = "Straße";
            this.colStreet.FieldName = "Street";
            this.colStreet.Name = "colStreet";
            this.colStreet.Visible = true;
            this.colStreet.Width = 179;
            // 
            // colCityID
            // 
            this.colCityID.Caption = "Stadt";
            this.colCityID.ColumnEdit = this.leCities;
            this.colCityID.FieldName = "CityID";
            this.colCityID.Name = "colCityID";
            this.colCityID.RowIndex = 1;
            this.colCityID.Visible = true;
            this.colCityID.Width = 122;
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
            this.leCities.NullText = "";
            this.leCities.ValueMember = "Id";
            this.leCities.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.leCities_EditValueChanging);
            this.leCities.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.Repository_CustomDisplayText);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.City);
            // 
            // colPostCode
            // 
            this.colPostCode.Caption = "PLZ";
            this.colPostCode.FieldName = "PostCode";
            this.colPostCode.Name = "colPostCode";
            this.colPostCode.RowIndex = 1;
            this.colPostCode.Visible = true;
            this.colPostCode.Width = 57;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Kontakt";
            this.gridBand3.Columns.Add(this.colTelefonNumber1);
            this.gridBand3.Columns.Add(this.colTelefonNumber2);
            this.gridBand3.Columns.Add(this.colTelefonNumber3);
            this.gridBand3.Columns.Add(this.colEMail);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 194;
            // 
            // colTelefonNumber1
            // 
            this.colTelefonNumber1.Caption = "Telefonnumer 1";
            this.colTelefonNumber1.FieldName = "TelefonNumber1";
            this.colTelefonNumber1.Name = "colTelefonNumber1";
            this.colTelefonNumber1.Visible = true;
            this.colTelefonNumber1.Width = 95;
            // 
            // colTelefonNumber2
            // 
            this.colTelefonNumber2.Caption = "Telefonnumer 2";
            this.colTelefonNumber2.FieldName = "TelefonNumber2";
            this.colTelefonNumber2.Name = "colTelefonNumber2";
            this.colTelefonNumber2.Visible = true;
            this.colTelefonNumber2.Width = 99;
            // 
            // colTelefonNumber3
            // 
            this.colTelefonNumber3.Caption = "Telefonnumer 3";
            this.colTelefonNumber3.FieldName = "TelefonNumber3";
            this.colTelefonNumber3.Name = "colTelefonNumber3";
            this.colTelefonNumber3.RowIndex = 1;
            this.colTelefonNumber3.Visible = true;
            this.colTelefonNumber3.Width = 95;
            // 
            // colEMail
            // 
            this.colEMail.Caption = "E-Mail";
            this.colEMail.FieldName = "EMail";
            this.colEMail.Name = "colEMail";
            this.colEMail.RowIndex = 1;
            this.colEMail.Visible = true;
            this.colEMail.Width = 99;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Verein";
            this.gridBand4.Columns.Add(this.colClassID);
            this.gridBand4.Columns.Add(this.colClass2ID);
            this.gridBand4.Columns.Add(this.colHealthInsuranceNumber);
            this.gridBand4.Columns.Add(this.colFunctions);
            this.gridBand4.Columns.Add(this.colDateOfClubEntry);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 296;
            // 
            // colClassID
            // 
            this.colClassID.Caption = "Klasse";
            this.colClassID.ColumnEdit = this.leClasses;
            this.colClassID.FieldName = "ClassID";
            this.colClassID.Name = "colClassID";
            this.colClassID.Visible = true;
            this.colClassID.Width = 87;
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
            this.leClasses.NullText = "";
            this.leClasses.ValueMember = "ID";
            this.leClasses.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.leClasses_EditValueChanging);
            this.leClasses.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.Repository_CustomDisplayText);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.Class);
            // 
            // colClass2ID
            // 
            this.colClass2ID.Caption = "Klasse 2";
            this.colClass2ID.ColumnEdit = this.leClasses;
            this.colClass2ID.FieldName = "Class2ID";
            this.colClass2ID.Name = "colClass2ID";
            this.colClass2ID.Visible = true;
            this.colClass2ID.Width = 85;
            // 
            // colHealthInsuranceNumber
            // 
            this.colHealthInsuranceNumber.Caption = "Krankenversicherung";
            this.colHealthInsuranceNumber.FieldName = "HealthInsuranceNumber";
            this.colHealthInsuranceNumber.Name = "colHealthInsuranceNumber";
            this.colHealthInsuranceNumber.Visible = true;
            this.colHealthInsuranceNumber.Width = 124;
            // 
            // colFunctions
            // 
            this.colFunctions.Caption = "Funktion(en)";
            this.colFunctions.ColumnEdit = this.ccbeFunctions;
            this.colFunctions.FieldName = "colFunctions";
            this.colFunctions.Name = "colFunctions";
            this.colFunctions.RowIndex = 1;
            this.colFunctions.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colFunctions.Visible = true;
            this.colFunctions.Width = 172;
            // 
            // ccbeFunctions
            // 
            this.ccbeFunctions.AutoHeight = false;
            this.ccbeFunctions.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbeFunctions.DataSource = this.functionBindingSource;
            this.ccbeFunctions.DisplayMember = "Description";
            this.ccbeFunctions.Name = "ccbeFunctions";
            this.ccbeFunctions.ValueMember = "ID";
            this.ccbeFunctions.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.Repository_CustomDisplayText);
            // 
            // functionBindingSource
            // 
            this.functionBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.Function);
            // 
            // colDateOfClubEntry
            // 
            this.colDateOfClubEntry.ColumnEdit = this.deDate;
            this.colDateOfClubEntry.FieldName = "DateOfClubEntry";
            this.colDateOfClubEntry.Name = "colDateOfClubEntry";
            this.colDateOfClubEntry.RowIndex = 1;
            this.colDateOfClubEntry.Visible = true;
            this.colDateOfClubEntry.Width = 124;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Zusatz";
            this.gridBand5.Columns.Add(this.colNote);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 84;
            // 
            // colNote
            // 
            this.colNote.Caption = "Notiz";
            this.colNote.ColumnEdit = this.memoEditNote;
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.Width = 84;
            // 
            // memoEditNote
            // 
            this.memoEditNote.AutoHeight = false;
            this.memoEditNote.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.memoEditNote.Name = "memoEditNote";
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // ribbonPageFunctions
            // 
            this.ribbonPageFunctions.ImageIndex = 7;
            this.ribbonPageFunctions.Name = "ribbonPageFunctions";
            this.ribbonPageFunctions.Text = "Funktionen";
            // 
            // FormMember
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 488);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.HtmlImages = this.sharedImageCollection.ImageSource;
            this.Name = "FormMember";
            this.Ribbon = this.ribbonControl;
            this.Text = "Mitgliederverwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMember_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection.ImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewCoreData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leGenders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ccbeFunctions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.functionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leGenders;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leCities;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leClasses;
        private System.Windows.Forms.BindingSource classBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit deDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit ccbeFunctions;
        private System.Windows.Forms.BindingSource functionBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategoryCoreData;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCoreData;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategoryAdministration;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCities;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageClasses;
        private DevExpress.Utils.SharedImageCollection sharedImageCollection;
        private DevExpress.XtraBars.BarButtonItem btnAddMember;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDeleteMember;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAddMember;
        private DevExpress.XtraBars.BarButtonItem btnDeleteMember;
        private DevExpress.XtraBars.BarButtonItem btnCancelEdit;
        private DevExpress.XtraBars.BarButtonItem btnSaveChanges;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCancelEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSaveChanges;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit memoEditNote;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView viewCoreData;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colLastName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colForeName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDateOfBirth;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGenderID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStreet;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colPostCode;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCityID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTelefonNumber1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTelefonNumber2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTelefonNumber3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colEMail;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colHealthInsuranceNumber;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDateOfClubEntry;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colClassID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colClass2ID;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colNote;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCity;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colClass;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colClass1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colGender;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMemberFunctions;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFunctions;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageFunctions;
    }
}

