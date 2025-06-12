using PX.Data;
using PX.Data.EP;
using PX.Data.Licensing;
using PX.Data.ReferentialIntegrity.Attributes;
using PX.Objects.AP;
using PX.Objects.CS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.LL.ExtLib
{
    public sealed class APSetupP1LLExt : PXCacheExtension<PX.Objects.AP.APSetup>
    {
        #region IsActive

        public static bool IsActive()
        {
            return PXAccess.FeatureInstalled<FeaturesSet.inventory>();
        }

        #endregion


        #region UsrP1LLIsVendorInactive
        [PXDBBool]
        [PXUIField(DisplayName = "Create New Vendor as Inactive")]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        public bool? UsrP1LLIsVendorInactive { get; set; }
        public abstract class usrP1LLIsVendorInactive : PX.Data.BQL.BqlBool.Field<usrP1LLIsVendorInactive> { }
        #endregion


    }
}