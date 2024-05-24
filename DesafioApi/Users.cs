using System.ComponentModel.DataAnnotations;

public class Users
{
    [Key]
    public string email { get; set; }
    public string gender { get; set; }
    public string title { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public int streetnumber { get; set; }
    public string streetname { get; set; }
    public string city { get; set; }
    public string statelocation { get; set; }
    public string country { get; set; }
    public string postcode { get; set; }
    public string latitude { get; set; }
    public string longitude { get; set; }
    public string timezoneoffset { get; set; }
    public string timezonedescription { get; set; }
    public string uuidlogin { get; set; }
    public string username { get; set; }
    public string passwordlogin { get; set; }
    public string salt { get; set; }
    public string md5 { get; set; }
    public string sha1 { get; set; }
    public string sha256 { get; set; }
    public string dateofbirth { get; set; }
    public int age { get; set; }
    public string dateregistered { get; set; }
    public int ageregistered { get; set; }
    public string phone { get; set; }
    public string cell { get; set; }
    public string nameid { get; set; }
    public string valueid { get; set; }
    public string picturelarge { get; set; }
    public string picturemedium { get; set; }
    public string thumbnail { get; set; }
    public string nat { get; set; }
}
