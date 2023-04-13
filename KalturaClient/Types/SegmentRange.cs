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
	public class SegmentRange : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string SYSTEMATIC_NAME = "systematicName";
		public const string NAME = "name";
		public const string GTE = "gte";
		public const string GT = "gt";
		public const string LTE = "lte";
		public const string LT = "lt";
		public const string EQUALS = "equals";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private string _SystematicName = null;
		private string _Name = null;
		private double _Gte = Double.MinValue;
		private double _Gt = Double.MinValue;
		private double _Lte = Double.MinValue;
		private double _Lt = Double.MinValue;
		private double _Equals = Double.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use SystematicNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SystematicName
		{
			get { return _SystematicName; }
			set 
			{ 
				_SystematicName = value;
				OnPropertyChanged("SystematicName");
			}
		}
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		/// <summary>
		/// Use GteAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double Gte
		{
			get { return _Gte; }
			set 
			{ 
				_Gte = value;
				OnPropertyChanged("Gte");
			}
		}
		/// <summary>
		/// Use GtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double Gt
		{
			get { return _Gt; }
			set 
			{ 
				_Gt = value;
				OnPropertyChanged("Gt");
			}
		}
		/// <summary>
		/// Use LteAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double Lte
		{
			get { return _Lte; }
			set 
			{ 
				_Lte = value;
				OnPropertyChanged("Lte");
			}
		}
		/// <summary>
		/// Use LtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double Lt
		{
			get { return _Lt; }
			set 
			{ 
				_Lt = value;
				OnPropertyChanged("Lt");
			}
		}
		/// <summary>
		/// Use EqualsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double Equals
		{
			get { return _Equals; }
			set 
			{ 
				_Equals = value;
				OnPropertyChanged("Equals");
			}
		}
		#endregion

		#region CTor
		public SegmentRange()
		{
		}

		public SegmentRange(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["systematicName"] != null)
			{
				this._SystematicName = node["systematicName"].Value<string>();
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["gte"] != null)
			{
				this._Gte = ParseDouble(node["gte"].Value<string>());
			}
			if(node["gt"] != null)
			{
				this._Gt = ParseDouble(node["gt"].Value<string>());
			}
			if(node["lte"] != null)
			{
				this._Lte = ParseDouble(node["lte"].Value<string>());
			}
			if(node["lt"] != null)
			{
				this._Lt = ParseDouble(node["lt"].Value<string>());
			}
			if(node["equals"] != null)
			{
				this._Equals = ParseDouble(node["equals"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSegmentRange");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("systematicName", this._SystematicName);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("gte", this._Gte);
			kparams.AddIfNotNull("gt", this._Gt);
			kparams.AddIfNotNull("lte", this._Lte);
			kparams.AddIfNotNull("lt", this._Lt);
			kparams.AddIfNotNull("equals", this._Equals);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case SYSTEMATIC_NAME:
					return "SystematicName";
				case NAME:
					return "Name";
				case GTE:
					return "Gte";
				case GT:
					return "Gt";
				case LTE:
					return "Lte";
				case LT:
					return "Lt";
				case EQUALS:
					return "Equals";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

