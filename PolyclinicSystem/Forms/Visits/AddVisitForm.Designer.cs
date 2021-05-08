
namespace PolyclinicSystem.Forms.Functions
{
    partial class AddVisitForm
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
            this.addVisitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.visitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.messagesLabel = new System.Windows.Forms.Label();
            this.visitTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.doctorTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addVisitButton
            // 
            this.addVisitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addVisitButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVisitButton.Location = new System.Drawing.Point(133, 399);
            this.addVisitButton.Name = "addVisitButton";
            this.addVisitButton.Size = new System.Drawing.Size(214, 40);
            this.addVisitButton.TabIndex = 8;
            this.addVisitButton.Text = "Записаться на прием";
            this.addVisitButton.UseVisualStyleBackColor = true;
            this.addVisitButton.Click += new System.EventHandler(this.addVisitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 57);
            this.panel1.TabIndex = 9;
            // 
            // visitDateTimePicker
            // 
            this.visitDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visitDateTimePicker.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitDateTimePicker.Location = new System.Drawing.Point(63, 226);
            this.visitDateTimePicker.Name = "visitDateTimePicker";
            this.visitDateTimePicker.Size = new System.Drawing.Size(367, 27);
            this.visitDateTimePicker.TabIndex = 10;
            this.visitDateTimePicker.ValueChanged += new System.EventHandler(this.visitDateTimePicker_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выберите врача:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Выберите дату:";
            // 
            // messagesLabel
            // 
            this.messagesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messagesLabel.AutoSize = true;
            this.messagesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messagesLabel.ForeColor = System.Drawing.Color.Tomato;
            this.messagesLabel.Location = new System.Drawing.Point(129, 365);
            this.messagesLabel.Name = "messagesLabel";
            this.messagesLabel.Size = new System.Drawing.Size(51, 19);
            this.messagesLabel.TabIndex = 14;
            this.messagesLabel.Text = "label3";
            // 
            // visitTypeComboBox
            // 
            this.visitTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visitTypeComboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitTypeComboBox.FormattingEnabled = true;
            this.visitTypeComboBox.Items.AddRange(new object[] {
            "Первичный",
            "Повторный"});
            this.visitTypeComboBox.Location = new System.Drawing.Point(63, 317);
            this.visitTypeComboBox.Name = "visitTypeComboBox";
            this.visitTypeComboBox.Size = new System.Drawing.Size(367, 27);
            this.visitTypeComboBox.Sorted = true;
            this.visitTypeComboBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(59, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Выберите тип приема:";
            // 
            // doctorTextBox
            // 
            this.doctorTextBox.Enabled = false;
            this.doctorTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorTextBox.Location = new System.Drawing.Point(63, 143);
            this.doctorTextBox.Name = "doctorTextBox";
            this.doctorTextBox.Size = new System.Drawing.Size(367, 27);
            this.doctorTextBox.TabIndex = 17;
            // 
            // AddVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 474);
            this.Controls.Add(this.doctorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.visitTypeComboBox);
            this.Controls.Add(this.messagesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visitDateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addVisitButton);
            this.MinimumSize = new System.Drawing.Size(513, 521);
            this.Name = "AddVisitForm";
            this.Text = "Выбранный врач:";
            this.Load += new System.EventHandler(this.AddVisitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVisitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker visitDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label messagesLabel;
        private System.Windows.Forms.ComboBox visitTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox doctorTextBox;
    }
}