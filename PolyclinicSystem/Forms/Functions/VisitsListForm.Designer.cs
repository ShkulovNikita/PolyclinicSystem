
namespace PolyclinicSystem.Forms.Functions
{
    partial class VisitsListForm
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.visitsDataGrid = new System.Windows.Forms.DataGridView();
            this.infoButton = new System.Windows.Forms.Button();
            this.addVisit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 57);
            this.panel1.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBox.Location = new System.Drawing.Point(92, 69);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(578, 30);
            this.searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(697, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(91, 30);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Поиск:";
            // 
            // visitsDataGrid
            // 
            this.visitsDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visitsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsDataGrid.Location = new System.Drawing.Point(12, 118);
            this.visitsDataGrid.MultiSelect = false;
            this.visitsDataGrid.Name = "visitsDataGrid";
            this.visitsDataGrid.RowHeadersWidth = 51;
            this.visitsDataGrid.RowTemplate.Height = 24;
            this.visitsDataGrid.Size = new System.Drawing.Size(776, 322);
            this.visitsDataGrid.TabIndex = 5;
            // 
            // infoButton
            // 
            this.infoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.Location = new System.Drawing.Point(526, 457);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(262, 40);
            this.infoButton.TabIndex = 6;
            this.infoButton.Text = "Информация о приеме";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // addVisit
            // 
            this.addVisit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addVisit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVisit.Location = new System.Drawing.Point(12, 457);
            this.addVisit.Name = "addVisit";
            this.addVisit.Size = new System.Drawing.Size(214, 40);
            this.addVisit.TabIndex = 7;
            this.addVisit.Text = "Записаться на прием";
            this.addVisit.UseVisualStyleBackColor = true;
            this.addVisit.Click += new System.EventHandler(this.addVisit_Click);
            // 
            // VisitsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.addVisit);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.visitsDataGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(818, 556);
            this.Name = "VisitsListForm";
            this.Text = "Приемы у врачей";
            this.Load += new System.EventHandler(this.VisitsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visitsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView visitsDataGrid;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button addVisit;
    }
}