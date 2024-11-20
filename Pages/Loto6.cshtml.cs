using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Lottery.Pages
{
    public class Loto6Model : PageModel
    {
        private readonly ILogger<Loto6Model> _logger;

        // Javni property za čuvanje nasumičnih brojeva
        public List<int> RandomNumbers { get; set; }

        public Loto6Model(ILogger<Loto6Model> logger)
        {
            _logger = logger;
            RandomNumbers = new List<int>(); // Inicializacija liste
        }

        public void OnGet()
        {
            GenerateRandomNumbers();
        }

        // Metoda za generisanje 6 nasumičnih brojeva
        private void GenerateRandomNumbers()
        {
            Random random = new Random();
            HashSet<int> numbers = new HashSet<int>(); // Koristi HashSet da izbegne duplikate

            while (numbers.Count < 6)
            {
                numbers.Add(random.Next(1, 46)); // Generiše nasumičan broj između 1 i 45
            }

            RandomNumbers = new List<int>(numbers); // Prebacuje brojeve iz HashSet u Listu
        }
    }
}
