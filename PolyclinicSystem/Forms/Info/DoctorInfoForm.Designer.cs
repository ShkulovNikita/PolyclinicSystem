
namespace PolyclinicSystem.Forms.Info
{
    partial class DoctorInfoForm
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
            this.feedbackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.specialtyLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addVisitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // feedbackButton
            // 
            this.feedbackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.feedbackButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feedbackButton.Location = new System.Drawing.Point(470, 173);
            this.feedbackButton.Name = "feedbackButton";
            this.feedbackButton.Size = new System.Drawing.Size(160, 50);
            this.feedbackButton.TabIndex = 20;
            this.feedbackButton.Text = "Отзывы";
            this.feedbackButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.specialtyLabel);
            this.panel1.Location = new System.Drawing.Point(23, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 142);
            this.panel1.TabIndex = 19;
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
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.Location = new System.Drawing.Point(17, 96);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 19);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.AutoSize = true;
            this.specialtyLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialtyLabel.Location = new System.Drawing.Point(17, 58);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(135, 19);
            this.specialtyLabel.TabIndex = 0;
            this.specialtyLabel.Text = "Специальность:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(704, 57);
            this.panel2.TabIndex = 18;
            // 
            // addVisitButton
            // 
            this.addVisitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addVisitButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVisitButton.Location = new System.Drawing.Point(470, 81);
            this.addVisitButton.Name = "addVisitButton";
            this.addVisitButton.Size = new System.Drawing.Size(160, 50);
            this.addVisitButton.TabIndex = 21;
            this.addVisitButton.Text = "Записаться на прием";
            this.addVisitButton.UseVisualStyleBackColor = true;
            this.addVisitButton.Click += new System.EventHandler(this.addVisitButton_Click);
            // 
            // DoctorInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 244);
            this.Controls.Add(this.addVisitButton);
            this.Controls.Add(this.feedbackButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DoctorInfoForm";
            this.Text = "Профиль врача";
            this.Load += new System.EventHandler(this.DoctorInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button feedbackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label specialtyLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addVisitButton;
    }
}