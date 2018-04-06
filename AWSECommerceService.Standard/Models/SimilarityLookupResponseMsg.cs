/*
 * AWSECommerceService.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using AWSECommerceService.Standard;
using AWSECommerceService.Standard.Utilities;


namespace AWSECommerceService.Standard.Models
{
    public class SimilarityLookupResponseMsg : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.SimilarityLookupResponse body;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("body")]
        public Models.SimilarityLookupResponse Body 
        { 
            get 
            {
                return this.body; 
            } 
            set 
            {
                this.body = value;
                onPropertyChanged("Body");
            }
        }
    }
} 