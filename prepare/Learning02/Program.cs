using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Denso";
        job1._jobTitle = "Account Executive";
        job1._startYear = 2014;
        job1._endYear = 2018;

        //job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Conci";
        job2._jobTitle = "Commercial Manager";
        job2._startYear = 2018;
        job2._endYear = 2024;

        //job2.DisplayJobDetails();


        Resume resume1 = new Resume();
        resume1._name = "Juan Coronel";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayJobDetails();

    }
    

}