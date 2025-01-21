namespace Mitarbeitsprojekt
{
    partial class Tables
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
            LabelTables = new Label();
            ComboBoxTables = new ComboBox();
            SuspendLayout();
            // 
            // LabelTables
            // 
            LabelTables.AutoSize = true;
            LabelTables.Location = new Point(35, 32);
            LabelTables.Name = "LabelTables";
            LabelTables.Size = new Size(47, 15);
            LabelTables.TabIndex = 0;
            LabelTables.Text = "Tabelle:";
            // 
            // ComboBoxTables
            // 
            ComboBoxTables.FormattingEnabled = true;
            ComboBoxTables.Location = new Point(237, 24);
            ComboBoxTables.Name = "ComboBoxTables";
            ComboBoxTables.Size = new Size(150, 23);
            ComboBoxTables.TabIndex = 3;
            // 
            // Tables
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 450);
            Controls.Add(ComboBoxTables);
            Controls.Add(LabelTables);
            Name = "Tables";
            Text = "Tables";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTables;
        private ComboBox ComboBoxTables;
    }
}