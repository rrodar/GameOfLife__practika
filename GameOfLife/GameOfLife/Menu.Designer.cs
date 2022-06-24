namespace GameOfLife
{
    partial class Menu
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
            this.BtStart = new System.Windows.Forms.Button();
            this.BtContent = new System.Windows.Forms.Button();
            this.BtClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtStart
            // 
            this.BtStart.BackColor = System.Drawing.Color.Snow;
            this.BtStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtStart.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtStart.Location = new System.Drawing.Point(171, 108);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(160, 56);
            this.BtStart.TabIndex = 0;
            this.BtStart.Text = "Начать игру";
            this.BtStart.UseVisualStyleBackColor = false;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // BtContent
            // 
            this.BtContent.BackColor = System.Drawing.Color.White;
            this.BtContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtContent.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtContent.Location = new System.Drawing.Point(171, 201);
            this.BtContent.Name = "BtContent";
            this.BtContent.Size = new System.Drawing.Size(160, 58);
            this.BtContent.TabIndex = 1;
            this.BtContent.Text = "Правила";
            this.BtContent.UseVisualStyleBackColor = false;
            this.BtContent.Click += new System.EventHandler(this.BtContent_Click);
            // 
            // BtClose
            // 
            this.BtClose.BackColor = System.Drawing.Color.White;
            this.BtClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtClose.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtClose.Location = new System.Drawing.Point(171, 297);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(160, 57);
            this.BtClose.TabIndex = 2;
            this.BtClose.Text = "Выход";
            this.BtClose.UseVisualStyleBackColor = false;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(169, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "GAME OF LIFE";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(515, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.BtContent);
            this.Controls.Add(this.BtStart);
            this.Name = "Menu";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.Button BtContent;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.Label label1;
    }
}