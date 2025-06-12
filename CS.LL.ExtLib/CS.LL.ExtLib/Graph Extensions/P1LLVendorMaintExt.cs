using PX.Data;
using PX.Objects.AP;
using PX.Objects.CS;

namespace CS.LL.ExtLib
{
    public class SLLVendorMaintCExt : PXGraphExtension<VendorMaint>
    {

        #region IsActive
        public static bool IsActive()
        {
            return PXAccess.FeatureInstalled<FeaturesSet.inventory>();
        }
        #endregion

        #region Event Handler
        protected void _(Events.RowInserted<Vendor> e)
        {
            var row = e.Row;
            if (row == null) return;

            APSetup setup = PXSelect<APSetup>.Select(Base);
            var setupExt = setup?.GetExtension<P1LLAPSetupExt>();

            if (setupExt?.UsrP1LLIsVendorInactive == true)
            {
                row.VStatus = VendorStatus.Inactive;
                e.Cache.Update(row);
            }
        }
        #endregion
    }
}
