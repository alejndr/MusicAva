using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaMusic.DataAccess.Base;
using AvaMusic.Entities;

namespace AvaMusic.DataAccess
{
	public class ArtistDataAccess : DataAccessBase
	{
		#region Public methods

		/// <summary>
		/// Get artist data given his ID.
		/// </summary>
		/// <param name="ArtistID"></param>
		/// <returns></returns>
		public Artist GetArtistByID(int ArtistID)
		{
			Artist artistData = new Artist();
			
			SqlConnection conn = new SqlConnection(base.ConnectionString);

			SqlDataReader reader = null;

			try
			{
				// Open connection
				conn.Open();

				//Set query
				StringBuilder query = new StringBuilder();

				query.Append("select ArtistID, ArtistName, AlbumID, AlbumName from ArtistAlbumTrack "); 
				query.Append("where ArtistID = @ArtistID ");
				query.Append("order by ArtistID ");

				// Init command
				SqlCommand cmd = new SqlCommand(query.ToString(), conn);

				SqlParameter paramId = new SqlParameter("@ArtistID", ArtistID);
				cmd.Parameters.Add(paramId);

				// Execute
				reader = cmd.ExecuteReader();

				// Read
				if (reader.Read())
				{

					artistData.ID = Convert.ToInt32(reader["ArtistID"]);
					artistData.Name = reader["ArtistName"].ToString();


					int repeatedAlbumCheck = 0;
					// Populate Artist.Albums<Album>
					while (reader.Read())
					{
						Album albumData = new Album();
						albumData.ID = Convert.ToInt32(reader["AlbumID"]);
						albumData.Name = reader["AlbumName"].ToString();

						
						// Check to not insert repeated albums given by the query.
						if (albumData.ID != repeatedAlbumCheck)
						{
							artistData.Albums.Add(albumData);
							repeatedAlbumCheck = albumData.ID;
						}
						
					}
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

			return artistData;
		}

		/// <summary>
		/// Get artist data given his name.
		/// </summary>
		/// <param name="ArtistName"></param>
		/// <returns></returns>
		public Artist GetArtistByName(string ArtistName)
		{
			Artist artistData = new Artist();
			
			SqlConnection conn = new SqlConnection(base.ConnectionString);

			SqlDataReader reader = null;

			try
			{
				// Open connection
				conn.Open();

				//Set query
				StringBuilder query = new StringBuilder();

				query.Append("select ArtistID, ArtistName, AlbumID, AlbumName from ArtistAlbumTrack ");
				query.Append("where ArtistName like @ArtistName ");
				query.Append("order by ArtistID ");

				// Init command
				SqlCommand cmd = new SqlCommand(query.ToString(), conn);

				SqlParameter paramId = new SqlParameter("@ArtistName", ArtistName);
				cmd.Parameters.Add(paramId);

				// Execute
				reader = cmd.ExecuteReader();

				// Read
				if (reader.Read())
				{

					artistData.ID = Convert.ToInt32(reader["ArtistID"]);
					artistData.Name = reader["ArtistName"].ToString();


					int repeatedAlbumCheck = 0;
					// Populate Artist.Albums<Album>
					while (reader.Read())
					{
						Album albumData = new Album();
						albumData.ID = Convert.ToInt32(reader["AlbumID"]);
						albumData.Name = reader["AlbumName"].ToString();


						// Check to not insert repeated albums given by the query.
						if (albumData.ID != repeatedAlbumCheck)
						{
							artistData.Albums.Add(albumData);
							repeatedAlbumCheck = albumData.ID;
						}

					}
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

			return artistData;
		}

		#endregion Public methods

	}
}
