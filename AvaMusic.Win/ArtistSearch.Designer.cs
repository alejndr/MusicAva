namespace AvaMusic.Win
{
	partial class ArtistSearch
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txbName = new System.Windows.Forms.TextBox();
			this.txbID = new System.Windows.Forms.TextBox();
			this.rdbName = new System.Windows.Forms.RadioButton();
			this.rdbID = new System.Windows.Forms.RadioButton();
			this.lblArtist = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboAlbum = new System.Windows.Forms.ComboBox();
			this.grdTrackList = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTrackList)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.txbName);
			this.groupBox1.Controls.Add(this.txbID);
			this.groupBox1.Controls.Add(this.rdbName);
			this.groupBox1.Controls.Add(this.rdbID);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(32, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(622, 176);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Buscar artista por:";
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(491, 60);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(93, 62);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Buscar";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txbName
			// 
			this.txbName.Location = new System.Drawing.Point(186, 100);
			this.txbName.Name = "txbName";
			this.txbName.Size = new System.Drawing.Size(262, 22);
			this.txbName.TabIndex = 3;
			this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
			// 
			// txbID
			// 
			this.txbID.Location = new System.Drawing.Point(186, 60);
			this.txbID.Name = "txbID";
			this.txbID.Size = new System.Drawing.Size(262, 22);
			this.txbID.TabIndex = 2;
			this.txbID.TextChanged += new System.EventHandler(this.txbID_TextChanged);
			// 
			// rdbName
			// 
			this.rdbName.AutoSize = true;
			this.rdbName.Location = new System.Drawing.Point(25, 101);
			this.rdbName.Name = "rdbName";
			this.rdbName.Size = new System.Drawing.Size(85, 21);
			this.rdbName.TabIndex = 1;
			this.rdbName.TabStop = true;
			this.rdbName.Text = "Nombre";
			this.rdbName.UseVisualStyleBackColor = true;
			this.rdbName.CheckedChanged += new System.EventHandler(this.rdbName_CheckedChanged);
			// 
			// rdbID
			// 
			this.rdbID.AutoSize = true;
			this.rdbID.Location = new System.Drawing.Point(25, 61);
			this.rdbID.Name = "rdbID";
			this.rdbID.Size = new System.Drawing.Size(44, 21);
			this.rdbID.TabIndex = 0;
			this.rdbID.TabStop = true;
			this.rdbID.Text = "ID";
			this.rdbID.UseVisualStyleBackColor = true;
			this.rdbID.CheckedChanged += new System.EventHandler(this.rdbID_CheckedChanged);
			// 
			// lblArtist
			// 
			this.lblArtist.AutoSize = true;
			this.lblArtist.Location = new System.Drawing.Point(57, 235);
			this.lblArtist.Name = "lblArtist";
			this.lblArtist.Size = new System.Drawing.Size(52, 17);
			this.lblArtist.TabIndex = 1;
			this.lblArtist.Text = "Artista:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 267);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Seleccione album:";
			// 
			// comboAlbum
			// 
			this.comboAlbum.FormattingEnabled = true;
			this.comboAlbum.Location = new System.Drawing.Point(218, 264);
			this.comboAlbum.Name = "comboAlbum";
			this.comboAlbum.Size = new System.Drawing.Size(314, 24);
			this.comboAlbum.TabIndex = 3;
			this.comboAlbum.SelectedIndexChanged += new System.EventHandler(this.comboAlbum_SelectedIndexChanged);
			// 
			// grdTrackList
			// 
			this.grdTrackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTrackList.Location = new System.Drawing.Point(32, 310);
			this.grdTrackList.Name = "grdTrackList";
			this.grdTrackList.RowTemplate.Height = 24;
			this.grdTrackList.Size = new System.Drawing.Size(622, 226);
			this.grdTrackList.TabIndex = 4;
			// 
			// ArtistSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 565);
			this.Controls.Add(this.grdTrackList);
			this.Controls.Add(this.comboAlbum);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblArtist);
			this.Controls.Add(this.groupBox1);
			this.Name = "ArtistSearch";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.ArtistSearch_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTrackList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txbName;
		private System.Windows.Forms.TextBox txbID;
		private System.Windows.Forms.RadioButton rdbName;
		private System.Windows.Forms.RadioButton rdbID;
		private System.Windows.Forms.Label lblArtist;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboAlbum;
		private System.Windows.Forms.DataGridView grdTrackList;
	}
}

