
namespace PolyclinicSystem.Forms.FeedbackForms
{
    partial class FeedbackListForm
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
            this.showFeedbackButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.feedbackDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // showFeedbackButton
            // 
            this.showFeedbackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showFeedbackButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showFeedbackButton.Location = new System.Drawing.Point(551, 418);
            this.showFeedbackButton.Name = "showFeedbackButton";
            this.showFeedbackButton.Size = new System.Drawing.Size(246, 48);
            this.showFeedbackButton.TabIndex = 23;
            this.showFeedbackButton.Text = "Просмотреть отзыв";
            this.showFeedbackButton.UseVisualStyleBackColor = true;
            this.showFeedbackButton.Click += new System.EventHandler(this.showFeedbackButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 57);
            this.panel2.TabIndex = 22;
            // 
            // feedbackDataGrid
            // 
            this.feedbackDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.feedbackDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedbackDataGrid.Location = new System.Drawing.Point(22, 76);
            this.feedbackDataGrid.MultiSelect = false;
            this.feedbackDataGrid.Name = "feedbackDataGrid";
            this.feedbackDataGrid.RowHeadersWidth = 51;
            this.feedbackDataGrid.RowTemplate.Height = 24;
            this.feedbackDataGrid.Size = new System.Drawing.Size(776, 322);
            this.feedbackDataGrid.TabIndex = 21;
            // 
            // FeedbackListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 481);
            this.Controls.Add(this.showFeedbackButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.feedbackDataGrid);
            this.Name = "FeedbackListForm";
            this.Text = "Список отзывов";
            this.Load += new System.EventHandler(this.FeedbackListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feedbackDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showFeedbackButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView feedbackDataGrid;
    }
}