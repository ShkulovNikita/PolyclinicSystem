
namespace PolyclinicSystem.Forms
{
    partial class PatientForm
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
            this.visitsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // visitsButton
            // 
            this.visitsButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitsButton.Location = new System.Drawing.Point(506, 180);
            this.visitsButton.Name = "visitsButton";
            this.visitsButton.Size = new System.Drawing.Size(75, 23);
            this.visitsButton.TabIndex = 0;
            this.visitsButton.Text = "button1";
            this.visitsButton.UseVisualStyleBackColor = true;
            this.visitsButton.Click += new System.EventHandler(this.visitsButton_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.visitsButton);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button visitsButton;
    }
}