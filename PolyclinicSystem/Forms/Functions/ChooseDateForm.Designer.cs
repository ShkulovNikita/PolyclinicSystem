
namespace PolyclinicSystem.Forms.Functions
{
    partial class ChooseDateForm
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
            this.visitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.messagesLabel = new System.Windows.Forms.Label();
            this.chooseDateButton = new System.Windows.Forms.Button();
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
            this.panel2.Size = new System.Drawing.Size(490, 57);
            this.panel2.TabIndex = 12;
            // 
            // visitDateTimePicker
            // 
            this.visitDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visitDateTimePicker.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visitDateTimePicker.Location = new System.Drawing.Point(46, 135);
            this.visitDateTimePicker.Name = "visitDateTimePicker";
            this.visitDateTimePicker.Size = new System.Drawing.Size(367, 27);
            this.visitDateTimePicker.TabIndex = 13;
            this.visitDateTimePicker.ValueChanged += new System.EventHandler(this.visitDateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Выберите дату:";
            // 
            // messagesLabel
            // 
            this.messagesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messagesLabel.AutoSize = true;
            this.messagesLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messagesLabel.ForeColor = System.Drawing.Color.Tomato;
            this.messagesLabel.Location = new System.Drawing.Point(120, 189);
            this.messagesLabel.Name = "messagesLabel";
            this.messagesLabel.Size = new System.Drawing.Size(51, 19);
            this.messagesLabel.TabIndex = 16;
            this.messagesLabel.Text = "label3";
            // 
            // chooseDateButton
            // 
            this.chooseDateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chooseDateButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDateButton.Location = new System.Drawing.Point(124, 223);
            this.chooseDateButton.Name = "chooseDateButton";
            this.chooseDateButton.Size = new System.Drawing.Size(214, 40);
            this.chooseDateButton.TabIndex = 15;
            this.chooseDateButton.Text = "Выбрать дату";
            this.chooseDateButton.UseVisualStyleBackColor = true;
            this.chooseDateButton.Click += new System.EventHandler(this.addVisitButton_Click);
            // 
            // ChooseDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 299);
            this.Controls.Add(this.messagesLabel);
            this.Controls.Add(this.chooseDateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visitDateTimePicker);
            this.Controls.Add(this.panel2);
            this.Name = "ChooseDateForm";
            this.Text = "Выбор даты";
            this.Load += new System.EventHandler(this.ChooseDateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker visitDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label messagesLabel;
        private System.Windows.Forms.Button chooseDateButton;
    }
}