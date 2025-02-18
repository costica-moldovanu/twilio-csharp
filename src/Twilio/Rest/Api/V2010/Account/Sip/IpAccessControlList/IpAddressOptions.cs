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




namespace Twilio.Rest.Api.V2010.Account.Sip.IpAccessControlList
{

    /// <summary> Create a new IpAddress resource. </summary>
    public class CreateIpAddressOptions : IOptions<IpAddressResource>
    {
        
        ///<summary> The IpAccessControlList Sid with which to associate the created IpAddress resource. </summary> 
        public string PathIpAccessControlListSid { get; }

        ///<summary> A human readable descriptive text for this resource, up to 255 characters long. </summary> 
        public string FriendlyName { get; }

        ///<summary> An IP address in dotted decimal notation from which you want to accept traffic. Any SIP requests from this IP address will be allowed by Twilio. IPv4 only supported today. </summary> 
        public string IpAddress { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> An integer representing the length of the CIDR prefix to use with this IP address when accepting traffic. By default the entire IP address is used. </summary> 
        public int? CidrPrefixLength { get; set; }


        /// <summary> Construct a new CreateSipIpAddressOptions </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid with which to associate the created IpAddress resource. </param>
        /// <param name="friendlyName"> A human readable descriptive text for this resource, up to 255 characters long. </param>
        /// <param name="ipAddress"> An IP address in dotted decimal notation from which you want to accept traffic. Any SIP requests from this IP address will be allowed by Twilio. IPv4 only supported today. </param>
        public CreateIpAddressOptions(string pathIpAccessControlListSid, string friendlyName, string ipAddress)
        {
            PathIpAccessControlListSid = pathIpAccessControlListSid;
            FriendlyName = friendlyName;
            IpAddress = ipAddress;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (IpAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("IpAddress", IpAddress));
            }
            if (CidrPrefixLength != null)
            {
                p.Add(new KeyValuePair<string, string>("CidrPrefixLength", CidrPrefixLength.ToString()));
            }
            return p;
        }
        

    }
    /// <summary> Delete an IpAddress resource. </summary>
    public class DeleteIpAddressOptions : IOptions<IpAddressResource>
    {
        
        ///<summary> The IpAccessControlList Sid that identifies the IpAddress resources to delete. </summary> 
        public string PathIpAccessControlListSid { get; }

        ///<summary> A 34 character string that uniquely identifies the resource to delete. </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new DeleteSipIpAddressOptions </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to delete. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the resource to delete. </param>
        public DeleteIpAddressOptions(string pathIpAccessControlListSid, string pathSid)
        {
            PathIpAccessControlListSid = pathIpAccessControlListSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Read one IpAddress resource. </summary>
    public class FetchIpAddressOptions : IOptions<IpAddressResource>
    {
    
        ///<summary> The IpAccessControlList Sid that identifies the IpAddress resources to fetch. </summary> 
        public string PathIpAccessControlListSid { get; }

        ///<summary> A 34 character string that uniquely identifies the IpAddress resource to fetch. </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new FetchSipIpAddressOptions </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to fetch. </param>
        /// <param name="pathSid"> A 34 character string that uniquely identifies the IpAddress resource to fetch. </param>
        public FetchIpAddressOptions(string pathIpAccessControlListSid, string pathSid)
        {
            PathIpAccessControlListSid = pathIpAccessControlListSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            return p;
        }
        

    }


    /// <summary> Read multiple IpAddress resources. </summary>
    public class ReadIpAddressOptions : ReadOptions<IpAddressResource>
    {
    
        ///<summary> The IpAccessControlList Sid that identifies the IpAddress resources to read. </summary> 
        public string PathIpAccessControlListSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }



        /// <summary> Construct a new ListSipIpAddressOptions </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to read. </param>
        public ReadIpAddressOptions(string pathIpAccessControlListSid)
        {
            PathIpAccessControlListSid = pathIpAccessControlListSid;
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

    /// <summary> Update an IpAddress resource. </summary>
    public class UpdateIpAddressOptions : IOptions<IpAddressResource>
    {
    
        ///<summary> The IpAccessControlList Sid that identifies the IpAddress resources to update. </summary> 
        public string PathIpAccessControlListSid { get; }

        ///<summary> A 34 character string that identifies the IpAddress resource to update. </summary> 
        public string PathSid { get; }

        ///<summary> The unique id of the [Account](https://www.twilio.com/docs/iam/api/account) responsible for this resource. </summary> 
        public string PathAccountSid { get; set; }

        ///<summary> An IP address in dotted decimal notation from which you want to accept traffic. Any SIP requests from this IP address will be allowed by Twilio. IPv4 only supported today. </summary> 
        public string IpAddress { get; set; }

        ///<summary> A human readable descriptive text for this resource, up to 255 characters long. </summary> 
        public string FriendlyName { get; set; }

        ///<summary> An integer representing the length of the CIDR prefix to use with this IP address when accepting traffic. By default the entire IP address is used. </summary> 
        public int? CidrPrefixLength { get; set; }



        /// <summary> Construct a new UpdateSipIpAddressOptions </summary>
        /// <param name="pathIpAccessControlListSid"> The IpAccessControlList Sid that identifies the IpAddress resources to update. </param>
        /// <param name="pathSid"> A 34 character string that identifies the IpAddress resource to update. </param>
        public UpdateIpAddressOptions(string pathIpAccessControlListSid, string pathSid)
        {
            PathIpAccessControlListSid = pathIpAccessControlListSid;
            PathSid = pathSid;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (IpAddress != null)
            {
                p.Add(new KeyValuePair<string, string>("IpAddress", IpAddress));
            }
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }
            if (CidrPrefixLength != null)
            {
                p.Add(new KeyValuePair<string, string>("CidrPrefixLength", CidrPrefixLength.ToString()));
            }
            return p;
        }
        

    }


}

