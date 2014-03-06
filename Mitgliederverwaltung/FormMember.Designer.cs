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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.sharedImageCollection = new DevExpress.Utils.SharedImageCollection();
            this.btnAddMember = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteMember = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveChanges = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddCity = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteCity = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddClass = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteClass = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddFunction = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteFunction = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategoryCoreData = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPageCoreData = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupAddMember = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDeleteMember = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupCancelEdit = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupSaveChanges = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageCategoryAdministration = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPageCities = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupAddCity = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDeleteCity = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageClasses = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupAddClass = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDeleteClass = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageFunctions = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupAddFunction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupDeleteFunction = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.memberBindingSource = new System.Windows.Forms.BindingSource();
            this.gridControlCoreData = new DevExpress.XtraGrid.GridControl();
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
            this.genderBindingSource = new System.Windows.Forms.BindingSource();
            this.colDateOfBirth = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.deDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colStreet = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCityID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.leCities = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cityBindingSource = new System.Windows.Forms.BindingSource();
            this.colPostCode = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colTelefonNumber1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTelefonNumber2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTelefonNumber3 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colEMail = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colClassID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.leClasses = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.classBindingSource = new System.Windows.Forms.BindingSource();
            this.colClass2ID = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAgeGroup = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colHealthInsuranceNumber = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFunctions = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.ccbeFunctions = new DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit();
            this.functionBindingSource = new System.Windows.Forms.BindingSource();
            this.colDateOfClubEntry = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colNote = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.memoEditNote = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            this.gridControlAdministration = new DevExpress.XtraGrid.GridControl();
            this.gridViewAdministration = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMembers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.memberFunctionBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection.ImageSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCoreData)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdministration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAdministration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberFunctionBindingSource)).BeginInit();
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
            this.btnSaveChanges,
            this.btnAddCity,
            this.btnDeleteCity,
            this.btnAddClass,
            this.btnDeleteClass,
            this.btnAddFunction,
            this.btnDeleteFunction});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 11;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategoryCoreData,
            this.ribbonPageCategoryAdministration});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(1138, 152);
            this.ribbonControl.SelectedPageChanging += new DevExpress.XtraBars.Ribbon.RibbonPageChangingEventHandler(this.ribbonControl_SelectedPageChanging);
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
            this.btnAddMember.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClick);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Id = 2;
            this.btnDeleteMember.ImageIndex = 4;
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDeleteMember.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClick);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Id = 3;
            this.btnCancelEdit.ImageIndex = 5;
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCancelEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClick);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Id = 4;
            this.btnSaveChanges.ImageIndex = 6;
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSaveChanges.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClick);
            // 
            // btnAddCity
            // 
            this.btnAddCity.Id = 5;
            this.btnAddCity.ImageIndex = 3;
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAddCity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClick);
            // 
            // btnDeleteCity
            // 
            this.btnDeleteCity.Id = 6;
            this.btnDeleteCity.ImageIndex = 4;
            this.btnDeleteCity.Name = "btnDeleteCity";
            this.btnDeleteCity.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDeleteCity.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClick);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Id = 7;
            this.btnAddClass.ImageIndex = 3;
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAddClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClick);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Id = 8;
            this.btnDeleteClass.ImageIndex = 4;
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDeleteClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClick);
            // 
            // btnAddFunction
            // 
            this.btnAddFunction.Id = 9;
            this.btnAddFunction.ImageIndex = 3;
            this.btnAddFunction.Name = "btnAddFunction";
            this.btnAddFunction.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnAddFunction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClick);
            // 
            // btnDeleteFunction
            // 
            this.btnDeleteFunction.Id = 10;
            this.btnDeleteFunction.ImageIndex = 4;
            this.btnDeleteFunction.Name = "btnDeleteFunction";
            this.btnDeleteFunction.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDeleteFunction.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ribbon_ItemClick);
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
            this.ribbonPageCities.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupAddCity,
            this.ribbonPageGroupDeleteCity});
            this.ribbonPageCities.ImageIndex = 0;
            this.ribbonPageCities.Name = "ribbonPageCities";
            this.ribbonPageCities.Text = "Städte";
            // 
            // ribbonPageGroupAddCity
            // 
            this.ribbonPageGroupAddCity.ItemLinks.Add(this.btnAddCity);
            this.ribbonPageGroupAddCity.Name = "ribbonPageGroupAddCity";
            this.ribbonPageGroupAddCity.ShowCaptionButton = false;
            this.ribbonPageGroupAddCity.Text = "Stadt hinzufügen";
            // 
            // ribbonPageGroupDeleteCity
            // 
            this.ribbonPageGroupDeleteCity.ItemLinks.Add(this.btnDeleteCity);
            this.ribbonPageGroupDeleteCity.Name = "ribbonPageGroupDeleteCity";
            this.ribbonPageGroupDeleteCity.ShowCaptionButton = false;
            this.ribbonPageGroupDeleteCity.Text = "Stadt löschen";
            // 
            // ribbonPageClasses
            // 
            this.ribbonPageClasses.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupAddClass,
            this.ribbonPageGroupDeleteClass});
            this.ribbonPageClasses.ImageIndex = 2;
            this.ribbonPageClasses.Name = "ribbonPageClasses";
            this.ribbonPageClasses.Text = "Klassen";
            // 
            // ribbonPageGroupAddClass
            // 
            this.ribbonPageGroupAddClass.ItemLinks.Add(this.btnAddClass);
            this.ribbonPageGroupAddClass.Name = "ribbonPageGroupAddClass";
            this.ribbonPageGroupAddClass.ShowCaptionButton = false;
            this.ribbonPageGroupAddClass.Text = "Klasse hinzufügen";
            // 
            // ribbonPageGroupDeleteClass
            // 
            this.ribbonPageGroupDeleteClass.ItemLinks.Add(this.btnDeleteClass);
            this.ribbonPageGroupDeleteClass.Name = "ribbonPageGroupDeleteClass";
            this.ribbonPageGroupDeleteClass.ShowCaptionButton = false;
            this.ribbonPageGroupDeleteClass.Text = "Klasse löschen";
            // 
            // ribbonPageFunctions
            // 
            this.ribbonPageFunctions.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupAddFunction,
            this.ribbonPageGroupDeleteFunction});
            this.ribbonPageFunctions.ImageIndex = 7;
            this.ribbonPageFunctions.Name = "ribbonPageFunctions";
            this.ribbonPageFunctions.Text = "Funktionen";
            // 
            // ribbonPageGroupAddFunction
            // 
            this.ribbonPageGroupAddFunction.ItemLinks.Add(this.btnAddFunction);
            this.ribbonPageGroupAddFunction.Name = "ribbonPageGroupAddFunction";
            this.ribbonPageGroupAddFunction.ShowCaptionButton = false;
            this.ribbonPageGroupAddFunction.Text = "Funktion hinzufügen";
            // 
            // ribbonPageGroupDeleteFunction
            // 
            this.ribbonPageGroupDeleteFunction.ItemLinks.Add(this.btnDeleteFunction);
            this.ribbonPageGroupDeleteFunction.Name = "ribbonPageGroupDeleteFunction";
            this.ribbonPageGroupDeleteFunction.ShowCaptionButton = false;
            this.ribbonPageGroupDeleteFunction.Text = "Funktion löschen";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.Member);
            // 
            // gridControlCoreData
            // 
            this.gridControlCoreData.DataSource = this.memberBindingSource;
            this.gridControlCoreData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCoreData.Location = new System.Drawing.Point(0, 152);
            this.gridControlCoreData.MainView = this.viewCoreData;
            this.gridControlCoreData.MenuManager = this.ribbonControl;
            this.gridControlCoreData.Name = "gridControlCoreData";
            this.gridControlCoreData.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.leGenders,
            this.leCities,
            this.leClasses,
            this.deDate,
            this.ccbeFunctions,
            this.memoEditNote});
            this.gridControlCoreData.Size = new System.Drawing.Size(1138, 336);
            this.gridControlCoreData.TabIndex = 2;
            this.gridControlCoreData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.viewCoreData,
            this.gridView1});
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
            this.colFunctions,
            this.colAgeGroup});
            this.viewCoreData.GridControl = this.gridControlCoreData;
            this.viewCoreData.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "")});
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
            this.gridBand1.Width = 187;
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
            this.colLastName.Width = 92;
            // 
            // colForeName
            // 
            this.colForeName.Caption = "Vorname";
            this.colForeName.FieldName = "ForeName";
            this.colForeName.Name = "colForeName";
            this.colForeName.Visible = true;
            this.colForeName.Width = 95;
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
            this.colGenderID.Width = 92;
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
            this.colDateOfBirth.Width = 95;
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
            this.gridBand2.Width = 200;
            // 
            // colStreet
            // 
            this.colStreet.Caption = "Straße";
            this.colStreet.FieldName = "Street";
            this.colStreet.Name = "colStreet";
            this.colStreet.Visible = true;
            this.colStreet.Width = 200;
            // 
            // colCityID
            // 
            this.colCityID.Caption = "Stadt";
            this.colCityID.ColumnEdit = this.leCities;
            this.colCityID.FieldName = "CityID";
            this.colCityID.Name = "colCityID";
            this.colCityID.RowIndex = 1;
            this.colCityID.Visible = true;
            this.colCityID.Width = 136;
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
            this.colPostCode.Width = 64;
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
            this.gridBand3.Width = 217;
            // 
            // colTelefonNumber1
            // 
            this.colTelefonNumber1.Caption = "Telefonnumer 1";
            this.colTelefonNumber1.FieldName = "TelefonNumber1";
            this.colTelefonNumber1.Name = "colTelefonNumber1";
            this.colTelefonNumber1.Visible = true;
            this.colTelefonNumber1.Width = 106;
            // 
            // colTelefonNumber2
            // 
            this.colTelefonNumber2.Caption = "Telefonnumer 2";
            this.colTelefonNumber2.FieldName = "TelefonNumber2";
            this.colTelefonNumber2.Name = "colTelefonNumber2";
            this.colTelefonNumber2.Visible = true;
            this.colTelefonNumber2.Width = 111;
            // 
            // colTelefonNumber3
            // 
            this.colTelefonNumber3.Caption = "Telefonnumer 3";
            this.colTelefonNumber3.FieldName = "TelefonNumber3";
            this.colTelefonNumber3.Name = "colTelefonNumber3";
            this.colTelefonNumber3.RowIndex = 1;
            this.colTelefonNumber3.Visible = true;
            this.colTelefonNumber3.Width = 106;
            // 
            // colEMail
            // 
            this.colEMail.Caption = "E-Mail";
            this.colEMail.FieldName = "EMail";
            this.colEMail.Name = "colEMail";
            this.colEMail.RowIndex = 1;
            this.colEMail.Visible = true;
            this.colEMail.Width = 111;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Verein";
            this.gridBand4.Columns.Add(this.colClassID);
            this.gridBand4.Columns.Add(this.colClass2ID);
            this.gridBand4.Columns.Add(this.colAgeGroup);
            this.gridBand4.Columns.Add(this.colHealthInsuranceNumber);
            this.gridBand4.Columns.Add(this.colFunctions);
            this.gridBand4.Columns.Add(this.colDateOfClubEntry);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.VisibleIndex = 3;
            this.gridBand4.Width = 416;
            // 
            // colClassID
            // 
            this.colClassID.Caption = "Klasse";
            this.colClassID.ColumnEdit = this.leClasses;
            this.colClassID.FieldName = "ClassID";
            this.colClassID.Name = "colClassID";
            this.colClassID.Visible = true;
            this.colClassID.Width = 97;
            // 
            // leClasses
            // 
            this.leClasses.AutoHeight = false;
            this.leClasses.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leClasses.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.leClasses.DataSource = this.classBindingSource;
            this.leClasses.DisplayMember = "Description";
            this.leClasses.Name = "leClasses";
            this.leClasses.NullText = "";
            this.leClasses.ValueMember = "ID";
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
            this.colClass2ID.Width = 95;
            // 
            // colAgeGroup
            // 
            this.colAgeGroup.Caption = "Altersklasse";
            this.colAgeGroup.FieldName = "colAgeGroup";
            this.colAgeGroup.Name = "colAgeGroup";
            this.colAgeGroup.OptionsColumn.AllowEdit = false;
            this.colAgeGroup.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colAgeGroup.Visible = true;
            this.colAgeGroup.Width = 109;
            // 
            // colHealthInsuranceNumber
            // 
            this.colHealthInsuranceNumber.Caption = "Krankenversicherung";
            this.colHealthInsuranceNumber.FieldName = "HealthInsuranceNumber";
            this.colHealthInsuranceNumber.Name = "colHealthInsuranceNumber";
            this.colHealthInsuranceNumber.Visible = true;
            this.colHealthInsuranceNumber.Width = 115;
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
            this.colFunctions.Width = 301;
            // 
            // ccbeFunctions
            // 
            this.ccbeFunctions.AutoHeight = false;
            this.ccbeFunctions.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbeFunctions.DataSource = this.functionBindingSource;
            this.ccbeFunctions.DisplayMember = "Description";
            this.ccbeFunctions.Name = "ccbeFunctions";
            this.ccbeFunctions.SelectAllItemCaption = "(Alle)";
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
            this.colDateOfClubEntry.Width = 115;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Zusatz";
            this.gridBand5.Columns.Add(this.colNote);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.VisibleIndex = 4;
            this.gridBand5.Width = 97;
            // 
            // colNote
            // 
            this.colNote.Caption = "Notiz";
            this.colNote.ColumnEdit = this.memoEditNote;
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.Width = 97;
            // 
            // memoEditNote
            // 
            this.memoEditNote.AutoHeight = false;
            this.memoEditNote.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.memoEditNote.Name = "memoEditNote";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlCoreData;
            this.gridView1.Name = "gridView1";
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // gridControlAdministration
            // 
            this.gridControlAdministration.DataSource = this.classBindingSource;
            this.gridControlAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAdministration.Location = new System.Drawing.Point(0, 152);
            this.gridControlAdministration.MainView = this.gridViewAdministration;
            this.gridControlAdministration.MenuManager = this.ribbonControl;
            this.gridControlAdministration.Name = "gridControlAdministration";
            this.gridControlAdministration.Size = new System.Drawing.Size(1138, 336);
            this.gridControlAdministration.TabIndex = 4;
            this.gridControlAdministration.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAdministration});
            // 
            // gridViewAdministration
            // 
            this.gridViewAdministration.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdAdmin,
            this.colName,
            this.colMembers});
            this.gridViewAdministration.GridControl = this.gridControlAdministration;
            this.gridViewAdministration.GroupPanelText = " ";
            this.gridViewAdministration.Name = "gridViewAdministration";
            // 
            // colIdAdmin
            // 
            this.colIdAdmin.FieldName = "Id";
            this.colIdAdmin.Name = "colIdAdmin";
            this.colIdAdmin.OptionsColumn.AllowEdit = false;
            this.colIdAdmin.OptionsColumn.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colMembers
            // 
            this.colMembers.FieldName = "Members";
            this.colMembers.Name = "colMembers";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAddMember);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Mitglied hinzufügen";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDeleteMember);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Mitglied löschen";
            // 
            // memberFunctionBindingSource
            // 
            this.memberFunctionBindingSource.DataSource = typeof(Mitgliederverwaltung.Database.MemberFunction);
            // 
            // FormMember
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 488);
            this.Controls.Add(this.gridControlCoreData);
            this.Controls.Add(this.gridControlAdministration);
            this.Controls.Add(this.ribbonControl);
            this.HtmlImages = this.sharedImageCollection.ImageSource;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMember";
            this.Ribbon = this.ribbonControl;
            this.Text = "Mitgliederverwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMember_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection.ImageSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharedImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCoreData)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdministration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAdministration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberFunctionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private DevExpress.XtraGrid.GridControl gridControlCoreData;
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageFunctions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControlAdministration;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAdministration;
        private DevExpress.XtraGrid.Columns.GridColumn colIdAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colMembers;
        private DevExpress.XtraBars.BarButtonItem btnAddCity;
        private DevExpress.XtraBars.BarButtonItem btnDeleteCity;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAddCity;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDeleteCity;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnAddClass;
        private DevExpress.XtraBars.BarButtonItem btnDeleteClass;
        private DevExpress.XtraBars.BarButtonItem btnAddFunction;
        private DevExpress.XtraBars.BarButtonItem btnDeleteFunction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAddClass;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDeleteClass;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupAddFunction;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupDeleteFunction;
        private System.Windows.Forms.BindingSource memberFunctionBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAgeGroup;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
    }
}

