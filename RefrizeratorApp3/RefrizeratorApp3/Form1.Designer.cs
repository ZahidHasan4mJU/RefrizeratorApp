namespace RefrizeratorApp3
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
            this.remainingWeightTextBox = new System.Windows.Forms.TextBox();
            this.currentWeightTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.weightPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.noOfItemsTextBox = new System.Windows.Forms.TextBox();
            this.maxWeightTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RefrizeratorForm = new System.Windows.Forms.GroupBox();
            this.RefrizeratorForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // remainingWeightTextBox
            // 
            this.remainingWeightTextBox.Location = new System.Drawing.Point(316, 120);
            this.remainingWeightTextBox.Name = "remainingWeightTextBox";
            this.remainingWeightTextBox.ReadOnly = true;
            this.remainingWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.remainingWeightTextBox.TabIndex = 33;
            // 
            // currentWeightTextBox
            // 
            this.currentWeightTextBox.Location = new System.Drawing.Point(104, 119);
            this.currentWeightTextBox.Name = "currentWeightTextBox";
            this.currentWeightTextBox.ReadOnly = true;
            this.currentWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentWeightTextBox.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Remaining (Weight)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Current (Weight)";
            // 
            // weightPerUnitTextBox
            // 
            this.weightPerUnitTextBox.Location = new System.Drawing.Point(305, 73);
            this.weightPerUnitTextBox.Name = "weightPerUnitTextBox";
            this.weightPerUnitTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightPerUnitTextBox.TabIndex = 29;
            // 
            // noOfItemsTextBox
            // 
            this.noOfItemsTextBox.Location = new System.Drawing.Point(104, 73);
            this.noOfItemsTextBox.Name = "noOfItemsTextBox";
            this.noOfItemsTextBox.Size = new System.Drawing.Size(100, 20);
            this.noOfItemsTextBox.TabIndex = 28;
            // 
            // maxWeightTextBox
            // 
            this.maxWeightTextBox.Location = new System.Drawing.Point(180, 28);
            this.maxWeightTextBox.Name = "maxWeightTextBox";
            this.maxWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxWeightTextBox.TabIndex = 27;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(411, 73);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 25;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(286, 28);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 26;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Weight (kg) /Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "No of items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Maximum weight it can take";
            // 
            // RefrizeratorForm
            // 
            this.RefrizeratorForm.Controls.Add(this.remainingWeightTextBox);
            this.RefrizeratorForm.Controls.Add(this.currentWeightTextBox);
            this.RefrizeratorForm.Controls.Add(this.label4);
            this.RefrizeratorForm.Controls.Add(this.label5);
            this.RefrizeratorForm.Controls.Add(this.weightPerUnitTextBox);
            this.RefrizeratorForm.Controls.Add(this.noOfItemsTextBox);
            this.RefrizeratorForm.Controls.Add(this.maxWeightTextBox);
            this.RefrizeratorForm.Controls.Add(this.enterButton);
            this.RefrizeratorForm.Controls.Add(this.saveButton);
            this.RefrizeratorForm.Controls.Add(this.label3);
            this.RefrizeratorForm.Controls.Add(this.label2);
            this.RefrizeratorForm.Controls.Add(this.label1);
            this.RefrizeratorForm.Location = new System.Drawing.Point(12, 12);
            this.RefrizeratorForm.Name = "RefrizeratorForm";
            this.RefrizeratorForm.Size = new System.Drawing.Size(499, 162);
            this.RefrizeratorForm.TabIndex = 34;
            this.RefrizeratorForm.TabStop = false;
            this.RefrizeratorForm.Text = "Refrizerator UI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 191);
            this.Controls.Add(this.RefrizeratorForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.RefrizeratorForm.ResumeLayout(false);
            this.RefrizeratorForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox remainingWeightTextBox;
        private System.Windows.Forms.TextBox currentWeightTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox weightPerUnitTextBox;
        private System.Windows.Forms.TextBox noOfItemsTextBox;
        private System.Windows.Forms.TextBox maxWeightTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox RefrizeratorForm;
    }
}

