
namespace v_2
{
    partial class InchirieriForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InchirieriForm));
            this.tbBack = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbUpdate = new System.Windows.Forms.Button();
            this.tbSalvare = new System.Windows.Forms.Button();
            this.tbStergere = new System.Windows.Forms.Button();
            this.tbVizualizare = new System.Windows.Forms.Button();
            this.tbAdauga = new System.Windows.Forms.Button();
            this.cbFilm = new System.Windows.Forms.ComboBox();
            this.tbFees = new System.Windows.Forms.TextBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbRetur = new System.Windows.Forms.DateTimePicker();
            this.tbRental = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBack
            // 
            this.tbBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBack.ForeColor = System.Drawing.Color.LavenderBlush;
            this.tbBack.Location = new System.Drawing.Point(822, 3);
            this.tbBack.Name = "tbBack";
            this.tbBack.Size = new System.Drawing.Size(28, 25);
            this.tbBack.TabIndex = 24;
            this.tbBack.Text = "<";
            this.tbBack.UseVisualStyleBackColor = false;
            this.tbBack.Click += new System.EventHandler(this.tbBack_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(861, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 25);
            this.button5.TabIndex = 7;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(89, 98);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(98, 22);
            this.tbID.TabIndex = 39;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightGray;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(262, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(579, 272);
            this.listView1.TabIndex = 49;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Movie";
            this.columnHeader2.Width = 107;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Customer";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rental Date";
            this.columnHeader4.Width = 67;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Return Date";
            this.columnHeader5.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fees";
            this.columnHeader6.Width = 114;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergereToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 28);
            // 
            // stergereToolStripMenuItem
            // 
            this.stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            this.stergereToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.stergereToolStripMenuItem.Text = "Stergere";
            this.stergereToolStripMenuItem.Click += new System.EventHandler(this.stergereToolStripMenuItem_Click);
            // 
            // tbUpdate
            // 
            this.tbUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbUpdate.FlatAppearance.BorderSize = 0;
            this.tbUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUpdate.ForeColor = System.Drawing.Color.White;
            this.tbUpdate.Location = new System.Drawing.Point(47, 408);
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Size = new System.Drawing.Size(115, 37);
            this.tbUpdate.TabIndex = 55;
            this.tbUpdate.Text = "Update";
            this.tbUpdate.UseVisualStyleBackColor = false;
            this.tbUpdate.Click += new System.EventHandler(this.tbUpdate_Click);
            // 
            // tbSalvare
            // 
            this.tbSalvare.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSalvare.FlatAppearance.BorderSize = 0;
            this.tbSalvare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSalvare.ForeColor = System.Drawing.Color.White;
            this.tbSalvare.Location = new System.Drawing.Point(47, 491);
            this.tbSalvare.Name = "tbSalvare";
            this.tbSalvare.Size = new System.Drawing.Size(115, 37);
            this.tbSalvare.TabIndex = 54;
            this.tbSalvare.Text = "Save";
            this.tbSalvare.UseVisualStyleBackColor = false;
            this.tbSalvare.Click += new System.EventHandler(this.tbSalvare_Click);
            // 
            // tbStergere
            // 
            this.tbStergere.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbStergere.FlatAppearance.BorderSize = 0;
            this.tbStergere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbStergere.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbStergere.ForeColor = System.Drawing.Color.White;
            this.tbStergere.Location = new System.Drawing.Point(47, 451);
            this.tbStergere.Name = "tbStergere";
            this.tbStergere.Size = new System.Drawing.Size(115, 37);
            this.tbStergere.TabIndex = 53;
            this.tbStergere.Text = "Delete";
            this.tbStergere.UseVisualStyleBackColor = false;
            this.tbStergere.Click += new System.EventHandler(this.tbStergere_Click);
            // 
            // tbVizualizare
            // 
            this.tbVizualizare.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbVizualizare.FlatAppearance.BorderSize = 0;
            this.tbVizualizare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbVizualizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbVizualizare.ForeColor = System.Drawing.Color.White;
            this.tbVizualizare.Location = new System.Drawing.Point(47, 374);
            this.tbVizualizare.Name = "tbVizualizare";
            this.tbVizualizare.Size = new System.Drawing.Size(115, 37);
            this.tbVizualizare.TabIndex = 52;
            this.tbVizualizare.Text = "View";
            this.tbVizualizare.UseVisualStyleBackColor = false;
            this.tbVizualizare.Click += new System.EventHandler(this.tbVizualizare_Click);
            // 
            // tbAdauga
            // 
            this.tbAdauga.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbAdauga.FlatAppearance.BorderSize = 0;
            this.tbAdauga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbAdauga.ForeColor = System.Drawing.Color.White;
            this.tbAdauga.Location = new System.Drawing.Point(47, 333);
            this.tbAdauga.Name = "tbAdauga";
            this.tbAdauga.Size = new System.Drawing.Size(115, 37);
            this.tbAdauga.TabIndex = 51;
            this.tbAdauga.Text = "Add";
            this.tbAdauga.UseVisualStyleBackColor = false;
            this.tbAdauga.Click += new System.EventHandler(this.tbAdauga_Click);
            // 
            // cbFilm
            // 
            this.cbFilm.FormattingEnabled = true;
            this.cbFilm.Location = new System.Drawing.Point(89, 179);
            this.cbFilm.Name = "cbFilm";
            this.cbFilm.Size = new System.Drawing.Size(98, 24);
            this.cbFilm.TabIndex = 56;
            this.cbFilm.SelectedIndexChanged += new System.EventHandler(this.cbFilm_SelectedIndexChanged);
            // 
            // tbFees
            // 
            this.tbFees.Location = new System.Drawing.Point(89, 224);
            this.tbFees.Name = "tbFees";
            this.tbFees.Size = new System.Drawing.Size(98, 22);
            this.tbFees.TabIndex = 58;
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(89, 137);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(98, 24);
            this.cbCustomer.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbBack);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 32);
            this.panel1.TabIndex = 60;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "RENTAL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.tbRetur);
            this.panel2.Controls.Add(this.tbRental);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbSalvare);
            this.panel2.Controls.Add(this.tbUpdate);
            this.panel2.Controls.Add(this.tbStergere);
            this.panel2.Controls.Add(this.cbCustomer);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbFees);
            this.panel2.Controls.Add(this.tbVizualizare);
            this.panel2.Controls.Add(this.cbFilm);
            this.panel2.Controls.Add(this.tbAdauga);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tbID);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 531);
            this.panel2.TabIndex = 61;
            // 
            // tbRetur
            // 
            this.tbRetur.Location = new System.Drawing.Point(89, 305);
            this.tbRetur.Name = "tbRetur";
            this.tbRetur.Size = new System.Drawing.Size(98, 22);
            this.tbRetur.TabIndex = 63;
            // 
            // tbRental
            // 
            this.tbRental.Location = new System.Drawing.Point(89, 267);
            this.tbRental.Name = "tbRental";
            this.tbRental.Size = new System.Drawing.Size(98, 22);
            this.tbRental.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Fees:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "Return:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 50;
            this.label11.Text = "Rental:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 50;
            this.label12.Text = "Movie:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 19);
            this.label13.TabIndex = 50;
            this.label13.Text = "Customer:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 19);
            this.label14.TabIndex = 50;
            this.label14.Text = "Id:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(662, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // InchirieriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 563);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InchirieriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InchirieriForm";
            this.Load += new System.EventHandler(this.InchirieriForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button tbBack;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button tbUpdate;
        private System.Windows.Forms.Button tbSalvare;
        private System.Windows.Forms.Button tbStergere;
        private System.Windows.Forms.Button tbVizualizare;
        private System.Windows.Forms.Button tbAdauga;
        private System.Windows.Forms.ComboBox cbFilm;
        private System.Windows.Forms.TextBox tbFees;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker tbRetur;
        private System.Windows.Forms.DateTimePicker tbRental;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
    }
}