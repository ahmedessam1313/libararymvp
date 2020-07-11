namespace libaraymvp.Views.forms
{
    partial class frm_bookplace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_bookplace));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnnext = new DevExpress.XtraEditors.SimpleButton();
            this.btnprev = new DevExpress.XtraEditors.SimpleButton();
            this.btnfirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnlast = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvshow = new System.Windows.Forms.DataGridView();
            this.btnnew = new DevExpress.XtraEditors.SimpleButton();
            this.btndeleteall = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books Data Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Place Name:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(305, 36);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(128, 20);
            this.txtname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Place ID:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(82, 36);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(128, 20);
            this.txtid.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnnext);
            this.groupBox2.Controls.Add(this.btnprev);
            this.groupBox2.Controls.Add(this.btnfirst);
            this.groupBox2.Controls.Add(this.btnlast);
            this.groupBox2.Location = new System.Drawing.Point(103, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 73);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controler Arrows:";
            // 
            // btnnext
            // 
            this.btnnext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnext.ImageOptions.Image")));
            this.btnnext.Location = new System.Drawing.Point(65, 19);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(43, 36);
            this.btnnext.TabIndex = 5;
            // 
            // btnprev
            // 
            this.btnprev.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnprev.ImageOptions.Image")));
            this.btnprev.Location = new System.Drawing.Point(114, 19);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(43, 36);
            this.btnprev.TabIndex = 4;
            // 
            // btnfirst
            // 
            this.btnfirst.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnfirst.ImageOptions.Image")));
            this.btnfirst.Location = new System.Drawing.Point(163, 19);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(43, 36);
            this.btnfirst.TabIndex = 3;
            // 
            // btnlast
            // 
            this.btnlast.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnlast.ImageOptions.Image")));
            this.btnlast.Location = new System.Drawing.Point(16, 19);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(43, 36);
            this.btnlast.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvshow);
            this.groupBox3.Controls.Add(this.btnnew);
            this.groupBox3.Controls.Add(this.btndeleteall);
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Controls.Add(this.btnadd);
            this.groupBox3.Location = new System.Drawing.Point(12, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 244);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Controler Arrows:";
            // 
            // dgvshow
            // 
            this.dgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvshow.Location = new System.Drawing.Point(6, 61);
            this.dgvshow.Name = "dgvshow";
            this.dgvshow.Size = new System.Drawing.Size(438, 177);
            this.dgvshow.TabIndex = 5;
            // 
            // btnnew
            // 
            this.btnnew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.ImageOptions.Image")));
            this.btnnew.Location = new System.Drawing.Point(91, 19);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(73, 36);
            this.btnnew.TabIndex = 4;
            this.btnnew.Text = "New";
            // 
            // btndeleteall
            // 
            this.btndeleteall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndeleteall.ImageOptions.Image")));
            this.btndeleteall.Location = new System.Drawing.Point(356, 19);
            this.btndeleteall.Name = "btndeleteall";
            this.btndeleteall.Size = new System.Drawing.Size(88, 36);
            this.btndeleteall.TabIndex = 3;
            this.btndeleteall.Text = "Delete all";
            // 
            // btndelete
            // 
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.Location = new System.Drawing.Point(268, 19);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(73, 36);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            // 
            // btnsave
            // 
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.Location = new System.Drawing.Point(180, 19);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(71, 36);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            // 
            // btnadd
            // 
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.Location = new System.Drawing.Point(5, 19);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(71, 36);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            // 
            // frm_bookplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 416);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_bookplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Place";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnnext;
        private DevExpress.XtraEditors.SimpleButton btnprev;
        private DevExpress.XtraEditors.SimpleButton btnfirst;
        private DevExpress.XtraEditors.SimpleButton btnlast;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvshow;
        private DevExpress.XtraEditors.SimpleButton btnnew;
        private DevExpress.XtraEditors.SimpleButton btndeleteall;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btnadd;
    }
}