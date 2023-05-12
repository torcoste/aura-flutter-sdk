using System;
using Newtonsoft.Json;
using UnityEngine;
namespace AuraMobileSDK{
    public partial class AuraConnect{
        string GenerateAuthorizationRequestUniqueID(){
            long d = (long) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds;
            //Logging.Verbose("genid", d);
            string id = "xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx";
            string ret = "";
            for (int i = 0; i < id.Length; ++i){
                if (id[i] != 'x' && id[i] != 'y') {
                    ret += id[i];
                    continue;
                }
                //Logging.Verbose("genid", d);
                System.Random random = new System.Random();
                long r = (long) (random.Next() % 16); // random number between 0 and 16
                // Use timestamp until depleted
                r = (d + r) % 16 | 0;
                d /= 16;
                string replacement = null;
                //if (id[i] == 'x')
                    replacement = r.ToString();
                //else if (id[i] == 'y')
                    //replacement = ((r & 0x3) | 0x8).ToString();
                //Logging.Verbose("genid i=", i, "id[i]=", id[i], "d=", d, "r=", r, "replacement=", replacement);
                ret += replacement;
            };
            return ret;
        }
        [Serializable]
        class C98MobileAppAuthorizationRequest{
            public string method;
            public class AppDescription{
                public string name;
                public string callbackURL;
                public string logo;
            }
            [JsonProperty(PropertyName = "params")]
            public AppDescription[] param_array; //to avoid matching c# keyword params
            public string id;
            public string chain;
            public string redirect;
        }
        void RequestC98MobileAppAuthorization(string connectionID, string dAppName, string callbackURL, string logoLink, string chainID){
            C98MobileAppAuthorizationRequest authorizationRequest = new C98MobileAppAuthorizationRequest {
                id = GenerateAuthorizationRequestUniqueID(),
                method = "connect",
                param_array = new C98MobileAppAuthorizationRequest.AppDescription[]{
                    new C98MobileAppAuthorizationRequest.AppDescription{
                        name = dAppName,
                        callbackURL = callbackURL,
                        logo = logoLink
                    }
                },
                redirect = callbackURL,
                chain = chainID
            };
            Logging.Verbose(JsonConvert.SerializeObject(authorizationRequest));
            string deeplink = $"coin98://{connectionID}&request={Uri.EscapeDataString(JsonConvert.SerializeObject(authorizationRequest))}";
            //deeplink = "coin98://" + Uri.EscapeDataString(deeplink);
            Logging.Verbose(deeplink);
            URLOpener.Open(deeplink);
        }
    }
}