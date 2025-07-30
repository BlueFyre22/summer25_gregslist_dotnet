using gregslist_dotnet.Interfaces;

namespace gregslist_dotnet.Repositories;

public class HousesRepositry : IRepository<House>
{

  private readonly IDbConnection _db;

  public HousesRepositry(IDbConnection db)
  {
    _db = db;
  }

  public House Create(House data)
  {
    throw new NotImplementedException();
  }

  public List<House> GetAll()
  {
    string sql = @"
    SELECT * 
    FROM houses;
   ";
    List<House> houses = _db.Query<House>(sql).ToList();
    return houses;
  }

  public void Delete(int id)
  {
    throw new NotImplementedException();
  }

  public House GetById(int id)
  {
    throw new NotImplementedException();
  }

  public void Update(House updateData)
  {
    throw new NotImplementedException();
  }
}