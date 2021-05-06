
namespace PolyclinicSystem.Forms.Functions
{
    partial class VisitForm
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
            this.moveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.writeInfoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.patientLabel = new System.Windows.Forms.Label();
            this.doctorLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.treatmentLabel = new System.Windows.Forms.Label();
            this.diagnosisLabel = new System.Windows.Forms.Label();
            this.complaintsLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.endVisitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveButton
            // 
            this.moveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.moveButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveButton.Location = new System.Drawing.Point(475, 81);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(147, 40);
            this.moveButton.TabIndex = 7;
            this.moveButton.Text = "Перенести";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(475, 140);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(147, 40);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отменить";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // writeInfoButton
            // 
            this.writeInfoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.writeInfoButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.writeInfoButton.Location = new System.Drawing.Point(475, 277);
            this.writeInfoButton.Name = "writeInfoButton";
            this.writeInfoButton.Size = new System.Drawing.Size(147, 63);
            this.writeInfoButton.TabIndex = 9;
            this.writeInfoButton.Text = "Записать результаты";
            this.writeInfoButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateLabel);
            this.panel1.Controls.Add(this.complaintsLabel);
            this.panel1.Controls.Add(this.diagnosisLabel);
            this.panel1.Controls.Add(this.treatmentLabel);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.typeLabel);
            this.panel1.Controls.Add(this.doctorLabel);
            this.panel1.Controls.Add(this.patientLabel);
            this.panel1.Location = new System.Drawing.Point(31, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 339);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(696, 57);
            this.panel2.TabIndex = 11;
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patientLabel.Location = new System.Drawing.Point(17, 58);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(79, 19);
            this.patientLabel.TabIndex = 0;
            this.patientLabel.Text = "Пациент:";
            // 
            // doctorLabel
            // 
            this.doctorLabel.AutoSize = true;
            this.doctorLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doctorLabel.Location = new System.Drawing.Point(17, 96);
            this.doctorLabel.Name = "doctorLabel";
            this.doctorLabel.Size = new System.Drawing.Size(68, 19);
            this.doctorLabel.TabIndex = 1;
            this.doctorLabel.Text = "Доктор:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(17, 173);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 19);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Тип:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(17, 134);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(69, 19);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Статус:";
            // 
            // treatmentLabel
            // 
            this.treatmentLabel.AutoSize = true;
            this.treatmentLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treatmentLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.treatmentLabel.Location = new System.Drawing.Point(17, 290);
            this.treatmentLabel.Name = "treatmentLabel";
            this.treatmentLabel.Size = new System.Drawing.Size(72, 19);
            this.treatmentLabel.TabIndex = 4;
            this.treatmentLabel.Text = "Лечение";
            this.treatmentLabel.Click += new System.EventHandler(this.treatmentLabel_Click);
            // 
            // diagnosisLabel
            // 
            this.diagnosisLabel.AutoSize = true;
            this.diagnosisLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diagnosisLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.diagnosisLabel.Location = new System.Drawing.Point(17, 252);
            this.diagnosisLabel.Name = "diagnosisLabel";
            this.diagnosisLabel.Size = new System.Drawing.Size(71, 19);
            this.diagnosisLabel.TabIndex = 5;
            this.diagnosisLabel.Text = "Диагноз";
            this.diagnosisLabel.Click += new System.EventHandler(this.diagnosisLabel_Click);
            // 
            // complaintsLabel
            // 
            this.complaintsLabel.AutoSize = true;
            this.complaintsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.complaintsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.complaintsLabel.Location = new System.Drawing.Point(17, 216);
            this.complaintsLabel.Name = "complaintsLabel";
            this.complaintsLabel.Size = new System.Drawing.Size(73, 19);
            this.complaintsLabel.TabIndex = 6;
            this.complaintsLabel.Text = "Жалобы";
            this.complaintsLabel.Click += new System.EventHandler(this.complaintsLabel_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(17, 19);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(57, 19);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Дата: ";
            // 
            // endVisitButton
            // 
            this.endVisitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endVisitButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endVisitButton.Location = new System.Drawing.Point(475, 357);
            this.endVisitButton.Name = "endVisitButton";
            this.endVisitButton.Size = new System.Drawing.Size(147, 63);
            this.endVisitButton.TabIndex = 12;
            this.endVisitButton.Text = "Завершить прием";
            this.endVisitButton.UseVisualStyleBackColor = true;
            this.endVisitButton.Click += new System.EventHandler(this.endVisitButton_Click);
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 454);
            this.Controls.Add(this.endVisitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.writeInfoButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.moveButton);
            this.MinimumSize = new System.Drawing.Size(667, 501);
            this.Name = "VisitForm";
            this.Text = "Информация о приеме";
            this.Load += new System.EventHandler(this.VisitForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button writeInfoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label doctorLabel;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label complaintsLabel;
        private System.Windows.Forms.Label diagnosisLabel;
        private System.Windows.Forms.Label treatmentLabel;
        private System.Windows.Forms.Button endVisitButton;
    }
}