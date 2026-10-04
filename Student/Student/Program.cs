class Student
{
    public string MSSV { get; set; }
    public string HoTen { get; set; }
    public string Lop { get; set; }

    public void Display()
    {
        System.Console.WriteLine(
            $"{MSSV} - {HoTen} - {Lop}"
        );
    }
}