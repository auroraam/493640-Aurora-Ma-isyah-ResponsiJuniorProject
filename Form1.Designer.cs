namespace responsi_aurora
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tbNama = new TextBox();
            cbDep = new ComboBox();
            btInsert = new Button();
            btEdit = new Button();
            btDelete = new Button();
            dataGridView1 = new DataGridView();
            richTextBox1 = new RichTextBox();
            cbJabatan = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download;
            pictureBox1.InitialImage = Properties.Resources.download;
            pictureBox1.Location = new Point(114, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 186);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 1;
            label1.Text = "Nama Karyawan : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 228);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 2;
            label2.Text = "Dep. Karyawan : ";
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbNama.Location = new Point(172, 183);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(186, 27);
            tbNama.TabIndex = 3;
            // 
            // cbDep
            // 
            cbDep.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDep.Location = new Point(172, 225);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(186, 28);
            cbDep.TabIndex = 4;
            // 
            // btInsert
            // 
            btInsert.Location = new Point(23, 313);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(94, 23);
            btInsert.TabIndex = 5;
            btInsert.Text = "Insert";
            btInsert.UseVisualStyleBackColor = true;
            btInsert.Click += btInsert_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(138, 313);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(107, 23);
            btEdit.TabIndex = 6;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(261, 313);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(97, 23);
            btDelete.TabIndex = 7;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 356);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(489, 206);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(385, 183);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(127, 149);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "ID Departemen:\n\nHR : HR\nENG : Engineer\nDEV : Developer\nPM : Product M\nFIN : Finance";
            // 
            // cbJabatan
            // 
            cbJabatan.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbJabatan.FormattingEnabled = true;
            cbJabatan.Items.AddRange(new object[] { "Kadiv", "Wakadiv", "Staff" });
            cbJabatan.Location = new Point(172, 269);
            cbJabatan.Name = "cbJabatan";
            cbJabatan.Size = new Size(186, 28);
            cbJabatan.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 272);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 10;
            label3.Text = "Jabatan : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 578);
            Controls.Add(cbJabatan);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(btInsert);
            Controls.Add(cbDep);
            Controls.Add(tbNama);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox tbNama;
        private ComboBox cbDep;
        private Button btInsert;
        private Button btEdit;
        private Button btDelete;
        private DataGridView dataGridView1;
        private RichTextBox richTextBox1;
        private ComboBox cbJabatan;
        private Label label3;
    }
}