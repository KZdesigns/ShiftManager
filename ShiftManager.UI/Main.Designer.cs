namespace ShiftManager.UI
{
    partial class Main
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmployeeNumber = new System.Windows.Forms.Label();
            this.labelShiftNumber = new System.Windows.Forms.Label();
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeNumber = new System.Windows.Forms.TextBox();
            this.textBoxShiftNumber = new System.Windows.Forms.TextBox();
            this.textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.listBoxProductionWoker = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(100, 48);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelEmployeeNumber
            // 
            this.labelEmployeeNumber.AutoSize = true;
            this.labelEmployeeNumber.Location = new System.Drawing.Point(100, 80);
            this.labelEmployeeNumber.Name = "labelEmployeeNumber";
            this.labelEmployeeNumber.Size = new System.Drawing.Size(93, 13);
            this.labelEmployeeNumber.TabIndex = 1;
            this.labelEmployeeNumber.Text = "Employee Number";
            // 
            // labelShiftNumber
            // 
            this.labelShiftNumber.AutoSize = true;
            this.labelShiftNumber.Location = new System.Drawing.Point(100, 111);
            this.labelShiftNumber.Name = "labelShiftNumber";
            this.labelShiftNumber.Size = new System.Drawing.Size(68, 13);
            this.labelShiftNumber.TabIndex = 2;
            this.labelShiftNumber.Text = "Shift Number";
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Location = new System.Drawing.Point(100, 141);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(63, 13);
            this.labelHourlyRate.TabIndex = 3;
            this.labelHourlyRate.Text = "Hourly Rate";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(199, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxEmployeeNumber
            // 
            this.textBoxEmployeeNumber.Location = new System.Drawing.Point(199, 77);
            this.textBoxEmployeeNumber.Name = "textBoxEmployeeNumber";
            this.textBoxEmployeeNumber.Size = new System.Drawing.Size(161, 20);
            this.textBoxEmployeeNumber.TabIndex = 5;
            // 
            // textBoxShiftNumber
            // 
            this.textBoxShiftNumber.Location = new System.Drawing.Point(199, 108);
            this.textBoxShiftNumber.Name = "textBoxShiftNumber";
            this.textBoxShiftNumber.Size = new System.Drawing.Size(161, 20);
            this.textBoxShiftNumber.TabIndex = 6;
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Location = new System.Drawing.Point(199, 138);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(161, 20);
            this.textBoxHourlyRate.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(452, 58);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 39);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(452, 108);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(102, 39);
            this.buttonSubmit.TabIndex = 9;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // listBoxProductionWoker
            // 
            this.listBoxProductionWoker.FormattingEnabled = true;
            this.listBoxProductionWoker.Location = new System.Drawing.Point(120, 192);
            this.listBoxProductionWoker.Name = "listBoxProductionWoker";
            this.listBoxProductionWoker.Size = new System.Drawing.Size(451, 225);
            this.listBoxProductionWoker.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 450);
            this.Controls.Add(this.listBoxProductionWoker);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxHourlyRate);
            this.Controls.Add(this.textBoxShiftNumber);
            this.Controls.Add(this.textBoxEmployeeNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelHourlyRate);
            this.Controls.Add(this.labelShiftNumber);
            this.Controls.Add(this.labelEmployeeNumber);
            this.Controls.Add(this.labelName);
            this.Name = "Main";
            this.Text = "Shift Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmployeeNumber;
        private System.Windows.Forms.Label labelShiftNumber;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmployeeNumber;
        private System.Windows.Forms.TextBox textBoxShiftNumber;
        private System.Windows.Forms.TextBox textBoxHourlyRate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.ListBox listBoxProductionWoker;
    }
}

