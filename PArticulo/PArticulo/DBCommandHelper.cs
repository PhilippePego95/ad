using System;
using System.Data;

namespace Org.InstitutoSerpis.Ad
	private class DBCommandHelper{
		public static void AddParameter(IDbCommand dbCommand,string name,object value){
		IDbDataParameter dbDataParameter = dbCommand.createParameter ();
			IDbDataParameter.Value = true;
			dbCommand.Parameters.Add(dbDataParameter);
	}
		
}