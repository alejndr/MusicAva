using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaMusic.DataAccess;
using AvaMusic.Entities;

namespace AvaMusic.BussinessLogic
{
	public class ArtistBussinessLogic
	{

		#region Global variables
		private ArtistDataAccess _artistDataAccess;

		#endregion Global variables

		#region constructor

		/// <summary>
		/// Constructor.
		/// </summary>
		public ArtistBussinessLogic()
		{
			_artistDataAccess = new ArtistDataAccess();
		}

		#endregion constructor

		#region Public methods

		public Artist GetArtistByID(int ArtistID)
		{
			return _artistDataAccess.GetArtistByID(ArtistID);
		}

		public Artist GetArtistByName(string ArtistName)
		{
			return _artistDataAccess.GetArtistByName(ArtistName);
		}


		#endregion Public methods

	}
}
