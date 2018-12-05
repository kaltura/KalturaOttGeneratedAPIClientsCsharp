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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class ChannelFilter : AssetFilter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string KSQL = "kSql";
		public const string EXCLUDE_WATCHED = "excludeWatched";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _KSql = null;
		private bool? _ExcludeWatched = null;
		#endregion

		#region Properties
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string KSql
		{
			get { return _KSql; }
			set 
			{ 
				_KSql = value;
				OnPropertyChanged("KSql");
			}
		}
		public bool? ExcludeWatched
		{
			get { return _ExcludeWatched; }
			set 
			{ 
				_ExcludeWatched = value;
				OnPropertyChanged("ExcludeWatched");
			}
		}
		#endregion

		#region CTor
		public ChannelFilter()
		{
		}

		public ChannelFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "kSql":
						this._KSql = propertyNode.InnerText;
						continue;
					case "excludeWatched":
						this._ExcludeWatched = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}

		public ChannelFilter(IDictionary<string,object> data) : base(data)
		{
			    this._IdEqual = data.TryGetValueSafe<int>("idEqual");
			    this._KSql = data.TryGetValueSafe<string>("kSql");
			    this._ExcludeWatched = data.TryGetValueSafe<bool>("excludeWatched");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaChannelFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("kSql", this._KSql);
			kparams.AddIfNotNull("excludeWatched", this._ExcludeWatched);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case KSQL:
					return "KSql";
				case EXCLUDE_WATCHED:
					return "ExcludeWatched";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

