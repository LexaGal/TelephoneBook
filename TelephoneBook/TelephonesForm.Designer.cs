using System.Windows.Forms;

namespace TelephoneBook
{
    partial class TelephonesForm
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
            this.TelephonesDataGridView = new System.Windows.Forms.DataGridView();
            this.SavePersonButton = new System.Windows.Forms.Button();
            this.SaveTelephoneButton = new System.Windows.Forms.Button();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.SurnameTb = new System.Windows.Forms.TextBox();
            this.PatronymicTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemoveTelephoneButton = new System.Windows.Forms.Button();
            this.RemovePersonButton = new System.Windows.Forms.Button();
            this.AddNewPersonButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PersonsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.TelephonesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TelephonesDataGridView
            // 
            this.TelephonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelephonesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.TelephonesDataGridView.Location = new System.Drawing.Point(192, 3);
            this.TelephonesDataGridView.Name = "TelephonesDataGridView";
            this.TelephonesDataGridView.Size = new System.Drawing.Size(272, 217);
            this.TelephonesDataGridView.TabIndex = 1;
            // 
            // SavePersonButton
            // 
            this.SavePersonButton.Location = new System.Drawing.Point(65, 71);
            this.SavePersonButton.Name = "SavePersonButton";
            this.SavePersonButton.Size = new System.Drawing.Size(57, 23);
            this.SavePersonButton.TabIndex = 2;
            this.SavePersonButton.Text = "Save";
            this.SavePersonButton.UseVisualStyleBackColor = true;
            this.SavePersonButton.Click += new System.EventHandler(this.SavePersonButtonClick);
            // 
            // SaveTelephoneButton
            // 
            this.SaveTelephoneButton.Location = new System.Drawing.Point(189, 247);
            this.SaveTelephoneButton.Name = "SaveTelephoneButton";
            this.SaveTelephoneButton.Size = new System.Drawing.Size(57, 23);
            this.SaveTelephoneButton.TabIndex = 3;
            this.SaveTelephoneButton.Text = "Save";
            this.SaveTelephoneButton.UseVisualStyleBackColor = true;
            this.SaveTelephoneButton.Click += new System.EventHandler(this.SaveTelephonesButtonClick);
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(65, 3);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(117, 20);
            this.NameTb.TabIndex = 4;
            // 
            // SurnameTb
            // 
            this.SurnameTb.Location = new System.Drawing.Point(65, 25);
            this.SurnameTb.Name = "SurnameTb";
            this.SurnameTb.Size = new System.Drawing.Size(117, 20);
            this.SurnameTb.TabIndex = 5;
            // 
            // PatronymicTb
            // 
            this.PatronymicTb.Location = new System.Drawing.Point(65, 47);
            this.PatronymicTb.Name = "PatronymicTb";
            this.PatronymicTb.Size = new System.Drawing.Size(117, 20);
            this.PatronymicTb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Patronymic";
            // 
            // RemoveTelephoneButton
            // 
            this.RemoveTelephoneButton.Location = new System.Drawing.Point(249, 247);
            this.RemoveTelephoneButton.Name = "RemoveTelephoneButton";
            this.RemoveTelephoneButton.Size = new System.Drawing.Size(61, 23);
            this.RemoveTelephoneButton.TabIndex = 10;
            this.RemoveTelephoneButton.Text = "Remove";
            this.RemoveTelephoneButton.UseVisualStyleBackColor = true;
            this.RemoveTelephoneButton.Click += new System.EventHandler(this.RemoveTelephonesButtonClick);
            // 
            // RemovePersonButton
            // 
            this.RemovePersonButton.Location = new System.Drawing.Point(4, 71);
            this.RemovePersonButton.Name = "RemovePersonButton";
            this.RemovePersonButton.Size = new System.Drawing.Size(59, 23);
            this.RemovePersonButton.TabIndex = 11;
            this.RemovePersonButton.Text = "Remove";
            this.RemovePersonButton.UseVisualStyleBackColor = true;
            this.RemovePersonButton.Click += new System.EventHandler(this.RemovePersonButtonClick);
            // 
            // AddNewPersonButton
            // 
            this.AddNewPersonButton.Location = new System.Drawing.Point(124, 71);
            this.AddNewPersonButton.Name = "AddNewPersonButton";
            this.AddNewPersonButton.Size = new System.Drawing.Size(59, 23);
            this.AddNewPersonButton.TabIndex = 12;
            this.AddNewPersonButton.Text = "Add new";
            this.AddNewPersonButton.UseVisualStyleBackColor = true;
            this.AddNewPersonButton.Click += new System.EventHandler(this.AddNewPersonButtonClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select some rows to save/remove them";
            // 
            // PersonsListBox
            // 
            this.PersonsListBox.FormattingEnabled = true;
            this.PersonsListBox.Location = new System.Drawing.Point(3, 98);
            this.PersonsListBox.Name = "PersonsListBox";
            this.PersonsListBox.Size = new System.Drawing.Size(179, 173);
            this.PersonsListBox.TabIndex = 15;
            this.PersonsListBox.SelectedIndexChanged += new System.EventHandler(this.PersonsListBoxSelectedIndexChanged);
            // 
            // TelephonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 275);
            this.Controls.Add(this.PersonsListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddNewPersonButton);
            this.Controls.Add(this.RemovePersonButton);
            this.Controls.Add(this.RemoveTelephoneButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PatronymicTb);
            this.Controls.Add(this.SurnameTb);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.SaveTelephoneButton);
            this.Controls.Add(this.SavePersonButton);
            this.Controls.Add(this.TelephonesDataGridView);
            this.Name = "TelephonesForm";
            this.Text = "TelephonesBook";
            this.Load += new System.EventHandler(this.TelephonesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TelephonesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TelephonesDataGridView;
        private Button SavePersonButton;
        private Button SaveTelephoneButton;
        private TextBox NameTb;
        private TextBox SurnameTb;
        private TextBox PatronymicTb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button RemoveTelephoneButton;
        private Button RemovePersonButton;
        private Button AddNewPersonButton;
        private Label label4;
        private ListBox PersonsListBox;
    }
}

