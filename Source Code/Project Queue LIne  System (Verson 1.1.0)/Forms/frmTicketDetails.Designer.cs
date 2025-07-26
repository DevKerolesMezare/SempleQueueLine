namespace QueueLine_Project.Forms
{
    partial class frmTicketDetails
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
            this.ctrlTicketInfo1 = new QueueLine_Project.usercontrols.ctrlTicketInfo();
            this.SuspendLayout();
            // 
            // ctrlTicketInfo1
            // 
            this.ctrlTicketInfo1._ticketNumber = null;
            this.ctrlTicketInfo1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlTicketInfo1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTicketInfo1.Location = new System.Drawing.Point(11, 11);
            this.ctrlTicketInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlTicketInfo1.Name = "ctrlTicketInfo1";
            this.ctrlTicketInfo1.Size = new System.Drawing.Size(380, 496);
            this.ctrlTicketInfo1.TabIndex = 0;
            // 
            // frmTicketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(400, 517);
            this.Controls.Add(this.ctrlTicketInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmTicketDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private usercontrols.ctrlTicketInfo ctrlTicketInfo1;
    }
}