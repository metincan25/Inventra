namespace DepoProjem
{
    partial class CariSil
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CariSil));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.exit = new System.Windows.Forms.Label();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cariIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiDairesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiIDTcNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
           
            this.btnSil = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
           
            this.label2 = new System.Windows.Forms.Label();
           
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
           
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1175, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 18);
            this.exit.TabIndex = 19;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            this.bunifuDataGridView1.AllowUserToAddRows = false;
            this.bunifuDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoGenerateColumns = false;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cariIDDataGridViewTextBoxColumn,
            this.cariAdıDataGridViewTextBoxColumn,
            this.cariKoduDataGridViewTextBoxColumn,
            this.cariTuruDataGridViewTextBoxColumn,
            this.vergiDairesiDataGridViewTextBoxColumn,
            this.vergiIDTcNoDataGridViewTextBoxColumn});
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(12, 39);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(1168, 319);
            this.bunifuDataGridView1.TabIndex = 20;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.bunifuDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellClick);
            // 
            // cariIDDataGridViewTextBoxColumn
            // 
            this.cariIDDataGridViewTextBoxColumn.DataPropertyName = "CariID";
            this.cariIDDataGridViewTextBoxColumn.HeaderText = "Cari Numarası";
            this.cariIDDataGridViewTextBoxColumn.Name = "cariIDDataGridViewTextBoxColumn";
            this.cariIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cariAdıDataGridViewTextBoxColumn
            // 
            this.cariAdıDataGridViewTextBoxColumn.DataPropertyName = "CariAdı";
            this.cariAdıDataGridViewTextBoxColumn.HeaderText = "Cari Adı";
            this.cariAdıDataGridViewTextBoxColumn.Name = "cariAdıDataGridViewTextBoxColumn";
            this.cariAdıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cariKoduDataGridViewTextBoxColumn
            // 
            this.cariKoduDataGridViewTextBoxColumn.DataPropertyName = "CariKodu";
            this.cariKoduDataGridViewTextBoxColumn.HeaderText = "Cari Kodu";
            this.cariKoduDataGridViewTextBoxColumn.Name = "cariKoduDataGridViewTextBoxColumn";
            this.cariKoduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cariTuruDataGridViewTextBoxColumn
            // 
            this.cariTuruDataGridViewTextBoxColumn.DataPropertyName = "CariTuru";
            this.cariTuruDataGridViewTextBoxColumn.HeaderText = "Cari Türü";
            this.cariTuruDataGridViewTextBoxColumn.Name = "cariTuruDataGridViewTextBoxColumn";
            this.cariTuruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vergiDairesiDataGridViewTextBoxColumn
            // 
            this.vergiDairesiDataGridViewTextBoxColumn.DataPropertyName = "VergiDairesi";
            this.vergiDairesiDataGridViewTextBoxColumn.HeaderText = "Vergi Dairesi";
            this.vergiDairesiDataGridViewTextBoxColumn.Name = "vergiDairesiDataGridViewTextBoxColumn";
            this.vergiDairesiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vergiIDTcNoDataGridViewTextBoxColumn
            // 
            this.vergiIDTcNoDataGridViewTextBoxColumn.DataPropertyName = "VergiID_TcNo";
            this.vergiIDTcNoDataGridViewTextBoxColumn.HeaderText = "VKN|TC";
            this.vergiIDTcNoDataGridViewTextBoxColumn.Name = "vergiIDTcNoDataGridViewTextBoxColumn";
            this.vergiIDTcNoDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // btnSil
            // 
            this.btnSil.AllowAnimations = true;
            this.btnSil.AllowMouseEffects = true;
            this.btnSil.AllowToggling = false;
            this.btnSil.AnimationSpeed = 200;
            this.btnSil.AutoGenerateColors = false;
            this.btnSil.AutoRoundBorders = false;
            this.btnSil.AutoSizeLeftIcon = true;
            this.btnSil.AutoSizeRightIcon = true;
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSil.BackgroundImage")));
            this.btnSil.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSil.ButtonText = "SİL";
            this.btnSil.ButtonTextMarginLeft = 0;
            this.btnSil.ColorContrastOnClick = 45;
            this.btnSil.ColorContrastOnHover = 45;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSil.CustomizableEdges = borderEdges1;
            this.btnSil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSil.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSil.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSil.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSil.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSil.IconMarginLeft = 11;
            this.btnSil.IconPadding = 10;
            this.btnSil.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSil.IconSize = 25;
            this.btnSil.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSil.IdleBorderRadius = 35;
            this.btnSil.IdleBorderThickness = 1;
            this.btnSil.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.IdleIconLeftImage = null;
            this.btnSil.IdleIconRightImage = null;
            this.btnSil.IndicateFocus = false;
            this.btnSil.Location = new System.Drawing.Point(208, 414);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSil.OnDisabledState.BorderRadius = 35;
            this.btnSil.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSil.OnDisabledState.BorderThickness = 1;
            this.btnSil.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSil.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSil.OnDisabledState.IconLeftImage = null;
            this.btnSil.OnDisabledState.IconRightImage = null;
            this.btnSil.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSil.onHoverState.BorderRadius = 35;
            this.btnSil.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSil.onHoverState.BorderThickness = 1;
            this.btnSil.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSil.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSil.onHoverState.IconLeftImage = null;
            this.btnSil.onHoverState.IconRightImage = null;
            this.btnSil.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSil.OnIdleState.BorderRadius = 35;
            this.btnSil.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSil.OnIdleState.BorderThickness = 1;
            this.btnSil.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSil.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSil.OnIdleState.IconLeftImage = null;
            this.btnSil.OnIdleState.IconRightImage = null;
            this.btnSil.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSil.OnPressedState.BorderRadius = 35;
            this.btnSil.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSil.OnPressedState.BorderThickness = 1;
            this.btnSil.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSil.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSil.OnPressedState.IconLeftImage = null;
            this.btnSil.OnPressedState.IconRightImage = null;
            this.btnSil.Size = new System.Drawing.Size(150, 39);
            this.btnSil.TabIndex = 26;
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSil.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSil.TextMarginLeft = 0;
            this.btnSil.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSil.UseDefaultRadiusAndThickness = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Seçilen Cari:";
            // 
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 27;
            // 
        
            // CariSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1192, 597);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CariSil";
            this.Text = "CariSil";
            this.Load += new System.EventHandler(this.CariSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSil;
        private System.Windows.Forms.Label label1;
       
       
        
        private System.Windows.Forms.DataGridViewTextBoxColumn cariIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cariTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiDairesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiIDTcNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
       
    }
}