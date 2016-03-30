namespace ElectronicObserver.Window.Dialog {
	partial class DialogShipGroupColumnFilter {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogShipGroupColumnFilter));
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ColumnView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ScrLkColumnCount = new System.Windows.Forms.NumericUpDown();
            this.ColumnView_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnView_Visible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnView_AutoSize = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnView_Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnView_Up = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnView_Down = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrLkColumnCount)).BeginInit();
            this.SuspendLayout();
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
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ColumnView
            // 
            resources.ApplyResources(this.ColumnView, "ColumnView");
            this.ColumnView.AllowUserToAddRows = false;
            this.ColumnView.AllowUserToDeleteRows = false;
            this.ColumnView.AllowUserToResizeColumns = false;
            this.ColumnView.AllowUserToResizeRows = false;
            this.ColumnView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ColumnView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnView_Name,
            this.ColumnView_Visible,
            this.ColumnView_AutoSize,
            this.ColumnView_Width,
            this.ColumnView_Up,
            this.ColumnView_Down});
            this.ColumnView.MultiSelect = false;
            this.ColumnView.Name = "ColumnView";
            this.ColumnView.RowHeadersVisible = false;
            this.ColumnView.RowTemplate.Height = 21;
            this.ColumnView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ColumnView_CellContentClick);
            this.ColumnView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.ColumnView_CellValidating);
            this.ColumnView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ColumnView_CellValueChanged);
            this.ColumnView.CurrentCellDirtyStateChanged += new System.EventHandler(this.ColumnView_CurrentCellDirtyStateChanged);
            this.ColumnView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ColumnView_DataError);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // ScrLkColumnCount
            // 
            resources.ApplyResources(this.ScrLkColumnCount, "ScrLkColumnCount");
            this.ScrLkColumnCount.Name = "ScrLkColumnCount";
            // 
            // ColumnView_Name
            // 
            this.ColumnView_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ColumnView_Name, "ColumnView_Name");
            this.ColumnView_Name.Name = "ColumnView_Name";
            this.ColumnView_Name.ReadOnly = true;
            this.ColumnView_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnView_Visible
            // 
            this.ColumnView_Visible.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ColumnView_Visible, "ColumnView_Visible");
            this.ColumnView_Visible.Name = "ColumnView_Visible";
            // 
            // ColumnView_AutoSize
            // 
            this.ColumnView_AutoSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.ColumnView_AutoSize, "ColumnView_AutoSize");
            this.ColumnView_AutoSize.Name = "ColumnView_AutoSize";
            // 
            // ColumnView_Width
            // 
            resources.ApplyResources(this.ColumnView_Width, "ColumnView_Width");
            this.ColumnView_Width.Name = "ColumnView_Width";
            this.ColumnView_Width.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnView_Up
            // 
            resources.ApplyResources(this.ColumnView_Up, "ColumnView_Up");
            this.ColumnView_Up.Name = "ColumnView_Up";
            // 
            // ColumnView_Down
            // 
            resources.ApplyResources(this.ColumnView_Down, "ColumnView_Down");
            this.ColumnView_Down.Name = "ColumnView_Down";
            // 
            // DialogShipGroupColumnFilter
            // 
            this.AcceptButton = this.ButtonOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.ButtonCancel;
            this.Controls.Add(this.ScrLkColumnCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColumnView);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogShipGroupColumnFilter";
            this.Load += new System.EventHandler(this.DialogShipGroupColumnFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScrLkColumnCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonOK;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.DataGridView ColumnView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown ScrLkColumnCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnView_Name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnView_Visible;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnView_AutoSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnView_Width;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnView_Up;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnView_Down;
    }
}