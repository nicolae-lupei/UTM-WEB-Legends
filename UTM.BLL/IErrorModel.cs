namespace UTM.BLL
{
    public interface IErrorModel
    {
        string Key { get; set; }
        string Message { get; set; }
        string ToString();
    }
}