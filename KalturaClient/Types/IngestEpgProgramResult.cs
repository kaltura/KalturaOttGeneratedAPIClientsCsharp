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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class IngestEpgProgramResult : ObjectBase
	{
		#region Constants
		public const string PROGRAM_ID = "programId";
		public const string EXTERNAL_PROGRAM_ID = "externalProgramId";
		public const string LINEAR_CHANNEL_ID = "linearChannelId";
		public const string INDEX_IN_FILE = "indexInFile";
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string STATUS = "status";
		public const string ERRORS = "errors";
		public const string WARNINGS = "warnings";
		#endregion

		#region Private Fields
		private long _ProgramId = long.MinValue;
		private string _ExternalProgramId = null;
		private long _LinearChannelId = long.MinValue;
		private long _IndexInFile = long.MinValue;
		private long _StartDate = long.MinValue;
		private long _EndDate = long.MinValue;
		private IngestEpgProgramStatus _Status = null;
		private IList<EpgIngestErrorMessage> _Errors;
		private IList<Message> _Warnings;
		#endregion

		#region Properties
		/// <summary>
		/// Use ProgramIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long ProgramId
		{
			get { return _ProgramId; }
			set 
			{ 
				_ProgramId = value;
				OnPropertyChanged("ProgramId");
			}
		}
		/// <summary>
		/// Use ExternalProgramIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExternalProgramId
		{
			get { return _ExternalProgramId; }
			set 
			{ 
				_ExternalProgramId = value;
				OnPropertyChanged("ExternalProgramId");
			}
		}
		/// <summary>
		/// Use LinearChannelIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long LinearChannelId
		{
			get { return _LinearChannelId; }
			set 
			{ 
				_LinearChannelId = value;
				OnPropertyChanged("LinearChannelId");
			}
		}
		/// <summary>
		/// Use IndexInFileAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IndexInFile
		{
			get { return _IndexInFile; }
			set 
			{ 
				_IndexInFile = value;
				OnPropertyChanged("IndexInFile");
			}
		}
		/// <summary>
		/// Use StartDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long StartDate
		{
			get { return _StartDate; }
			set 
			{ 
				_StartDate = value;
				OnPropertyChanged("StartDate");
			}
		}
		/// <summary>
		/// Use EndDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IngestEpgProgramStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use ErrorsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<EpgIngestErrorMessage> Errors
		{
			get { return _Errors; }
			set 
			{ 
				_Errors = value;
				OnPropertyChanged("Errors");
			}
		}
		/// <summary>
		/// Use WarningsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<Message> Warnings
		{
			get { return _Warnings; }
			set 
			{ 
				_Warnings = value;
				OnPropertyChanged("Warnings");
			}
		}
		#endregion

		#region CTor
		public IngestEpgProgramResult()
		{
		}

		public IngestEpgProgramResult(JToken node) : base(node)
		{
			if(node["programId"] != null)
			{
				this._ProgramId = ParseLong(node["programId"].Value<string>());
			}
			if(node["externalProgramId"] != null)
			{
				this._ExternalProgramId = node["externalProgramId"].Value<string>();
			}
			if(node["linearChannelId"] != null)
			{
				this._LinearChannelId = ParseLong(node["linearChannelId"].Value<string>());
			}
			if(node["indexInFile"] != null)
			{
				this._IndexInFile = ParseLong(node["indexInFile"].Value<string>());
			}
			if(node["startDate"] != null)
			{
				this._StartDate = ParseLong(node["startDate"].Value<string>());
			}
			if(node["endDate"] != null)
			{
				this._EndDate = ParseLong(node["endDate"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (IngestEpgProgramStatus)StringEnum.Parse(typeof(IngestEpgProgramStatus), node["status"].Value<string>());
			}
			if(node["errors"] != null)
			{
				this._Errors = new List<EpgIngestErrorMessage>();
				foreach(var arrayNode in node["errors"].Children())
				{
					this._Errors.Add(ObjectFactory.Create<EpgIngestErrorMessage>(arrayNode));
				}
			}
			if(node["warnings"] != null)
			{
				this._Warnings = new List<Message>();
				foreach(var arrayNode in node["warnings"].Children())
				{
					this._Warnings.Add(ObjectFactory.Create<Message>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIngestEpgProgramResult");
			kparams.AddIfNotNull("programId", this._ProgramId);
			kparams.AddIfNotNull("externalProgramId", this._ExternalProgramId);
			kparams.AddIfNotNull("linearChannelId", this._LinearChannelId);
			kparams.AddIfNotNull("indexInFile", this._IndexInFile);
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("errors", this._Errors);
			kparams.AddIfNotNull("warnings", this._Warnings);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROGRAM_ID:
					return "ProgramId";
				case EXTERNAL_PROGRAM_ID:
					return "ExternalProgramId";
				case LINEAR_CHANNEL_ID:
					return "LinearChannelId";
				case INDEX_IN_FILE:
					return "IndexInFile";
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case STATUS:
					return "Status";
				case ERRORS:
					return "Errors";
				case WARNINGS:
					return "Warnings";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

