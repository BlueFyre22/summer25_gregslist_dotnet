namespace gregslist_dotnet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HousesController : ControllerBase
{

  private readonly HousesServices _housesService;
  private readonly Auth0Provider _auth0Provider;
  public HousesController(HousesServices housesService, Auth0Provider auth0Provider)
  {
    _housesService = housesService;
    _auth0Provider = auth0Provider;
  }


  [HttpPost, Authorize]
  public async Task<ActionResult<House>> CreateHouse([FromBody] House houseData)
  {
    try
    {
      Account userInfo = await _auth0Provider.GetUserInfoAsync<Account>(HttpContext);
      houseData.CreatorId = userInfo.Id;
      House house = _housesService.CreateHouse(houseData);
      return Ok(house);
    }
    catch (Exception exception)
    {
      return BadRequest(exception.Message);
    }
  }



  [HttpGet]
  public ActionResult<List<House>> GetAllHouses()
  {
    try
    {
      List<House> houses = _housesService.GetHouses();
      return Ok(houses);
    }
    catch (Exception exception)
    {
      return BadRequest(exception.Message);
    }
  }



}