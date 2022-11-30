using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CandidateDetailsWebApp.Models
{
    public class CandidateDBContext : DbContext
    {
       public DbSet<Candidate> candidates { get; set; }
    }
}