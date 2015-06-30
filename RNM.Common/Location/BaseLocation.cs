
namespace RNM.Common
{
    #region [Namespace]

    using RNM.Common.Constants;
    using RNM.Common.Interfaces;

    #endregion

    public abstract class BaseLocation : ILocation
    {
        public int LocationId { get; set; }
        public LocationType Type { get; private set; }
        public string City { get; set; }
        public string Province { get; set; }

        public BaseLocation(LocationType type)
        {
            this.Type = type;
        }
    }
}
