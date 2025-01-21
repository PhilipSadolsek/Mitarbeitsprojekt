namespace Mitarbeitsprojekt
{
    partial class DatabaseForm
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
            LabelDatabase = new Label();
            label1 = new Label();
            ComboBoxDatenbanken = new ComboBox();
            TextBoxCreateDatabase = new TextBox();
            ButtonCreateDatabase = new Button();
            ButtonDatabaseDelete = new Button();
            ButtonDatabaseLoad = new Button();
            SuspendLayout();
            // 
            // LabelDatabase
            // 
            LabelDatabase.AutoSize = true;
            LabelDatabase.Location = new Point(21, 22);
            LabelDatabase.Name = "LabelDatabase";
            LabelDatabase.Size = new Size(67, 15);
            LabelDatabase.TabIndex = 0;
            LabelDatabase.Text = "Datenbank:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 62);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 1;
            label1.Text = "Datenbank erstellen";
            // 
            // ComboBoxDatenbanken
            // 
            ComboBoxDatenbanken.FormattingEnabled = true;
            ComboBoxDatenbanken.Location = new Point(307, 22);
            ComboBoxDatenbanken.Name = "ComboBoxDatenbanken";
            ComboBoxDatenbanken.Size = new Size(150, 23);
            ComboBoxDatenbanken.TabIndex = 2;
            // 
            // TextBoxCreateDatabase
            // 
            TextBoxCreateDatabase.Location = new Point(307, 62);
            TextBoxCreateDatabase.Name = "TextBoxCreateDatabase";
            TextBoxCreateDatabase.Size = new Size(150, 23);
            TextBoxCreateDatabase.TabIndex = 3;
            // 
            // ButtonCreateDatabase
            // 
            ButtonCreateDatabase.Location = new Point(167, 115);
            ButtonCreateDatabase.Name = "ButtonCreateDatabase";
            ButtonCreateDatabase.Size = new Size(111, 26);
            ButtonCreateDatabase.TabIndex = 4;
            ButtonCreateDatabase.Text = "Erstellen";
            ButtonCreateDatabase.UseVisualStyleBackColor = true;
            // 
            // ButtonDatabaseDelete
            // 
            ButtonDatabaseDelete.Location = new Point(32, 174);
            ButtonDatabaseDelete.Name = "ButtonDatabaseDelete";
            ButtonDatabaseDelete.Size = new Size(111, 26);
            ButtonDatabaseDelete.TabIndex = 5;
            ButtonDatabaseDelete.Text = "Löschen";
            ButtonDatabaseDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonDatabaseLoad
            // 
            ButtonDatabaseLoad.Location = new Point(307, 174);
            ButtonDatabaseLoad.Name = "ButtonDatabaseLoad";
            ButtonDatabaseLoad.Size = new Size(111, 26);
            ButtonDatabaseLoad.TabIndex = 6;
            ButtonDatabaseLoad.Text = "Erstellen";
            ButtonDatabaseLoad.UseVisualStyleBackColor = true;
            ButtonDatabaseLoad.Click += ButtonDatabaseLoad_Click;
            // 
            // DatabaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 439);
            Controls.Add(ButtonDatabaseLoad);
            Controls.Add(ButtonDatabaseDelete);
            Controls.Add(ButtonCreateDatabase);
            Controls.Add(TextBoxCreateDatabase);
            Controls.Add(ComboBoxDatenbanken);
            Controls.Add(label1);
            Controls.Add(LabelDatabase);
            Name = "DatabaseForm";
            Text = "DatabaseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelDatabase;
        private Label label1;
        private ComboBox ComboBoxDatenbanken;
        private TextBox TextBoxCreateDatabase;
        private Button ButtonCreateDatabase;
        private Button ButtonDatabaseDelete;
        private Button ButtonDatabaseLoad;
    }
}