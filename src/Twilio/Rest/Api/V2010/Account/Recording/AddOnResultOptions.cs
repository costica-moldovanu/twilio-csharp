/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Api
 * This is the public Twilio REST API.
 *
 * NOTE: This class is auto generated by OpenAPI Generator.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;




namespace Twilio.Rest.Api.V2010.Account.Recording
{
    /// <summary> Delete a result and purge all associated Payloads </summary>
    public class DeleteAddOnResultOptions : IOptions<AddOnResultResource>
    {
        
        ///<summary> The SID of the recording to which the result to delete belongs. </summary> 
        public string PathReferenceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Recording AddOnResult resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Recording AddOnResult resources to delete. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteRecordingAddOnResultOptions </summary>
        /// <param name="pathReferenceSid"> The SID of the recording to which the result to delete belongs. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Recording AddOnResult resource to delete. </param>
        public DeleteAddOnResultOptions(string pathReferenceSid, string pathSid)
        {
            PathReferenceSid = pathReferenceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Fetch an instance of an AddOnResult </summary>
    public class FetchAddOnResultOptions : IOptions<AddOnResultResource>
    {
    
        ///<summary> The SID of the recording to which the result to fetch belongs. </summary> 
        public string PathReferenceSid { get; }

        ///<summary> The Twilio-provided string that uniquely identifies the Recording AddOnResult resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Recording AddOnResult resource to fetch. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchRecordingAddOnResultOptions </summary>
        /// <param name="pathReferenceSid"> The SID of the recording to which the result to fetch belongs. </param>
        /// <param name="pathSid"> The Twilio-provided string that uniquely identifies the Recording AddOnResult resource to fetch. </param>
        public FetchAddOnResultOptions(string pathReferenceSid, string pathSid)
        {
            PathReferenceSid = pathReferenceSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Retrieve a list of results belonging to the recording </summary>
    public class ReadAddOnResultOptions : ReadOptions<AddOnResultResource>
    {
    
        ///<summary> The SID of the recording to which the result to read belongs. </summary> 
        public string PathReferenceSid { get; }

        ///<summary> The SID of the [Account](https://www.twilio.com/docs/iam/api/account) that created the Recording AddOnResult resources to read. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new ListRecordingAddOnResultOptions </summary>
        /// <param name="pathReferenceSid"> The SID of the recording to which the result to read belongs. </param>
        public ReadAddOnResultOptions(string pathReferenceSid)
        {
            PathReferenceSid = pathReferenceSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }
            return p;
        }
        

    }

}

