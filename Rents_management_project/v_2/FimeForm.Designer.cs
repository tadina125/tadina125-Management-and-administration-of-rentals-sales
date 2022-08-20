
namespace v_2
{
    partial class FimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FimeForm));
            this.tbBack = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbCategorie = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbAn = new System.Windows.Forms.TextBox();
            this.cbDisponibilitate = new System.Windows.Forms.ComboBox();
            this.tbUpdate = new System.Windows.Forms.Button();
            this.tbSalvare = new System.Windows.Forms.Button();
            this.tbStergere = new System.Windows.Forms.Button();
            this.tbVizualizare = new System.Windows.Forms.Button();
            this.tbAdauga = new System.Windows.Forms.Button();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBack
            // 
            this.tbBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBack.ForeColor = System.Drawing.Color.White;
            this.tbBack.Location = new System.Drawing.Point(824, 4);
            this.tbBack.Name = "tbBack";
            this.tbBack.Size = new System.Drawing.Size(26, 25);
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
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(96, 264);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(98, 22);
            this.tbPret.TabIndex = 32;
            // 
            // tbCategorie
            // 
            this.tbCategorie.Location = new System.Drawing.Point(96, 140);
            this.tbCategorie.Name = "tbCategorie";
            this.tbCategorie.Size = new System.Drawing.Size(98, 22);
            this.tbCategorie.TabIndex = 31;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(96, 185);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(98, 22);
            this.tbDenumire.TabIndex = 30;
            // 
            // tbAn
            // 
            this.tbAn.Location = new System.Drawing.Point(96, 224);
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(98, 22);
            this.tbAn.TabIndex = 29;
            // 
            // cbDisponibilitate
            // 
            this.cbDisponibilitate.FormattingEnabled = true;
            this.cbDisponibilitate.Items.AddRange(new object[] {
            "Disponibil",
            "Indisponibil"});
            this.cbDisponibilitate.Location = new System.Drawing.Point(96, 303);
            this.cbDisponibilitate.Name = "cbDisponibilitate";
            this.cbDisponibilitate.Size = new System.Drawing.Size(98, 24);
            this.cbDisponibilitate.TabIndex = 3;
            this.cbDisponibilitate.SelectedIndexChanged += new System.EventHandler(this.cbDisponibilitate_SelectedIndexChanged);
            // 
            // tbUpdate
            // 
            this.tbUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbUpdate.FlatAppearance.BorderSize = 0;
            this.tbUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUpdate.ForeColor = System.Drawing.Color.White;
            this.tbUpdate.Location = new System.Drawing.Point(47, 405);
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Size = new System.Drawing.Size(115, 37);
            this.tbUpdate.TabIndex = 44;
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
            this.tbSalvare.Location = new System.Drawing.Point(47, 488);
            this.tbSalvare.Name = "tbSalvare";
            this.tbSalvare.Size = new System.Drawing.Size(115, 37);
            this.tbSalvare.TabIndex = 43;
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
            this.tbStergere.Location = new System.Drawing.Point(47, 448);
            this.tbStergere.Name = "tbStergere";
            this.tbStergere.Size = new System.Drawing.Size(115, 37);
            this.tbStergere.TabIndex = 42;
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
            this.tbVizualizare.Location = new System.Drawing.Point(47, 368);
            this.tbVizualizare.Name = "tbVizualizare";
            this.tbVizualizare.Size = new System.Drawing.Size(115, 37);
            this.tbVizualizare.TabIndex = 41;
            this.tbVizualizare.Text = "View";
            this.tbVizualizare.UseVisualStyleBackColor = false;
            this.tbVizualizare.Click += new System.EventHandler(this.tbVizualizare_Click_1);
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
            this.tbAdauga.TabIndex = 40;
            this.tbAdauga.Text = "Add";
            this.tbAdauga.UseVisualStyleBackColor = false;
            this.tbAdauga.Click += new System.EventHandler(this.tbAdauga_Click_1);
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(96, 100);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(98, 22);
            this.tbCod.TabIndex = 46;
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
            this.listView1.Location = new System.Drawing.Point(271, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(579, 272);
            this.listView1.TabIndex = 47;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Title";
            this.columnHeader3.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Year";
            this.columnHeader4.Width = 72;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.Width = 83;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Availability";
            this.columnHeader6.Width = 105;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbBack);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 32);
            this.panel1.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(478, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "MOVIES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbSalvare);
            this.panel2.Controls.Add(this.tbUpdate);
            this.panel2.Controls.Add(this.tbStergere);
            this.panel2.Controls.Add(this.tbCod);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.tbVizualizare);
            this.panel2.Controls.Add(this.tbCategorie);
            this.panel2.Controls.Add(this.tbAdauga);
            this.panel2.Controls.Add(this.tbDenumire);
            this.panel2.Controls.Add(this.cbDisponibilitate);
            this.panel2.Controls.Add(this.tbAn);
            this.panel2.Controls.Add(this.tbPret);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 531);
            this.panel2.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 51;
            this.label10.Text = "Availability:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 19);
            this.label9.TabIndex = 51;
            this.label9.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 50;
            this.label8.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 50;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Id:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(662, 406);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
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
            // FimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 563);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FimeForm";
            this.Load += new System.EventHandler(this.FimeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button tbBack;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbCategorie;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbAn;
        private System.Windows.Forms.ComboBox cbDisponibilitate;
        private System.Windows.Forms.Button tbUpdate;
        private System.Windows.Forms.Button tbSalvare;
        private System.Windows.Forms.Button tbStergere;
        private System.Windows.Forms.Button tbVizualizare;
        private System.Windows.Forms.Button tbAdauga;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergereToolStripMenuItem;
    }
}