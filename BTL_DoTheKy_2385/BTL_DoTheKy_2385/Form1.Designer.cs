namespace BTL_DoTheKy_2385
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnimport = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvds = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.cbsx = new System.Windows.Forms.ComboBox();
            this.cbto = new System.Windows.Forms.ComboBox();
            this.cbfrom = new System.Windows.Forms.ComboBox();
            this.txtFlightNumber = new System.Windows.Forms.TextBox();
            this.btnapply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnimport
            // 
            this.btnimport.Image = ((System.Drawing.Image)(resources.GetObject("btnimport.Image")));
            this.btnimport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimport.Location = new System.Drawing.Point(733, 458);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(126, 50);
            this.btnimport.TabIndex = 8;
            this.btnimport.Text = "Import  Changes";
            this.btnimport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(184, 458);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(109, 50);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "Edit Flight";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(38, 458);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 50);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel Flight";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvds
            // 
            this.dgvds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvds.Location = new System.Drawing.Point(24, 164);
            this.dgvds.Name = "dgvds";
            this.dgvds.Size = new System.Drawing.Size(861, 288);
            this.dgvds.TabIndex = 6;
            this.dgvds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.cbsx);
            this.groupBox1.Controls.Add(this.cbto);
            this.groupBox1.Controls.Add(this.cbfrom);
            this.groupBox1.Controls.Add(this.txtFlightNumber);
            this.groupBox1.Controls.Add(this.btnapply);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(861, 110);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(113, 66);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(156, 20);
            this.txtdate.TabIndex = 12;
            // 
            // cbsx
            // 
            this.cbsx.FormattingEnabled = true;
            this.cbsx.Items.AddRange(new object[] {
            "Date-time",
            "Economy",
            "Confirmed"});
            this.cbsx.Location = new System.Drawing.Point(674, 18);
            this.cbsx.Name = "cbsx";
            this.cbsx.Size = new System.Drawing.Size(117, 21);
            this.cbsx.TabIndex = 6;
            this.cbsx.Text = "Date-time";
            this.cbsx.SelectedIndexChanged += new System.EventHandler(this.cbsx_SelectedIndexChanged);
            // 
            // cbto
            // 
            this.cbto.FormattingEnabled = true;
            this.cbto.Items.AddRange(new object[] {
            "thedeptrai"});
            this.cbto.Location = new System.Drawing.Point(396, 18);
            this.cbto.Name = "cbto";
            this.cbto.Size = new System.Drawing.Size(167, 21);
            this.cbto.TabIndex = 4;
            // 
            // cbfrom
            // 
            this.cbfrom.FormattingEnabled = true;
            this.cbfrom.Items.AddRange(new object[] {
            "thedeptrai"});
            this.cbfrom.Location = new System.Drawing.Point(113, 18);
            this.cbfrom.Name = "cbfrom";
            this.cbfrom.Size = new System.Drawing.Size(156, 21);
            this.cbfrom.TabIndex = 2;
            // 
            // txtFlightNumber
            // 
            this.txtFlightNumber.Location = new System.Drawing.Point(396, 68);
            this.txtFlightNumber.Name = "txtFlightNumber";
            this.txtFlightNumber.Size = new System.Drawing.Size(167, 20);
            this.txtFlightNumber.TabIndex = 10;
            // 
            // btnapply
            // 
            this.btnapply.Location = new System.Drawing.Point(674, 57);
            this.btnapply.Name = "btnapply";
            this.btnapply.Size = new System.Drawing.Size(117, 42);
            this.btnapply.TabIndex = 0;
            this.btnapply.Text = "Apply";
            this.btnapply.UseVisualStyleBackColor = true;
            this.btnapply.Click += new System.EventHandler(this.btnapply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Flight Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sort by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Outbound";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 553);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvds);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Flight Schedules";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DataGridView dgvds;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbsx;
        public System.Windows.Forms.ComboBox cbto;
        public System.Windows.Forms.ComboBox cbfrom;
        public System.Windows.Forms.TextBox txtFlightNumber;
        private System.Windows.Forms.Button btnapply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdate;
    }
}

