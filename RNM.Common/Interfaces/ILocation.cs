
namespace RNM.Common.Interfaces
{
    #region [Namespace]

    using RNM.Common.Constants;

    #endregion

    public interface ILocation
    {
        int LocationId { get; }
        LocationType Type { get; }
        string City { get; set; }
        string Province { get; set; }
    }
}
