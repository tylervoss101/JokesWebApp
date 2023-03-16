using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace JokesWebApp.Models
{
    public class Joke
    {
        public int id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        public Joke()
        {
        }
    }
}