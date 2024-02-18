public class Job {

    private string  _company;

    private string _jobTitle;
    
    private int _startYear;

    private int _endYear;
    
    
    public void Display() {

        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");

    }
        
    
}