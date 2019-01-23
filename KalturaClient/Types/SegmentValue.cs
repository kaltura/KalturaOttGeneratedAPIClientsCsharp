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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class SegmentValue : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string SYSTEMATIC_NAME = "systematicName";
		public const string NAME = "name";
		public const string MULTILINGUAL_NAME = "multilingualName";
		public const string VALUE = "value";
		public const string THRESHOLD = "threshold";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private string _SystematicName = null;
		private string _Name = null;
		private IList<TranslationToken> _MultilingualName;
		private string _Value = null;
		private int _Threshold = Int32.MinValue;
		#endregion

		#region Properties
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
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			private set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public IList<TranslationToken> MultilingualName
		{
			get { return _MultilingualName; }
			set 
			{ 
				_MultilingualName = value;
				OnPropertyChanged("MultilingualName");
			}
		}
		[JsonProperty]
		public string Value
		{
			get { return _Value; }
			set 
			{ 
				_Value = value;
				OnPropertyChanged("Value");
			}
		}
		[JsonProperty]
		public int Threshold
		{
			get { return _Threshold; }
			set 
			{ 
				_Threshold = value;
				OnPropertyChanged("Threshold");
			}
		}
		#endregion

		#region CTor
		public SegmentValue()
		{
		}

		public SegmentValue(JToken node) : base(node)
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
			if(node["multilingualName"] != null)
			{
				this._MultilingualName = new List<TranslationToken>();
				foreach(var arrayNode in node["multilingualName"].Children())
				{
					this._MultilingualName.Add(ObjectFactory.Create<TranslationToken>(arrayNode));
				}
			}
			if(node["value"] != null)
			{
				this._Value = node["value"].Value<string>();
			}
			if(node["threshold"] != null)
			{
				this._Threshold = ParseInt(node["threshold"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSegmentValue");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("systematicName", this._SystematicName);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("multilingualName", this._MultilingualName);
			kparams.AddIfNotNull("value", this._Value);
			kparams.AddIfNotNull("threshold", this._Threshold);
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
				case MULTILINGUAL_NAME:
					return "MultilingualName";
				case VALUE:
					return "Value";
				case THRESHOLD:
					return "Threshold";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

