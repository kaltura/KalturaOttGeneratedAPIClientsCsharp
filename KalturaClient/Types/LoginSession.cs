// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2017  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class LoginSession : ObjectBase
	{
		#region Constants
		public const string KS = "ks";
		public const string REFRESH_TOKEN = "refreshToken";
		#endregion

		#region Private Fields
		private string _Ks = null;
		private string _RefreshToken = null;
		#endregion

		#region Properties
		public string Ks
		{
			get { return _Ks; }
			set 
			{ 
				_Ks = value;
				OnPropertyChanged("Ks");
			}
		}
		public string RefreshToken
		{
			get { return _RefreshToken; }
			set 
			{ 
				_RefreshToken = value;
				OnPropertyChanged("RefreshToken");
			}
		}
		#endregion

		#region CTor
		public LoginSession()
		{
		}

		public LoginSession(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "ks":
						this._Ks = propertyNode.InnerText;
						continue;
					case "refreshToken":
						this._RefreshToken = propertyNode.InnerText;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLoginSession");
			kparams.AddIfNotNull("ks", this._Ks);
			kparams.AddIfNotNull("refreshToken", this._RefreshToken);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KS:
					return "Ks";
				case REFRESH_TOKEN:
					return "RefreshToken";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

