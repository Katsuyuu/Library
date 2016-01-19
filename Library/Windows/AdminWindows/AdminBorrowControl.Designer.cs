namespace Library.Windows.AdminWindows
{
    partial class AdminBorrowControl
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Kto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tytuł = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Od = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Do = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Kto,
            this.Tytuł,
            this.Autor,
            this.Od,
            this.Do});
            this.listView1.Location = new System.Drawing.Point(34, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 245);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Kto
            // 
            this.Kto.Text = "Kto wypożyczył";
            this.Kto.Width = 88;
            // 
            // Tytuł
            // 
            this.Tytuł.Text = "Tytuł";
            this.Tytuł.Width = 172;
            // 
            // Autor
            // 
            this.Autor.Text = "Autor";
            this.Autor.Width = 90;
            // 
            // Od
            // 
            this.Od.Text = "Od";
            // 
            // Do
            // 
            this.Do.Text = "Do";
            // 
            // AdminBorrowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 299);
            this.Controls.Add(this.listView1);
            this.Name = "AdminBorrowControl";
            this.Text = "AdminBorrowControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Kto;
        private System.Windows.Forms.ColumnHeader Tytuł;
        private System.Windows.Forms.ColumnHeader Autor;
        private System.Windows.Forms.ColumnHeader Od;
        private System.Windows.Forms.ColumnHeader Do;

    }
}