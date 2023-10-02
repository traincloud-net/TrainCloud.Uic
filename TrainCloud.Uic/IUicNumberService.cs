namespace TrainCloud.Uic;

public interface IUicNumberService
{
    public string GetCarTypeCode(string fullUIC);

    public string GetCountryCode(string fullUIC);

    public string GetCarClassCode(string fullUIC);

    public string GetCarClassSerialNr(string fullUIC);

    public string GetChecksum(string fullUIC);

    bool ValidateUic(string fullUic);
}
