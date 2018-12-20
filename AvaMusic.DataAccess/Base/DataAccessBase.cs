using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaMusic.DataAccess.Base
{

    public class DataAccessBase
	{

		public string ConnectionString
		{
			//string conection = ConfigurationManager.ConnectionStrings["ChinookConnection"].ConnectionString;

			get { return ConfigurationManager.ConnectionStrings["ChinookConnection"].ConnectionString;; }

		}
	}

}

