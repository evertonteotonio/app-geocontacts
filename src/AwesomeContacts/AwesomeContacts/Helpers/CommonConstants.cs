﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AwesomeContacts.Helpers
{
    public class CommonConstants
    {
        #region AppCenter
        public const string AppCenteriOS = "AC_IOS";
        public const string AppCenterAndroid = "AC_ANDROID";
        public const string AppCenterUWP = "AC_UWP";
        #endregion

        #region AD
        public const string ADApplicationID = "8f999c10-2a7f-403c-b20b-cbe07b319cf3";
        public const string ADRedirectID = "msal" + ADApplicationID + "://auth";
        public static readonly string[] ADScopes = new string[] { "user.read" };
        public const string ADAuthority = "https://login.microsoftonline.com/organizations/";
        #endregion

        #region LocationFunction
        public const string FunctionUrl = "https://awesomecontactz.azurewebsites.net/api/UpdateGeolocation?code=dbn/fuOeJ460IEGCuA7M5AZoKeWQsc81haxZiHokFGazXHku/ZY3Zw==&clientId=_master";
        #endregion

        #region DodcumentDb

        public const string CDADatabaseId = "CDALocations";
        public const string AllCDACollectionId = "CDAInfo";
        public const string CDALocationCollectionId = "Location";

#error Fill in the CosmosDB URL & Key!
        public const string CosmosDbUrl = "";
        public const string CosmosAuthKey = "";

        #endregion
    }
}
