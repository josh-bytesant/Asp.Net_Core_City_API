using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto
                {
                    Id = 1,
                    Name = "Abuja",
                    Description = "The Capital of Nigeria",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto
                        {
                            Id = 1,
                            Name = "Millenium Park",
                            Description = "An expansive park with a river and fountains"

                        },

                        new PointOfInterestDto
                        {
                            Id = 2,
                            Name = "Zuma Rock",
                            Description = "A unique, famed rock qith a 'face'"

                        }
                    }

                },

                 new CityDto
                {
                    Id = 2,
                    Name = "Asaba",
                    Description = "The Capital of Delta State",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto
                        {
                            Id = 3,
                            Name = "Stephen Keshi Stadium",
                            Description = "A multipurpose stadium in Asaba"

                        },

                        new PointOfInterestDto
                        {
                            Id = 4,
                            Name = "Mungo Park House",
                            Description = "This was built in 1886. It is notable as first headquarters of the Royal Niger Company and Nigeria’s first political headquarters in 1900"

                        }
                    }


                },

                 new CityDto
                {
                    Id = 3,
                    Name = "Awka",
                    Description = "The Capital of Anambra State",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto
                        {
                            Id = 5,
                            Name = "Nnamdi Azikiwe University",
                            Description = "The main campus of the Nnamdi Azikiwe University is located in Awka"
                        },

                        new PointOfInterestDto
                        {
                            Id = 6,
                            Name = "Eke Awka Market",
                            Description = "The largest market in the city, Eke Awka is named after one of the Igbo market days"
                        }

                    }

                },

                  new CityDto
                {
                    Id = 4,
                    Name = "Benin",
                    Description = "The Capital of Edo State",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto
                        {
                            Id = 7,
                            Name = "The Benin Moat",
                            Description = "The Benin moat, also known traditionally as Iya,is the largest man-made earthworks in the world"
                        },

                        new PointOfInterestDto
                        {
                            Id = 8,
                            Name = "Benin City National Museum",
                            Description = "The Benin City National Museum opened to the public on August 10, 1973"
                        }
                    }
                }

                  
            };
            
        }
    }
}
