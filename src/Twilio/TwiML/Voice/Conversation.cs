/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Twilio.Converters;
using Twilio.Types;

namespace Twilio.TwiML.Voice
{

    /// <summary>
    /// Conversation TwiML Noun
    /// </summary>
    public class Conversation : TwiML
    {
        public sealed class RecordEnum : StringEnum
        {
            private RecordEnum(string value) : base(value) {}
            public RecordEnum() {}
            public static implicit operator RecordEnum(string value)
            {
                return new RecordEnum(value);
            }

            public static readonly RecordEnum DoNotRecord = new RecordEnum("do-not-record");
            public static readonly RecordEnum RecordFromAnswer = new RecordEnum("record-from-answer");
            public static readonly RecordEnum RecordFromRinging = new RecordEnum("record-from-ringing");
            public static readonly RecordEnum RecordFromAnswerDual = new RecordEnum("record-from-answer-dual");
            public static readonly RecordEnum RecordFromRingingDual = new RecordEnum("record-from-ringing-dual");
            public static readonly RecordEnum True = new RecordEnum("true");
            public static readonly RecordEnum False = new RecordEnum("false");
        }

        public sealed class TrimEnum : StringEnum
        {
            private TrimEnum(string value) : base(value) {}
            public TrimEnum() {}
            public static implicit operator TrimEnum(string value)
            {
                return new TrimEnum(value);
            }

            public static readonly TrimEnum TrimSilence = new TrimEnum("trim-silence");
            public static readonly TrimEnum DoNotTrim = new TrimEnum("do-not-trim");
        }

        public sealed class RecordingEventEnum : StringEnum
        {
            private RecordingEventEnum(string value) : base(value) {}
            public RecordingEventEnum() {}
            public static implicit operator RecordingEventEnum(string value)
            {
                return new RecordingEventEnum(value);
            }

            public static readonly RecordingEventEnum InProgress = new RecordingEventEnum("in-progress");
            public static readonly RecordingEventEnum Completed = new RecordingEventEnum("completed");
            public static readonly RecordingEventEnum Absent = new RecordingEventEnum("absent");
        }

        public sealed class EventEnum : StringEnum
        {
            private EventEnum(string value) : base(value) {}
            public EventEnum() {}
            public static implicit operator EventEnum(string value)
            {
                return new EventEnum(value);
            }

            public static readonly EventEnum CallInitiated = new EventEnum("call-initiated");
            public static readonly EventEnum CallRinging = new EventEnum("call-ringing");
            public static readonly EventEnum CallAnswered = new EventEnum("call-answered");
            public static readonly EventEnum CallCompleted = new EventEnum("call-completed");
        }

        /// <summary>
        /// Service instance Sid
        /// </summary>
        public string ServiceInstanceSid { get; set; }
        /// <summary>
        /// Inbound autocreation
        /// </summary>
        public bool? InboundAutocreation { get; set; }
        /// <summary>
        /// Routing assignment timeout
        /// </summary>
        public int? RoutingAssignmentTimeout { get; set; }
        /// <summary>
        /// Inbound timeout
        /// </summary>
        public int? InboundTimeout { get; set; }
        /// <summary>
        /// TwiML URL
        /// </summary>
        public Uri Url { get; set; }
        /// <summary>
        /// TwiML URL method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; set; }
        /// <summary>
        /// Record
        /// </summary>
        public Conversation.RecordEnum Record { get; set; }
        /// <summary>
        /// Trim
        /// </summary>
        public Conversation.TrimEnum Trim { get; set; }
        /// <summary>
        /// Recording status callback URL
        /// </summary>
        public Uri RecordingStatusCallback { get; set; }
        /// <summary>
        /// Recording status callback URL method
        /// </summary>
        public Twilio.Http.HttpMethod RecordingStatusCallbackMethod { get; set; }
        /// <summary>
        /// Recording status callback events
        /// </summary>
        public List<Conversation.RecordingEventEnum> RecordingStatusCallbackEvent { get; set; }
        /// <summary>
        /// Status callback URL
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// Status callback URL method
        /// </summary>
        public Twilio.Http.HttpMethod StatusCallbackMethod { get; set; }
        /// <summary>
        /// Events to call status callback URL
        /// </summary>
        public List<Conversation.EventEnum> StatusCallbackEvent { get; set; }

