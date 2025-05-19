namespace DepoProjem
{
    partial class Siparisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparisler));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.siparisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siparisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamTutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            
           
            this.btnRapor = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSiparisGuncelle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSiparisSil = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSiparisEkle = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSiparisOnayla = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
      
            
            
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            
            this.SuspendLayout();
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
            this.siparisIDDataGridViewTextBoxColumn,
            this.musteriIDDataGridViewTextBoxColumn,
            this.siparisTarihiDataGridViewTextBoxColumn,
            this.urunIDDataGridViewTextBoxColumn,
            this.urunAdıDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.toplamTutarDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn});
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
            this.bunifuDataGridView1.Location = new System.Drawing.Point(12, 12);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.ReadOnly = true;
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(1168, 412);
            this.bunifuDataGridView1.TabIndex = 10;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // siparisIDDataGridViewTextBoxColumn
            // 
            this.siparisIDDataGridViewTextBoxColumn.DataPropertyName = "SiparisID";
            this.siparisIDDataGridViewTextBoxColumn.HeaderText = "Sipariş No";
            this.siparisIDDataGridViewTextBoxColumn.Name = "siparisIDDataGridViewTextBoxColumn";
            this.siparisIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // musteriIDDataGridViewTextBoxColumn
            // 
            this.musteriIDDataGridViewTextBoxColumn.DataPropertyName = "MusteriID";
            this.musteriIDDataGridViewTextBoxColumn.HeaderText = "Müşteri No";
            this.musteriIDDataGridViewTextBoxColumn.Name = "musteriIDDataGridViewTextBoxColumn";
            this.musteriIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // siparisTarihiDataGridViewTextBoxColumn
            // 
            this.siparisTarihiDataGridViewTextBoxColumn.DataPropertyName = "SiparisTarihi";
            this.siparisTarihiDataGridViewTextBoxColumn.HeaderText = "Sipariş Tarihi";
            this.siparisTarihiDataGridViewTextBoxColumn.Name = "siparisTarihiDataGridViewTextBoxColumn";
            this.siparisTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "Ürün No";
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdıDataGridViewTextBoxColumn
            // 
            this.urunAdıDataGridViewTextBoxColumn.DataPropertyName = "UrunAdı";
            this.urunAdıDataGridViewTextBoxColumn.HeaderText = "Ürün Adı";
            this.urunAdıDataGridViewTextBoxColumn.Name = "urunAdıDataGridViewTextBoxColumn";
            this.urunAdıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birimFiyatDataGridViewTextBoxColumn
            // 
            this.birimFiyatDataGridViewTextBoxColumn.DataPropertyName = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.HeaderText = "Birim Fiyat";
            this.birimFiyatDataGridViewTextBoxColumn.Name = "birimFiyatDataGridViewTextBoxColumn";
            this.birimFiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toplamTutarDataGridViewTextBoxColumn
            // 
            this.toplamTutarDataGridViewTextBoxColumn.DataPropertyName = "ToplamTutar";
            this.toplamTutarDataGridViewTextBoxColumn.HeaderText = "Toplam Tutar";
            this.toplamTutarDataGridViewTextBoxColumn.Name = "toplamTutarDataGridViewTextBoxColumn";
            this.toplamTutarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktar";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            
            // btnRapor
            // 
            this.btnRapor.AllowAnimations = true;
            this.btnRapor.AllowMouseEffects = true;
            this.btnRapor.AllowToggling = false;
            this.btnRapor.AnimationSpeed = 200;
            this.btnRapor.AutoGenerateColors = false;
            this.btnRapor.AutoRoundBorders = false;
            this.btnRapor.AutoSizeLeftIcon = true;
            this.btnRapor.AutoSizeRightIcon = true;
            this.btnRapor.BackColor = System.Drawing.Color.Transparent;
            this.btnRapor.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnRapor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRapor.BackgroundImage")));
            this.btnRapor.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRapor.ButtonText = "Rapor";
            this.btnRapor.ButtonTextMarginLeft = 0;
            this.btnRapor.ColorContrastOnClick = 45;
            this.btnRapor.ColorContrastOnHover = 45;
            this.btnRapor.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnRapor.CustomizableEdges = borderEdges1;
            this.btnRapor.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRapor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRapor.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRapor.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRapor.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnRapor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRapor.ForeColor = System.Drawing.Color.Black;
            this.btnRapor.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRapor.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRapor.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnRapor.IconMarginLeft = 11;
            this.btnRapor.IconPadding = 10;
            this.btnRapor.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRapor.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnRapor.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnRapor.IconSize = 25;
            this.btnRapor.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRapor.IdleBorderRadius = 35;
            this.btnRapor.IdleBorderThickness = 1;
            this.btnRapor.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnRapor.IdleIconLeftImage = null;
            this.btnRapor.IdleIconRightImage = null;
            this.btnRapor.IndicateFocus = false;
            this.btnRapor.Location = new System.Drawing.Point(976, 460);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnRapor.OnDisabledState.BorderRadius = 35;
            this.btnRapor.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRapor.OnDisabledState.BorderThickness = 1;
            this.btnRapor.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnRapor.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnRapor.OnDisabledState.IconLeftImage = null;
            this.btnRapor.OnDisabledState.IconRightImage = null;
            this.btnRapor.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRapor.onHoverState.BorderRadius = 35;
            this.btnRapor.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRapor.onHoverState.BorderThickness = 1;
            this.btnRapor.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnRapor.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnRapor.onHoverState.IconLeftImage = null;
            this.btnRapor.onHoverState.IconRightImage = null;
            this.btnRapor.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRapor.OnIdleState.BorderRadius = 35;
            this.btnRapor.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRapor.OnIdleState.BorderThickness = 1;
            this.btnRapor.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnRapor.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnRapor.OnIdleState.IconLeftImage = null;
            this.btnRapor.OnIdleState.IconRightImage = null;
            this.btnRapor.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRapor.OnPressedState.BorderRadius = 35;
            this.btnRapor.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnRapor.OnPressedState.BorderThickness = 1;
            this.btnRapor.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnRapor.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnRapor.OnPressedState.IconLeftImage = null;
            this.btnRapor.OnPressedState.IconRightImage = null;
            this.btnRapor.Size = new System.Drawing.Size(160, 71);
            this.btnRapor.TabIndex = 14;
            this.btnRapor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRapor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRapor.TextMarginLeft = 0;
            this.btnRapor.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnRapor.UseDefaultRadiusAndThickness = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnSiparisGuncelle
            // 
            this.btnSiparisGuncelle.AllowAnimations = true;
            this.btnSiparisGuncelle.AllowMouseEffects = true;
            this.btnSiparisGuncelle.AllowToggling = false;
            this.btnSiparisGuncelle.AnimationSpeed = 200;
            this.btnSiparisGuncelle.AutoGenerateColors = false;
            this.btnSiparisGuncelle.AutoRoundBorders = false;
            this.btnSiparisGuncelle.AutoSizeLeftIcon = true;
            this.btnSiparisGuncelle.AutoSizeRightIcon = true;
            this.btnSiparisGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnSiparisGuncelle.BackColor1 = System.Drawing.Color.DarkKhaki;
            this.btnSiparisGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiparisGuncelle.BackgroundImage")));
            this.btnSiparisGuncelle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisGuncelle.ButtonText = "Sipariş Güncelle";
            this.btnSiparisGuncelle.ButtonTextMarginLeft = 0;
            this.btnSiparisGuncelle.ColorContrastOnClick = 45;
            this.btnSiparisGuncelle.ColorContrastOnHover = 45;
            this.btnSiparisGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSiparisGuncelle.CustomizableEdges = borderEdges2;
            this.btnSiparisGuncelle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSiparisGuncelle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSiparisGuncelle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSiparisGuncelle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSiparisGuncelle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSiparisGuncelle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisGuncelle.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisGuncelle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiparisGuncelle.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSiparisGuncelle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSiparisGuncelle.IconMarginLeft = 11;
            this.btnSiparisGuncelle.IconPadding = 10;
            this.btnSiparisGuncelle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiparisGuncelle.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSiparisGuncelle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSiparisGuncelle.IconSize = 25;
            this.btnSiparisGuncelle.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSiparisGuncelle.IdleBorderRadius = 35;
            this.btnSiparisGuncelle.IdleBorderThickness = 1;
            this.btnSiparisGuncelle.IdleFillColor = System.Drawing.Color.DarkKhaki;
            this.btnSiparisGuncelle.IdleIconLeftImage = null;
            this.btnSiparisGuncelle.IdleIconRightImage = null;
            this.btnSiparisGuncelle.IndicateFocus = false;
            this.btnSiparisGuncelle.Location = new System.Drawing.Point(659, 460);
            this.btnSiparisGuncelle.Name = "btnSiparisGuncelle";
            this.btnSiparisGuncelle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSiparisGuncelle.OnDisabledState.BorderRadius = 35;
            this.btnSiparisGuncelle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisGuncelle.OnDisabledState.BorderThickness = 1;
            this.btnSiparisGuncelle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSiparisGuncelle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSiparisGuncelle.OnDisabledState.IconLeftImage = null;
            this.btnSiparisGuncelle.OnDisabledState.IconRightImage = null;
            this.btnSiparisGuncelle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSiparisGuncelle.onHoverState.BorderRadius = 35;
            this.btnSiparisGuncelle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisGuncelle.onHoverState.BorderThickness = 1;
            this.btnSiparisGuncelle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSiparisGuncelle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSiparisGuncelle.onHoverState.IconLeftImage = null;
            this.btnSiparisGuncelle.onHoverState.IconRightImage = null;
            this.btnSiparisGuncelle.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSiparisGuncelle.OnIdleState.BorderRadius = 35;
            this.btnSiparisGuncelle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisGuncelle.OnIdleState.BorderThickness = 1;
            this.btnSiparisGuncelle.OnIdleState.FillColor = System.Drawing.Color.DarkKhaki;
            this.btnSiparisGuncelle.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisGuncelle.OnIdleState.IconLeftImage = null;
            this.btnSiparisGuncelle.OnIdleState.IconRightImage = null;
            this.btnSiparisGuncelle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSiparisGuncelle.OnPressedState.BorderRadius = 35;
            this.btnSiparisGuncelle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisGuncelle.OnPressedState.BorderThickness = 1;
            this.btnSiparisGuncelle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSiparisGuncelle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSiparisGuncelle.OnPressedState.IconLeftImage = null;
            this.btnSiparisGuncelle.OnPressedState.IconRightImage = null;
            this.btnSiparisGuncelle.Size = new System.Drawing.Size(160, 71);
            this.btnSiparisGuncelle.TabIndex = 13;
            this.btnSiparisGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSiparisGuncelle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSiparisGuncelle.TextMarginLeft = 0;
            this.btnSiparisGuncelle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSiparisGuncelle.UseDefaultRadiusAndThickness = true;
            this.btnSiparisGuncelle.Click += new System.EventHandler(this.btnSiparisGuncelle_Click);
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.AllowAnimations = true;
            this.btnSiparisSil.AllowMouseEffects = true;
            this.btnSiparisSil.AllowToggling = false;
            this.btnSiparisSil.AnimationSpeed = 200;
            this.btnSiparisSil.AutoGenerateColors = false;
            this.btnSiparisSil.AutoRoundBorders = false;
            this.btnSiparisSil.AutoSizeLeftIcon = true;
            this.btnSiparisSil.AutoSizeRightIcon = true;
            this.btnSiparisSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSiparisSil.BackColor1 = System.Drawing.Color.Crimson;
            this.btnSiparisSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiparisSil.BackgroundImage")));
            this.btnSiparisSil.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisSil.ButtonText = "Sipariş Sil";
            this.btnSiparisSil.ButtonTextMarginLeft = 0;
            this.btnSiparisSil.ColorContrastOnClick = 45;
            this.btnSiparisSil.ColorContrastOnHover = 45;
            this.btnSiparisSil.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSiparisSil.CustomizableEdges = borderEdges3;
            this.btnSiparisSil.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSiparisSil.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSiparisSil.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSiparisSil.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSiparisSil.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSiparisSil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisSil.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisSil.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiparisSil.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSiparisSil.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSiparisSil.IconMarginLeft = 11;
            this.btnSiparisSil.IconPadding = 10;
            this.btnSiparisSil.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiparisSil.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSiparisSil.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSiparisSil.IconSize = 25;
            this.btnSiparisSil.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSiparisSil.IdleBorderRadius = 35;
            this.btnSiparisSil.IdleBorderThickness = 1;
            this.btnSiparisSil.IdleFillColor = System.Drawing.Color.Crimson;
            this.btnSiparisSil.IdleIconLeftImage = null;
            this.btnSiparisSil.IdleIconRightImage = null;
            this.btnSiparisSil.IndicateFocus = false;
            this.btnSiparisSil.Location = new System.Drawing.Point(346, 460);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSiparisSil.OnDisabledState.BorderRadius = 35;
            this.btnSiparisSil.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisSil.OnDisabledState.BorderThickness = 1;
            this.btnSiparisSil.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSiparisSil.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSiparisSil.OnDisabledState.IconLeftImage = null;
            this.btnSiparisSil.OnDisabledState.IconRightImage = null;
            this.btnSiparisSil.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSiparisSil.onHoverState.BorderRadius = 35;
            this.btnSiparisSil.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisSil.onHoverState.BorderThickness = 1;
            this.btnSiparisSil.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSiparisSil.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSiparisSil.onHoverState.IconLeftImage = null;
            this.btnSiparisSil.onHoverState.IconRightImage = null;
            this.btnSiparisSil.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSiparisSil.OnIdleState.BorderRadius = 35;
            this.btnSiparisSil.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisSil.OnIdleState.BorderThickness = 1;
            this.btnSiparisSil.OnIdleState.FillColor = System.Drawing.Color.Crimson;
            this.btnSiparisSil.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisSil.OnIdleState.IconLeftImage = null;
            this.btnSiparisSil.OnIdleState.IconRightImage = null;
            this.btnSiparisSil.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSiparisSil.OnPressedState.BorderRadius = 35;
            this.btnSiparisSil.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisSil.OnPressedState.BorderThickness = 1;
            this.btnSiparisSil.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSiparisSil.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSiparisSil.OnPressedState.IconLeftImage = null;
            this.btnSiparisSil.OnPressedState.IconRightImage = null;
            this.btnSiparisSil.Size = new System.Drawing.Size(160, 71);
            this.btnSiparisSil.TabIndex = 12;
            this.btnSiparisSil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSiparisSil.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSiparisSil.TextMarginLeft = 0;
            this.btnSiparisSil.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSiparisSil.UseDefaultRadiusAndThickness = true;
            this.btnSiparisSil.Click += new System.EventHandler(this.btnSiparisSil_Click);
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.AllowAnimations = true;
            this.btnSiparisEkle.AllowMouseEffects = true;
            this.btnSiparisEkle.AllowToggling = false;
            this.btnSiparisEkle.AnimationSpeed = 200;
            this.btnSiparisEkle.AutoGenerateColors = false;
            this.btnSiparisEkle.AutoRoundBorders = false;
            this.btnSiparisEkle.AutoSizeLeftIcon = true;
            this.btnSiparisEkle.AutoSizeRightIcon = true;
            this.btnSiparisEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnSiparisEkle.BackColor1 = System.Drawing.Color.SpringGreen;
            this.btnSiparisEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiparisEkle.BackgroundImage")));
            this.btnSiparisEkle.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisEkle.ButtonText = "Sipariş Oluştur";
            this.btnSiparisEkle.ButtonTextMarginLeft = 0;
            this.btnSiparisEkle.ColorContrastOnClick = 45;
            this.btnSiparisEkle.ColorContrastOnHover = 45;
            this.btnSiparisEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnSiparisEkle.CustomizableEdges = borderEdges4;
            this.btnSiparisEkle.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSiparisEkle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSiparisEkle.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSiparisEkle.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSiparisEkle.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSiparisEkle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisEkle.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisEkle.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiparisEkle.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisEkle.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSiparisEkle.IconMarginLeft = 11;
            this.btnSiparisEkle.IconPadding = 10;
            this.btnSiparisEkle.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiparisEkle.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisEkle.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSiparisEkle.IconSize = 25;
            this.btnSiparisEkle.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSiparisEkle.IdleBorderRadius = 35;
            this.btnSiparisEkle.IdleBorderThickness = 1;
            this.btnSiparisEkle.IdleFillColor = System.Drawing.Color.SpringGreen;
            this.btnSiparisEkle.IdleIconLeftImage = null;
            this.btnSiparisEkle.IdleIconRightImage = null;
            this.btnSiparisEkle.IndicateFocus = false;
            this.btnSiparisEkle.Location = new System.Drawing.Point(63, 460);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSiparisEkle.OnDisabledState.BorderRadius = 35;
            this.btnSiparisEkle.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisEkle.OnDisabledState.BorderThickness = 1;
            this.btnSiparisEkle.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSiparisEkle.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSiparisEkle.OnDisabledState.IconLeftImage = null;
            this.btnSiparisEkle.OnDisabledState.IconRightImage = null;
            this.btnSiparisEkle.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSiparisEkle.onHoverState.BorderRadius = 35;
            this.btnSiparisEkle.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisEkle.onHoverState.BorderThickness = 1;
            this.btnSiparisEkle.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSiparisEkle.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSiparisEkle.onHoverState.IconLeftImage = null;
            this.btnSiparisEkle.onHoverState.IconRightImage = null;
            this.btnSiparisEkle.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSiparisEkle.OnIdleState.BorderRadius = 35;
            this.btnSiparisEkle.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisEkle.OnIdleState.BorderThickness = 1;
            this.btnSiparisEkle.OnIdleState.FillColor = System.Drawing.Color.SpringGreen;
            this.btnSiparisEkle.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisEkle.OnIdleState.IconLeftImage = null;
            this.btnSiparisEkle.OnIdleState.IconRightImage = null;
            this.btnSiparisEkle.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSiparisEkle.OnPressedState.BorderRadius = 35;
            this.btnSiparisEkle.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisEkle.OnPressedState.BorderThickness = 1;
            this.btnSiparisEkle.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSiparisEkle.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSiparisEkle.OnPressedState.IconLeftImage = null;
            this.btnSiparisEkle.OnPressedState.IconRightImage = null;
            this.btnSiparisEkle.Size = new System.Drawing.Size(160, 71);
            this.btnSiparisEkle.TabIndex = 11;
            this.btnSiparisEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSiparisEkle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSiparisEkle.TextMarginLeft = 0;
            this.btnSiparisEkle.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSiparisEkle.UseDefaultRadiusAndThickness = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // btnSiparisOnayla
            // 
            this.btnSiparisOnayla.AllowAnimations = true;
            this.btnSiparisOnayla.AllowMouseEffects = true;
            this.btnSiparisOnayla.AllowToggling = false;
            this.btnSiparisOnayla.AnimationSpeed = 200;
            this.btnSiparisOnayla.AutoGenerateColors = false;
            this.btnSiparisOnayla.AutoRoundBorders = false;
            this.btnSiparisOnayla.AutoSizeLeftIcon = true;
            this.btnSiparisOnayla.AutoSizeRightIcon = true;
            this.btnSiparisOnayla.BackColor = System.Drawing.Color.Transparent;
            this.btnSiparisOnayla.BackColor1 = System.Drawing.Color.Cyan;
            this.btnSiparisOnayla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiparisOnayla.BackgroundImage")));
            this.btnSiparisOnayla.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisOnayla.ButtonText = "Sipariş Onayla";
            this.btnSiparisOnayla.ButtonTextMarginLeft = 0;
            this.btnSiparisOnayla.ColorContrastOnClick = 45;
            this.btnSiparisOnayla.ColorContrastOnHover = 45;
            this.btnSiparisOnayla.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnSiparisOnayla.CustomizableEdges = borderEdges5;
            this.btnSiparisOnayla.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSiparisOnayla.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSiparisOnayla.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSiparisOnayla.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSiparisOnayla.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSiparisOnayla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisOnayla.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisOnayla.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiparisOnayla.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisOnayla.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSiparisOnayla.IconMarginLeft = 11;
            this.btnSiparisOnayla.IconPadding = 10;
            this.btnSiparisOnayla.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiparisOnayla.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiparisOnayla.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSiparisOnayla.IconSize = 25;
            this.btnSiparisOnayla.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSiparisOnayla.IdleBorderRadius = 35;
            this.btnSiparisOnayla.IdleBorderThickness = 1;
            this.btnSiparisOnayla.IdleFillColor = System.Drawing.Color.Cyan;
            this.btnSiparisOnayla.IdleIconLeftImage = null;
            this.btnSiparisOnayla.IdleIconRightImage = null;
            this.btnSiparisOnayla.IndicateFocus = false;
            this.btnSiparisOnayla.Location = new System.Drawing.Point(507, 581);
            this.btnSiparisOnayla.Name = "btnSiparisOnayla";
            this.btnSiparisOnayla.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSiparisOnayla.OnDisabledState.BorderRadius = 35;
            this.btnSiparisOnayla.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisOnayla.OnDisabledState.BorderThickness = 1;
            this.btnSiparisOnayla.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSiparisOnayla.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSiparisOnayla.OnDisabledState.IconLeftImage = null;
            this.btnSiparisOnayla.OnDisabledState.IconRightImage = null;
            this.btnSiparisOnayla.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSiparisOnayla.onHoverState.BorderRadius = 35;
            this.btnSiparisOnayla.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisOnayla.onHoverState.BorderThickness = 1;
            this.btnSiparisOnayla.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSiparisOnayla.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSiparisOnayla.onHoverState.IconLeftImage = null;
            this.btnSiparisOnayla.onHoverState.IconRightImage = null;
            this.btnSiparisOnayla.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSiparisOnayla.OnIdleState.BorderRadius = 35;
            this.btnSiparisOnayla.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisOnayla.OnIdleState.BorderThickness = 1;
            this.btnSiparisOnayla.OnIdleState.FillColor = System.Drawing.Color.Cyan;
            this.btnSiparisOnayla.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSiparisOnayla.OnIdleState.IconLeftImage = null;
            this.btnSiparisOnayla.OnIdleState.IconRightImage = null;
            this.btnSiparisOnayla.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSiparisOnayla.OnPressedState.BorderRadius = 35;
            this.btnSiparisOnayla.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiparisOnayla.OnPressedState.BorderThickness = 1;
            this.btnSiparisOnayla.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSiparisOnayla.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSiparisOnayla.OnPressedState.IconLeftImage = null;
            this.btnSiparisOnayla.OnPressedState.IconRightImage = null;
            this.btnSiparisOnayla.Size = new System.Drawing.Size(160, 71);
            this.btnSiparisOnayla.TabIndex = 15;
            this.btnSiparisOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSiparisOnayla.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSiparisOnayla.TextMarginLeft = 0;
            this.btnSiparisOnayla.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSiparisOnayla.UseDefaultRadiusAndThickness = true;
            this.btnSiparisOnayla.Click += new System.EventHandler(this.btnSiparisOnayla_Click);
            // 
          
            // Siparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1192, 684);
            this.Controls.Add(this.btnSiparisOnayla);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnSiparisGuncelle);
            this.Controls.Add(this.btnSiparisSil);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.bunifuDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Siparisler";
            this.Text = "Siparisler";
            this.Load += new System.EventHandler(this.Siparisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSiparisGuncelle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSiparisSil;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSiparisEkle;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnRapor;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siparisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamTutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSiparisOnayla;
        
      
    }
}