using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaMusic.Entities
{	
	/// <summary>
	/// Artist data.
	/// </summary>
	public class Artist 
	{
		public int ID { get; set; }

		public string Name { get; set; }

		public List<Album> Albums { get; set; }

		public Artist()
		{
			this.Albums = new List<Album>();
		}

	}
}
