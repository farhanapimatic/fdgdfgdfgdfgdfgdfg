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
    public class BrowseNodes : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.Request request;
        private List<Models.BrowseNode> browseNode;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Request")]
        public Models.Request Request 
        { 
            get 
            {
                return this.request; 
            } 
            set 
            {
                this.request = value;
                onPropertyChanged("Request");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("BrowseNode")]
        public List<Models.BrowseNode> BrowseNode 
        { 
            get 
            {
                return this.browseNode; 
            } 
            set 
            {
                this.browseNode = value;
                onPropertyChanged("BrowseNode");
            }
        }
    }
} 