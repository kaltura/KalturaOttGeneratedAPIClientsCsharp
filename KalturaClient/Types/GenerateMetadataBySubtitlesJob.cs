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
	public class GenerateMetadataBySubtitlesJob : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CREATE_DATE = "createDate";
		public const string UPDATE_DATE = "updateDate";
		public const string FILE_NAME = "fileName";
		public const string STATUS = "status";
		public const string ERROR_MESSAGE = "errorMessage";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private long _CreateDate = long.MinValue;
		private long _UpdateDate = long.MinValue;
		private string _FileName = null;
		private GenerateMetadataStatus _Status = null;
		private string _ErrorMessage = null;
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
		/// Use CreateDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long CreateDate
		{
			get { return _CreateDate; }
			private set 
			{ 
				_CreateDate = value;
				OnPropertyChanged("CreateDate");
			}
		}
		/// <summary>
		/// Use UpdateDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long UpdateDate
		{
			get { return _UpdateDate; }
			private set 
			{ 
				_UpdateDate = value;
				OnPropertyChanged("UpdateDate");
			}
		}
		/// <summary>
		/// Use FileNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileName
		{
			get { return _FileName; }
			private set 
			{ 
				_FileName = value;
				OnPropertyChanged("FileName");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public GenerateMetadataStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use ErrorMessageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ErrorMessage
		{
			get { return _ErrorMessage; }
			private set 
			{ 
				_ErrorMessage = value;
				OnPropertyChanged("ErrorMessage");
			}
		}
		#endregion

		#region CTor
		public GenerateMetadataBySubtitlesJob()
		{
		}

		public GenerateMetadataBySubtitlesJob(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["createDate"] != null)
			{
				this._CreateDate = ParseLong(node["createDate"].Value<string>());
			}
			if(node["updateDate"] != null)
			{
				this._UpdateDate = ParseLong(node["updateDate"].Value<string>());
			}
			if(node["fileName"] != null)
			{
				this._FileName = node["fileName"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (GenerateMetadataStatus)StringEnum.Parse(typeof(GenerateMetadataStatus), node["status"].Value<string>());
			}
			if(node["errorMessage"] != null)
			{
				this._ErrorMessage = node["errorMessage"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGenerateMetadataBySubtitlesJob");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createDate", this._CreateDate);
			kparams.AddIfNotNull("updateDate", this._UpdateDate);
			kparams.AddIfNotNull("fileName", this._FileName);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("errorMessage", this._ErrorMessage);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CREATE_DATE:
					return "CreateDate";
				case UPDATE_DATE:
					return "UpdateDate";
				case FILE_NAME:
					return "FileName";
				case STATUS:
					return "Status";
				case ERROR_MESSAGE:
					return "ErrorMessage";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

