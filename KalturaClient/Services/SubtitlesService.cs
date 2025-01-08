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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class SubtitlesGetRequestBuilder : RequestBuilder<Subtitles>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public SubtitlesGetRequestBuilder()
			: base("subtitles", "get")
		{
		}

		public SubtitlesGetRequestBuilder(long id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Subtitles>(result);
		}
	}

	public class SubtitlesListRequestBuilder : RequestBuilder<ListResponse<Subtitles>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public SubtitlesFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public SubtitlesListRequestBuilder()
			: base("subtitles", "list")
		{
		}

		public SubtitlesListRequestBuilder(SubtitlesFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<Subtitles>>(result);
		}
	}

	public class SubtitlesUploadFileRequestBuilder : RequestBuilder<Subtitles>
	{
		#region Constants
		public const string SUBTITLES = "subtitles";
		public const string FILE = "file";
		#endregion

		public Subtitles Subtitles { get; set; }
		public Stream File { get; set; }
		public string File_FileName { get; set; }

		public SubtitlesUploadFileRequestBuilder()
			: base("subtitles", "uploadFile")
		{
		}

		public SubtitlesUploadFileRequestBuilder(Subtitles subtitles, Stream file)
			: this()
		{
			this.Subtitles = subtitles;
			this.File = file;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("subtitles"))
				kparams.AddIfNotNull("subtitles", Subtitles);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("file", new FileData(File, File_FileName));
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Subtitles>(result);
		}
	}


	public class SubtitlesService
	{
		private SubtitlesService()
		{
		}

		public static SubtitlesGetRequestBuilder Get(long id)
		{
			return new SubtitlesGetRequestBuilder(id);
		}

		public static SubtitlesListRequestBuilder List(SubtitlesFilter filter, FilterPager pager)
		{
			return new SubtitlesListRequestBuilder(filter, pager);
		}

		public static SubtitlesUploadFileRequestBuilder UploadFile(Subtitles subtitles, Stream file)
		{
			return new SubtitlesUploadFileRequestBuilder(subtitles, file);
		}
	}
}
