namespace QueueLine_Project.Forms
{
    partial class frmTicketController
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
            this.ctrlTicketQueueScreen1 = new QueueLine_UI.UserControls.ctrlTicketQueueScreen();
            this.SuspendLayout();
            // 
            // ctrlTicketQueueScreen1
            // 
            this.ctrlTicketQueueScreen1.BackColor = System.Drawing.Color.White;
            this.ctrlTicketQueueScreen1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTicketQueueScreen1.Location = new System.Drawing.Point(4, 2);
            this.ctrlTicketQueueScreen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlTicketQueueScreen1.Name = "ctrlTicketQueueScreen1";
            this.ctrlTicketQueueScreen1.Size = new System.Drawing.Size(509, 764);
            this.ctrlTicketQueueScreen1.TabIndex = 0;
            // 
            // frmTicketController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 771);
            this.Controls.Add(this.ctrlTicketQueueScreen1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmTicketController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private QueueLine_UI.UserControls.ctrlTicketQueueScreen ctrlTicketQueueScreen1;
    }
}