
namespace RaspV2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SaveC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_kab = new System.Windows.Forms.TextBox();
            this.txbx_prep = new System.Windows.Forms.TextBox();
            this.txbx_Naz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_nedeli = new System.Windows.Forms.ComboBox();
            this.btn_addc = new System.Windows.Forms.Button();
            this.btn_addr = new System.Windows.Forms.Button();
            this.dgv_ocn = new System.Windows.Forms.DataGridView();
            this.dgv_rasp = new System.Windows.Forms.DataGridView();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_upd = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ocn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rasp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SaveC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txbx_kab);
            this.groupBox2.Controls.Add(this.txbx_prep);
            this.groupBox2.Controls.Add(this.txbx_Naz);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1049, 157);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование";
            // 
            // btn_SaveC
            // 
            this.btn_SaveC.Location = new System.Drawing.Point(833, 27);
            this.btn_SaveC.Name = "btn_SaveC";
            this.btn_SaveC.Size = new System.Drawing.Size(132, 31);
            this.btn_SaveC.TabIndex = 6;
            this.btn_SaveC.Text = "Сохранить";
            this.btn_SaveC.UseVisualStyleBackColor = true;
            this.btn_SaveC.Click += new System.EventHandler(this.btn_SaveC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Кабинет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Преподаватель";
            // 
            // txbx_kab
            // 
            this.txbx_kab.Location = new System.Drawing.Point(157, 118);
            this.txbx_kab.Name = "txbx_kab";
            this.txbx_kab.Size = new System.Drawing.Size(567, 22);
            this.txbx_kab.TabIndex = 3;
            // 
            // txbx_prep
            // 
            this.txbx_prep.Location = new System.Drawing.Point(157, 73);
            this.txbx_prep.Name = "txbx_prep";
            this.txbx_prep.Size = new System.Drawing.Size(567, 22);
            this.txbx_prep.TabIndex = 2;
            // 
            // txbx_Naz
            // 
            this.txbx_Naz.Location = new System.Drawing.Point(157, 31);
            this.txbx_Naz.Name = "txbx_Naz";
            this.txbx_Naz.Size = new System.Drawing.Size(567, 22);
            this.txbx_Naz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название предмета";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbx_nedeli);
            this.groupBox1.Controls.Add(this.btn_addc);
            this.groupBox1.Controls.Add(this.btn_addr);
            this.groupBox1.Controls.Add(this.dgv_ocn);
            this.groupBox1.Controls.Add(this.dgv_rasp);
            this.groupBox1.Controls.Add(this.btn_del);
            this.groupBox1.Controls.Add(this.btn_upd);
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1078, 661);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расписание";
            // 
            // cbx_nedeli
            // 
            this.cbx_nedeli.FormattingEnabled = true;
            this.cbx_nedeli.Location = new System.Drawing.Point(15, 21);
            this.cbx_nedeli.Name = "cbx_nedeli";
            this.cbx_nedeli.Size = new System.Drawing.Size(207, 24);
            this.cbx_nedeli.TabIndex = 9;
            // 
            // btn_addc
            // 
            this.btn_addc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addc.Location = new System.Drawing.Point(683, 18);
            this.btn_addc.Name = "btn_addc";
            this.btn_addc.Size = new System.Drawing.Size(120, 46);
            this.btn_addc.TabIndex = 8;
            this.btn_addc.Text = "Добавить столбец";
            this.btn_addc.UseVisualStyleBackColor = true;
            this.btn_addc.Click += new System.EventHandler(this.btn_addc_Click);
            // 
            // btn_addr
            // 
            this.btn_addr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addr.Location = new System.Drawing.Point(554, 17);
            this.btn_addr.Name = "btn_addr";
            this.btn_addr.Size = new System.Drawing.Size(120, 46);
            this.btn_addr.TabIndex = 7;
            this.btn_addr.Text = "Добавить строку";
            this.btn_addr.UseVisualStyleBackColor = true;
            this.btn_addr.Click += new System.EventHandler(this.btn_addr_Click);
            // 
            // dgv_ocn
            // 
            this.dgv_ocn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ocn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ocn.Location = new System.Drawing.Point(15, 514);
            this.dgv_ocn.Name = "dgv_ocn";
            this.dgv_ocn.RowHeadersWidth = 51;
            this.dgv_ocn.RowTemplate.Height = 24;
            this.dgv_ocn.Size = new System.Drawing.Size(1044, 129);
            this.dgv_ocn.TabIndex = 6;
            // 
            // dgv_rasp
            // 
            this.dgv_rasp.AllowUserToAddRows = false;
            this.dgv_rasp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_rasp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rasp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_rasp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rasp.ColumnHeadersVisible = false;
            this.dgv_rasp.Location = new System.Drawing.Point(15, 98);
            this.dgv_rasp.Name = "dgv_rasp";
            this.dgv_rasp.ReadOnly = true;
            this.dgv_rasp.RowHeadersWidth = 51;
            this.dgv_rasp.RowTemplate.Height = 24;
            this.dgv_rasp.Size = new System.Drawing.Size(1044, 383);
            this.dgv_rasp.TabIndex = 0;
            this.dgv_rasp.Click += new System.EventHandler(this.dgv_rasp_Click);
            // 
            // btn_del
            // 
            this.btn_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_del.Location = new System.Drawing.Point(936, 18);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(120, 45);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_upd
            // 
            this.btn_upd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_upd.Location = new System.Drawing.Point(810, 18);
            this.btn_upd.Name = "btn_upd";
            this.btn_upd.Size = new System.Drawing.Size(120, 46);
            this.btn_upd.TabIndex = 2;
            this.btn_upd.Text = "Обновить";
            this.btn_upd.UseVisualStyleBackColor = true;
            this.btn_upd.Click += new System.EventHandler(this.btn_upd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 867);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ocn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rasp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_SaveC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_kab;
        private System.Windows.Forms.TextBox txbx_prep;
        private System.Windows.Forms.TextBox txbx_Naz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ocn;
        private System.Windows.Forms.DataGridView dgv_rasp;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_upd;
        private System.Windows.Forms.Button btn_addc;
        private System.Windows.Forms.Button btn_addr;
        private System.Windows.Forms.ComboBox cbx_nedeli;
    }
}

