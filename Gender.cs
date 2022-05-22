using System;
using System.ComponentModel;

public class Gender
{
	public Gender()
	{
	}

    [Key]
    public int GenderId { get; set; }
    public string GenderName { get; set; }
}
