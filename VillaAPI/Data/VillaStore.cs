using VillaAPI.Dto;

namespace VillaAPI.Data
{
    public static class VillaStore
    {
       public static List<VillaDto> villaList= new List<VillaDto>()
            {
                new VillaDto{Id=1,Name="Pool View",Occupancy=4,Sqft=100},
                new VillaDto{Id=2,Name="Beach View",Occupancy=3,Sqft=300}
            };
    }
}
