namespace ElectronicObserver.Window.Dialog {
	partial class DialogShipGroupSortOrder {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogShipGroupSortOrder));
            this.AutoSortFlag = new System.Windows.Forms.CheckBox();
            this.EnabledView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonRightAll = new System.Windows.Forms.Button();
            this.ButtonLeftAll = new System.Windows.Forms.Button();
            this.DisabledView = new System.Windows.Forms.DataGridView();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.EnabledView_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnabledView_SortDirection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EnabledView_Up = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EnabledView_Down = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DisabledView_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EnabledView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisabledView)).BeginInit();
            this.SuspendLayout();
            // 
            // AutoSortFlag
            // 
            resources.ApplyResources(this.AutoSortFlag, "AutoSortFlag");
            this.AutoSortFlag.Name = "AutoSortFlag";
            this.AutoSortFlag.UseVisualStyleBackColor = true;
            // 
            // EnabledView
            // 
            resources.ApplyResources(this.EnabledView, "EnabledView");
            this.EnabledView.AllowUserToAddRows = false;
            this.EnabledView.AllowUserToDeleteRows = false;
            this.EnabledView.AllowUserToResizeColumns = false;
            this.EnabledView.AllowUserToResizeRows = false;
            this.EnabledView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EnabledView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnabledView_Name,
            this.EnabledView_SortDirection,
            this.EnabledView_Up,
            this.EnabledView_Down});
            this.EnabledView.Name = "EnabledView";
            this.EnabledView.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.EnabledView, 3);
            this.EnabledView.RowTemplate.Height = 21;
            this.EnabledView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EnabledView.ShowCellToolTips = false;
            this.EnabledView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EnabledView_CellContentClick);
            this.EnabledView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.EnabledView_CellFormatting);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EnabledView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.DisabledView, 2, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.ButtonDown);
            this.panel3.Controls.Add(this.ButtonUp);
            this.panel3.Name = "panel3";
            // 
            // ButtonDown
            // 
            resources.ApplyResources(this.ButtonDown, "ButtonDown");
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.UseVisualStyleBackColor = true;
            this.ButtonDown.Click += new System.EventHandler(this.ButtonDown_Click);
            // 
            // ButtonUp
            // 
            resources.ApplyResources(this.ButtonUp, "ButtonUp");
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += new System.EventHandler(this.ButtonUp_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.ButtonRight);
            this.panel1.Controls.Add(this.ButtonLeft);
            this.panel1.Name = "panel1";
            // 
            // ButtonRight
            // 
            resources.ApplyResources(this.ButtonRight, "ButtonRight");
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // ButtonLeft
            // 
            resources.ApplyResources(this.ButtonLeft, "ButtonLeft");
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.ButtonRightAll);
            this.panel2.Controls.Add(this.ButtonLeftAll);
            this.panel2.Name = "panel2";
            // 
            // ButtonRightAll
            // 
            resources.ApplyResources(this.ButtonRightAll, "ButtonRightAll");
            this.ButtonRightAll.Name = "ButtonRightAll";
            this.ButtonRightAll.UseVisualStyleBackColor = true;
            this.ButtonRightAll.Click += new System.EventHandler(this.ButtonRightAll_Click);
            // 
            // ButtonLeftAll
            // 
            resources.ApplyResources(this.ButtonLeftAll, "ButtonLeftAll");
            this.ButtonLeftAll.Name = "ButtonLeftAll";
            this.ButtonLeftAll.UseVisualStyleBackColor = true;
            this.ButtonLeftAll.Click += new System.EventHandler(this.ButtonLeftAll_Click);
            // 
            // DisabledView
            // 
            resources.ApplyResources(this.DisabledView, "DisabledView");
            this.DisabledView.AllowUserToAddRows = false;
            this.DisabledView.AllowUserToDeleteRows = false;
            this.DisabledView.AllowUserToResizeColumns = false;
            this.DisabledView.AllowUserToResizeRows = false;
            this.DisabledView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisabledView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DisabledView_Name});
            this.DisabledView.Name = "DisabledView";
            this.DisabledView.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.DisabledView, 3);
            this.DisabledView.RowTemplate.Height = 21;
            this.DisabledView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DisabledView.ShowCellToolTips = false;
            this.DisabledView.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.DisabledView_SortCompare);
            // 
            // ButtonOK
            // 
            resources.ApplyResources(this.ButtonOK, "ButtonOK");
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // EnabledView_Name
            // 
            this.EnabledView_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.EnabledView_Name, "EnabledView_Name");
            this.EnabledView_Name.Name = "EnabledView_Name";
            this.EnabledView_Name.ReadOnly = true;
            this.EnabledView_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EnabledView_SortDirection
            // 
            this.EnabledView_SortDirection.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            resources.ApplyResources(this.EnabledView_SortDirection, "EnabledView_SortDirection");
            this.EnabledView_SortDirection.Name = "EnabledView_SortDirection";
            // 
            // EnabledView_Up
            // 
            resources.ApplyResources(this.EnabledView_Up, "EnabledView_Up");
            this.EnabledView_Up.Name = "EnabledView_Up";
            // 
            // EnabledView_Down
            // 
            resources.ApplyResources(this.EnabledView_Down, "EnabledView_Down");
            this.EnabledView_Down.Name = "EnabledView_Down";
            // 
            // DisabledView_Name
            // 
            this.DisabledView_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.DisabledView_Name, "DisabledView_Name");
            this.DisabledView_Name.Name = "DisabledView_Name";
            this.DisabledView_Name.ReadOnly = true;
            // 
            // DialogShipGroupSortOrder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AutoSortFlag);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogShipGroupSortOrder";
            this.Load += new System.EventHandler(this.DialogShipGroupSortOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnabledView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DisabledView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox AutoSortFlag;
		private System.Windows.Forms.DataGridView EnabledView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button ButtonOK;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonLeft;
		private System.Windows.Forms.Button ButtonRight;
		private System.Windows.Forms.Button ButtonRightAll;
		private System.Windows.Forms.Button ButtonLeftAll;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button ButtonDown;
		private System.Windows.Forms.Button ButtonUp;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView DisabledView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnabledView_Name;
        private System.Windows.Forms.DataGridViewButtonColumn EnabledView_SortDirection;
        private System.Windows.Forms.DataGridViewButtonColumn EnabledView_Up;
        private System.Windows.Forms.DataGridViewButtonColumn EnabledView_Down;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisabledView_Name;
    }
}