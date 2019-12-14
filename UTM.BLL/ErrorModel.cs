using System;
using Newtonsoft.Json;

namespace UTM.BLL
{
    public class ErrorModel : IErrorModel
    {
        private const string ToStringFormat = "{0}: {1}";

        /// <summary>
        /// The instance of <see cref="ErrorModel"/>
        /// </summary>
        public ErrorModel() { }

        /// <summary>
        /// The instance of <see cref="ErrorModel"/>
        /// </summary>
        public ErrorModel(string key, string message = null)
        {
            Key = key;

            if (!string.IsNullOrEmpty(message))
                Message = message.Trim();
        }

        /// <summary>
        /// Localization key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Detailed message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        public override string ToString() =>
            string.Format(ToStringFormat, Key, Message);

    }
}
