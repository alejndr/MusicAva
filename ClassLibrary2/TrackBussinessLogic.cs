using AvaMusic.DataAccess;
using AvaMusic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaMusic.BussinessLogic
{
	public class TrackBussinessLogic
	{
		#region Global variables

		private TrackDataAccess _trackDataAccess;

		#endregion Global variables

		#region Constructor

		public TrackBussinessLogic()
		{
			_trackDataAccess = new TrackDataAccess();
		}

		#endregion Constructor

		#region Public methods

		public List<Track> GetTracks(int TrackID)
		{
			return _trackDataAccess.GetTracks(TrackID);
		}

		#endregion Public methods

	}
}
