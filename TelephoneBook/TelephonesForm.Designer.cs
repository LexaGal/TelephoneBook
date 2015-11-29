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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HouseTb = new System.Windows.Forms.TextBox();
            this.StreetTb = new System.Windows.Forms.TextBox();
            this.CityTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FlatTb = new System.Windows.Forms.TextBox();
            this.SaveAddressButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TelephonesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TelephonesDataGridView
            // 
            this.TelephonesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelephonesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.TelephonesDataGridView.Location = new System.Drawing.Point(365, 3);
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
            this.SaveTelephoneButton.Location = new System.Drawing.Point(447, 245);
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
            this.RemoveTelephoneButton.Location = new System.Drawing.Point(507, 245);
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
            this.AddNewPersonButton.Location = new System.Drawing.Point(123, 71);
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
            this.label4.Location = new System.Drawing.Point(410, 227);
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
            this.PersonsListBox.Size = new System.Drawing.Size(235, 173);
            this.PersonsListBox.TabIndex = 15;
            this.PersonsListBox.SelectedIndexChanged += new System.EventHandler(this.PersonsListBoxSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "House";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Street";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "City ";
            // 
            // HouseTb
            // 
            this.HouseTb.Location = new System.Drawing.Point(244, 49);
            this.HouseTb.Name = "HouseTb";
            this.HouseTb.Size = new System.Drawing.Size(117, 20);
            this.HouseTb.TabIndex = 18;
            // 
            // StreetTb
            // 
            this.StreetTb.Location = new System.Drawing.Point(244, 27);
            this.StreetTb.Name = "StreetTb";
            this.StreetTb.Size = new System.Drawing.Size(117, 20);
            this.StreetTb.TabIndex = 17;
            // 
            // CityTb
            // 
            this.CityTb.Location = new System.Drawing.Point(244, 5);
            this.CityTb.Name = "CityTb";
            this.CityTb.Size = new System.Drawing.Size(117, 20);
            this.CityTb.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Flat";
            // 
            // FlatTb
            // 
            this.FlatTb.Location = new System.Drawing.Point(244, 71);
            this.FlatTb.Name = "FlatTb";
            this.FlatTb.Size = new System.Drawing.Size(117, 20);
            this.FlatTb.TabIndex = 22;
            // 
            // SaveAddressButton
            // 
            this.SaveAddressButton.Location = new System.Drawing.Point(244, 97);
            this.SaveAddressButton.Name = "SaveAddressButton";
            this.SaveAddressButton.Size = new System.Drawing.Size(57, 23);
            this.SaveAddressButton.TabIndex = 24;
            this.SaveAddressButton.Text = "Save";
            this.SaveAddressButton.UseVisualStyleBackColor = true;
            this.SaveAddressButton.Click += new System.EventHandler(this.SaveAddressButtonClick);
            // 
            // TelephonesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 275);
            this.Controls.Add(this.SaveAddressButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FlatTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HouseTb);
            this.Controls.Add(this.StreetTb);
            this.Controls.Add(this.CityTb);
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
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox HouseTb;
        private TextBox StreetTb;
        private TextBox CityTb;
        private Label label8;
        private TextBox FlatTb;
        private Button SaveAddressButton;
    }
}

