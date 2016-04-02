namespace ElectronicObserver.Window.Dialog {
	partial class DialogShipGroupFilter {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogShipGroupFilter));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ExpressionView = new System.Windows.Forms.DataGridView();
            this.LabelResult = new System.Windows.Forms.Label();
            this.Expression_Delete = new System.Windows.Forms.Button();
            this.Expression_Add = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.ExpressionDetailView = new System.Windows.Forms.DataGridView();
            this.ExpressionDetailView_Enabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExpressionDetailView_LeftOperand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpressionDetailView_Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpressionDetailView_RightOperand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightOperand_ComboBox = new System.Windows.Forms.ComboBox();
            this.RightOperand_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Operator = new System.Windows.Forms.ComboBox();
            this.LeftOperand = new System.Windows.Forms.ComboBox();
            this.Description = new System.Windows.Forms.Label();
            this.ExpressionDetail_Delete = new System.Windows.Forms.Button();
            this.ExpressionDetail_Edit = new System.Windows.Forms.Button();
            this.ExpressionDetail_Add = new System.Windows.Forms.Button();
            this.RightOperand_TextBox = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ConvertToExpression = new System.Windows.Forms.Button();
            this.OptimizeConstFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearConstFilter = new System.Windows.Forms.Button();
            this.ConstFilterView = new System.Windows.Forms.DataGridView();
            this.ConstFilterView_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstFilterView_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConstFilterView_Up = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ConstFilterView_Down = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ConstFilterView_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ConstFilterSelector = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ButtonMenu = new System.Windows.Forms.Button();
            this.SubMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SubMenu_ImportFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenu_ExportFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpressionView_Enabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExpressionView_ExternalAndOr = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ExpressionView_Inverse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ExpressionView_InternalAndOr = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ExpressionView_Expression = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpressionView_Up = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ExpressionView_Down = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpressionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpressionDetailView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightOperand_NumericUpDown)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConstFilterView)).BeginInit();
            this.SubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.toolTip1.SetToolTip(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            this.toolTip1.SetToolTip(this.splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            // 
            // splitContainer3
            // 
            resources.ApplyResources(this.splitContainer3, "splitContainer3");
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            resources.ApplyResources(this.splitContainer3.Panel1, "splitContainer3.Panel1");
            this.splitContainer3.Panel1.Controls.Add(this.ExpressionView);
            this.toolTip1.SetToolTip(this.splitContainer3.Panel1, resources.GetString("splitContainer3.Panel1.ToolTip"));
            // 
            // splitContainer3.Panel2
            // 
            resources.ApplyResources(this.splitContainer3.Panel2, "splitContainer3.Panel2");
            this.splitContainer3.Panel2.Controls.Add(this.LabelResult);
            this.splitContainer3.Panel2.Controls.Add(this.Expression_Delete);
            this.splitContainer3.Panel2.Controls.Add(this.Expression_Add);
            this.toolTip1.SetToolTip(this.splitContainer3.Panel2, resources.GetString("splitContainer3.Panel2.ToolTip"));
            this.toolTip1.SetToolTip(this.splitContainer3, resources.GetString("splitContainer3.ToolTip"));
            // 
            // ExpressionView
            // 
            resources.ApplyResources(this.ExpressionView, "ExpressionView");
            this.ExpressionView.AllowUserToAddRows = false;
            this.ExpressionView.AllowUserToDeleteRows = false;
            this.ExpressionView.AllowUserToResizeColumns = false;
            this.ExpressionView.AllowUserToResizeRows = false;
            this.ExpressionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpressionView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpressionView_Enabled,
            this.ExpressionView_ExternalAndOr,
            this.ExpressionView_Inverse,
            this.ExpressionView_InternalAndOr,
            this.ExpressionView_Expression,
            this.ExpressionView_Up,
            this.ExpressionView_Down});
            this.ExpressionView.MultiSelect = false;
            this.ExpressionView.Name = "ExpressionView";
            this.ExpressionView.RowHeadersVisible = false;
            this.ExpressionView.RowTemplate.Height = 21;
            this.ExpressionView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.ExpressionView, resources.GetString("ExpressionView.ToolTip"));
            this.ExpressionView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpressionView_CellClick);
            this.ExpressionView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpressionView_CellContentClick);
            this.ExpressionView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpressionView_CellValueChanged);
            this.ExpressionView.CurrentCellDirtyStateChanged += new System.EventHandler(this.ExpressionView_CurrentCellDirtyStateChanged);
            this.ExpressionView.SelectionChanged += new System.EventHandler(this.ExpressionView_SelectionChanged);
            // 
            // LabelResult
            // 
            resources.ApplyResources(this.LabelResult, "LabelResult");
            this.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelResult.Name = "LabelResult";
            this.toolTip1.SetToolTip(this.LabelResult, resources.GetString("LabelResult.ToolTip"));
            this.LabelResult.Click += new System.EventHandler(this.LabelResult_Click);
            // 
            // Expression_Delete
            // 
            resources.ApplyResources(this.Expression_Delete, "Expression_Delete");
            this.Expression_Delete.Name = "Expression_Delete";
            this.toolTip1.SetToolTip(this.Expression_Delete, resources.GetString("Expression_Delete.ToolTip"));
            this.Expression_Delete.UseVisualStyleBackColor = true;
            this.Expression_Delete.Click += new System.EventHandler(this.Expression_Delete_Click);
            // 
            // Expression_Add
            // 
            resources.ApplyResources(this.Expression_Add, "Expression_Add");
            this.Expression_Add.Name = "Expression_Add";
            this.toolTip1.SetToolTip(this.Expression_Add, resources.GetString("Expression_Add.ToolTip"));
            this.Expression_Add.UseVisualStyleBackColor = true;
            this.Expression_Add.Click += new System.EventHandler(this.Expression_Add_Click);
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            this.splitContainer2.Panel1.Controls.Add(this.ExpressionDetailView);
            this.toolTip1.SetToolTip(this.splitContainer2.Panel1, resources.GetString("splitContainer2.Panel1.ToolTip"));
            // 
            // splitContainer2.Panel2
            // 
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            this.splitContainer2.Panel2.Controls.Add(this.RightOperand_ComboBox);
            this.splitContainer2.Panel2.Controls.Add(this.RightOperand_NumericUpDown);
            this.splitContainer2.Panel2.Controls.Add(this.Operator);
            this.splitContainer2.Panel2.Controls.Add(this.LeftOperand);
            this.splitContainer2.Panel2.Controls.Add(this.Description);
            this.splitContainer2.Panel2.Controls.Add(this.ExpressionDetail_Delete);
            this.splitContainer2.Panel2.Controls.Add(this.ExpressionDetail_Edit);
            this.splitContainer2.Panel2.Controls.Add(this.ExpressionDetail_Add);
            this.splitContainer2.Panel2.Controls.Add(this.RightOperand_TextBox);
            this.toolTip1.SetToolTip(this.splitContainer2.Panel2, resources.GetString("splitContainer2.Panel2.ToolTip"));
            this.toolTip1.SetToolTip(this.splitContainer2, resources.GetString("splitContainer2.ToolTip"));
            // 
            // ExpressionDetailView
            // 
            resources.ApplyResources(this.ExpressionDetailView, "ExpressionDetailView");
            this.ExpressionDetailView.AllowUserToAddRows = false;
            this.ExpressionDetailView.AllowUserToDeleteRows = false;
            this.ExpressionDetailView.AllowUserToResizeColumns = false;
            this.ExpressionDetailView.AllowUserToResizeRows = false;
            this.ExpressionDetailView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExpressionDetailView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpressionDetailView_Enabled,
            this.ExpressionDetailView_LeftOperand,
            this.ExpressionDetailView_Operator,
            this.ExpressionDetailView_RightOperand});
            this.ExpressionDetailView.MultiSelect = false;
            this.ExpressionDetailView.Name = "ExpressionDetailView";
            this.ExpressionDetailView.RowHeadersVisible = false;
            this.ExpressionDetailView.RowTemplate.Height = 21;
            this.ExpressionDetailView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.ExpressionDetailView, resources.GetString("ExpressionDetailView.ToolTip"));
            this.ExpressionDetailView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ExpressionDetailView_CellFormatting);
            this.ExpressionDetailView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpressionDetailView_CellValueChanged);
            this.ExpressionDetailView.CurrentCellDirtyStateChanged += new System.EventHandler(this.ExpressionDetailView_CurrentCellDirtyStateChanged);
            this.ExpressionDetailView.SelectionChanged += new System.EventHandler(this.ExpressionDetailView_SelectionChanged);
            // 
            // ExpressionDetailView_Enabled
            // 
            resources.ApplyResources(this.ExpressionDetailView_Enabled, "ExpressionDetailView_Enabled");
            this.ExpressionDetailView_Enabled.Name = "ExpressionDetailView_Enabled";
            // 
            // ExpressionDetailView_LeftOperand
            // 
            this.ExpressionDetailView_LeftOperand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ExpressionDetailView_LeftOperand, "ExpressionDetailView_LeftOperand");
            this.ExpressionDetailView_LeftOperand.Name = "ExpressionDetailView_LeftOperand";
            this.ExpressionDetailView_LeftOperand.ReadOnly = true;
            this.ExpressionDetailView_LeftOperand.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpressionDetailView_LeftOperand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExpressionDetailView_Operator
            // 
            this.ExpressionDetailView_Operator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ExpressionDetailView_Operator, "ExpressionDetailView_Operator");
            this.ExpressionDetailView_Operator.Name = "ExpressionDetailView_Operator";
            this.ExpressionDetailView_Operator.ReadOnly = true;
            this.ExpressionDetailView_Operator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpressionDetailView_Operator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExpressionDetailView_RightOperand
            // 
            this.ExpressionDetailView_RightOperand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ExpressionDetailView_RightOperand, "ExpressionDetailView_RightOperand");
            this.ExpressionDetailView_RightOperand.Name = "ExpressionDetailView_RightOperand";
            this.ExpressionDetailView_RightOperand.ReadOnly = true;
            this.ExpressionDetailView_RightOperand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // RightOperand_ComboBox
            // 
            resources.ApplyResources(this.RightOperand_ComboBox, "RightOperand_ComboBox");
            this.RightOperand_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RightOperand_ComboBox.FormattingEnabled = true;
            this.RightOperand_ComboBox.Name = "RightOperand_ComboBox";
            this.toolTip1.SetToolTip(this.RightOperand_ComboBox, resources.GetString("RightOperand_ComboBox.ToolTip"));
            // 
            // RightOperand_NumericUpDown
            // 
            resources.ApplyResources(this.RightOperand_NumericUpDown, "RightOperand_NumericUpDown");
            this.RightOperand_NumericUpDown.Name = "RightOperand_NumericUpDown";
            this.toolTip1.SetToolTip(this.RightOperand_NumericUpDown, resources.GetString("RightOperand_NumericUpDown.ToolTip"));
            this.RightOperand_NumericUpDown.ValueChanged += new System.EventHandler(this.RightOperand_NumericUpDown_ValueChanged);
            // 
            // Operator
            // 
            resources.ApplyResources(this.Operator, "Operator");
            this.Operator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operator.FormattingEnabled = true;
            this.Operator.Name = "Operator";
            this.toolTip1.SetToolTip(this.Operator, resources.GetString("Operator.ToolTip"));
            // 
            // LeftOperand
            // 
            resources.ApplyResources(this.LeftOperand, "LeftOperand");
            this.LeftOperand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeftOperand.FormattingEnabled = true;
            this.LeftOperand.Name = "LeftOperand";
            this.toolTip1.SetToolTip(this.LeftOperand, resources.GetString("LeftOperand.ToolTip"));
            this.LeftOperand.SelectedValueChanged += new System.EventHandler(this.LeftOperand_SelectedValueChanged);
            // 
            // Description
            // 
            resources.ApplyResources(this.Description, "Description");
            this.Description.Name = "Description";
            this.toolTip1.SetToolTip(this.Description, resources.GetString("Description.ToolTip"));
            // 
            // ExpressionDetail_Delete
            // 
            resources.ApplyResources(this.ExpressionDetail_Delete, "ExpressionDetail_Delete");
            this.ExpressionDetail_Delete.Name = "ExpressionDetail_Delete";
            this.toolTip1.SetToolTip(this.ExpressionDetail_Delete, resources.GetString("ExpressionDetail_Delete.ToolTip"));
            this.ExpressionDetail_Delete.UseVisualStyleBackColor = true;
            this.ExpressionDetail_Delete.Click += new System.EventHandler(this.ExpressionDetail_Delete_Click);
            // 
            // ExpressionDetail_Edit
            // 
            resources.ApplyResources(this.ExpressionDetail_Edit, "ExpressionDetail_Edit");
            this.ExpressionDetail_Edit.Name = "ExpressionDetail_Edit";
            this.toolTip1.SetToolTip(this.ExpressionDetail_Edit, resources.GetString("ExpressionDetail_Edit.ToolTip"));
            this.ExpressionDetail_Edit.UseVisualStyleBackColor = true;
            this.ExpressionDetail_Edit.Click += new System.EventHandler(this.ExpressionDetail_Edit_Click);
            // 
            // ExpressionDetail_Add
            // 
            resources.ApplyResources(this.ExpressionDetail_Add, "ExpressionDetail_Add");
            this.ExpressionDetail_Add.Name = "ExpressionDetail_Add";
            this.toolTip1.SetToolTip(this.ExpressionDetail_Add, resources.GetString("ExpressionDetail_Add.ToolTip"));
            this.ExpressionDetail_Add.UseVisualStyleBackColor = true;
            this.ExpressionDetail_Add.Click += new System.EventHandler(this.ExpressionDetail_Add_Click);
            // 
            // RightOperand_TextBox
            // 
            resources.ApplyResources(this.RightOperand_TextBox, "RightOperand_TextBox");
            this.RightOperand_TextBox.Name = "RightOperand_TextBox";
            this.toolTip1.SetToolTip(this.RightOperand_TextBox, resources.GetString("RightOperand_TextBox.ToolTip"));
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.Name = "ButtonCancel";
            this.toolTip1.SetToolTip(this.ButtonCancel, resources.GetString("ButtonCancel.ToolTip"));
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonOK
            // 
            resources.ApplyResources(this.ButtonOK, "ButtonOK");
            this.ButtonOK.Name = "ButtonOK";
            this.toolTip1.SetToolTip(this.ButtonOK, resources.GetString("ButtonOK.ToolTip"));
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.toolTip1.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Name = "tabPage1";
            this.toolTip1.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Controls.Add(this.ConvertToExpression);
            this.tabPage2.Controls.Add(this.OptimizeConstFilter);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ClearConstFilter);
            this.tabPage2.Controls.Add(this.ConstFilterView);
            this.tabPage2.Controls.Add(this.ConstFilterSelector);
            this.tabPage2.Name = "tabPage2";
            this.toolTip1.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ConvertToExpression
            // 
            resources.ApplyResources(this.ConvertToExpression, "ConvertToExpression");
            this.ConvertToExpression.Name = "ConvertToExpression";
            this.toolTip1.SetToolTip(this.ConvertToExpression, resources.GetString("ConvertToExpression.ToolTip"));
            this.ConvertToExpression.UseVisualStyleBackColor = true;
            this.ConvertToExpression.Click += new System.EventHandler(this.ConvertToExpression_Click);
            // 
            // OptimizeConstFilter
            // 
            resources.ApplyResources(this.OptimizeConstFilter, "OptimizeConstFilter");
            this.OptimizeConstFilter.Name = "OptimizeConstFilter";
            this.toolTip1.SetToolTip(this.OptimizeConstFilter, resources.GetString("OptimizeConstFilter.ToolTip"));
            this.OptimizeConstFilter.UseVisualStyleBackColor = true;
            this.OptimizeConstFilter.Click += new System.EventHandler(this.OptimizeConstFilter_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // ClearConstFilter
            // 
            resources.ApplyResources(this.ClearConstFilter, "ClearConstFilter");
            this.ClearConstFilter.Name = "ClearConstFilter";
            this.toolTip1.SetToolTip(this.ClearConstFilter, resources.GetString("ClearConstFilter.ToolTip"));
            this.ClearConstFilter.UseVisualStyleBackColor = true;
            this.ClearConstFilter.Click += new System.EventHandler(this.ClearConstFilter_Click);
            // 
            // ConstFilterView
            // 
            resources.ApplyResources(this.ConstFilterView, "ConstFilterView");
            this.ConstFilterView.AllowUserToAddRows = false;
            this.ConstFilterView.AllowUserToDeleteRows = false;
            this.ConstFilterView.AllowUserToResizeColumns = false;
            this.ConstFilterView.AllowUserToResizeRows = false;
            this.ConstFilterView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConstFilterView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConstFilterView_ID,
            this.ConstFilterView_Name,
            this.ConstFilterView_Up,
            this.ConstFilterView_Down,
            this.ConstFilterView_Delete});
            this.ConstFilterView.Name = "ConstFilterView";
            this.ConstFilterView.ReadOnly = true;
            this.ConstFilterView.RowHeadersVisible = false;
            this.ConstFilterView.RowTemplate.Height = 21;
            this.ConstFilterView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.toolTip1.SetToolTip(this.ConstFilterView, resources.GetString("ConstFilterView.ToolTip"));
            this.ConstFilterView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConstFilterView_CellContentClick);
            // 
            // ConstFilterView_ID
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ConstFilterView_ID.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.ConstFilterView_ID, "ConstFilterView_ID");
            this.ConstFilterView_ID.Name = "ConstFilterView_ID";
            this.ConstFilterView_ID.ReadOnly = true;
            this.ConstFilterView_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ConstFilterView_Name
            // 
            this.ConstFilterView_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ConstFilterView_Name, "ConstFilterView_Name");
            this.ConstFilterView_Name.Name = "ConstFilterView_Name";
            this.ConstFilterView_Name.ReadOnly = true;
            this.ConstFilterView_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ConstFilterView_Up
            // 
            resources.ApplyResources(this.ConstFilterView_Up, "ConstFilterView_Up");
            this.ConstFilterView_Up.Name = "ConstFilterView_Up";
            this.ConstFilterView_Up.ReadOnly = true;
            this.ConstFilterView_Up.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ConstFilterView_Down
            // 
            resources.ApplyResources(this.ConstFilterView_Down, "ConstFilterView_Down");
            this.ConstFilterView_Down.Name = "ConstFilterView_Down";
            this.ConstFilterView_Down.ReadOnly = true;
            this.ConstFilterView_Down.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ConstFilterView_Delete
            // 
            resources.ApplyResources(this.ConstFilterView_Delete, "ConstFilterView_Delete");
            this.ConstFilterView_Delete.Name = "ConstFilterView_Delete";
            this.ConstFilterView_Delete.ReadOnly = true;
            this.ConstFilterView_Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ConstFilterSelector
            // 
            resources.ApplyResources(this.ConstFilterSelector, "ConstFilterSelector");
            this.ConstFilterSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConstFilterSelector.FormattingEnabled = true;
            this.ConstFilterSelector.Items.AddRange(new object[] {
            resources.GetString("ConstFilterSelector.Items"),
            resources.GetString("ConstFilterSelector.Items1")});
            this.ConstFilterSelector.Name = "ConstFilterSelector";
            this.toolTip1.SetToolTip(this.ConstFilterSelector, resources.GetString("ConstFilterSelector.ToolTip"));
            this.ConstFilterSelector.SelectedIndexChanged += new System.EventHandler(this.ConstFilterSelector_SelectedIndexChanged);
            // 
            // ButtonMenu
            // 
            resources.ApplyResources(this.ButtonMenu, "ButtonMenu");
            this.ButtonMenu.Name = "ButtonMenu";
            this.toolTip1.SetToolTip(this.ButtonMenu, resources.GetString("ButtonMenu.ToolTip"));
            this.ButtonMenu.UseVisualStyleBackColor = true;
            this.ButtonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // SubMenu
            // 
            resources.ApplyResources(this.SubMenu, "SubMenu");
            this.SubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMenu_ImportFilter,
            this.SubMenu_ExportFilter});
            this.SubMenu.Name = "Menu";
            this.toolTip1.SetToolTip(this.SubMenu, resources.GetString("SubMenu.ToolTip"));
            // 
            // SubMenu_ImportFilter
            // 
            resources.ApplyResources(this.SubMenu_ImportFilter, "SubMenu_ImportFilter");
            this.SubMenu_ImportFilter.Name = "SubMenu_ImportFilter";
            this.SubMenu_ImportFilter.Click += new System.EventHandler(this.Menu_ImportFilter_Click);
            // 
            // SubMenu_ExportFilter
            // 
            resources.ApplyResources(this.SubMenu_ExportFilter, "SubMenu_ExportFilter");
            this.SubMenu_ExportFilter.Name = "SubMenu_ExportFilter";
            this.SubMenu_ExportFilter.Click += new System.EventHandler(this.Menu_ExportFilter_Click);
            // 
            // ExpressionView_Enabled
            // 
            this.ExpressionView_Enabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ExpressionView_Enabled, "ExpressionView_Enabled");
            this.ExpressionView_Enabled.Name = "ExpressionView_Enabled";
            // 
            // ExpressionView_ExternalAndOr
            // 
            this.ExpressionView_ExternalAndOr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ExpressionView_ExternalAndOr, "ExpressionView_ExternalAndOr");
            this.ExpressionView_ExternalAndOr.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.ExpressionView_ExternalAndOr.Name = "ExpressionView_ExternalAndOr";
            // 
            // ExpressionView_Inverse
            // 
            this.ExpressionView_Inverse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ExpressionView_Inverse, "ExpressionView_Inverse");
            this.ExpressionView_Inverse.Name = "ExpressionView_Inverse";
            // 
            // ExpressionView_InternalAndOr
            // 
            this.ExpressionView_InternalAndOr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ExpressionView_InternalAndOr, "ExpressionView_InternalAndOr");
            this.ExpressionView_InternalAndOr.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.ExpressionView_InternalAndOr.Name = "ExpressionView_InternalAndOr";
            // 
            // ExpressionView_Expression
            // 
            this.ExpressionView_Expression.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ExpressionView_Expression, "ExpressionView_Expression");
            this.ExpressionView_Expression.Name = "ExpressionView_Expression";
            this.ExpressionView_Expression.ReadOnly = true;
            this.ExpressionView_Expression.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExpressionView_Up
            // 
            resources.ApplyResources(this.ExpressionView_Up, "ExpressionView_Up");
            this.ExpressionView_Up.Name = "ExpressionView_Up";
            // 
            // ExpressionView_Down
            // 
            resources.ApplyResources(this.ExpressionView_Down, "ExpressionView_Down");
            this.ExpressionView_Down.Name = "ExpressionView_Down";
            // 
            // DialogShipGroupFilter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ButtonMenu);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogShipGroupFilter";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.DialogShipGroupFilter_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpressionView)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpressionDetailView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightOperand_NumericUpDown)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConstFilterView)).EndInit();
            this.SubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView ExpressionView;
		private System.Windows.Forms.DataGridView ExpressionDetailView;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.Button Expression_Delete;
		private System.Windows.Forms.Button Expression_Add;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Button ExpressionDetail_Delete;
		private System.Windows.Forms.Button ExpressionDetail_Edit;
		private System.Windows.Forms.Button ExpressionDetail_Add;
		private System.Windows.Forms.ComboBox RightOperand_ComboBox;
		private System.Windows.Forms.NumericUpDown RightOperand_NumericUpDown;
		private System.Windows.Forms.ComboBox Operator;
		private System.Windows.Forms.TextBox RightOperand_TextBox;
		private System.Windows.Forms.ComboBox LeftOperand;
		private System.Windows.Forms.Label Description;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonOK;
		private System.Windows.Forms.Label LabelResult;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ClearConstFilter;
		private System.Windows.Forms.DataGridView ConstFilterView;
		private System.Windows.Forms.ComboBox ConstFilterSelector;
		private System.Windows.Forms.Button OptimizeConstFilter;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button ConvertToExpression;
		private System.Windows.Forms.Button ButtonMenu;
		private System.Windows.Forms.ContextMenuStrip SubMenu;
		private System.Windows.Forms.ToolStripMenuItem SubMenu_ImportFilter;
		private System.Windows.Forms.ToolStripMenuItem SubMenu_ExportFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstFilterView_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConstFilterView_Name;
        private System.Windows.Forms.DataGridViewButtonColumn ConstFilterView_Up;
        private System.Windows.Forms.DataGridViewButtonColumn ConstFilterView_Down;
        private System.Windows.Forms.DataGridViewButtonColumn ConstFilterView_Delete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExpressionDetailView_Enabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpressionDetailView_LeftOperand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpressionDetailView_Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpressionDetailView_RightOperand;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExpressionView_Enabled;
        private System.Windows.Forms.DataGridViewComboBoxColumn ExpressionView_ExternalAndOr;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ExpressionView_Inverse;
        private System.Windows.Forms.DataGridViewComboBoxColumn ExpressionView_InternalAndOr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpressionView_Expression;
        private System.Windows.Forms.DataGridViewButtonColumn ExpressionView_Up;
        private System.Windows.Forms.DataGridViewButtonColumn ExpressionView_Down;
    }
}