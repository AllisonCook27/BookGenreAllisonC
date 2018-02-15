namespace BookGenreAllisonC
{
    partial class frmBookGenre
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
            this.mnuBooks = new System.Windows.Forms.MenuStrip();
            this.mniBookGenre = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFantasy = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHorror = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMystery = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAction = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBookGenre = new System.Windows.Forms.Label();
            this.lblBook1 = new System.Windows.Forms.Label();
            this.lblBook2 = new System.Windows.Forms.Label();
            this.lblBook3 = new System.Windows.Forms.Label();
            this.mnuBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuBooks
            // 
            this.mnuBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniBookGenre});
            this.mnuBooks.Location = new System.Drawing.Point(0, 0);
            this.mnuBooks.Name = "mnuBooks";
            this.mnuBooks.Size = new System.Drawing.Size(284, 24);
            this.mnuBooks.TabIndex = 0;
            this.mnuBooks.Text = "Books";
            // 
            // mniBookGenre
            // 
            this.mniBookGenre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFantasy,
            this.mniHorror,
            this.mniMystery,
            this.mniAction});
            this.mniBookGenre.Name = "mniBookGenre";
            this.mniBookGenre.Size = new System.Drawing.Size(85, 20);
            this.mniBookGenre.Text = "Book Genres";
            // 
            // mniFantasy
            // 
            this.mniFantasy.Name = "mniFantasy";
            this.mniFantasy.Size = new System.Drawing.Size(152, 22);
            this.mniFantasy.Text = "Fantasy";
            this.mniFantasy.Click += new System.EventHandler(this.mniFantasy_Click);
            // 
            // mniHorror
            // 
            this.mniHorror.Name = "mniHorror";
            this.mniHorror.Size = new System.Drawing.Size(152, 22);
            this.mniHorror.Text = "Horror";
            this.mniHorror.Click += new System.EventHandler(this.mniHorror_Click);
            // 
            // mniMystery
            // 
            this.mniMystery.Name = "mniMystery";
            this.mniMystery.Size = new System.Drawing.Size(152, 22);
            this.mniMystery.Text = "Mystery";
            this.mniMystery.Click += new System.EventHandler(this.mniMystery_Click);
            // 
            // mniAction
            // 
            this.mniAction.Name = "mniAction";
            this.mniAction.Size = new System.Drawing.Size(152, 22);
            this.mniAction.Text = "Action";
            this.mniAction.Click += new System.EventHandler(this.mniAction_Click);
            // 
            // lblBookGenre
            // 
            this.lblBookGenre.AutoSize = true;
            this.lblBookGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookGenre.Location = new System.Drawing.Point(-2, 46);
            this.lblBookGenre.Name = "lblBookGenre";
            this.lblBookGenre.Size = new System.Drawing.Size(286, 20);
            this.lblBookGenre.TabIndex = 1;
            this.lblBookGenre.Text = "Chose a book genre from the menu bar";
            // 
            // lblBook1
            // 
            this.lblBook1.AutoSize = true;
            this.lblBook1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook1.Location = new System.Drawing.Point(-2, 108);
            this.lblBook1.Name = "lblBook1";
            this.lblBook1.Size = new System.Drawing.Size(0, 20);
            this.lblBook1.TabIndex = 2;
            // 
            // lblBook2
            // 
            this.lblBook2.AutoSize = true;
            this.lblBook2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook2.Location = new System.Drawing.Point(12, 152);
            this.lblBook2.Name = "lblBook2";
            this.lblBook2.Size = new System.Drawing.Size(0, 20);
            this.lblBook2.TabIndex = 3;
            // 
            // lblBook3
            // 
            this.lblBook3.AutoSize = true;
            this.lblBook3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook3.Location = new System.Drawing.Point(12, 172);
            this.lblBook3.Name = "lblBook3";
            this.lblBook3.Size = new System.Drawing.Size(0, 20);
            this.lblBook3.TabIndex = 4;
            // 
            // frmBookGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblBook3);
            this.Controls.Add(this.lblBook2);
            this.Controls.Add(this.lblBook1);
            this.Controls.Add(this.lblBookGenre);
            this.Controls.Add(this.mnuBooks);
            this.MainMenuStrip = this.mnuBooks;
            this.Name = "frmBookGenre";
            this.Text = "Book Genres by Allison C";
            this.mnuBooks.ResumeLayout(false);
            this.mnuBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuBooks;
        private System.Windows.Forms.ToolStripMenuItem mniBookGenre;
        private System.Windows.Forms.ToolStripMenuItem mniFantasy;
        private System.Windows.Forms.ToolStripMenuItem mniHorror;
        private System.Windows.Forms.ToolStripMenuItem mniMystery;
        private System.Windows.Forms.ToolStripMenuItem mniAction;
        private System.Windows.Forms.Label lblBookGenre;
        private System.Windows.Forms.Label lblBook1;
        private System.Windows.Forms.Label lblBook2;
        private System.Windows.Forms.Label lblBook3;
    }
}

