namespace Week7Day2.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ClassmatesDB : DbContext
    {
        // Your context has been configured to use a 'ClassmatesDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Week7Day2.Models.ClassmatesDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ClassmatesDB' 
        // connection string in the application configuration file.
        public ClassmatesDB()
            : base("name=ClassmatesDB1")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Classmate> Classmates { get; set; }
    }

    public class Classmate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string School { get; set; }
        public DateTime Graduation { get; set; }
        public string Awards { get; set; }
        public string Photo { get; set; }
    }
}