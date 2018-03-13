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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class OttUserActivateRequestBuilder : RequestBuilder<OTTUser>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string USERNAME = "username";
		public const string ACTIVATION_TOKEN = "activationToken";
		#endregion

		public new int PartnerId
		{
			set;
			get;
		}
		public string Username
		{
			set;
			get;
		}
		public string ActivationToken
		{
			set;
			get;
		}

		public OttUserActivateRequestBuilder()
			: base("ottuser", "activate")
		{
		}

		public OttUserActivateRequestBuilder(int partnerId, string username, string activationToken)
			: this()
		{
			this.PartnerId = partnerId;
			this.Username = username;
			this.ActivationToken = activationToken;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("username"))
				kparams.AddIfNotNull("username", Username);
			if (!isMapped("activationToken"))
				kparams.AddIfNotNull("activationToken", ActivationToken);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<OTTUser>(result);
		}
	}

	public class OttUserAddRoleRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string ROLE_ID = "roleId";
		#endregion

		public long RoleId
		{
			set;
			get;
		}

		public OttUserAddRoleRequestBuilder()
			: base("ottuser", "addRole")
		{
		}

		public OttUserAddRoleRequestBuilder(long roleId)
			: this()
		{
			this.RoleId = roleId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("roleId"))
				kparams.AddIfNotNull("roleId", RoleId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class OttUserAnonymousLoginRequestBuilder : RequestBuilder<LoginSession>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string UDID = "udid";
		#endregion

		public new int PartnerId
		{
			set;
			get;
		}
		public string Udid
		{
			set;
			get;
		}

		public OttUserAnonymousLoginRequestBuilder()
			: base("ottuser", "anonymousLogin")
		{
		}

		public OttUserAnonymousLoginRequestBuilder(int partnerId, string udid)
			: this()
		{
			this.PartnerId = partnerId;
			this.Udid = udid;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("udid"))
				kparams.AddIfNotNull("udid", Udid);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LoginSession>(result);
		}
	}

	public class OttUserDeleteRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		#endregion


		public OttUserDeleteRequestBuilder()
			: base("ottuser", "delete")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class OttUserGetRequestBuilder : RequestBuilder<OTTUser>
	{
		#region Constants
		#endregion


		public OttUserGetRequestBuilder()
			: base("ottuser", "get")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<OTTUser>(result);
		}
	}

	public class OttUserGetEncryptedUserIdRequestBuilder : RequestBuilder<StringValue>
	{
		#region Constants
		#endregion


		public OttUserGetEncryptedUserIdRequestBuilder()
			: base("ottuser", "getEncryptedUserId")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<StringValue>(result);
		}
	}

	public class OttUserListRequestBuilder : RequestBuilder<ListResponse<OTTUser>>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public OTTUserFilter Filter
		{
			set;
			get;
		}

		public OttUserListRequestBuilder()
			: base("ottuser", "list")
		{
		}

		public OttUserListRequestBuilder(OTTUserFilter filter)
			: this()
		{
			this.Filter = filter;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<OTTUser>>(result);
		}
	}

	public class OttUserLoginRequestBuilder : RequestBuilder<LoginResponse>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		public const string EXTRA_PARAMS = "extraParams";
		public const string UDID = "udid";
		#endregion

		public new int PartnerId
		{
			set;
			get;
		}
		public string Username
		{
			set;
			get;
		}
		public string Password
		{
			set;
			get;
		}
		public IDictionary<string, StringValue> ExtraParams
		{
			set;
			get;
		}
		public string Udid
		{
			set;
			get;
		}

		public OttUserLoginRequestBuilder()
			: base("ottuser", "login")
		{
		}

		public OttUserLoginRequestBuilder(int partnerId, string username, string password, IDictionary<string, StringValue> extraParams, string udid)
			: this()
		{
			this.PartnerId = partnerId;
			this.Username = username;
			this.Password = password;
			this.ExtraParams = extraParams;
			this.Udid = udid;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("username"))
				kparams.AddIfNotNull("username", Username);
			if (!isMapped("password"))
				kparams.AddIfNotNull("password", Password);
			if (!isMapped("extraParams"))
				kparams.AddIfNotNull("extraParams", ExtraParams);
			if (!isMapped("udid"))
				kparams.AddIfNotNull("udid", Udid);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LoginResponse>(result);
		}
	}

	public class OttUserLoginWithPinRequestBuilder : RequestBuilder<LoginResponse>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string PIN = "pin";
		public const string UDID = "udid";
		public const string SECRET = "secret";
		#endregion

		public new int PartnerId
		{
			set;
			get;
		}
		public string Pin
		{
			set;
			get;
		}
		public string Udid
		{
			set;
			get;
		}
		public string Secret
		{
			set;
			get;
		}

		public OttUserLoginWithPinRequestBuilder()
			: base("ottuser", "loginWithPin")
		{
		}

		public OttUserLoginWithPinRequestBuilder(int partnerId, string pin, string udid, string secret)
			: this()
		{
			this.PartnerId = partnerId;
			this.Pin = pin;
			this.Udid = udid;
			this.Secret = secret;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("pin"))
				kparams.AddIfNotNull("pin", Pin);
			if (!isMapped("udid"))
				kparams.AddIfNotNull("udid", Udid);
			if (!isMapped("secret"))
				kparams.AddIfNotNull("secret", Secret);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LoginResponse>(result);
		}
	}

	public class OttUserLogoutRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		#endregion


		public OttUserLogoutRequestBuilder()
			: base("ottuser", "logout")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class OttUserRegisterRequestBuilder : RequestBuilder<OTTUser>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string USER = "user";
		public const string PASSWORD = "password";
		#endregion

		public new int PartnerId
		{
			set;
			get;
		}
		public OTTUser User
		{
			set;
			get;
		}
		public string Password
		{
			set;
			get;
		}

		public OttUserRegisterRequestBuilder()
			: base("ottuser", "register")
		{
		}

		public OttUserRegisterRequestBuilder(int partnerId, OTTUser user, string password)
			: this()
		{
			this.PartnerId = partnerId;
			this.User = user;
			this.Password = password;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("user"))
				kparams.AddIfNotNull("user", User);
			if (!isMapped("password"))
				kparams.AddIfNotNull("password", Password);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<OTTUser>(result);
		}
	}

	public class OttUserResendActivationTokenRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string USERNAME = "username";
		#endregion

		public new int PartnerId
		{
			set;
			get;
		}
		public string Username
		{
			set;
			get;
		}

		public OttUserResendActivationTokenRequestBuilder()
			: base("ottuser", "resendActivationToken")
		{
		}

		public OttUserResendActivationTokenRequestBuilder(int partnerId, string username)
			: this()
		{
			this.PartnerId = partnerId;
			this.Username = username;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("username"))
				kparams.AddIfNotNull("username", Username);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class OttUserResetPasswordRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string USERNAME = "username";
		#endregion

		public new int PartnerId
		{
			set;
			get;
		}
		public string Username
		{
			set;
			get;
		}

		public OttUserResetPasswordRequestBuilder()
			: base("ottuser", "resetPassword")
		{
		}

		public OttUserResetPasswordRequestBuilder(int partnerId, string username)
			: this()
		{
			this.PartnerId = partnerId;
			this.Username = username;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("username"))
				kparams.AddIfNotNull("username", Username);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class OttUserSetInitialPasswordRequestBuilder : RequestBuilder<OTTUser>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string TOKEN = "token";
		public const string PASSWORD = "password";
		#endregion

		public new int PartnerId
		{
			set;
			get;
		}
		public string Token
		{
			set;
			get;
		}
		public string Password
		{
			set;
			get;
		}

		public OttUserSetInitialPasswordRequestBuilder()
			: base("ottuser", "setInitialPassword")
		{
		}

		public OttUserSetInitialPasswordRequestBuilder(int partnerId, string token, string password)
			: this()
		{
			this.PartnerId = partnerId;
			this.Token = token;
			this.Password = password;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("token"))
				kparams.AddIfNotNull("token", Token);
			if (!isMapped("password"))
				kparams.AddIfNotNull("password", Password);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<OTTUser>(result);
		}
	}

	public class OttUserUpdateRequestBuilder : RequestBuilder<OTTUser>
	{
		#region Constants
		public const string USER = "user";
		public const string ID = "id";
		#endregion

		public OTTUser User
		{
			set;
			get;
		}
		public string Id
		{
			set;
			get;
		}

		public OttUserUpdateRequestBuilder()
			: base("ottuser", "update")
		{
		}

		public OttUserUpdateRequestBuilder(OTTUser user, string id)
			: this()
		{
			this.User = user;
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("user"))
				kparams.AddIfNotNull("user", User);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<OTTUser>(result);
		}
	}

	public class OttUserUpdateLoginDataRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string USERNAME = "username";
		public const string OLD_PASSWORD = "oldPassword";
		public const string NEW_PASSWORD = "newPassword";
		#endregion

		public string Username
		{
			set;
			get;
		}
		public string OldPassword
		{
			set;
			get;
		}
		public string NewPassword
		{
			set;
			get;
		}

		public OttUserUpdateLoginDataRequestBuilder()
			: base("ottuser", "updateLoginData")
		{
		}

		public OttUserUpdateLoginDataRequestBuilder(string username, string oldPassword, string newPassword)
			: this()
		{
			this.Username = username;
			this.OldPassword = oldPassword;
			this.NewPassword = newPassword;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("username"))
				kparams.AddIfNotNull("username", Username);
			if (!isMapped("oldPassword"))
				kparams.AddIfNotNull("oldPassword", OldPassword);
			if (!isMapped("newPassword"))
				kparams.AddIfNotNull("newPassword", NewPassword);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class OttUserUpdatePasswordRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public new const string USER_ID = "userId";
		public const string PASSWORD = "password";
		#endregion

		public new int UserId
		{
			set;
			get;
		}
		public string Password
		{
			set;
			get;
		}

		public OttUserUpdatePasswordRequestBuilder()
			: base("ottuser", "updatePassword")
		{
		}

		public OttUserUpdatePasswordRequestBuilder(int userId, string password)
			: this()
		{
			this.UserId = userId;
			this.Password = password;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("password"))
				kparams.AddIfNotNull("password", Password);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}


	public class OttUserService
	{
		private OttUserService()
		{
		}

		public static OttUserActivateRequestBuilder Activate(int partnerId, string username, string activationToken)
		{
			return new OttUserActivateRequestBuilder(partnerId, username, activationToken);
		}

		public static OttUserAddRoleRequestBuilder AddRole(long roleId)
		{
			return new OttUserAddRoleRequestBuilder(roleId);
		}

		public static OttUserAnonymousLoginRequestBuilder AnonymousLogin(int partnerId, string udid = null)
		{
			return new OttUserAnonymousLoginRequestBuilder(partnerId, udid);
		}

		public static OttUserDeleteRequestBuilder Delete()
		{
			return new OttUserDeleteRequestBuilder();
		}

		public static OttUserGetRequestBuilder Get()
		{
			return new OttUserGetRequestBuilder();
		}

		public static OttUserGetEncryptedUserIdRequestBuilder GetEncryptedUserId()
		{
			return new OttUserGetEncryptedUserIdRequestBuilder();
		}

		public static OttUserListRequestBuilder List(OTTUserFilter filter = null)
		{
			return new OttUserListRequestBuilder(filter);
		}

		public static OttUserLoginRequestBuilder Login(int partnerId, string username = null, string password = null, IDictionary<string, StringValue> extraParams = null, string udid = null)
		{
			return new OttUserLoginRequestBuilder(partnerId, username, password, extraParams, udid);
		}

		public static OttUserLoginWithPinRequestBuilder LoginWithPin(int partnerId, string pin, string udid = null, string secret = null)
		{
			return new OttUserLoginWithPinRequestBuilder(partnerId, pin, udid, secret);
		}

		public static OttUserLogoutRequestBuilder Logout()
		{
			return new OttUserLogoutRequestBuilder();
		}

		public static OttUserRegisterRequestBuilder Register(int partnerId, OTTUser user, string password)
		{
			return new OttUserRegisterRequestBuilder(partnerId, user, password);
		}

		public static OttUserResendActivationTokenRequestBuilder ResendActivationToken(int partnerId, string username)
		{
			return new OttUserResendActivationTokenRequestBuilder(partnerId, username);
		}

		public static OttUserResetPasswordRequestBuilder ResetPassword(int partnerId, string username)
		{
			return new OttUserResetPasswordRequestBuilder(partnerId, username);
		}

		public static OttUserSetInitialPasswordRequestBuilder SetInitialPassword(int partnerId, string token, string password)
		{
			return new OttUserSetInitialPasswordRequestBuilder(partnerId, token, password);
		}

		public static OttUserUpdateRequestBuilder Update(OTTUser user, string id = null)
		{
			return new OttUserUpdateRequestBuilder(user, id);
		}

		public static OttUserUpdateLoginDataRequestBuilder UpdateLoginData(string username, string oldPassword, string newPassword)
		{
			return new OttUserUpdateLoginDataRequestBuilder(username, oldPassword, newPassword);
		}

		public static OttUserUpdatePasswordRequestBuilder UpdatePassword(int userId, string password)
		{
			return new OttUserUpdatePasswordRequestBuilder(userId, password);
		}
	}
}
