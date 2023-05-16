namespace SerializableAppv2
{
    partial class Form1
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
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.NameValue = new System.Windows.Forms.TextBox();
            this.SurnameValue = new System.Windows.Forms.TextBox();
            this.AgeValue = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.ChoosePerson = new System.Windows.Forms.ComboBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.customSavePath = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(64, 30);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(29, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Imie:";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(64, 71);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(56, 13);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Nazwisko:";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(64, 114);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(35, 13);
            this.Age.TabIndex = 2;
            this.Age.Text = "Wiek:";
            // 
            // NameValue
            // 
            this.NameValue.Location = new System.Drawing.Point(67, 47);
            this.NameValue.Name = "NameValue";
            this.NameValue.Size = new System.Drawing.Size(100, 20);
            this.NameValue.TabIndex = 3;
            // 
            // SurnameValue
            // 
            this.SurnameValue.Location = new System.Drawing.Point(67, 87);
            this.SurnameValue.Name = "SurnameValue";
            this.SurnameValue.Size = new System.Drawing.Size(100, 20);
            this.SurnameValue.TabIndex = 4;
            // 
            // AgeValue
            // 
            this.AgeValue.Location = new System.Drawing.Point(67, 130);
            this.AgeValue.Name = "AgeValue";
            this.AgeValue.Size = new System.Drawing.Size(100, 20);
            this.AgeValue.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(344, 41);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Zapisz";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(344, 71);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(75, 23);
            this.ModifyButton.TabIndex = 7;
            this.ModifyButton.Text = "Modyfikuj";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(344, 114);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Usun";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Location = new System.Drawing.Point(78, 156);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(75, 23);
            this.AddPersonButton.TabIndex = 9;
            this.AddPersonButton.TabStop = false;
            this.AddPersonButton.Text = "Dodaj";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // ChoosePerson
            // 
            this.ChoosePerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChoosePerson.FormattingEnabled = true;
            this.ChoosePerson.Location = new System.Drawing.Point(198, 43);
            this.ChoosePerson.Name = "ChoosePerson";
            this.ChoosePerson.Size = new System.Drawing.Size(121, 21);
            this.ChoosePerson.TabIndex = 10;
            this.ChoosePerson.TextChanged += new System.EventHandler(this.ChoosePerson_TextChanged);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(222, 14);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Wczytaj liste";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // customSavePath
            // 
            this.customSavePath.AutoSize = true;
            this.customSavePath.Location = new System.Drawing.Point(426, 43);
            this.customSavePath.Name = "customSavePath";
            this.customSavePath.Size = new System.Drawing.Size(135, 17);
            this.customSavePath.TabIndex = 12;
            this.customSavePath.Text = "Wybierz miejsce zapisu";
            this.customSavePath.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customSavePath);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.ChoosePerson);
            this.Controls.Add(this.AddPersonButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AgeValue);
            this.Controls.Add(this.SurnameValue);
            this.Controls.Add(this.NameValue);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.TextBox NameValue;
        private System.Windows.Forms.TextBox SurnameValue;
        private System.Windows.Forms.TextBox AgeValue;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddPersonButton;
        private System.Windows.Forms.ComboBox ChoosePerson;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.CheckBox customSavePath;
    }
}

