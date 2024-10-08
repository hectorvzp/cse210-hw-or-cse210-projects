public class Job
{
   public string _jobTitle = "";
   public double _startYear   ;
   public double _endYear  ;
   public string _company = "";

  public void display()
  {
    Console.WriteLine($"{_jobTitle} {_company} {_endYear}-{_startYear}");

  }
}