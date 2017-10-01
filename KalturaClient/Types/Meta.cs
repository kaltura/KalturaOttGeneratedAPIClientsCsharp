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
	public class Meta : ObjectBase
	{
		#region Constants
		public const string NAME = "name";
		public const string FIELD_NAME = "fieldName";
		public const string TYPE = "type";
		public const string ASSET_TYPE = "assetType";
		#endregion

		#region Private Fields
		private string _Name = null;
		private MetaFieldName _FieldName = null;
		private MetaType _Type = null;
		private AssetType _AssetType = null;
		#endregion

		#region Properties
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public MetaFieldName FieldName
		{
			get { return _FieldName; }
			set 
			{ 
				_FieldName = value;
				OnPropertyChanged("FieldName");
			}
		}
		public MetaType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public AssetType AssetType
		{
			get { return _AssetType; }
			set 
			{ 
				_AssetType = value;
				OnPropertyChanged("AssetType");
			}
		}
		#endregion

		#region CTor
		public Meta()
		{
		}

		public Meta(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "fieldName":
						this._FieldName = (MetaFieldName)StringEnum.Parse(typeof(MetaFieldName), propertyNode.InnerText);
						continue;
					case "type":
						this._Type = (MetaType)StringEnum.Parse(typeof(MetaType), propertyNode.InnerText);
						continue;
					case "assetType":
						this._AssetType = (AssetType)StringEnum.Parse(typeof(AssetType), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaMeta");
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("fieldName", this._FieldName);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("assetType", this._AssetType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case NAME:
					return "Name";
				case FIELD_NAME:
					return "FieldName";
				case TYPE:
					return "Type";
				case ASSET_TYPE:
					return "AssetType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

