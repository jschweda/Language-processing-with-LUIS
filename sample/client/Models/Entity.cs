// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace jschweda.luisDemo.client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Entity
    {
        /// <summary>
        /// Initializes a new instance of the Entity class.
        /// </summary>
        public Entity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Entity class.
        /// </summary>
        public Entity(string entityProperty = default(string), string type = default(string), int? startIndex = default(int?), int? endIndex = default(int?), double? score = default(double?), IDictionary<string, object> resolution = default(IDictionary<string, object>), string role = default(string))
        {
            EntityProperty = entityProperty;
            Type = type;
            StartIndex = startIndex;
            EndIndex = endIndex;
            Score = score;
            Resolution = resolution;
            Role = role;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entity")]
        public string EntityProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startIndex")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endIndex")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public IDictionary<string, object> Resolution { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

    }
}
