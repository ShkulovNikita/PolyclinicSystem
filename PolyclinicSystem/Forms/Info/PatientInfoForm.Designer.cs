
namespace PolyclinicSystem.Forms
{
    partial class PatientInfoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.jobPlaceLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.omsLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.jobPlaceLabel);
            this.panel1.Controls.Add(this.phoneLabel);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.birthdateLabel);
            this.panel1.Controls.Add(this.omsLabel);
            this.panel1.Controls.Add(this.genderLabel);
            this.panel1.Location = new System.Drawing.Point(21, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 337);
            this.panel1.TabIndex = 14;
            // 
            // jobPlaceLabel
            // 
            this.jobPlaceLabel.AutoSize = true;
            this.jobPlaceLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jobPlaceLabel.Location = new System.Drawing.Point(17, 210);
            this.jobPlaceLabel.Name = "jobPlaceLabel";
            this.jobPlaceLabel.Size = new System.Drawing.Size(123, 19);
            this.jobPlaceLabel.TabIndex = 9;
            this.jobPlaceLabel.Text = "Место работы:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(17, 171);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(80, 19);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Телефон:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(17, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 19);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "ФИО: ";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.Location = new System.Drawing.Point(17, 246);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 19);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Адрес:";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdateLabel.Location = new System.Drawing.Point(17, 134);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(132, 19);
            this.birthdateLabel.TabIndex = 2;
            this.birthdateLabel.Text = "Дата рождения:";
            // 
            // omsLabel
            // 
            this.omsLabel.AutoSize = true;
            this.omsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omsLabel.Location = new System.Drawing.Point(17, 96);
            this.omsLabel.Name = "omsLabel";
            this.omsLabel.Size = new System.Drawing.Size(51, 19);
            this.omsLabel.TabIndex = 1;
            this.omsLabel.Text = "ОМС:";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genderLabel.Location = new System.Drawing.Point(17, 58);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(44, 19);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Пол:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 57);
            this.panel2.TabIndex = 15;
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PatientInfoForm";
            this.Text = "Профиль пациента";
            this.Load += new System.EventHandler(this.PatientInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label jobPlaceLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label omsLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Panel panel2;
    }
}