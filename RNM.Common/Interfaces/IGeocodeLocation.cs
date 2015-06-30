
namespace RNM.Common.Interfaces
{
    interface IGeocodeLocation: ILocation
    {
       decimal Longtude { get; set; }
       decimal Latitude { get; set; }
    }
}
