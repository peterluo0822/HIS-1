﻿namespace com.digitalwave.iCare.gui.MedicineStore_Maintain
{
    partial class frmRecipeBySpecialMedicineReport
    {
        /// <summary>
        /// 必需的设计器变量。

        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。

        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。

        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeBySpecialMedicineReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dw = new Sybase.DataWindow.DataWindowControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.m_btnQuery = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.m_btnPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.m_btnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_btnExport = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.m_btnExit = new System.Windows.Forms.ToolStripButton();
            this.gradientPanel2 = new com.digitalwave.iCare.gui.MedicineStore.GradientPanel();
            this.m_txtMedicineCode = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.m_cbbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.m_dtpSearchBeginDate = new System.Windows.Forms.DateTimePicker();
            this.m_dtpSearchEndDate = new System.Windows.Forms.DateTimePicker();
            this.m_dgvMedDetail = new System.Windows.Forms.DataGridView();
            this.medicinename_vchr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medspec_vchr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatdate_dat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientcardid_chr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname_vchr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usagename_vchr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.days_int = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tolqty_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitid_chr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosage_dec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tys = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_dgvSortRowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freqname_chr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosageunit_chr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMedDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dw
            // 
            this.dw.DataWindowObject = "";
            this.dw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dw.LibraryList = "";
            this.dw.Location = new System.Drawing.Point(0, 0);
            this.dw.Name = "dw";
            this.dw.ScrollBars = Sybase.DataWindow.DataWindowScrollBars.Both;
            this.dw.Size = new System.Drawing.Size(1008, 664);
            this.dw.TabIndex = 10059;
            this.dw.Text = "dataWindowControl1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_btnQuery,
            this.toolStripSeparator4,
            this.m_btnPreview,
            this.toolStripSeparator2,
            this.m_btnPrint,
            this.toolStripSeparator1,
            this.m_btnExport,
            this.toolStripSeparator3,
            this.m_btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1008, 38);
            this.toolStrip1.TabIndex = 10058;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // m_btnQuery
            // 
            this.m_btnQuery.AutoSize = false;
            this.m_btnQuery.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("m_btnQuery.Image")));
            this.m_btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_btnQuery.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_btnQuery.ImageTransparentColor = System.Drawing.Color.Black;
            this.m_btnQuery.Name = "m_btnQuery";
            this.m_btnQuery.Size = new System.Drawing.Size(90, 35);
            this.m_btnQuery.Text = "查 询(&Q)";
            this.m_btnQuery.Click += new System.EventHandler(this.m_cmdSearch_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // m_btnPreview
            // 
            this.m_btnPreview.AutoSize = false;
            this.m_btnPreview.Image = ((System.Drawing.Image)(resources.GetObject("m_btnPreview.Image")));
            this.m_btnPreview.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_btnPreview.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.m_btnPreview.Name = "m_btnPreview";
            this.m_btnPreview.Size = new System.Drawing.Size(90, 35);
            this.m_btnPreview.Text = "预 览(&V)";
            this.m_btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnPreview.Click += new System.EventHandler(this.m_cmdPreview_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // m_btnPrint
            // 
            this.m_btnPrint.AutoSize = false;
            this.m_btnPrint.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("m_btnPrint.Image")));
            this.m_btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_btnPrint.ImageTransparentColor = System.Drawing.Color.Black;
            this.m_btnPrint.Name = "m_btnPrint";
            this.m_btnPrint.Size = new System.Drawing.Size(90, 35);
            this.m_btnPrint.Text = "打 印(&P)";
            this.m_btnPrint.Click += new System.EventHandler(this.m_cmdPrint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // m_btnExport
            // 
            this.m_btnExport.AutoSize = false;
            this.m_btnExport.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnExport.Image = ((System.Drawing.Image)(resources.GetObject("m_btnExport.Image")));
            this.m_btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_btnExport.ImageTransparentColor = System.Drawing.Color.Black;
            this.m_btnExport.Name = "m_btnExport";
            this.m_btnExport.Size = new System.Drawing.Size(90, 35);
            this.m_btnExport.Text = "导 出(&E)";
            this.m_btnExport.Click += new System.EventHandler(this.m_cmdExport_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // m_btnExit
            // 
            this.m_btnExit.AutoSize = false;
            this.m_btnExit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_btnExit.Image = ((System.Drawing.Image)(resources.GetObject("m_btnExit.Image")));
            this.m_btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.m_btnExit.ImageTransparentColor = System.Drawing.Color.Black;
            this.m_btnExit.Name = "m_btnExit";
            this.m_btnExit.Size = new System.Drawing.Size(90, 35);
            this.m_btnExit.Text = "关 闭(&C)";
            this.m_btnExit.Click += new System.EventHandler(this.m_cmdExit_Click);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Controls.Add(this.m_txtMedicineCode);
            this.gradientPanel2.Controls.Add(this.label15);
            this.gradientPanel2.Controls.Add(this.m_cbbType);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.label8);
            this.gradientPanel2.Controls.Add(this.m_dtpSearchBeginDate);
            this.gradientPanel2.Controls.Add(this.m_dtpSearchEndDate);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel2.Flip = false;
            this.gradientPanel2.FloatingImage = null;
            this.gradientPanel2.GradientAngle = 90;
            this.gradientPanel2.GradientEndColor = System.Drawing.SystemColors.Control;
            this.gradientPanel2.GradientStartColor = System.Drawing.Color.White;
            this.gradientPanel2.HorizontalFillPercent = 100F;
            this.gradientPanel2.imageXOffset = 0;
            this.gradientPanel2.imageYOffset = 0;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 38);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(1008, 41);
            this.gradientPanel2.TabIndex = 10059;
            this.gradientPanel2.VerticalFillPercent = 100F;
            // 
            // m_txtMedicineCode
            // 
            this.m_txtMedicineCode.AccessibleDescription = "药品代码";
            this.m_txtMedicineCode.BackColor = System.Drawing.SystemColors.Window;
            this.m_txtMedicineCode.Font = new System.Drawing.Font("宋体", 10.5F);
            this.m_txtMedicineCode.Location = new System.Drawing.Point(722, 8);
            this.m_txtMedicineCode.Name = "m_txtMedicineCode";
            this.m_txtMedicineCode.Size = new System.Drawing.Size(254, 23);
            this.m_txtMedicineCode.TabIndex = 10060;
            this.m_txtMedicineCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txtMedicineCode_KeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(672, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 14);
            this.label15.TabIndex = 10061;
            this.label15.Text = "药品：";
            // 
            // m_cbbType
            // 
            this.m_cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbbType.FormattingEnabled = true;
            this.m_cbbType.Items.AddRange(new object[] {
            "麻醉药品",
            "毒性药品",
            "精神一类",
            "精神二类"});
            this.m_cbbType.Location = new System.Drawing.Point(565, 9);
            this.m_cbbType.Name = "m_cbbType";
            this.m_cbbType.Size = new System.Drawing.Size(99, 22);
            this.m_cbbType.TabIndex = 10049;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(519, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 10050;
            this.label2.Text = "类型：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 10047;
            this.label1.Text = "统计时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(290, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 14);
            this.label8.TabIndex = 10048;
            this.label8.Text = "~";
            // 
            // m_dtpSearchBeginDate
            // 
            this.m_dtpSearchBeginDate.CustomFormat = "yyyy年MM月dd日HH时mm分ss秒";
            this.m_dtpSearchBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtpSearchBeginDate.Location = new System.Drawing.Point(85, 9);
            this.m_dtpSearchBeginDate.Name = "m_dtpSearchBeginDate";
            this.m_dtpSearchBeginDate.Size = new System.Drawing.Size(205, 23);
            this.m_dtpSearchBeginDate.TabIndex = 0;
            // 
            // m_dtpSearchEndDate
            // 
            this.m_dtpSearchEndDate.CustomFormat = "yyyy年MM月dd日HH时mm分ss秒";
            this.m_dtpSearchEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dtpSearchEndDate.Location = new System.Drawing.Point(304, 9);
            this.m_dtpSearchEndDate.Name = "m_dtpSearchEndDate";
            this.m_dtpSearchEndDate.Size = new System.Drawing.Size(205, 23);
            this.m_dtpSearchEndDate.TabIndex = 1;
            // 
            // m_dgvMedDetail
            // 
            this.m_dgvMedDetail.AllowUserToAddRows = false;
            this.m_dgvMedDetail.AllowUserToOrderColumns = true;
            this.m_dgvMedDetail.BackgroundColor = System.Drawing.Color.White;
            this.m_dgvMedDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_dgvMedDetail.ColumnHeadersHeight = 25;
            this.m_dgvMedDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.m_dgvMedDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicinename_vchr,
            this.medspec_vchr,
            this.treatdate_dat,
            this.patientcardid_chr,
            this.lastname_vchr,
            this.usagename_vchr,
            this.days_int,
            this.tolqty_dec,
            this.unitid_chr,
            this.dosage_dec,
            this.lastname,
            this.tys,
            this.m_dgvSortRowNo,
            this.freqname_chr,
            this.dosageunit_chr});
            this.m_dgvMedDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_dgvMedDetail.Location = new System.Drawing.Point(0, 79);
            this.m_dgvMedDetail.Name = "m_dgvMedDetail";
            this.m_dgvMedDetail.ReadOnly = true;
            this.m_dgvMedDetail.RowHeadersVisible = false;
            this.m_dgvMedDetail.RowTemplate.Height = 23;
            this.m_dgvMedDetail.Size = new System.Drawing.Size(1008, 585);
            this.m_dgvMedDetail.TabIndex = 10060;
            this.m_dgvMedDetail.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.m_dgvMedDetail_ColumnHeaderMouseClick);
            // 
            // medicinename_vchr
            // 
            this.medicinename_vchr.DataPropertyName = "medicinename_vchr";
            this.medicinename_vchr.HeaderText = "药品名称";
            this.medicinename_vchr.Name = "medicinename_vchr";
            this.medicinename_vchr.ReadOnly = true;
            this.medicinename_vchr.Width = 135;
            // 
            // medspec_vchr
            // 
            this.medspec_vchr.DataPropertyName = "medspec_vchr";
            this.medspec_vchr.HeaderText = "规格";
            this.medspec_vchr.Name = "medspec_vchr";
            this.medspec_vchr.ReadOnly = true;
            this.medspec_vchr.Width = 120;
            // 
            // treatdate_dat
            // 
            this.treatdate_dat.DataPropertyName = "treatdate_dat";
            this.treatdate_dat.HeaderText = "配药日期";
            this.treatdate_dat.Name = "treatdate_dat";
            this.treatdate_dat.ReadOnly = true;
            this.treatdate_dat.Width = 130;
            // 
            // patientcardid_chr
            // 
            this.patientcardid_chr.DataPropertyName = "patientcardid_chr";
            this.patientcardid_chr.HeaderText = "病人ID";
            this.patientcardid_chr.Name = "patientcardid_chr";
            this.patientcardid_chr.ReadOnly = true;
            this.patientcardid_chr.Width = 120;
            // 
            // lastname_vchr
            // 
            this.lastname_vchr.DataPropertyName = "lastname_vchr";
            this.lastname_vchr.HeaderText = "病人姓名";
            this.lastname_vchr.Name = "lastname_vchr";
            this.lastname_vchr.ReadOnly = true;
            // 
            // usagename_vchr
            // 
            this.usagename_vchr.DataPropertyName = "usagename_vchr";
            this.usagename_vchr.HeaderText = "用法";
            this.usagename_vchr.Name = "usagename_vchr";
            this.usagename_vchr.ReadOnly = true;
            // 
            // days_int
            // 
            this.days_int.DataPropertyName = "days_int";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.days_int.DefaultCellStyle = dataGridViewCellStyle1;
            this.days_int.HeaderText = "天数";
            this.days_int.Name = "days_int";
            this.days_int.ReadOnly = true;
            this.days_int.Visible = false;
            this.days_int.Width = 60;
            // 
            // tolqty_dec
            // 
            this.tolqty_dec.DataPropertyName = "tolqty_dec";
            this.tolqty_dec.HeaderText = "数量";
            this.tolqty_dec.Name = "tolqty_dec";
            this.tolqty_dec.ReadOnly = true;
            this.tolqty_dec.Width = 60;
            // 
            // unitid_chr
            // 
            this.unitid_chr.DataPropertyName = "unitid_chr";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.unitid_chr.DefaultCellStyle = dataGridViewCellStyle2;
            this.unitid_chr.HeaderText = "单位";
            this.unitid_chr.Name = "unitid_chr";
            this.unitid_chr.ReadOnly = true;
            this.unitid_chr.Width = 60;
            // 
            // dosage_dec
            // 
            this.dosage_dec.DataPropertyName = "dosage_dec";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dosage_dec.DefaultCellStyle = dataGridViewCellStyle3;
            this.dosage_dec.HeaderText = "用量";
            this.dosage_dec.Name = "dosage_dec";
            this.dosage_dec.ReadOnly = true;
            this.dosage_dec.Visible = false;
            // 
            // lastname
            // 
            this.lastname.DataPropertyName = "lastname";
            this.lastname.HeaderText = "配药人";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // tys
            // 
            this.tys.DataPropertyName = "tys";
            this.tys.HeaderText = "退药量";
            this.tys.Name = "tys";
            this.tys.ReadOnly = true;
            this.tys.Width = 60;
            // 
            // m_dgvSortRowNo
            // 
            this.m_dgvSortRowNo.DataPropertyName = "SortRowNo";
            this.m_dgvSortRowNo.HeaderText = "排序号";
            this.m_dgvSortRowNo.Name = "m_dgvSortRowNo";
            this.m_dgvSortRowNo.ReadOnly = true;
            this.m_dgvSortRowNo.Visible = false;
            // 
            // freqname_chr
            // 
            this.freqname_chr.DataPropertyName = "freqname_chr";
            this.freqname_chr.HeaderText = "频率";
            this.freqname_chr.Name = "freqname_chr";
            this.freqname_chr.ReadOnly = true;
            this.freqname_chr.Visible = false;
            this.freqname_chr.Width = 50;
            // 
            // dosageunit_chr
            // 
            this.dosageunit_chr.DataPropertyName = "dosageunit_chr";
            this.dosageunit_chr.HeaderText = "单位";
            this.dosageunit_chr.Name = "dosageunit_chr";
            this.dosageunit_chr.ReadOnly = true;
            this.dosageunit_chr.Visible = false;
            this.dosageunit_chr.Width = 70;
            // 
            // frmRecipeBySpecialMedicineReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 664);
            this.Controls.Add(this.m_dgvMedDetail);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dw);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecipeBySpecialMedicineReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "麻、精药品处方出库明细表";
            this.Load += new System.EventHandler(this.frmRptInstorageStat_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgvMedDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Sybase.DataWindow.DataWindowControl dw;
        internal System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripButton m_btnQuery;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton m_btnPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton m_btnPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripLabel m_btnExport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton m_btnExit;
        private com.digitalwave.iCare.gui.MedicineStore.GradientPanel gradientPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.DateTimePicker m_dtpSearchBeginDate;
        internal System.Windows.Forms.DateTimePicker m_dtpSearchEndDate;
        internal System.Windows.Forms.DataGridView m_dgvMedDetail;
        internal System.Windows.Forms.ComboBox m_cbbType;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox m_txtMedicineCode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicinename_vchr;
        private System.Windows.Forms.DataGridViewTextBoxColumn medspec_vchr;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatdate_dat;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientcardid_chr;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname_vchr;
        private System.Windows.Forms.DataGridViewTextBoxColumn usagename_vchr;
        private System.Windows.Forms.DataGridViewTextBoxColumn days_int;
        private System.Windows.Forms.DataGridViewTextBoxColumn tolqty_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitid_chr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosage_dec;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tys;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_dgvSortRowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn freqname_chr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dosageunit_chr;
    }
}