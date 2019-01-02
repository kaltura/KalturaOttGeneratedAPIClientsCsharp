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
	public class Ratio : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string HEIGHT = "height";
		public const string WIDTH = "width";
		public const string PRECISION_PRECENTAGE = "precisionPrecentage";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private string _Name = null;
		private int _Height = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _PrecisionPrecentage = Int32.MinValue;
		#endregion

		#region Properties
		public long Id
		{
			get { return _Id; }
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public int Height
		{
			get { return _Height; }
			set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		public int Width
		{
			get { return _Width; }
			set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		public int PrecisionPrecentage
		{
			get { return _PrecisionPrecentage; }
			set 
			{ 
				_PrecisionPrecentage = value;
				OnPropertyChanged("PrecisionPrecentage");
			}
		}
		#endregion

		#region CTor
		public Ratio()
		{
		}

		public Ratio(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseLong(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "height":
						this._Height = ParseInt(propertyNode.InnerText);
						continue;
					case "width":
						this._Width = ParseInt(propertyNode.InnerText);
						continue;
					case "precisionPrecentage":
						this._PrecisionPrecentage = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public Ratio(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<long>("id");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._Height = data.TryGetValueSafe<int>("height");
			    this._Width = data.TryGetValueSafe<int>("width");
			    this._PrecisionPrecentage = data.TryGetValueSafe<int>("precisionPrecentage");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaRatio");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("height", this._Height);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("precisionPrecentage", this._PrecisionPrecentage);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case NAME:
					return "Name";
				case HEIGHT:
					return "Height";
				case WIDTH:
					return "Width";
				case PRECISION_PRECENTAGE:
					return "PrecisionPrecentage";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

