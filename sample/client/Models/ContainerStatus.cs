// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace jschweda.luisDemo.client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ContainerStatus
    {
        /// <summary>
        /// Initializes a new instance of the ContainerStatus class.
        /// </summary>
        public ContainerStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerStatus class.
        /// </summary>
        public ContainerStatus(string service = default(string), string apiStatus = default(string), string apiStatusMessage = default(string))
        {
            Service = service;
            ApiStatus = apiStatus;
            ApiStatusMessage = apiStatusMessage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public string Service { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiStatus")]
        public string ApiStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "apiStatusMessage")]
        public string ApiStatusMessage { get; set; }

    }
}
