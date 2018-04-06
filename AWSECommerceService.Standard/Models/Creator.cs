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
    public class Creator : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string role;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Role")]
        public string Role 
        { 
            get 
            {
                return this.role; 
            } 
            set 
            {
                this.role = value;
                onPropertyChanged("Role");
            }
        }
    }
} 