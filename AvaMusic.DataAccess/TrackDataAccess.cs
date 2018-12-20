using AvaMusic.DataAccess.Base;
using AvaMusic.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaMusic.DataAccess
{
	public class TrackDataAccess : DataAccessBase
	{
		#region Public methods

		/// <summary>
		/// Get a Track list given an album id. 
		/// </summary>
		/// <param name="AlbumID"></param>
		/// <returns></returns>
		public List<Track> GetTracks(int AlbumID)
		{
			List<Track> trackList = new List<Track>();

			SqlConnection conn = new SqlConnection(base.ConnectionString);

			SqlDataReader reader = null;

			try
			{
				// Open connection
				conn.Open();

				//Set query
				StringBuilder query = new StringBuilder();

				query.Append("select TrackID, TrackName from ArtistAlbumTrack ");
				query.Append("where AlbumID = @AlbumID ");
				
				// Init command
				SqlCommand cmd = new SqlCommand(query.ToString(), conn);

				SqlParameter paramId = new SqlParameter("@AlbumID", AlbumID);
				cmd.Parameters.Add(paramId);

				// Execute
				reader = cmd.ExecuteReader();

				// Read
				while (reader.Read())
				{
					Track actualTrack = new Track();

					actualTrack.ID = Convert.ToInt32(reader["TrackID"]);
					actualTrack.Name = reader["TrackName"].ToString();
					trackList.Add(actualTrack);
					
				}
			}
			catch
			{

				throw;
			}
			finally
			{
				// Close datareader
				if (reader != null)
				{
					reader.Close();
				}

				// Close connection
				if (conn != null)
				{
					conn.Close();
				}
			}

			return trackList;
		}

		#endregion Public methods

	}
}
