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
    public class Items117 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.Request request;
        private Models.CorrectedQuery correctedQuery;
        private string qid;
        private string engineQuery;
        private int? totalResults;
        private int? totalPages;
        private string moreSearchResultsUrl;
        private Models.SearchResultsMap searchResultsMap;
        private List<Models.Item116> item;
        private Models.SearchBinSets searchBinSets;

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
        [JsonProperty("CorrectedQuery")]
        public Models.CorrectedQuery CorrectedQuery 
        { 
            get 
            {
                return this.correctedQuery; 
            } 
            set 
            {
                this.correctedQuery = value;
                onPropertyChanged("CorrectedQuery");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Qid")]
        public string Qid 
        { 
            get 
            {
                return this.qid; 
            } 
            set 
            {
                this.qid = value;
                onPropertyChanged("Qid");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("EngineQuery")]
        public string EngineQuery 
        { 
            get 
            {
                return this.engineQuery; 
            } 
            set 
            {
                this.engineQuery = value;
                onPropertyChanged("EngineQuery");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TotalResults")]
        public int? TotalResults 
        { 
            get 
            {
                return this.totalResults; 
            } 
            set 
            {
                this.totalResults = value;
                onPropertyChanged("TotalResults");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("TotalPages")]
        public int? TotalPages 
        { 
            get 
            {
                return this.totalPages; 
            } 
            set 
            {
                this.totalPages = value;
                onPropertyChanged("TotalPages");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("MoreSearchResultsUrl")]
        public string MoreSearchResultsUrl 
        { 
            get 
            {
                return this.moreSearchResultsUrl; 
            } 
            set 
            {
                this.moreSearchResultsUrl = value;
                onPropertyChanged("MoreSearchResultsUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SearchResultsMap")]
        public Models.SearchResultsMap SearchResultsMap 
        { 
            get 
            {
                return this.searchResultsMap; 
            } 
            set 
            {
                this.searchResultsMap = value;
                onPropertyChanged("SearchResultsMap");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("Item")]
        public List<Models.Item116> Item 
        { 
            get 
            {
                return this.item; 
            } 
            set 
            {
                this.item = value;
                onPropertyChanged("Item");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("SearchBinSets")]
        public Models.SearchBinSets SearchBinSets 
        { 
            get 
            {
                return this.searchBinSets; 
            } 
            set 
            {
                this.searchBinSets = value;
                onPropertyChanged("SearchBinSets");
            }
        }
    }
} 