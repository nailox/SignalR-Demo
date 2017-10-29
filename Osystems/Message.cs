using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Osystems
{
    public class Message
    {
        //private string v1;
        //private DateTime now;
        //private bool v2;

        [Key]
        public int MsgNumber { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }

        public Message(string Body, DateTime Time, bool Read)
        {
            this.Body = Body;
            this.Time = Time;
            this.Read = Read;
        }
    }
}