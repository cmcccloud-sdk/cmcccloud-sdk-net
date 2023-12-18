using System;
using System.Collections.Generic;
using CmccCloud.SDK.Core;

namespace CmccCloud.SDK.Kms.V2
{
    public class KmsRegion
    {
        public static readonly Region CIDC_RP_11 = new Region("CIDC-RP-11",
            "https://kms.cidc-rp-11.joint.cmecloud.cn");
        public static readonly Region CIDC_RP_12 = new Region("CIDC-RP-12",
            "https://kms.cidc-rp-12.joint.cmecloud.cn");
        public static readonly Region CIDC_RP_13 = new Region("CIDC-RP-13",
            "https://kms.cidc-rp-13.joint.cmecloud.cn");
        public static readonly Region CIDC_RP_19 = new Region("CIDC-RP-19",
            "https://kms.cidc-rp-19.joint.cmecloud.cn");
        public static readonly Region CIDC_RP_2000 = new Region("CIDC-RP-2000",
            "https://kms.cidc-rp-2000.joint.cmecloud.cn");
        public static readonly Region CIDC_RP_2005 = new Region("CIDC-RP-2005",
            "https://kms.cidc-rp-2005.joint.cmecloud.cn");
        public static readonly Region CIDC_RP_2006 = new Region("CIDC-RP-2006",
            "https://kms.cidc-rp-2006.joint.cmecloud.cn");
        public static readonly Region CIDC_RP_2011 = new Region("CIDC-RP-2011",
            "https://kms.cidc-rp-2011.joint.cmecloud.cn");
        
        private static readonly IRegionProvider Provider = RegionProviderChain.GetDefault("KMS");

        private static readonly Dictionary<string, Region> StaticFields = new Dictionary<string, Region>()
        {
                { "CIDC-RP-11", CIDC_RP_11 },
                { "CIDC-RP-12", CIDC_RP_12 },
                { "CIDC-RP-13", CIDC_RP_13 },
                { "CIDC-RP-19", CIDC_RP_19 },
                { "CIDC-RP-2000", CIDC_RP_2000 },
                { "CIDC-RP-2005", CIDC_RP_2005 },
                { "CIDC-RP-2006", CIDC_RP_2006 },
                { "CIDC-RP-2011", CIDC_RP_2011 },
        };

        public static Region ValueOf(string regionId)
        {
            if (string.IsNullOrEmpty(regionId))
            {
                throw new ArgumentNullException(regionId);
            }

            var region = Provider.GetRegion(regionId);
            if (region != null)
            {
                return region;
            }

            if (StaticFields.ContainsKey(regionId))
            {
                return StaticFields[regionId];
            }

            throw new ArgumentException("Unexpected regionId: ", regionId);
        }
    }
}