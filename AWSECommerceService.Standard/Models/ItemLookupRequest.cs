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
    public class ItemLookupRequest : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.ConditionEnum? condition;
        private Models.IdTypeEnum? idType;
        private string merchantId;
        private List<string> itemId;
        private List<string> responseGroup;
        private string searchIndex;
        private object variationPage;
        private object relatedItemPage;
        private List<string> relationshipType;
        private string includeReviewsSummary;
        private int? truncateReviewsAt;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Condition", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.ConditionEnum? Condition 
        { 
            get 
            {
                return this.condition; 
            } 
            set 
            {
                this.condition = value;
                onPropertyChanged("Condition");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IdType", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.IdTypeEnum? IdType 
        { 
            get 
            {
                return this.idType; 
            } 
            set 
            {
                this.idType = value;
                onPropertyChanged("IdType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId 
        { 
            get 
            {
                return this.merchantId; 
            } 
            set 
            {
                this.merchantId = value;
                onPropertyChanged("MerchantId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ItemId")]
        public List<string> ItemId 
        { 
            get 
            {
                return this.itemId; 
            } 
            set 
            {
                this.itemId = value;
                onPropertyChanged("ItemId");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("ResponseGroup")]
        public List<string> ResponseGroup 
        { 
            get 
            {
                return this.responseGroup; 
            } 
            set 
            {
                this.responseGroup = value;
                onPropertyChanged("ResponseGroup");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SearchIndex")]
        public string SearchIndex 
        { 
            get 
            {
                return this.searchIndex; 
            } 
            set 
            {
                this.searchIndex = value;
                onPropertyChanged("SearchIndex");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("VariationPage")]
        public object VariationPage 
        { 
            get 
            {
                return this.variationPage; 
            } 
            set 
            {
                this.variationPage = value;
                onPropertyChanged("VariationPage");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("RelatedItemPage")]
        public object RelatedItemPage 
        { 
            get 
            {
                return this.relatedItemPage; 
            } 
            set 
            {
                this.relatedItemPage = value;
                onPropertyChanged("RelatedItemPage");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("RelationshipType")]
        public List<string> RelationshipType 
        { 
            get 
            {
                return this.relationshipType; 
            } 
            set 
            {
                this.relationshipType = value;
                onPropertyChanged("RelationshipType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("IncludeReviewsSummary")]
        public string IncludeReviewsSummary 
        { 
            get 
            {
                return this.includeReviewsSummary; 
            } 
            set 
            {
                this.includeReviewsSummary = value;
                onPropertyChanged("IncludeReviewsSummary");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TruncateReviewsAt")]
        public int? TruncateReviewsAt 
        { 
            get 
            {
                return this.truncateReviewsAt; 
            } 
            set 
            {
                this.truncateReviewsAt = value;
                onPropertyChanged("TruncateReviewsAt");
            }
        }
    }
} 