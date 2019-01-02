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
	public class BaseSearchAssetFilter : AssetFilter
	{
		#region Constants
		public const string KSQL = "kSql";
		public const string GROUP_BY = "groupBy";
		public const string GROUP_ORDER_BY = "groupOrderBy";
		#endregion

		#region Private Fields
		private string _KSql = null;
		private IList<AssetGroupBy> _GroupBy;
		private GroupByOrder _GroupOrderBy = null;
		#endregion

		#region Properties
		public string KSql
		{
			get { return _KSql; }
			set 
			{ 
				_KSql = value;
				OnPropertyChanged("KSql");
			}
		}
		public IList<AssetGroupBy> GroupBy
		{
			get { return _GroupBy; }
			set 
			{ 
				_GroupBy = value;
				OnPropertyChanged("GroupBy");
			}
		}
		public GroupByOrder GroupOrderBy
		{
			get { return _GroupOrderBy; }
			set 
			{ 
				_GroupOrderBy = value;
				OnPropertyChanged("GroupOrderBy");
			}
		}
		#endregion

		#region CTor
		public BaseSearchAssetFilter()
		{
		}

		public BaseSearchAssetFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "kSql":
						this._KSql = propertyNode.InnerText;
						continue;
					case "groupBy":
						this._GroupBy = new List<AssetGroupBy>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._GroupBy.Add(ObjectFactory.Create<AssetGroupBy>(arrayNode));
						}
						continue;
					case "groupOrderBy":
						this._GroupOrderBy = (GroupByOrder)StringEnum.Parse(typeof(GroupByOrder), propertyNode.InnerText);
						continue;
				}
			}
		}

		public BaseSearchAssetFilter(IDictionary<string,object> data) : base(data)
		{
			    this._KSql = data.TryGetValueSafe<string>("kSql");
			    this._GroupBy = new List<AssetGroupBy>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("groupBy", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._GroupBy.Add(ObjectFactory.Create<AssetGroupBy>((IDictionary<string,object>)dataDictionary));
			    }
			    this._GroupOrderBy = (GroupByOrder)StringEnum.Parse(typeof(GroupByOrder), data.TryGetValueSafe<string>("groupOrderBy"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBaseSearchAssetFilter");
			kparams.AddIfNotNull("kSql", this._KSql);
			kparams.AddIfNotNull("groupBy", this._GroupBy);
			kparams.AddIfNotNull("groupOrderBy", this._GroupOrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KSQL:
					return "KSql";
				case GROUP_BY:
					return "GroupBy";
				case GROUP_ORDER_BY:
					return "GroupOrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

