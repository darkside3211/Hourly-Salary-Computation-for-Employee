namespace EmployeeApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtboxFirstName = new TextBox();
            txtboxDepartment = new TextBox();
            txtboxLastName = new TextBox();
            txtboxJobTitle = new TextBox();
            txtboxRatePerHour = new TextBox();
            txtboxTotalHoursWorked = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            DisplayFirstName = new Label();
            label9 = new Label();
            DisplayLastName = new Label();
            DisplaySalary = new Label();
            SuspendLayout();
            // 
            // txtboxFirstName
            // 
            txtboxFirstName.Location = new Point(64, 75);
            txtboxFirstName.Name = "txtboxFirstName";
            txtboxFirstName.Size = new Size(188, 23);
            txtboxFirstName.TabIndex = 0;
            // 
            // txtboxDepartment
            // 
            txtboxDepartment.Location = new Point(64, 136);
            txtboxDepartment.Name = "txtboxDepartment";
            txtboxDepartment.Size = new Size(188, 23);
            txtboxDepartment.TabIndex = 1;
            // 
            // txtboxLastName
            // 
            txtboxLastName.Location = new Point(328, 75);
            txtboxLastName.Name = "txtboxLastName";
            txtboxLastName.Size = new Size(188, 23);
            txtboxLastName.TabIndex = 2;
            // 
            // txtboxJobTitle
            // 
            txtboxJobTitle.Location = new Point(328, 136);
            txtboxJobTitle.Name = "txtboxJobTitle";
            txtboxJobTitle.Size = new Size(188, 23);
            txtboxJobTitle.TabIndex = 3;
            // 
            // txtboxRatePerHour
            // 
            txtboxRatePerHour.Location = new Point(64, 222);
            txtboxRatePerHour.Name = "txtboxRatePerHour";
            txtboxRatePerHour.Size = new Size(188, 23);
            txtboxRatePerHour.TabIndex = 4;
            // 
            // txtboxTotalHoursWorked
            // 
            txtboxTotalHoursWorked.Location = new Point(328, 222);
            txtboxTotalHoursWorked.Name = "txtboxTotalHoursWorked";
            txtboxTotalHoursWorked.Size = new Size(188, 23);
            txtboxTotalHoursWorked.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 46);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 6;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(328, 52);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(64, 113);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 8;
            label3.Text = "Department";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(328, 113);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 9;
            label4.Text = "Job title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(64, 199);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 10;
            label5.Text = "Rate per hour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(328, 199);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 11;
            label6.Text = "Total hours worked";
            // 
            // button1
            // 
            button1.Location = new Point(226, 265);
            button1.Name = "button1";
            button1.Size = new Size(126, 39);
            button1.TabIndex = 12;
            button1.Text = "Compute Salary";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 321);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 13;
            label7.Text = "First Name: ";
            // 
            // DisplayFirstName
            // 
            DisplayFirstName.AutoSize = true;
            DisplayFirstName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayFirstName.Location = new Point(123, 321);
            DisplayFirstName.Name = "DisplayFirstName";
            DisplayFirstName.Size = new Size(87, 20);
            DisplayFirstName.TabIndex = 14;
            DisplayFirstName.Text = "First Name: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(30, 350);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 15;
            label9.Text = "Last name:";
            // 
            // DisplayLastName
            // 
            DisplayLastName.AutoSize = true;
            DisplayLastName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DisplayLastName.Location = new Point(123, 350);
            DisplayLastName.Name = "DisplayLastName";
            DisplayLastName.Size = new Size(79, 20);
            DisplayLastName.TabIndex = 16;
            DisplayLastName.Text = "Last name:";
            // 
            // DisplaySalary
            // 
            DisplaySalary.AutoSize = true;
            DisplaySalary.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DisplaySalary.Location = new Point(75, 379);
            DisplaySalary.Name = "DisplaySalary";
            DisplaySalary.Size = new Size(88, 20);
            DisplaySalary.TabIndex = 18;
            DisplaySalary.Text = "Basic salary:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 424);
            Controls.Add(DisplaySalary);
            Controls.Add(DisplayLastName);
            Controls.Add(label9);
            Controls.Add(DisplayFirstName);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxTotalHoursWorked);
            Controls.Add(txtboxRatePerHour);
            Controls.Add(txtboxJobTitle);
            Controls.Add(txtboxLastName);
            Controls.Add(txtboxDepartment);
            Controls.Add(txtboxFirstName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxFirstName;
        private TextBox txtboxDepartment;
        private TextBox txtboxLastName;
        private TextBox txtboxJobTitle;
        private TextBox txtboxRatePerHour;
        private TextBox txtboxTotalHoursWorked;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label DisplayFirstName;
        private Label label9;
        private Label DisplayLastName;
        private Label DisplaySalary;
    }
}