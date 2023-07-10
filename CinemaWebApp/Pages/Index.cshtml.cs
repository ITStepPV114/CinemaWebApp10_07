using CinemaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Movie> Movies { get; set; }
        public IndexModel()
        {
            Movies = new List<Movie>();
            FullData();
        }

        public void FullData() { 

            Movies.Add(new Movie() { 
                Id=1,
                Title="Titl1",
                Director="Autor1",
                Style="Thirller",
                ShortDescription="Info...",
                Sessions=new List<Session>
                {
                    new Session()
                    {
                        Id=1,
                        DateSession=new DateTime(2023,07,11),
                        TimeSession=new TimeOnly(10,30)
                    },
                     new Session()
                    {
                        Id=2,
                        DateSession=new DateTime(2023,07,11),
                        TimeSession=new TimeOnly(14,30)
                    },
                     new Session()
                    {
                        Id=3,
                        DateSession=new DateTime(2023,07,11),
                        TimeSession=new TimeOnly(17,30)
                    }
                }

            });
            Movies.Add(new Movie()
            {
                Id = 2,
                Title = "Titl2",
                Director = "Autor2",
                Style = "Fantasy",
                ShortDescription = "Info...",
                Sessions = new List<Session>
                {
                    new Session()
                    {
                        Id=4,
                        DateSession=new DateTime(2023,07,11),
                        TimeSession=new TimeOnly(12,15)
                    },
                     new Session()
                    {
                        Id=5,
                        DateSession=new DateTime(2023,07,12),
                        TimeSession=new TimeOnly(14,30)
                    },
                     new Session()
                    {
                        Id=6,
                        DateSession=new DateTime(2023,07,11),
                        TimeSession=new TimeOnly(17,30)
                    }
                }

            });
        }
    
    }
}