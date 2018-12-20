namespace AvaMusic
{
	partial class frmArtistDetail
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
			this.txbID = new System.Windows.Forms.TextBox();
			this.txbName = new System.Windows.Forms.TextBox();
			this.rdbID = new System.Windows.Forms.RadioButton();
			this.rdbName = new System.Windows.Forms.RadioButton();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblArtist = new System.Windows.Forms.Label();
			this.lblSelectAlbum = new System.Windows.Forms.Label();
			this.comboAlbum = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnSearch);
			this.groupBox1.Controls.Add(this.rdbName);
			this.groupBox1.Controls.Add(this.rdbID);
			this.groupBox1.Controls.Add(this.txbName);
			this.groupBox1.Controls.Add(this.txbID);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(22, 26);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(407, 133);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Buscar artista por:";
			// 
			// txbID
			// 
			this.txbID.Location = new System.Drawing.Point(146, 41);
			this.txbID.Name = "txbID";
			this.txbID.Size = new System.Drawing.Size(100, 22);
			this.txbID.TabIndex = 0;
			// 
			// txbName
			// 
			this.txbName.Location = new System.Drawing.Point(146, 85);
			this.txbName.Name = "txbName";
			this.txbName.Size = new System.Drawing.Size(100, 22);
			this.txbName.TabIndex = 1;
			// 
			// rdbID
			// 
			this.rdbID.AutoSize = true;
			this.rdbID.Location = new System.Drawing.Point(19, 42);
			this.rdbID.Name = "rdbID";
			this.rdbID.Size = new System.Drawing.Size(44, 21);
			this.rdbID.TabIndex = 2;
			this.rdbID.TabStop = true;
			this.rdbID.Text = "ID";
			this.rdbID.UseVisualStyleBackColor = true;
			// 
			// rdbName
			// 
			this.rdbName.AutoSize = true;
			this.rdbName.Location = new System.Drawing.Point(19, 85);
			this.rdbName.Name = "rdbName";
			this.rdbName.Size = new System.Drawing.Size(85, 21);
			this.rdbName.TabIndex = 3;
			this.rdbName.TabStop = true;
			this.rdbName.Text = "Nombre";
			this.rdbName.UseVisualStyleBackColor = true;
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(288, 51);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 39);
			this.btnSearch.TabIndex = 4;
			this.btnSearch.Text = "Buscar";
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// lblArtist
			// 
			this.lblArtist.AutoSize = true;
			this.lblArtist.Location = new System.Drawing.Point(22, 193);
			this.lblArtist.Name = "lblArtist";
			this.lblArtist.Size = new System.Drawing.Size(52, 17);
			this.lblArtist.TabIndex = 1;
			this.lblArtist.Text = "Artista:";
			// 
			// lblSelectAlbum
			// 
			this.lblSelectAlbum.AutoSize = true;
			this.lblSelectAlbum.Location = new System.Drawing.Point(25, 229);
			this.lblSelectAlbum.Name = "lblSelectAlbum";
			this.lblSelectAlbum.Size = new System.Drawing.Size(123, 17);
			this.lblSelectAlbum.TabIndex = 2;
			this.lblSelectAlbum.Text = "Seleccione album:";
			// 
			// comboAlbum
			// 
			this.comboAlbum.FormattingEnabled = true;
			this.comboAlbum.Location = new System.Drawing.Point(168, 229);
			this.comboAlbum.Name = "comboAlbum";
			this.comboAlbum.Size = new System.Drawing.Size(217, 24);
			this.comboAlbum.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 464);
			this.Controls.Add(this.comboAlbum);
			this.Controls.Add(this.lblSelectAlbum);
			this.Controls.Add(this.lblArtist);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.RadioButton rdbName;
		private System.Windows.Forms.RadioButton rdbID;
		private System.Windows.Forms.TextBox txbName;
		private System.Windows.Forms.TextBox txbID;
		private System.Windows.Forms.Label lblArtist;
		private System.Windows.Forms.Label lblSelectAlbum;
		private System.Windows.Forms.ComboBox comboAlbum;
	}
}

