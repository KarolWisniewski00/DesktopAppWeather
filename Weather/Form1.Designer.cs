namespace Weather
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.tableLayoutInfo = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutInfo1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDegree = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelMain = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelWeek = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelWindDegree = new System.Windows.Forms.Label();
            this.labelVisibility = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.labelVisibilityValue = new System.Windows.Forms.Label();
            this.labelWindSpeedValue = new System.Windows.Forms.Label();
            this.labelWindDegreeValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelFeelLike = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelFeelLikeValue = new System.Windows.Forms.Label();
            this.labelPressureValue = new System.Windows.Forms.Label();
            this.labelHumidityValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelLoc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutInfo.SuspendLayout();
            this.tableLayoutInfo1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Controls.Add(this.buttonSettings, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutInfo, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(804, 450);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.Location = new System.Drawing.Point(769, 5);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(30, 30);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.UseVisualStyleBackColor = false;
            // 
            // tableLayoutInfo
            // 
            this.tableLayoutInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tableLayoutInfo.ColumnCount = 1;
            this.tableLayoutInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutInfo.Controls.Add(this.tableLayoutInfo1, 0, 1);
            this.tableLayoutInfo.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutInfo.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutInfo.Location = new System.Drawing.Point(110, 45);
            this.tableLayoutInfo.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.tableLayoutInfo.Name = "tableLayoutInfo";
            this.tableLayoutInfo.RowCount = 3;
            this.tableLayoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutInfo.Size = new System.Drawing.Size(583, 360);
            this.tableLayoutInfo.TabIndex = 1;
            // 
            // tableLayoutInfo1
            // 
            this.tableLayoutInfo1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutInfo1.ColumnCount = 2;
            this.tableLayoutInfo1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutInfo1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutInfo1.Controls.Add(this.labelDegree, 0, 0);
            this.tableLayoutInfo1.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutInfo1.Location = new System.Drawing.Point(0, 79);
            this.tableLayoutInfo1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutInfo1.Name = "tableLayoutInfo1";
            this.tableLayoutInfo1.RowCount = 1;
            this.tableLayoutInfo1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutInfo1.Size = new System.Drawing.Size(583, 200);
            this.tableLayoutInfo1.TabIndex = 1;
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.BackColor = System.Drawing.Color.Transparent;
            this.labelDegree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDegree.ForeColor = System.Drawing.Color.White;
            this.labelDegree.Location = new System.Drawing.Point(3, 0);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(285, 200);
            this.labelDegree.TabIndex = 1;
            this.labelDegree.Text = "16°C";
            this.labelDegree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.labelDescription, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.labelMain, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(294, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(286, 194);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.labelDescription.Location = new System.Drawing.Point(0, 164);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(286, 30);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.BackColor = System.Drawing.Color.Transparent;
            this.labelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMain.ForeColor = System.Drawing.Color.White;
            this.labelMain.Location = new System.Drawing.Point(0, 134);
            this.labelMain.Margin = new System.Windows.Forms.Padding(0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(286, 30);
            this.labelMain.TabIndex = 2;
            this.labelMain.Text = "Main";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(280, 128);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelWeek, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(583, 79);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(291, 0);
            this.labelTime.Margin = new System.Windows.Forms.Padding(0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.labelTime.Size = new System.Drawing.Size(292, 79);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "16:57";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.labelWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(39)))));
            this.labelWeek.Location = new System.Drawing.Point(0, 0);
            this.labelWeek.Margin = new System.Windows.Forms.Padding(0);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.labelWeek.Size = new System.Drawing.Size(291, 79);
            this.labelWeek.TabIndex = 0;
            this.labelWeek.Text = "Monday";
            this.labelWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 282);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(577, 75);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.labelWindDegree, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.labelVisibility, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelWindSpeed, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelVisibilityValue, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelWindSpeedValue, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelWindDegreeValue, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(291, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(283, 69);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // labelWindDegree
            // 
            this.labelWindDegree.AutoSize = true;
            this.labelWindDegree.BackColor = System.Drawing.Color.Transparent;
            this.labelWindDegree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWindDegree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.labelWindDegree.Location = new System.Drawing.Point(0, 45);
            this.labelWindDegree.Margin = new System.Windows.Forms.Padding(0);
            this.labelWindDegree.Name = "labelWindDegree";
            this.labelWindDegree.Size = new System.Drawing.Size(141, 24);
            this.labelWindDegree.TabIndex = 3;
            this.labelWindDegree.Text = "Wind Degree";
            this.labelWindDegree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVisibility
            // 
            this.labelVisibility.AutoSize = true;
            this.labelVisibility.BackColor = System.Drawing.Color.Transparent;
            this.labelVisibility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisibility.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.labelVisibility.Location = new System.Drawing.Point(0, 0);
            this.labelVisibility.Margin = new System.Windows.Forms.Padding(0);
            this.labelVisibility.Name = "labelVisibility";
            this.labelVisibility.Size = new System.Drawing.Size(141, 22);
            this.labelVisibility.TabIndex = 1;
            this.labelVisibility.Text = "Visibility";
            this.labelVisibility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelWindSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWindSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.labelWindSpeed.Location = new System.Drawing.Point(0, 22);
            this.labelWindSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(141, 23);
            this.labelWindSpeed.TabIndex = 2;
            this.labelWindSpeed.Text = "Wind speed";
            this.labelWindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVisibilityValue
            // 
            this.labelVisibilityValue.AutoSize = true;
            this.labelVisibilityValue.BackColor = System.Drawing.Color.Transparent;
            this.labelVisibilityValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVisibilityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVisibilityValue.ForeColor = System.Drawing.Color.White;
            this.labelVisibilityValue.Location = new System.Drawing.Point(141, 0);
            this.labelVisibilityValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelVisibilityValue.Name = "labelVisibilityValue";
            this.labelVisibilityValue.Size = new System.Drawing.Size(142, 22);
            this.labelVisibilityValue.TabIndex = 4;
            this.labelVisibilityValue.Text = "1000m";
            this.labelVisibilityValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWindSpeedValue
            // 
            this.labelWindSpeedValue.AutoSize = true;
            this.labelWindSpeedValue.BackColor = System.Drawing.Color.Transparent;
            this.labelWindSpeedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWindSpeedValue.ForeColor = System.Drawing.Color.White;
            this.labelWindSpeedValue.Location = new System.Drawing.Point(141, 22);
            this.labelWindSpeedValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelWindSpeedValue.Name = "labelWindSpeedValue";
            this.labelWindSpeedValue.Size = new System.Drawing.Size(142, 23);
            this.labelWindSpeedValue.TabIndex = 5;
            this.labelWindSpeedValue.Text = "15m/s";
            this.labelWindSpeedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWindDegreeValue
            // 
            this.labelWindDegreeValue.AutoSize = true;
            this.labelWindDegreeValue.BackColor = System.Drawing.Color.Transparent;
            this.labelWindDegreeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWindDegreeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWindDegreeValue.ForeColor = System.Drawing.Color.White;
            this.labelWindDegreeValue.Location = new System.Drawing.Point(141, 45);
            this.labelWindDegreeValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelWindDegreeValue.Name = "labelWindDegreeValue";
            this.labelWindDegreeValue.Size = new System.Drawing.Size(142, 24);
            this.labelWindDegreeValue.TabIndex = 6;
            this.labelWindDegreeValue.Text = "SW";
            this.labelWindDegreeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.labelFeelLike, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelPressure, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelHumidity, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelFeelLikeValue, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelPressureValue, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelHumidityValue, 1, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(282, 69);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // labelFeelLike
            // 
            this.labelFeelLike.AutoSize = true;
            this.labelFeelLike.BackColor = System.Drawing.Color.Transparent;
            this.labelFeelLike.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFeelLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFeelLike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.labelFeelLike.Location = new System.Drawing.Point(0, 0);
            this.labelFeelLike.Margin = new System.Windows.Forms.Padding(0);
            this.labelFeelLike.Name = "labelFeelLike";
            this.labelFeelLike.Size = new System.Drawing.Size(141, 22);
            this.labelFeelLike.TabIndex = 0;
            this.labelFeelLike.Text = "Feel like";
            this.labelFeelLike.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.BackColor = System.Drawing.Color.Transparent;
            this.labelPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPressure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.labelPressure.Location = new System.Drawing.Point(0, 22);
            this.labelPressure.Margin = new System.Windows.Forms.Padding(0);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(141, 23);
            this.labelPressure.TabIndex = 1;
            this.labelPressure.Text = "Pressure";
            this.labelPressure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.labelHumidity.Location = new System.Drawing.Point(0, 45);
            this.labelHumidity.Margin = new System.Windows.Forms.Padding(0);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(141, 24);
            this.labelHumidity.TabIndex = 2;
            this.labelHumidity.Text = "Humidity";
            this.labelHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFeelLikeValue
            // 
            this.labelFeelLikeValue.AutoSize = true;
            this.labelFeelLikeValue.BackColor = System.Drawing.Color.Transparent;
            this.labelFeelLikeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFeelLikeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFeelLikeValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(39)))));
            this.labelFeelLikeValue.Location = new System.Drawing.Point(141, 0);
            this.labelFeelLikeValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelFeelLikeValue.Name = "labelFeelLikeValue";
            this.labelFeelLikeValue.Size = new System.Drawing.Size(141, 22);
            this.labelFeelLikeValue.TabIndex = 3;
            this.labelFeelLikeValue.Text = "16°C";
            this.labelFeelLikeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPressureValue
            // 
            this.labelPressureValue.AutoSize = true;
            this.labelPressureValue.BackColor = System.Drawing.Color.Transparent;
            this.labelPressureValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPressureValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPressureValue.ForeColor = System.Drawing.Color.White;
            this.labelPressureValue.Location = new System.Drawing.Point(141, 22);
            this.labelPressureValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelPressureValue.Name = "labelPressureValue";
            this.labelPressureValue.Size = new System.Drawing.Size(141, 23);
            this.labelPressureValue.TabIndex = 4;
            this.labelPressureValue.Text = "100hPa";
            this.labelPressureValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHumidityValue
            // 
            this.labelHumidityValue.AutoSize = true;
            this.labelHumidityValue.BackColor = System.Drawing.Color.Transparent;
            this.labelHumidityValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHumidityValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHumidityValue.ForeColor = System.Drawing.Color.White;
            this.labelHumidityValue.Location = new System.Drawing.Point(141, 45);
            this.labelHumidityValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelHumidityValue.Name = "labelHumidityValue";
            this.labelHumidityValue.Size = new System.Drawing.Size(141, 24);
            this.labelHumidityValue.TabIndex = 5;
            this.labelHumidityValue.Text = "2%";
            this.labelHumidityValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelLoc, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(110, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(583, 39);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // labelLoc
            // 
            this.labelLoc.AutoSize = true;
            this.labelLoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoc.ForeColor = System.Drawing.Color.White;
            this.labelLoc.Location = new System.Drawing.Point(33, 0);
            this.labelLoc.Name = "labelLoc";
            this.labelLoc.Size = new System.Drawing.Size(547, 39);
            this.labelLoc.TabIndex = 1;
            this.labelLoc.Text = "Warsaw, Poland";
            this.labelLoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(110, 405);
            this.label5.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(613, 45);
            this.label5.TabIndex = 3;
            this.label5.Text = "Created by Karol Wiśniewski";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.tableLayoutPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MinimumSize = new System.Drawing.Size(820, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutInfo.ResumeLayout(false);
            this.tableLayoutInfo1.ResumeLayout(false);
            this.tableLayoutInfo1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutInfo1;
        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelLoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelWindDegree;
        private System.Windows.Forms.Label labelVisibility;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.Label labelFeelLike;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelVisibilityValue;
        private System.Windows.Forms.Label labelWindSpeedValue;
        private System.Windows.Forms.Label labelWindDegreeValue;
        private System.Windows.Forms.Label labelFeelLikeValue;
        private System.Windows.Forms.Label labelPressureValue;
        private System.Windows.Forms.Label labelHumidityValue;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

