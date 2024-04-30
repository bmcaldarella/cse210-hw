using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.DisplayJobDetails("Software Engineer", "Microsoft", 2017, 2022);

        Job job2 = new Job();
        job2.DisplayJobDetails("Manager", "Apple", 2022, 2023);

        Resume resume1 = new Resume();

        resume1._name = "Brandon Caldarella";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}