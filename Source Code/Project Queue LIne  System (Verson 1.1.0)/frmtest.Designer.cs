namespace QueueLine_Project.Forms
{
    partial class frmtest
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalTickets = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAvreageTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWatingClient = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblServedClient = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblScippedClient = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSkippedClient = new System.Windows.Forms.Button();
            this.ctrlTicketQueueScreen1 = new QueueLine_UI.UserControls.ctrlTicketQueueScreen();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(640, 219);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "IssueTicket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "TotalTickets:";
            // 
            // lblTotalTickets
            // 
            this.lblTotalTickets.AutoSize = true;
            this.lblTotalTickets.Location = new System.Drawing.Point(801, 65);
            this.lblTotalTickets.Name = "lblTotalTickets";
            this.lblTotalTickets.Size = new System.Drawing.Size(40, 17);
            this.lblTotalTickets.TabIndex = 4;
            this.lblTotalTickets.Text = "[????]";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(581, 442);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(457, 152);
            this.dataGridView1.TabIndex = 5;
            // 
            // lblAvreageTime
            // 
            this.lblAvreageTime.AutoSize = true;
            this.lblAvreageTime.Location = new System.Drawing.Point(801, 91);
            this.lblAvreageTime.Name = "lblAvreageTime";
            this.lblAvreageTime.Size = new System.Drawing.Size(40, 17);
            this.lblAvreageTime.TabIndex = 7;
            this.lblAvreageTime.Text = "[????]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(708, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "AverageTime:";
            // 
            // lblWatingClient
            // 
            this.lblWatingClient.AutoSize = true;
            this.lblWatingClient.Location = new System.Drawing.Point(801, 121);
            this.lblWatingClient.Name = "lblWatingClient";
            this.lblWatingClient.Size = new System.Drawing.Size(40, 17);
            this.lblWatingClient.TabIndex = 9;
            this.lblWatingClient.Text = "[????]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(708, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "WatingClient:";
            // 
            // lblServedClient
            // 
            this.lblServedClient.AutoSize = true;
            this.lblServedClient.Location = new System.Drawing.Point(801, 147);
            this.lblServedClient.Name = "lblServedClient";
            this.lblServedClient.Size = new System.Drawing.Size(40, 17);
            this.lblServedClient.TabIndex = 11;
            this.lblServedClient.Text = "[????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(708, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "ServedClient:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(815, 219);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 69);
            this.button2.TabIndex = 12;
            this.button2.Text = "Mark As Served";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblScippedClient
            // 
            this.lblScippedClient.AutoSize = true;
            this.lblScippedClient.Location = new System.Drawing.Point(801, 174);
            this.lblScippedClient.Name = "lblScippedClient";
            this.lblScippedClient.Size = new System.Drawing.Size(40, 17);
            this.lblScippedClient.TabIndex = 15;
            this.lblScippedClient.Text = "[????]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(708, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "SkippedClient:";
            // 
            // btnSkippedClient
            // 
            this.btnSkippedClient.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkippedClient.Location = new System.Drawing.Point(720, 296);
            this.btnSkippedClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnSkippedClient.Name = "btnSkippedClient";
            this.btnSkippedClient.Size = new System.Drawing.Size(167, 69);
            this.btnSkippedClient.TabIndex = 16;
            this.btnSkippedClient.Text = "Skipped Client";
            this.btnSkippedClient.UseVisualStyleBackColor = true;
            this.btnSkippedClient.Click += new System.EventHandler(this.btnSkippedClient_Click);
            // 
            // ctrlTicketQueueScreen1
            // 
            this.ctrlTicketQueueScreen1.BackColor = System.Drawing.Color.White;
            this.ctrlTicketQueueScreen1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTicketQueueScreen1.Location = new System.Drawing.Point(13, 14);
            this.ctrlTicketQueueScreen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlTicketQueueScreen1.Name = "ctrlTicketQueueScreen1";
            this.ctrlTicketQueueScreen1.Size = new System.Drawing.Size(509, 764);
            this.ctrlTicketQueueScreen1.TabIndex = 17;
            // 
            // frmtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 791);
            this.Controls.Add(this.ctrlTicketQueueScreen1);
            this.Controls.Add(this.btnSkippedClient);
            this.Controls.Add(this.lblScippedClient);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblServedClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblWatingClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAvreageTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotalTickets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmtest";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalTickets;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAvreageTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWatingClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblServedClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblScippedClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSkippedClient;
        private QueueLine_UI.UserControls.ctrlTicketQueueScreen ctrlTicketQueueScreen1;
    }
}