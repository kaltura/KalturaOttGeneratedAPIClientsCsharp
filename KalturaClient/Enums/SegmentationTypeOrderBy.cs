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
	public sealed class SegmentationTypeOrderBy : StringEnum
	{
		public static readonly SegmentationTypeOrderBy UPDATE_DATE_DESC = new SegmentationTypeOrderBy("UPDATE_DATE_DESC");
		public static readonly SegmentationTypeOrderBy UPDATE_DATE_ASC = new SegmentationTypeOrderBy("UPDATE_DATE_ASC");
		public static readonly SegmentationTypeOrderBy CREATE_DATE_DESC = new SegmentationTypeOrderBy("CREATE_DATE_DESC");
		public static readonly SegmentationTypeOrderBy CREATE_DATE_ASC = new SegmentationTypeOrderBy("CREATE_DATE_ASC");
		public static readonly SegmentationTypeOrderBy EXECUTE_DATE_DESC = new SegmentationTypeOrderBy("EXECUTE_DATE_DESC");
		public static readonly SegmentationTypeOrderBy EXECUTE_DATE_ASC = new SegmentationTypeOrderBy("EXECUTE_DATE_ASC");
		public static readonly SegmentationTypeOrderBy AFFECTED_USERS_DESC = new SegmentationTypeOrderBy("AFFECTED_USERS_DESC");
		public static readonly SegmentationTypeOrderBy AFFECTED_USERS_ASC = new SegmentationTypeOrderBy("AFFECTED_USERS_ASC");
		public static readonly SegmentationTypeOrderBy AFFECTED_HOUSEHOLDS_DESC = new SegmentationTypeOrderBy("AFFECTED_HOUSEHOLDS_DESC");
		public static readonly SegmentationTypeOrderBy AFFECTED_HOUSEHOLDS_ASC = new SegmentationTypeOrderBy("AFFECTED_HOUSEHOLDS_ASC");

		private SegmentationTypeOrderBy(string name) : base(name) { }
	}
}
