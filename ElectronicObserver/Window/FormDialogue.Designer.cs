namespace ElectronicObserver.Window
{
    partial class FormDialogue
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
            this.LogList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LogList
            // 
            this.LogList.BackColor = System.Drawing.SystemColors.Control;
            this.LogList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogList.FormattingEnabled = true;
            this.LogList.HorizontalScrollbar = true;
            this.LogList.IntegralHeight = false;
            this.LogList.Items.AddRange(new object[] {
            "Ka-n-co-lle! Starting up!",
            "Are you ready? Carve victory on the dawn\'s horizon!",
            "Mutsu: Nagato-class battleship, second ship, Mutsu! Nice to meet you. Don\'t play " +
                "too much with fire, please?"});
            this.LogList.Location = new System.Drawing.Point(0, 0);
            this.LogList.Name = "LogList";
            this.LogList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LogList.Size = new System.Drawing.Size(284, 261);
            this.LogList.TabIndex = 1;
            // 
            // FormDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LogList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDialogue";
            this.Text = "FormDialogue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LogList;
    }
}