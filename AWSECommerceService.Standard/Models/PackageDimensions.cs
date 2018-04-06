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
    public class PackageDimensions : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.DecimalWithUnits height;
        private Models.DecimalWithUnits length;
        private Models.DecimalWithUnits weight;
        private Models.DecimalWithUnits width;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Height")]
        public Models.DecimalWithUnits Height 
        { 
            get 
            {
                return this.height; 
            } 
            set 
            {
                this.height = value;
                onPropertyChanged("Height");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Length")]
        public Models.DecimalWithUnits Length 
        { 
            get 
            {
                return this.length; 
            } 
            set 
            {
                this.length = value;
                onPropertyChanged("Length");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Weight")]
        public Models.DecimalWithUnits Weight 
        { 
            get 
            {
                return this.weight; 
            } 
            set 
            {
                this.weight = value;
                onPropertyChanged("Weight");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Width")]
        public Models.DecimalWithUnits Width 
        { 
            get 
            {
                return this.width; 
            } 
            set 
            {
                this.width = value;
                onPropertyChanged("Width");
            }
        }
    }
} 