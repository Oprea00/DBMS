namespace DBMS_lab_1
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
            this.dataGridParent = new System.Windows.Forms.DataGridView();
            this.dataGridChild = new System.Windows.Forms.DataGridView();
            this.Display_Records = new System.Windows.Forms.Button();
            this.Update_DB = new System.Windows.Forms.Button();
            this.RoutineID_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Description_textBox = new System.Windows.Forms.TextBox();
            this.ExerciseID_textBox = new System.Windows.Forms.TextBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Remove_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChild)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridParent
            // 
            this.dataGridParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridParent.Location = new System.Drawing.Point(12, 12);
            this.dataGridParent.Name = "dataGridParent";
            this.dataGridParent.RowHeadersWidth = 51;
            this.dataGridParent.RowTemplate.Height = 24;
            this.dataGridParent.Size = new System.Drawing.Size(433, 180);
            this.dataGridParent.TabIndex = 0;
            // 
            // dataGridChild
            // 
            this.dataGridChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChild.Location = new System.Drawing.Point(12, 226);
            this.dataGridChild.Name = "dataGridChild";
            this.dataGridChild.RowHeadersWidth = 51;
            this.dataGridChild.RowTemplate.Height = 24;
            this.dataGridChild.Size = new System.Drawing.Size(433, 136);
            this.dataGridChild.TabIndex = 1;
            // 
            // Display_Records
            // 
            this.Display_Records.Location = new System.Drawing.Point(540, 23);
            this.Display_Records.Name = "Display_Records";
            this.Display_Records.Size = new System.Drawing.Size(198, 33);
            this.Display_Records.TabIndex = 2;
            this.Display_Records.Text = "Display Records\r\n\r\n";
            this.Display_Records.UseVisualStyleBackColor = true;
            this.Display_Records.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // Update_DB
            // 
            this.Update_DB.Location = new System.Drawing.Point(540, 337);
            this.Update_DB.Name = "Update_DB";
            this.Update_DB.Size = new System.Drawing.Size(198, 38);
            this.Update_DB.TabIndex = 3;
            this.Update_DB.Text = "Update DB";
            this.Update_DB.UseVisualStyleBackColor = true;
            this.Update_DB.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // RoutineID_textBox
            // 
            this.RoutineID_textBox.Location = new System.Drawing.Point(451, 94);
            this.RoutineID_textBox.Name = "RoutineID_textBox";
            this.RoutineID_textBox.Size = new System.Drawing.Size(105, 22);
            this.RoutineID_textBox.TabIndex = 4;
            this.RoutineID_textBox.Text = "RoutineID\r\n";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(557, 94);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 22);
            this.Name_textBox.TabIndex = 5;
            this.Name_textBox.Text = "Name\r\n";
            // 
            // Description_textBox
            // 
            this.Description_textBox.Location = new System.Drawing.Point(663, 94);
            this.Description_textBox.Name = "Description_textBox";
            this.Description_textBox.Size = new System.Drawing.Size(100, 22);
            this.Description_textBox.TabIndex = 6;
            this.Description_textBox.Text = "Description\r\n";
            // 
            // ExerciseID_textBox
            // 
            this.ExerciseID_textBox.Location = new System.Drawing.Point(769, 94);
            this.ExerciseID_textBox.Name = "ExerciseID_textBox";
            this.ExerciseID_textBox.Size = new System.Drawing.Size(100, 22);
            this.ExerciseID_textBox.TabIndex = 7;
            this.ExerciseID_textBox.Text = "Exercise ID";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(571, 138);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(139, 54);
            this.Add_Button.TabIndex = 8;
            this.Add_Button.Text = "Add Record\r\n";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Remove_Button
            // 
            this.Remove_Button.Location = new System.Drawing.Point(571, 198);
            this.Remove_Button.Name = "Remove_Button";
            this.Remove_Button.Size = new System.Drawing.Size(139, 52);
            this.Remove_Button.TabIndex = 9;
            this.Remove_Button.Text = "Remove Record";
            this.Remove_Button.UseVisualStyleBackColor = true;
            this.Remove_Button.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(571, 256);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(139, 47);
            this.Update_Button.TabIndex = 10;
            this.Update_Button.Text = "Update Record";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(875, 429);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Remove_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.ExerciseID_textBox);
            this.Controls.Add(this.Description_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.RoutineID_textBox);
            this.Controls.Add(this.Update_DB);
            this.Controls.Add(this.Display_Records);
            this.Controls.Add(this.dataGridChild);
            this.Controls.Add(this.dataGridParent);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridParent;
        private System.Windows.Forms.DataGridView dataGridChild;
        private System.Windows.Forms.Button Display_Records;
        private System.Windows.Forms.Button Update_DB;
        private System.Windows.Forms.TextBox RoutineID_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Description_textBox;
        private System.Windows.Forms.TextBox ExerciseID_textBox;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Remove_Button;
        private System.Windows.Forms.Button Update_Button;
    } 
}

