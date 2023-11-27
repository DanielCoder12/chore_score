using Microsoft.IdentityModel.Tokens;

namespace chore_score.Repositories;

public class BlakesRepository
{

    private List<Blake> _blakes;
    public BlakesRepository()
    {
        _blakes = [
            new Blake(1,"Blake", true, true, 2, "Original"),
            new Blake(2, "Rhys", false, false, 2, "Maybe Blake?"),
            new Blake(3, "Matt", false, false, 2, "Definitely Not Blake")
        ];
    }

    internal Blake CreateBlake(Blake blakeData)
    {
        blakeData.Id = _blakes.Count + 1;
        _blakes.Add(blakeData);
        return _blakes[_blakes.Count - 1];
    }

    internal string DestroyBlake(Blake blake)
    {
        _blakes.Remove(blake);
        return "blake destroyed";
    }

    internal Blake GetBlakeById(int blakeId)
    {
        Blake blake = _blakes.Find(b => b.Id == blakeId);
        return blake;
    }

    internal List<Blake> getBlakes()
    {
        return _blakes;
    }
}