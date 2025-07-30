

namespace gregslist_dotnet.Services;

public class HousesServices
{

  private readonly HousesRepositry _housesRepository;

  public HousesServices(HousesRepositry housesRepository)
  {
    _housesRepository = housesRepository;
  }

  internal House CreateHouse(House houseData)
  {
    House house = _housesRepository.Create(houseData);
    return house;
  }

  internal List<House> GetHouses()
  {
    List<House> houses = _housesRepository.GetAll();
    return houses;
  }
}