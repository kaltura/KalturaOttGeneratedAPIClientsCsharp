// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class DeviceBrandFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string DEVICE_FAMILY_ID_EQUAL = "deviceFamilyIdEqual";
		public const string NAME_EQUAL = "nameEqual";
		public const string TYPE_EQUAL = "typeEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private long _IdEqual = long.MinValue;
		private long _DeviceFamilyIdEqual = long.MinValue;
		private string _NameEqual = null;
		private DeviceBrandType _TypeEqual = null;
		private DeviceBrandOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		/// <summary>
		/// Use DeviceFamilyIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long DeviceFamilyIdEqual
		{
			get { return _DeviceFamilyIdEqual; }
			set 
			{ 
				_DeviceFamilyIdEqual = value;
				OnPropertyChanged("DeviceFamilyIdEqual");
			}
		}
		/// <summary>
		/// Use NameEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string NameEqual
		{
			get { return _NameEqual; }
			set 
			{ 
				_NameEqual = value;
				OnPropertyChanged("NameEqual");
			}
		}
		/// <summary>
		/// Use TypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DeviceBrandType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new DeviceBrandOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public DeviceBrandFilter()
		{
		}

		public DeviceBrandFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseLong(node["idEqual"].Value<string>());
			}
			if(node["deviceFamilyIdEqual"] != null)
			{
				this._DeviceFamilyIdEqual = ParseLong(node["deviceFamilyIdEqual"].Value<string>());
			}
			if(node["nameEqual"] != null)
			{
				this._NameEqual = node["nameEqual"].Value<string>();
			}
			if(node["typeEqual"] != null)
			{
				this._TypeEqual = (DeviceBrandType)StringEnum.Parse(typeof(DeviceBrandType), node["typeEqual"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (DeviceBrandOrderBy)StringEnum.Parse(typeof(DeviceBrandOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDeviceBrandFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("deviceFamilyIdEqual", this._DeviceFamilyIdEqual);
			kparams.AddIfNotNull("nameEqual", this._NameEqual);
			kparams.AddIfNotNull("typeEqual", this._TypeEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case DEVICE_FAMILY_ID_EQUAL:
					return "DeviceFamilyIdEqual";
				case NAME_EQUAL:
					return "NameEqual";
				case TYPE_EQUAL:
					return "TypeEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

