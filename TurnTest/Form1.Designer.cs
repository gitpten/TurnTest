namespace TurnTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pDeck = new System.Windows.Forms.Panel();
            this.pTable = new System.Windows.Forms.Panel();
            this.pPlayer = new System.Windows.Forms.Panel();
            this.pActive = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pActive)).BeginInit();
            this.SuspendLayout();
            // 
            // pDeck
            // 
            this.pDeck.Location = new System.Drawing.Point(99, 215);
            this.pDeck.Name = "pDeck";
            this.pDeck.Size = new System.Drawing.Size(113, 125);
            this.pDeck.TabIndex = 0;
            // 
            // pTable
            // 
            this.pTable.Location = new System.Drawing.Point(330, 215);
            this.pTable.Name = "pTable";
            this.pTable.Size = new System.Drawing.Size(370, 125);
            this.pTable.TabIndex = 1;
            // 
            // pPlayer
            // 
            this.pPlayer.Location = new System.Drawing.Point(330, 430);
            this.pPlayer.Name = "pPlayer";
            this.pPlayer.Size = new System.Drawing.Size(486, 125);
            this.pPlayer.TabIndex = 2;
            // 
            // pActive
            // 
            this.pActive.Location = new System.Drawing.Point(706, 215);
            this.pActive.Name = "pActive";
            this.pActive.Size = new System.Drawing.Size(95, 125);
            this.pActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pActive.TabIndex = 3;
            this.pActive.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 612);
            this.Controls.Add(this.pActive);
            this.Controls.Add(this.pPlayer);
            this.Controls.Add(this.pTable);
            this.Controls.Add(this.pDeck);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pDeck;
        private Panel pTable;
        private Panel pPlayer;
        private PictureBox pActive;
    }
}