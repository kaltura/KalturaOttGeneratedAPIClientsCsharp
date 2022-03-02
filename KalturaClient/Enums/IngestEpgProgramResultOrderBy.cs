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
namespace Kaltura.Enums
{
	public sealed class IngestEpgProgramResultOrderBy : StringEnum
	{
		public static readonly IngestEpgProgramResultOrderBy NONE = new IngestEpgProgramResultOrderBy("NONE");
		public static readonly IngestEpgProgramResultOrderBy EXTERNAL_PROGRAM_ID_DESC = new IngestEpgProgramResultOrderBy("EXTERNAL_PROGRAM_ID_DESC");
		public static readonly IngestEpgProgramResultOrderBy EXTERNAL_PROGRAM_ID_ASC = new IngestEpgProgramResultOrderBy("EXTERNAL_PROGRAM_ID_ASC");
		public static readonly IngestEpgProgramResultOrderBy LINEAR_CHANNEL_ID_DESC = new IngestEpgProgramResultOrderBy("LINEAR_CHANNEL_ID_DESC");
		public static readonly IngestEpgProgramResultOrderBy LINEAR_CHANNEL_ID_ASC = new IngestEpgProgramResultOrderBy("LINEAR_CHANNEL_ID_ASC");
		public static readonly IngestEpgProgramResultOrderBy INDEX_IN_FILE_DESC = new IngestEpgProgramResultOrderBy("INDEX_IN_FILE_DESC");
		public static readonly IngestEpgProgramResultOrderBy INDEX_IN_FILE_ASC = new IngestEpgProgramResultOrderBy("INDEX_IN_FILE_ASC");
		public static readonly IngestEpgProgramResultOrderBy START_DATE_DESC = new IngestEpgProgramResultOrderBy("START_DATE_DESC");
		public static readonly IngestEpgProgramResultOrderBy START_DATE_ASC = new IngestEpgProgramResultOrderBy("START_DATE_ASC");
		public static readonly IngestEpgProgramResultOrderBy SEVERITY_DESC = new IngestEpgProgramResultOrderBy("SEVERITY_DESC");
		public static readonly IngestEpgProgramResultOrderBy SEVERITY_ASC = new IngestEpgProgramResultOrderBy("SEVERITY_ASC");

		private IngestEpgProgramResultOrderBy(string name) : base(name) { }
	}
}
