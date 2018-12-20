using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AvaMusic.BussinessLogic;
using AvaMusic.Entities;

namespace AvaMusic.Win
{
	public partial class ArtistSearch : Form
	{
		#region Global variables


		#endregion Global variables

		#region Constructor

		public ArtistSearch()
		{
			InitializeComponent();
		}

		#endregion Constructor

		#region Events

		/// <summary>
		/// Load event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ArtistSearch_Load(object sender, EventArgs e)
		{
			InitializeForm();
		}

		/// <summary>
		/// ID radiobutton checked event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdbID_CheckedChanged(object sender, EventArgs e)
		{
			txbID.Enabled = true;
			txbName.Enabled = false;
			txbName.Text = "";
		}

		/// <summary>
		/// Name radio button checked event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rdbName_CheckedChanged(object sender, EventArgs e)
		{
			txbID.Enabled = false;
			txbName.Enabled = true;
			txbID.Text = "";
		}

		/// <summary>
		/// ID textbox changed event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txbID_TextChanged(object sender, EventArgs e)
		{
			btnSearch.Enabled = true;
			
		}

		/// <summary>
		/// Name textbox changed event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txbName_TextChanged(object sender, EventArgs e)
		{
			btnSearch.Enabled = true;
		}

		/// <summary>
		/// Search button click event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearch_Click(object sender, EventArgs e)
		{
			
			if (rdbID.Checked)
			{
				GetArtistByID();
			}
			else
			{
				GetArtistByName();
			}
		}

		/// <summary>
		/// Combo changed selected item event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void comboAlbum_SelectedIndexChanged(object sender, EventArgs e)
		{
			GetTracks();

		}

		#endregion Events

		#region Private methods

		/// <summary>
		/// Initialize Form.
		/// </summary>
		private void InitializeForm()
		{
			btnSearch.Enabled = false;
			txbID.Enabled = false;
			txbName.Enabled = false;
			InitializeGrid();
		}

		/// <summary>
		/// Get Artist object by ID.
		/// </summary>
		private void GetArtistByID()
		{
			ArtistBussinessLogic ArtistBL = new ArtistBussinessLogic();
			Artist artistData = new Artist();

			int artistID = Convert.ToInt32(txbID.Text);

			artistData = ArtistBL.GetArtistByID(artistID);

			FillName(artistData);
			populateCombo(artistData);
		}

		/// <summary>
		/// Get artist object by Name
		/// </summary>
		private void GetArtistByName()
		{
			ArtistBussinessLogic ArtistBL = new ArtistBussinessLogic();
			Artist artistData = new Artist();

			string artistName = txbName.Text;

			artistData = ArtistBL.GetArtistByName(artistName);

			FillID(artistData);
			populateCombo(artistData);
		}

		/// <summary>
		/// Get Track list.
		/// </summary>
		private void GetTracks()
		{
			TrackBussinessLogic TrackBL = new TrackBussinessLogic();
			List<Track> trackList = new List<Track>();

			int albumID = Convert.ToInt32(comboAlbum.SelectedValue);

			trackList = TrackBL.GetTracks(albumID);

			grdTrackList.DataSource = trackList;
			grdTrackList.ClearSelection();

		}

		/// <summary>
		/// Populate the combo with albums list in Artist object.
		/// </summary>
		/// <param name="artist"></param>
		private void populateCombo(Artist artist)
		{
			
			comboAlbum.DisplayMember = "Name";
			comboAlbum.ValueMember = "ID";
			comboAlbum.DataSource = artist.Albums;

			comboAlbum.DropDownStyle = ComboBoxStyle.DropDownList;

		}

		/// <summary>
		/// Initialize gridview.
		/// </summary>
		private void InitializeGrid()
		{

			DataGridViewColumn colTrackName = new DataGridViewTextBoxColumn()
			{
				DataPropertyName = "Name",
				Name = "colTrackName",
				HeaderText = "Song name",
				ValueType = typeof(string),
				Visible = true
			};
			
			grdTrackList.Columns.Add(colTrackName);

			// Set properties

			grdTrackList.AutoGenerateColumns = false;
			grdTrackList.ReadOnly = true;
			grdTrackList.MultiSelect = false;
			grdTrackList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			grdTrackList.RowHeadersVisible = false;
			grdTrackList.AllowUserToResizeRows = false;
			grdTrackList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			
		}

		/// <summary>
		/// Fill the name textbox with artist info.
		/// </summary>
		/// <param name="artist"></param>
		private void FillName(Artist artist)
		{
			txbName.Text = artist.Name;
		}

		/// <summary>
		/// Fill the ID textbox with artist info.
		/// </summary>
		/// <param name="artist"></param>
		private void FillID(Artist artist)
		{
			txbID.Text = artist.ID.ToString();
		}





		#endregion Private methods

		
	}


}
