
namespace RNM.Common.Interfaces
{
    public interface IPhysicalLocation : ILocation
    {
        int StreetNumber { get; set; }
        string StreetName { get; set; }
        string Suburb { get; set; }
    }
}
