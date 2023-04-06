namespace final_project.FORMS
{
    partial class VechicleStocklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VechicleStocklist));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnview = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.txtcolour = new System.Windows.Forms.TextBox();
            this.txtfuel = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.lblsize = new System.Windows.Forms.Label();
            this.lblcolour = new System.Windows.Forms.Label();
            this.lblfuel = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblmodel = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(683, 349);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Maroon;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Snow;
            this.btnview.Location = new System.Drawing.Point(674, 540);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(99, 41);
            this.btnview.TabIndex = 34;
            this.btnview.Text = "VIEW";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Maroon;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.Snow;
            this.btndelete.Location = new System.Drawing.Point(549, 540);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(101, 41);
            this.btndelete.TabIndex = 33;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Maroon;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Snow;
            this.btnupdate.Location = new System.Drawing.Point(429, 540);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(101, 41);
            this.btnupdate.TabIndex = 32;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Maroon;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.Snow;
            this.btnsave.Location = new System.Drawing.Point(317, 540);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(101, 41);
            this.btnsave.TabIndex = 31;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(132, 368);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(146, 20);
            this.txtsize.TabIndex = 30;
            // 
            // txtcolour
            // 
            this.txtcolour.Location = new System.Drawing.Point(132, 324);
            this.txtcolour.Name = "txtcolour";
            this.txtcolour.Size = new System.Drawing.Size(146, 20);
            this.txtcolour.TabIndex = 29;
            // 
            // txtfuel
            // 
            this.txtfuel.Location = new System.Drawing.Point(132, 289);
            this.txtfuel.Name = "txtfuel";
            this.txtfuel.Size = new System.Drawing.Size(146, 20);
            this.txtfuel.TabIndex = 28;
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(132, 243);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(146, 20);
            this.txttype.TabIndex = 27;
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(132, 203);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(146, 20);
            this.txtmodel.TabIndex = 26;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(132, 154);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(146, 20);
            this.txtyear.TabIndex = 25;
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsize.Location = new System.Drawing.Point(7, 373);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(105, 16);
            this.lblsize.TabIndex = 24;
            this.lblsize.Text = "Engine - size :";
            // 
            // lblcolour
            // 
            this.lblcolour.AutoSize = true;
            this.lblcolour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolour.Location = new System.Drawing.Point(38, 329);
            this.lblcolour.Name = "lblcolour";
            this.lblcolour.Size = new System.Drawing.Size(61, 16);
            this.lblcolour.TabIndex = 23;
            this.lblcolour.Text = "Colour :";
            // 
            // lblfuel
            // 
            this.lblfuel.AutoSize = true;
            this.lblfuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfuel.Location = new System.Drawing.Point(25, 294);
            this.lblfuel.Name = "lblfuel";
            this.lblfuel.Size = new System.Drawing.Size(89, 16);
            this.lblfuel.TabIndex = 22;
            this.lblfuel.Text = "Fuel - type :";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(25, 248);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(95, 16);
            this.lbltype.TabIndex = 21;
            this.lbltype.Text = "Body - type :";
            // 
            // lblmodel
            // 
            this.lblmodel.AutoSize = true;
            this.lblmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodel.Location = new System.Drawing.Point(29, 208);
            this.lblmodel.Name = "lblmodel";
            this.lblmodel.Size = new System.Drawing.Size(96, 16);
            this.lblmodel.TabIndex = 20;
            this.lblmodel.Text = "Car - model :";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(33, 159);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(84, 16);
            this.lblyear.TabIndex = 19;
            this.lblyear.Text = "Car - year :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Vechicle Stocklist inventory System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(857, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 37;
            this.label3.Text = "Status";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "car stocklist";
            this.notifyIcon1.Text = "car stocklist";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 711);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1127, 22);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblstatus
            // 
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 17);
            // 
            // VechicleStocklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1127, 733);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.txtcolour);
            this.Controls.Add(this.txtfuel);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.lblcolour);
            this.Controls.Add(this.lblfuel);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lblmodel);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VechicleStocklist";
            this.Text = "car_stocklist";
            this.Load += new System.EventHandler(this.car_stocklist_Load);
            this.SizeChanged += new System.EventHandler(this.VechicleStocklist_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txtcolour;
        private System.Windows.Forms.TextBox txtfuel;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lblcolour;
        private System.Windows.Forms.Label lblfuel;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblmodel;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus;
    }
}