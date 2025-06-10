using PX.Data;
using PX.Objects.GL;


namespace CS.LL.ExtLib.DAC.GL
{
    public sealed class P1LLAccountExt : PXCacheExtension<Account>
    {
        public static bool IsActive() => true;

        #region UsrP1LLReportingGroup
        [PXDBString(100)]
        [PXUIField(DisplayName = "Reporting Group")]
        public string UsrP1LLReportingGroup { get; set; }
        public abstract class usrP1LLReportingGroup : PX.Data.BQL.BqlString.Field<usrP1LLReportingGroup> { }
        #endregion
    }
}
