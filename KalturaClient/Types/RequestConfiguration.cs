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
	public class RequestConfiguration : ObjectBase
	{
		#region Constants
		public const string PARTNER_ID = "partnerId";
		public const string USER_ID = "userId";
		public const string LANGUAGE = "language";
		public const string CURRENCY = "currency";
		public const string KS = "ks";
		public const string RESPONSE_PROFILE = "responseProfile";
		public const string ABORT_ALL_ON_ERROR = "abortAllOnError";
		public const string SKIP_CONDITION = "skipCondition";
		#endregion

		#region Private Fields
		private int _PartnerId = Int32.MinValue;
		private int _UserId = Int32.MinValue;
		private string _Language = null;
		private string _Currency = null;
		private string _Ks = null;
		private BaseResponseProfile _ResponseProfile;
		private bool? _AbortAllOnError = null;
		private SkipCondition _SkipCondition;
		#endregion

		#region Properties
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public int UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public string Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public string Currency
		{
			get { return _Currency; }
			set 
			{ 
				_Currency = value;
				OnPropertyChanged("Currency");
			}
		}
		public string Ks
		{
			get { return _Ks; }
			set 
			{ 
				_Ks = value;
				OnPropertyChanged("Ks");
			}
		}
		public BaseResponseProfile ResponseProfile
		{
			get { return _ResponseProfile; }
			set 
			{ 
				_ResponseProfile = value;
				OnPropertyChanged("ResponseProfile");
			}
		}
		public bool? AbortAllOnError
		{
			get { return _AbortAllOnError; }
			set 
			{ 
				_AbortAllOnError = value;
				OnPropertyChanged("AbortAllOnError");
			}
		}
		public SkipCondition SkipCondition
		{
			get { return _SkipCondition; }
			set 
			{ 
				_SkipCondition = value;
				OnPropertyChanged("SkipCondition");
			}
		}
		#endregion

		#region CTor
		public RequestConfiguration()
		{
		}

		public RequestConfiguration(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "userId":
						this._UserId = ParseInt(propertyNode.InnerText);
						continue;
					case "language":
						this._Language = propertyNode.InnerText;
						continue;
					case "currency":
						this._Currency = propertyNode.InnerText;
						continue;
					case "ks":
						this._Ks = propertyNode.InnerText;
						continue;
					case "responseProfile":
						this._ResponseProfile = ObjectFactory.Create<BaseResponseProfile>(propertyNode);
						continue;
					case "abortAllOnError":
						this._AbortAllOnError = ParseBool(propertyNode.InnerText);
						continue;
					case "skipCondition":
						this._SkipCondition = ObjectFactory.Create<SkipCondition>(propertyNode);
						continue;
				}
			}
		}

		public RequestConfiguration(IDictionary<string,object> data) : base(data)
		{
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._UserId = data.TryGetValueSafe<int>("userId");
			    this._Language = data.TryGetValueSafe<string>("language");
			    this._Currency = data.TryGetValueSafe<string>("currency");
			    this._Ks = data.TryGetValueSafe<string>("ks");
			    this._ResponseProfile = ObjectFactory.Create<BaseResponseProfile>(data.TryGetValueSafe<IDictionary<string,object>>("responseProfile"));
			    this._AbortAllOnError = data.TryGetValueSafe<bool>("abortAllOnError");
			    this._SkipCondition = ObjectFactory.Create<SkipCondition>(data.TryGetValueSafe<IDictionary<string,object>>("skipCondition"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaRequestConfiguration");
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("currency", this._Currency);
			kparams.AddIfNotNull("ks", this._Ks);
			kparams.AddIfNotNull("responseProfile", this._ResponseProfile);
			kparams.AddIfNotNull("abortAllOnError", this._AbortAllOnError);
			kparams.AddIfNotNull("skipCondition", this._SkipCondition);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_ID:
					return "PartnerId";
				case USER_ID:
					return "UserId";
				case LANGUAGE:
					return "Language";
				case CURRENCY:
					return "Currency";
				case KS:
					return "Ks";
				case RESPONSE_PROFILE:
					return "ResponseProfile";
				case ABORT_ALL_ON_ERROR:
					return "AbortAllOnError";
				case SKIP_CONDITION:
					return "SkipCondition";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

