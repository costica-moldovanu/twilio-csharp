/*
 * This code was generated by
 * ___ _ _ _ _ _    _ ____    ____ ____ _    ____ ____ _  _ ____ ____ ____ ___ __   __
 *  |  | | | | |    | |  | __ |  | |__| | __ | __ |___ |\ | |___ |__/ |__|  | |  | |__/
 *  |  |_|_| | |___ | |__|    |__| |  | |    |__] |___ | \| |___ |  \ |  |  | |__| |  \
 *
 * Twilio - Flex
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




namespace Twilio.Rest.FlexApi.V1.Interaction.InteractionChannel
{

    /// <summary> Add a Participant to a Channel. </summary>
    public class CreateInteractionChannelParticipantOptions : IOptions<InteractionChannelParticipantResource>
    {
        
        ///<summary> The Interaction Sid for the new Channel Participant. </summary> 
        public string PathInteractionSid { get; }

        ///<summary> The Channel Sid for the new Channel Participant. </summary> 
        public string PathChannelSid { get; }

        
        public InteractionChannelParticipantResource.TypeEnum Type { get; }

        ///<summary> JSON representing the Media Properties for the new Participant. </summary> 
        public object MediaProperties { get; }


        /// <summary> Construct a new CreateInteractionChannelParticipantOptions </summary>
        /// <param name="pathInteractionSid"> The Interaction Sid for the new Channel Participant. </param>
        /// <param name="pathChannelSid"> The Channel Sid for the new Channel Participant. </param>
        /// <param name="type">  </param>
        /// <param name="mediaProperties"> JSON representing the Media Properties for the new Participant. </param>
        public CreateInteractionChannelParticipantOptions(string pathInteractionSid, string pathChannelSid, InteractionChannelParticipantResource.TypeEnum type, object mediaProperties)
        {
            PathInteractionSid = pathInteractionSid;
            PathChannelSid = pathChannelSid;
            Type = type;
            MediaProperties = mediaProperties;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Type != null)
            {
                p.Add(new KeyValuePair<string, string>("Type", Type.ToString()));
            }
            if (MediaProperties != null)
            {
                p.Add(new KeyValuePair<string, string>("MediaProperties", Serializers.JsonObject(MediaProperties)));
            }
            return p;
        }
        

    }
    /// <summary> List all Participants for a Channel. </summary>
    public class ReadInteractionChannelParticipantOptions : ReadOptions<InteractionChannelParticipantResource>
    {
    
        ///<summary> The Interaction Sid for this channel. </summary> 
        public string PathInteractionSid { get; }

        ///<summary> The Channel Sid for this Participant. </summary> 
        public string PathChannelSid { get; }



        /// <summary> Construct a new ListInteractionChannelParticipantOptions </summary>
        /// <param name="pathInteractionSid"> The Interaction Sid for this channel. </param>
        /// <param name="pathChannelSid"> The Channel Sid for this Participant. </param>
        public ReadInteractionChannelParticipantOptions(string pathInteractionSid, string pathChannelSid)
        {
            PathInteractionSid = pathInteractionSid;
            PathChannelSid = pathChannelSid;
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

    /// <summary> Update an existing Channel Participant. </summary>
    public class UpdateInteractionChannelParticipantOptions : IOptions<InteractionChannelParticipantResource>
    {
    
        ///<summary> The Interaction Sid for this channel. </summary> 
        public string PathInteractionSid { get; }

        ///<summary> The Channel Sid for this Participant. </summary> 
        public string PathChannelSid { get; }

        ///<summary> The unique string created by Twilio to identify an Interaction Channel resource. </summary> 
        public string PathSid { get; }

        
        public InteractionChannelParticipantResource.StatusEnum Status { get; }



        /// <summary> Construct a new UpdateInteractionChannelParticipantOptions </summary>
        /// <param name="pathInteractionSid"> The Interaction Sid for this channel. </param>
        /// <param name="pathChannelSid"> The Channel Sid for this Participant. </param>
        /// <param name="pathSid"> The unique string created by Twilio to identify an Interaction Channel resource. </param>
        /// <param name="status">  </param>
        public UpdateInteractionChannelParticipantOptions(string pathInteractionSid, string pathChannelSid, string pathSid, InteractionChannelParticipantResource.StatusEnum status)
        {
            PathInteractionSid = pathInteractionSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
            Status = status;
        }

        
        /// <summary> Generate the necessary parameters </summary>
        public  List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();

            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }
            return p;
        }
        

    }


}

