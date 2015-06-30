
namespace RNM.Common
{
    #region [Namespace]

    using RNM.Common.Constants;
    using RNM.Common.Interfaces;

    #endregion

    public class IntersectionLocation : BaseLocation, IIntersectionLocation
    {
        #region [Fields]

        string firstName;

        string secondStreet;

        #endregion

        #region [Constructors]

        public IntersectionLocation(LocationType type)
            : base(type)
        {
        }

        #endregion

        #region [Properties]

        public string FirstStreet
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string SecondStreet
        {
            get
            {
                return this.secondStreet;
            }
            set
            {
                this.secondStreet = value;
            }
        }

        #endregion
    }
}
