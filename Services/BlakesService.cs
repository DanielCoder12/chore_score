

namespace chore_score.Services;

public class BlakesService
{

    private readonly BlakesRepository _blakesRepository;
    public BlakesService(BlakesRepository blakesRepository)
    {
        _blakesRepository = blakesRepository;
    }

    internal Blake CreateBlake(Blake blakeData)
    {
        Blake blake = _blakesRepository.CreateBlake(blakeData);
        return blake;
    }

    internal string DestroyBlake(int blakeId)
    {
        Blake blake = GetBlakeById(blakeId);
        string message = _blakesRepository.DestroyBlake(blake);
        return message;
    }

    internal Blake GetBlakeById(int blakeId)
    {
        Blake blake = _blakesRepository.GetBlakeById(blakeId);
        if (blake == null)
        {
            throw new Exception($"invalid Id: {blakeId}");
        }
        else
        {
            return blake;
        }
    }

    internal List<Blake> getBlakes()
    {
        List<Blake> blakes = _blakesRepository.getBlakes();
        return blakes;
    }
}