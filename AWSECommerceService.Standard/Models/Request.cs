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
    public class Request : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string isValid;
        private Models.BrowseNodeLookupRequest browseNodeLookupRequest;
        private Models.ItemSearchRequest itemSearchRequest;
        private Models.ItemLookupRequest itemLookupRequest;
        private Models.SimilarityLookupRequest similarityLookupRequest;
        private Models.CartGetRequest cartGetRequest;
        private Models.CartAddRequest cartAddRequest;
        private Models.CartCreateRequest cartCreateRequest;
        private Models.CartModifyRequest cartModifyRequest;
        private Models.CartClearRequest cartClearRequest;
        private Models.Errors errors;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IsValid")]
        public string IsValid 
        { 
            get 
            {
                return this.isValid; 
            } 
            set 
            {
                this.isValid = value;
                onPropertyChanged("IsValid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("BrowseNodeLookupRequest")]
        public Models.BrowseNodeLookupRequest BrowseNodeLookupRequest 
        { 
            get 
            {
                return this.browseNodeLookupRequest; 
            } 
            set 
            {
                this.browseNodeLookupRequest = value;
                onPropertyChanged("BrowseNodeLookupRequest");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ItemSearchRequest")]
        public Models.ItemSearchRequest ItemSearchRequest 
        { 
            get 
            {
                return this.itemSearchRequest; 
            } 
            set 
            {
                this.itemSearchRequest = value;
                onPropertyChanged("ItemSearchRequest");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ItemLookupRequest")]
        public Models.ItemLookupRequest ItemLookupRequest 
        { 
            get 
            {
                return this.itemLookupRequest; 
            } 
            set 
            {
                this.itemLookupRequest = value;
                onPropertyChanged("ItemLookupRequest");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SimilarityLookupRequest")]
        public Models.SimilarityLookupRequest SimilarityLookupRequest 
        { 
            get 
            {
                return this.similarityLookupRequest; 
            } 
            set 
            {
                this.similarityLookupRequest = value;
                onPropertyChanged("SimilarityLookupRequest");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CartGetRequest")]
        public Models.CartGetRequest CartGetRequest 
        { 
            get 
            {
                return this.cartGetRequest; 
            } 
            set 
            {
                this.cartGetRequest = value;
                onPropertyChanged("CartGetRequest");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CartAddRequest")]
        public Models.CartAddRequest CartAddRequest 
        { 
            get 
            {
                return this.cartAddRequest; 
            } 
            set 
            {
                this.cartAddRequest = value;
                onPropertyChanged("CartAddRequest");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CartCreateRequest")]
        public Models.CartCreateRequest CartCreateRequest 
        { 
            get 
            {
                return this.cartCreateRequest; 
            } 
            set 
            {
                this.cartCreateRequest = value;
                onPropertyChanged("CartCreateRequest");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CartModifyRequest")]
        public Models.CartModifyRequest CartModifyRequest 
        { 
            get 
            {
                return this.cartModifyRequest; 
            } 
            set 
            {
                this.cartModifyRequest = value;
                onPropertyChanged("CartModifyRequest");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("CartClearRequest")]
        public Models.CartClearRequest CartClearRequest 
        { 
            get 
            {
                return this.cartClearRequest; 
            } 
            set 
            {
                this.cartClearRequest = value;
                onPropertyChanged("CartClearRequest");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Errors")]
        public Models.Errors Errors 
        { 
            get 
            {
                return this.errors; 
            } 
            set 
            {
                this.errors = value;
                onPropertyChanged("Errors");
            }
        }
    }
} 