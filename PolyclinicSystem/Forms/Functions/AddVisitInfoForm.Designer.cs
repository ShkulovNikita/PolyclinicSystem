
namespace PolyclinicSystem.Forms.Functions
{
    partial class AddVisitInfoForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.treatmentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.complaintsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(966, 57);
            this.panel2.TabIndex = 13;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmButton.Location = new System.Drawing.Point(320, 527);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(146, 37);
            this.confirmButton.TabIndex = 14;
            this.confirmButton.Text = "Сохранить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLabel.Location = new System.Drawing.Point(18, 69);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(73, 19);
            this.titleLabel.TabIndex = 15;
            this.titleLabel.Text = "Жалобы";
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diagnosisTextBox.Font = new System.Drawing.Font("Arial", 8F);
            this.diagnosisTextBox.Location = new System.Drawing.Point(22, 239);
            this.diagnosisTextBox.Multiline = true;
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(760, 119);
            this.diagnosisTextBox.TabIndex = 16;
            // 
            // treatmentTextBox
            // 
            this.treatmentTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.treatmentTextBox.Font = new System.Drawing.Font("Arial", 8F);
            this.treatmentTextBox.Location = new System.Drawing.Point(22, 387);
            this.treatmentTextBox.Multiline = true;
            this.treatmentTextBox.Name = "treatmentTextBox";
            this.treatmentTextBox.Size = new System.Drawing.Size(760, 119);
            this.treatmentTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Диагноз";
            // 
            // complaintsTextBox
            // 
            this.complaintsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.complaintsTextBox.Font = new System.Drawing.Font("Arial", 8F);
            this.complaintsTextBox.Location = new System.Drawing.Point(22, 91);
            this.complaintsTextBox.Multiline = true;
            this.complaintsTextBox.Name = "complaintsTextBox";
            this.complaintsTextBox.Size = new System.Drawing.Size(760, 119);
            this.complaintsTextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(18, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Лечение";
            // 
            // AddVisitInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 578);
            this.Controls.Add(this.complaintsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treatmentTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diagnosisTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(827, 625);
            this.Name = "AddVisitInfoForm";
            this.Text = "Записать информацию о приеме";
            this.Load += new System.EventHandler(this.AddVisitInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.TextBox treatmentTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox complaintsTextBox;
        private System.Windows.Forms.Label label2;
    }
}