namespace ElectronicObserver.Window.Dialog {
	partial class DialogDropRecordViewer {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogDropRecordViewer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MergeRows = new System.Windows.Forms.CheckBox();
            this.MapCellID = new System.Windows.Forms.ComboBox();
            this.LabelShipName = new ElectronicObserver.Window.Control.ImageLabel();
            this.MapInfoID = new System.Windows.Forms.ComboBox();
            this.LabelItemName = new ElectronicObserver.Window.Control.ImageLabel();
            this.MapAreaID = new System.Windows.Forms.ComboBox();
            this.LabelEquipmentName = new ElectronicObserver.Window.Control.ImageLabel();
            this.IsBossOnly = new System.Windows.Forms.CheckBox();
            this.ItemName = new System.Windows.Forms.ComboBox();
            this.ButtonRun = new System.Windows.Forms.Button();
            this.ShipName = new System.Windows.Forms.ComboBox();
            this.MapDifficulty = new System.Windows.Forms.ComboBox();
            this.EquipmentName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateBegin = new System.Windows.Forms.DateTimePicker();
            this.RankX = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RankB = new System.Windows.Forms.CheckBox();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.RankA = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RankS = new System.Windows.Forms.CheckBox();
            this.RecordView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.Searcher = new System.ComponentModel.BackgroundWorker();
            this.RecordView_Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordView_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordView_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordView_Map = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordView_Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordView_RankS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordView_RankA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecordView_RankB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.MergeRows);
            this.splitContainer1.Panel1.Controls.Add(this.MapCellID);
            this.splitContainer1.Panel1.Controls.Add(this.LabelShipName);
            this.splitContainer1.Panel1.Controls.Add(this.MapInfoID);
            this.splitContainer1.Panel1.Controls.Add(this.LabelItemName);
            this.splitContainer1.Panel1.Controls.Add(this.MapAreaID);
            this.splitContainer1.Panel1.Controls.Add(this.LabelEquipmentName);
            this.splitContainer1.Panel1.Controls.Add(this.IsBossOnly);
            this.splitContainer1.Panel1.Controls.Add(this.ItemName);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonRun);
            this.splitContainer1.Panel1.Controls.Add(this.ShipName);
            this.splitContainer1.Panel1.Controls.Add(this.MapDifficulty);
            this.splitContainer1.Panel1.Controls.Add(this.EquipmentName);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.DateBegin);
            this.splitContainer1.Panel1.Controls.Add(this.RankX);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.RankB);
            this.splitContainer1.Panel1.Controls.Add(this.DateEnd);
            this.splitContainer1.Panel1.Controls.Add(this.RankA);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.RankS);
            this.ToolTipInfo.SetToolTip(this.splitContainer1.Panel1, resources.GetString("splitContainer1.Panel1.ToolTip"));
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.RecordView);
            this.ToolTipInfo.SetToolTip(this.splitContainer1.Panel2, resources.GetString("splitContainer1.Panel2.ToolTip"));
            this.ToolTipInfo.SetToolTip(this.splitContainer1, resources.GetString("splitContainer1.ToolTip"));
            // 
            // MergeRows
            // 
            resources.ApplyResources(this.MergeRows, "MergeRows");
            this.MergeRows.Name = "MergeRows";
            this.ToolTipInfo.SetToolTip(this.MergeRows, resources.GetString("MergeRows.ToolTip"));
            this.MergeRows.UseVisualStyleBackColor = true;
            // 
            // MapCellID
            // 
            resources.ApplyResources(this.MapCellID, "MapCellID");
            this.MapCellID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapCellID.FormattingEnabled = true;
            this.MapCellID.Name = "MapCellID";
            this.ToolTipInfo.SetToolTip(this.MapCellID, resources.GetString("MapCellID.ToolTip"));
            // 
            // LabelShipName
            // 
            resources.ApplyResources(this.LabelShipName, "LabelShipName");
            this.LabelShipName.BackColor = System.Drawing.Color.Transparent;
            this.LabelShipName.Name = "LabelShipName";
            this.LabelShipName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTipInfo.SetToolTip(this.LabelShipName, resources.GetString("LabelShipName.ToolTip"));
            // 
            // MapInfoID
            // 
            resources.ApplyResources(this.MapInfoID, "MapInfoID");
            this.MapInfoID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapInfoID.FormattingEnabled = true;
            this.MapInfoID.Name = "MapInfoID";
            this.ToolTipInfo.SetToolTip(this.MapInfoID, resources.GetString("MapInfoID.ToolTip"));
            this.MapInfoID.SelectedIndexChanged += new System.EventHandler(this.MapAreaID_SelectedIndexChanged);
            // 
            // LabelItemName
            // 
            resources.ApplyResources(this.LabelItemName, "LabelItemName");
            this.LabelItemName.BackColor = System.Drawing.Color.Transparent;
            this.LabelItemName.Name = "LabelItemName";
            this.LabelItemName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTipInfo.SetToolTip(this.LabelItemName, resources.GetString("LabelItemName.ToolTip"));
            // 
            // MapAreaID
            // 
            resources.ApplyResources(this.MapAreaID, "MapAreaID");
            this.MapAreaID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapAreaID.FormattingEnabled = true;
            this.MapAreaID.Name = "MapAreaID";
            this.ToolTipInfo.SetToolTip(this.MapAreaID, resources.GetString("MapAreaID.ToolTip"));
            this.MapAreaID.SelectedIndexChanged += new System.EventHandler(this.MapAreaID_SelectedIndexChanged);
            // 
            // LabelEquipmentName
            // 
            resources.ApplyResources(this.LabelEquipmentName, "LabelEquipmentName");
            this.LabelEquipmentName.BackColor = System.Drawing.Color.Transparent;
            this.LabelEquipmentName.Name = "LabelEquipmentName";
            this.LabelEquipmentName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTipInfo.SetToolTip(this.LabelEquipmentName, resources.GetString("LabelEquipmentName.ToolTip"));
            // 
            // IsBossOnly
            // 
            resources.ApplyResources(this.IsBossOnly, "IsBossOnly");
            this.IsBossOnly.Checked = true;
            this.IsBossOnly.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.IsBossOnly.Name = "IsBossOnly";
            this.IsBossOnly.ThreeState = true;
            this.ToolTipInfo.SetToolTip(this.IsBossOnly, resources.GetString("IsBossOnly.ToolTip"));
            this.IsBossOnly.UseVisualStyleBackColor = true;
            // 
            // ItemName
            // 
            resources.ApplyResources(this.ItemName, "ItemName");
            this.ItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemName.FormattingEnabled = true;
            this.ItemName.Name = "ItemName";
            this.ToolTipInfo.SetToolTip(this.ItemName, resources.GetString("ItemName.ToolTip"));
            // 
            // ButtonRun
            // 
            resources.ApplyResources(this.ButtonRun, "ButtonRun");
            this.ButtonRun.Name = "ButtonRun";
            this.ToolTipInfo.SetToolTip(this.ButtonRun, resources.GetString("ButtonRun.ToolTip"));
            this.ButtonRun.UseVisualStyleBackColor = true;
            this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
            // 
            // ShipName
            // 
            resources.ApplyResources(this.ShipName, "ShipName");
            this.ShipName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShipName.FormattingEnabled = true;
            this.ShipName.Name = "ShipName";
            this.ToolTipInfo.SetToolTip(this.ShipName, resources.GetString("ShipName.ToolTip"));
            // 
            // MapDifficulty
            // 
            resources.ApplyResources(this.MapDifficulty, "MapDifficulty");
            this.MapDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapDifficulty.FormattingEnabled = true;
            this.MapDifficulty.Name = "MapDifficulty";
            this.ToolTipInfo.SetToolTip(this.MapDifficulty, resources.GetString("MapDifficulty.ToolTip"));
            // 
            // EquipmentName
            // 
            resources.ApplyResources(this.EquipmentName, "EquipmentName");
            this.EquipmentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EquipmentName.FormattingEnabled = true;
            this.EquipmentName.Name = "EquipmentName";
            this.ToolTipInfo.SetToolTip(this.EquipmentName, resources.GetString("EquipmentName.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.ToolTipInfo.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // DateBegin
            // 
            resources.ApplyResources(this.DateBegin, "DateBegin");
            this.DateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateBegin.Name = "DateBegin";
            this.ToolTipInfo.SetToolTip(this.DateBegin, resources.GetString("DateBegin.ToolTip"));
            // 
            // RankX
            // 
            resources.ApplyResources(this.RankX, "RankX");
            this.RankX.Checked = true;
            this.RankX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RankX.Name = "RankX";
            this.ToolTipInfo.SetToolTip(this.RankX, resources.GetString("RankX.ToolTip"));
            this.RankX.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.ToolTipInfo.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // RankB
            // 
            resources.ApplyResources(this.RankB, "RankB");
            this.RankB.Checked = true;
            this.RankB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RankB.Name = "RankB";
            this.ToolTipInfo.SetToolTip(this.RankB, resources.GetString("RankB.ToolTip"));
            this.RankB.UseVisualStyleBackColor = true;
            // 
            // DateEnd
            // 
            resources.ApplyResources(this.DateEnd, "DateEnd");
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateEnd.Name = "DateEnd";
            this.ToolTipInfo.SetToolTip(this.DateEnd, resources.GetString("DateEnd.ToolTip"));
            // 
            // RankA
            // 
            resources.ApplyResources(this.RankA, "RankA");
            this.RankA.Checked = true;
            this.RankA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RankA.Name = "RankA";
            this.ToolTipInfo.SetToolTip(this.RankA, resources.GetString("RankA.ToolTip"));
            this.RankA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.ToolTipInfo.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // RankS
            // 
            resources.ApplyResources(this.RankS, "RankS");
            this.RankS.Checked = true;
            this.RankS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RankS.Name = "RankS";
            this.ToolTipInfo.SetToolTip(this.RankS, resources.GetString("RankS.ToolTip"));
            this.RankS.UseVisualStyleBackColor = true;
            // 
            // RecordView
            // 
            resources.ApplyResources(this.RecordView, "RecordView");
            this.RecordView.AllowUserToAddRows = false;
            this.RecordView.AllowUserToDeleteRows = false;
            this.RecordView.AllowUserToResizeRows = false;
            this.RecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RecordView.ColumnHeadersVisible = false;
            this.RecordView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecordView_Header,
            this.RecordView_Name,
            this.RecordView_Date,
            this.RecordView_Map,
            this.RecordView_Rank,
            this.RecordView_RankS,
            this.RecordView_RankA,
            this.RecordView_RankB});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecordView.DefaultCellStyle = dataGridViewCellStyle5;
            this.RecordView.Name = "RecordView";
            this.RecordView.ReadOnly = true;
            this.RecordView.RowHeadersVisible = false;
            this.RecordView.RowTemplate.Height = 21;
            this.RecordView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ToolTipInfo.SetToolTip(this.RecordView, resources.GetString("RecordView.ToolTip"));
            this.RecordView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.RecordView_CellFormatting);
            this.RecordView.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.RecordView_SortCompare);
            this.RecordView.Sorted += new System.EventHandler(this.RecordView_Sorted);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusInfo});
            this.statusStrip1.Name = "statusStrip1";
            this.ToolTipInfo.SetToolTip(this.statusStrip1, resources.GetString("statusStrip1.ToolTip"));
            // 
            // StatusInfo
            // 
            resources.ApplyResources(this.StatusInfo, "StatusInfo");
            this.StatusInfo.Name = "StatusInfo";
            // 
            // ToolTipInfo
            // 
            this.ToolTipInfo.AutoPopDelay = 30000;
            this.ToolTipInfo.InitialDelay = 500;
            this.ToolTipInfo.ReshowDelay = 100;
            this.ToolTipInfo.ShowAlways = true;
            // 
            // Searcher
            // 
            this.Searcher.WorkerSupportsCancellation = true;
            this.Searcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Searcher_DoWork);
            this.Searcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Searcher_RunWorkerCompleted);
            // 
            // RecordView_Header
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.RecordView_Header.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.RecordView_Header, "RecordView_Header");
            this.RecordView_Header.Name = "RecordView_Header";
            this.RecordView_Header.ReadOnly = true;
            // 
            // RecordView_Name
            // 
            this.RecordView_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.RecordView_Name, "RecordView_Name");
            this.RecordView_Name.Name = "RecordView_Name";
            this.RecordView_Name.ReadOnly = true;
            // 
            // RecordView_Date
            // 
            resources.ApplyResources(this.RecordView_Date, "RecordView_Date");
            this.RecordView_Date.Name = "RecordView_Date";
            this.RecordView_Date.ReadOnly = true;
            // 
            // RecordView_Map
            // 
            resources.ApplyResources(this.RecordView_Map, "RecordView_Map");
            this.RecordView_Map.Name = "RecordView_Map";
            this.RecordView_Map.ReadOnly = true;
            // 
            // RecordView_Rank
            // 
            resources.ApplyResources(this.RecordView_Rank, "RecordView_Rank");
            this.RecordView_Rank.Name = "RecordView_Rank";
            this.RecordView_Rank.ReadOnly = true;
            // 
            // RecordView_RankS
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.RecordView_RankS.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.RecordView_RankS, "RecordView_RankS");
            this.RecordView_RankS.Name = "RecordView_RankS";
            this.RecordView_RankS.ReadOnly = true;
            // 
            // RecordView_RankA
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.RecordView_RankA.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.RecordView_RankA, "RecordView_RankA");
            this.RecordView_RankA.Name = "RecordView_RankA";
            this.RecordView_RankA.ReadOnly = true;
            // 
            // RecordView_RankB
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.RecordView_RankB.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.RecordView_RankB, "RecordView_RankB");
            this.RecordView_RankB.Name = "RecordView_RankB";
            this.RecordView_RankB.ReadOnly = true;
            // 
            // DialogDropRecordViewer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "DialogDropRecordViewer";
            this.ToolTipInfo.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DialogDropRecordViewer_FormClosed);
            this.Load += new System.EventHandler(this.DialogDropRecordViewer_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecordView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox IsBossOnly;
		private System.Windows.Forms.Button ButtonRun;
		private System.Windows.Forms.ComboBox MapDifficulty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox RankX;
		private System.Windows.Forms.CheckBox RankB;
		private System.Windows.Forms.CheckBox RankA;
		private System.Windows.Forms.CheckBox RankS;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker DateEnd;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker DateBegin;
		private System.Windows.Forms.ComboBox EquipmentName;
		private System.Windows.Forms.ComboBox ShipName;
		private System.Windows.Forms.ComboBox ItemName;
		private Control.ImageLabel LabelEquipmentName;
		private Control.ImageLabel LabelItemName;
		private Control.ImageLabel LabelShipName;
		private System.Windows.Forms.DataGridView RecordView;
		private System.Windows.Forms.ComboBox MapCellID;
		private System.Windows.Forms.ComboBox MapInfoID;
		private System.Windows.Forms.ComboBox MapAreaID;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.CheckBox MergeRows;
		private System.Windows.Forms.ToolTip ToolTipInfo;
		private System.Windows.Forms.ToolStripStatusLabel StatusInfo;
		private System.ComponentModel.BackgroundWorker Searcher;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordView_Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordView_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordView_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordView_Map;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordView_Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordView_RankS;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordView_RankA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecordView_RankB;
    }
}