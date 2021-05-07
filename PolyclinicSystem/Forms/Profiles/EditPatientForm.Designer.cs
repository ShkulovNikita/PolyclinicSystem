
namespace PolyclinicSystem.Forms
{
    partial class EditPatientForm
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.jobPlaceLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.omsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.omsTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.jobPlaceTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmButton.Location = new System.Drawing.Point(228, 270);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(131, 43);
            this.confirmButton.TabIndex = 0;
            this.confirmButton.Text = "Сохранить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // jobPlaceLabel
            // 
            this.jobPlaceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jobPlaceLabel.AutoSize = true;
            this.jobPlaceLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jobPlaceLabel.Location = new System.Drawing.Point(12, 178);
            this.jobPlaceLabel.Name = "jobPlaceLabel";
            this.jobPlaceLabel.Size = new System.Drawing.Size(123, 19);
            this.jobPlaceLabel.TabIndex = 15;
            this.jobPlaceLabel.Text = "Место работы:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(12, 131);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(80, 19);
            this.phoneLabel.TabIndex = 14;
            this.phoneLabel.Text = "Телефон:";
            // 
            // addressLabel
            // 
            this.addressLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.Location = new System.Drawing.Point(12, 225);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(62, 19);
            this.addressLabel.TabIndex = 13;
            this.addressLabel.Text = "Адрес:";
            // 
            // omsLabel
            // 
            this.omsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.omsLabel.AutoSize = true;
            this.omsLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omsLabel.Location = new System.Drawing.Point(12, 79);
            this.omsLabel.Name = "omsLabel";
            this.omsLabel.Size = new System.Drawing.Size(51, 19);
            this.omsLabel.TabIndex = 11;
            this.omsLabel.Text = "ОМС:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 57);
            this.panel2.TabIndex = 16;
            // 
            // omsTextBox
            // 
            this.omsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.omsTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.omsTextBox.Location = new System.Drawing.Point(114, 76);
            this.omsTextBox.MaxLength = 16;
            this.omsTextBox.Name = "omsTextBox";
            this.omsTextBox.Size = new System.Drawing.Size(445, 27);
            this.omsTextBox.TabIndex = 17;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(114, 128);
            this.phoneTextBox.MaxLength = 11;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(445, 27);
            this.phoneTextBox.TabIndex = 18;
            // 
            // jobPlaceTextBox
            // 
            this.jobPlaceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.jobPlaceTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.jobPlaceTextBox.Location = new System.Drawing.Point(164, 175);
            this.jobPlaceTextBox.Name = "jobPlaceTextBox";
            this.jobPlaceTextBox.Size = new System.Drawing.Size(395, 27);
            this.jobPlaceTextBox.TabIndex = 19;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addressTextBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(114, 222);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(445, 27);
            this.addressTextBox.TabIndex = 20;
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 325);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.jobPlaceTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.omsTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.jobPlaceLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.omsLabel);
            this.Controls.Add(this.confirmButton);
            this.MinimumSize = new System.Drawing.Size(601, 372);
            this.Name = "EditPatientForm";
            this.Text = "Редактировать профиль";
            this.Load += new System.EventHandler(this.EditPatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label jobPlaceLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label omsLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox omsTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox jobPlaceTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
    }
}