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
	public class BaseWatchCondition : BaseSegmentCondition
	{
		#region Constants
		public const string CONTENT_FILTER = "contentFilter";
		public const string EVALUATION_DAYS = "evaluationDays";
		public const string DEVICE_FAMILY_IN = "deviceFamilyIn";
		public const string VIEW_TIME_CONSTRAINT = "viewTimeConstraint";
		public const string CONSTRAINTS_OPERATOR = "constraintsOperator";
		public const string CONSTRAINT_ATTRIBUTES = "constraintAttributes";
		#endregion

		#region Private Fields
		private ContentTypeSelector _ContentFilter;
		private int _EvaluationDays = Int32.MinValue;
		private string _DeviceFamilyIn = null;
		private ViewTimeConstraint _ViewTimeConstraint;
		private BooleanOperator _ConstraintsOperator = null;
		private IList<BaseAttributeConstraint> _ConstraintAttributes;
		#endregion

		#region Properties
		/// <summary>
		/// Use ContentFilterAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ContentTypeSelector ContentFilter
		{
			get { return _ContentFilter; }
			set 
			{ 
				_ContentFilter = value;
				OnPropertyChanged("ContentFilter");
			}
		}
		/// <summary>
		/// Use EvaluationDaysAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EvaluationDays
		{
			get { return _EvaluationDays; }
			set 
			{ 
				_EvaluationDays = value;
				OnPropertyChanged("EvaluationDays");
			}
		}
		/// <summary>
		/// Use DeviceFamilyInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DeviceFamilyIn
		{
			get { return _DeviceFamilyIn; }
			set 
			{ 
				_DeviceFamilyIn = value;
				OnPropertyChanged("DeviceFamilyIn");
			}
		}
		/// <summary>
		/// Use ViewTimeConstraintAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ViewTimeConstraint ViewTimeConstraint
		{
			get { return _ViewTimeConstraint; }
			set 
			{ 
				_ViewTimeConstraint = value;
				OnPropertyChanged("ViewTimeConstraint");
			}
		}
		/// <summary>
		/// Use ConstraintsOperatorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BooleanOperator ConstraintsOperator
		{
			get { return _ConstraintsOperator; }
			set 
			{ 
				_ConstraintsOperator = value;
				OnPropertyChanged("ConstraintsOperator");
			}
		}
		/// <summary>
		/// Use ConstraintAttributesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<BaseAttributeConstraint> ConstraintAttributes
		{
			get { return _ConstraintAttributes; }
			set 
			{ 
				_ConstraintAttributes = value;
				OnPropertyChanged("ConstraintAttributes");
			}
		}
		#endregion

		#region CTor
		public BaseWatchCondition()
		{
		}

		public BaseWatchCondition(JToken node) : base(node)
		{
			if(node["contentFilter"] != null)
			{
				this._ContentFilter = ObjectFactory.Create<ContentTypeSelector>(node["contentFilter"]);
			}
			if(node["evaluationDays"] != null)
			{
				this._EvaluationDays = ParseInt(node["evaluationDays"].Value<string>());
			}
			if(node["deviceFamilyIn"] != null)
			{
				this._DeviceFamilyIn = node["deviceFamilyIn"].Value<string>();
			}
			if(node["viewTimeConstraint"] != null)
			{
				this._ViewTimeConstraint = ObjectFactory.Create<ViewTimeConstraint>(node["viewTimeConstraint"]);
			}
			if(node["constraintsOperator"] != null)
			{
				this._ConstraintsOperator = (BooleanOperator)StringEnum.Parse(typeof(BooleanOperator), node["constraintsOperator"].Value<string>());
			}
			if(node["constraintAttributes"] != null)
			{
				this._ConstraintAttributes = new List<BaseAttributeConstraint>();
				foreach(var arrayNode in node["constraintAttributes"].Children())
				{
					this._ConstraintAttributes.Add(ObjectFactory.Create<BaseAttributeConstraint>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBaseWatchCondition");
			kparams.AddIfNotNull("contentFilter", this._ContentFilter);
			kparams.AddIfNotNull("evaluationDays", this._EvaluationDays);
			kparams.AddIfNotNull("deviceFamilyIn", this._DeviceFamilyIn);
			kparams.AddIfNotNull("viewTimeConstraint", this._ViewTimeConstraint);
			kparams.AddIfNotNull("constraintsOperator", this._ConstraintsOperator);
			kparams.AddIfNotNull("constraintAttributes", this._ConstraintAttributes);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONTENT_FILTER:
					return "ContentFilter";
				case EVALUATION_DAYS:
					return "EvaluationDays";
				case DEVICE_FAMILY_IN:
					return "DeviceFamilyIn";
				case VIEW_TIME_CONSTRAINT:
					return "ViewTimeConstraint";
				case CONSTRAINTS_OPERATOR:
					return "ConstraintsOperator";
				case CONSTRAINT_ATTRIBUTES:
					return "ConstraintAttributes";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

