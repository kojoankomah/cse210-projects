public class Resumes{
    public string _name;
    public List<Job> jobs = new List<Job>();

    public Resumes()
    {

    }

    public void DisplayResume(){
        Console.WriteLine($"Name : {_name} ");
        Console.WriteLine("Jobs :");

        foreach(Job job in jobs)
        {
            job.DisplayJobDetails();
        }
        }
}