        /// <summary>
        /// Create a new Conversation
        /// </summary>
        /// <param name="serviceInstanceSid"> Service instance Sid </param>
        /// <param name="inboundAutocreation"> Inbound autocreation </param>
        /// <param name="routingAssignmentTimeout"> Routing assignment timeout </param>
        /// <param name="inboundTimeout"> Inbound timeout </param>
        /// <param name="url"> TwiML URL </param>
        /// <param name="method"> TwiML URL method </param>
        /// <param name="record"> Record </param>
        /// <param name="trim"> Trim </param>
        /// <param name="recordingStatusCallback"> Recording status callback URL </param>
        /// <param name="recordingStatusCallbackMethod"> Recording status callback URL method </param>
        /// <param name="recordingStatusCallbackEvent"> Recording status callback events </param>
        /// <param name="statusCallback"> Status callback URL </param>
        /// <param name="statusCallbackMethod"> Status callback URL method </param>
        /// <param name="statusCallbackEvent"> Events to call status callback URL </param>
        public Conversation(string serviceInstanceSid = null,
                            bool? inboundAutocreation = null,
                            int? routingAssignmentTimeout = null,
                            int? inboundTimeout = null,
                            Uri url = null,
                            Twilio.Http.HttpMethod method = null,
                            Conversation.RecordEnum record = null,
                            Conversation.TrimEnum trim = null,
                            Uri recordingStatusCallback = null,
                            Twilio.Http.HttpMethod recordingStatusCallbackMethod = null,
                            List<Conversation.RecordingEventEnum> recordingStatusCallbackEvent = null,
                            Uri statusCallback = null,
                            Twilio.Http.HttpMethod statusCallbackMethod = null,
                            List<Conversation.EventEnum> statusCallbackEvent = null) : base("Conversation")
        {
            this.ServiceInstanceSid = serviceInstanceSid;
            this.InboundAutocreation = inboundAutocreation;
            this.RoutingAssignmentTimeout = routingAssignmentTimeout;
            this.InboundTimeout = inboundTimeout;
            this.Url = url;
            this.Method = method;
            this.Record = record;
            this.Trim = trim;
            this.RecordingStatusCallback = recordingStatusCallback;
            this.RecordingStatusCallbackMethod = recordingStatusCallbackMethod;
            this.RecordingStatusCallbackEvent = recordingStatusCallbackEvent;
            this.StatusCallback = statusCallback;
            this.StatusCallbackMethod = statusCallbackMethod;
            this.StatusCallbackEvent = statusCallbackEvent;
        }

        /// <summary>
        /// Return the attributes of the TwiML tag
        /// </summary>
        protected override List<XAttribute> GetElementAttributes()
        {
            var attributes = new List<XAttribute>();
            if (this.ServiceInstanceSid != null)
            {
                attributes.Add(new XAttribute("serviceInstanceSid", this.ServiceInstanceSid));
            }
            if (this.InboundAutocreation != null)
            {
                attributes.Add(new XAttribute("inboundAutocreation", this.InboundAutocreation.Value.ToString().ToLower()));
            }
            if (this.RoutingAssignmentTimeout != null)
            {
                attributes.Add(new XAttribute("routingAssignmentTimeout", this.RoutingAssignmentTimeout.ToString()));
            }
            if (this.InboundTimeout != null)
            {
                attributes.Add(new XAttribute("inboundTimeout", this.InboundTimeout.ToString()));
            }
            if (this.Url != null)
            {
                attributes.Add(new XAttribute("url", Serializers.Url(this.Url)));
            }
            if (this.Method != null)
            {
                attributes.Add(new XAttribute("method", this.Method.ToString()));
            }
            if (this.Record != null)
            {
                attributes.Add(new XAttribute("record", this.Record.ToString()));
            }
            if (this.Trim != null)
            {
                attributes.Add(new XAttribute("trim", this.Trim.ToString()));
            }
            if (this.RecordingStatusCallback != null)
            {
                attributes.Add(new XAttribute("recordingStatusCallback", Serializers.Url(this.RecordingStatusCallback)));
            }
            if (this.RecordingStatusCallbackMethod != null)
            {
                attributes.Add(new XAttribute("recordingStatusCallbackMethod", this.RecordingStatusCallbackMethod.ToString()));
            }
            if (this.RecordingStatusCallbackEvent != null)
            {
                attributes.Add(new XAttribute("recordingStatusCallbackEvent", String.Join(" ", this.RecordingStatusCallbackEvent.Select(e => e.ToString()).ToArray())));
            }
            if (this.StatusCallback != null)
            {
                attributes.Add(new XAttribute("statusCallback", Serializers.Url(this.StatusCallback)));
            }
            if (this.StatusCallbackMethod != null)
            {
                attributes.Add(new XAttribute("statusCallbackMethod", this.StatusCallbackMethod.ToString()));
            }
            if (this.StatusCallbackEvent != null)
            {
                attributes.Add(new XAttribute("statusCallbackEvent", String.Join(" ", this.StatusCallbackEvent.Select(e => e.ToString()).ToArray())));
            }
            return attributes;
        }

        /// <summary>
        /// Append a child TwiML element to this element returning this element to allow chaining.
        /// </summary>
        /// <param name="childElem"> Child TwiML element to add </param>
        public new Conversation Append(TwiML childElem)
        {
            return (Conversation) base.Append(childElem);
        }

        /// <summary>
        /// Add freeform key-value attributes to the generated xml
        /// </summary>
        /// <param name="key"> Option key </param>
        /// <param name="value"> Option value </param>
        public new Conversation SetOption(string key, object value)
        {
            return (Conversation) base.SetOption(key, value);
        }
    }

}