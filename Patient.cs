using System;

public class Patient
{
	public Patient()
	{
	}

    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string IDNo { get; set; }
    public int GenderId { get; set; }
    public DateTime BirthDate { get; set; }
    public string Email { get; set; }
    public string ContactNo { get; set; }
    public DateTime AdmitDate { get; set; }
    public int WardNo { get; set; }
    public string Status { get; set; }
}
