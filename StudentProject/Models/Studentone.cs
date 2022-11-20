using System.ComponentModel.DataAnnotations;
public class Studentone
{
    [Key]
    public int Sid {get; set;}
    public string Sname {get; set;}
    public int age {get; set;}
}