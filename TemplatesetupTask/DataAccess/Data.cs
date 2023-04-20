using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TemplatesetupTask.Models;

namespace TemplatesetupTask.DataAccess
{
    public static class Data
    {
        public static List<Feature> Features = new List<Feature>()
        {
             new Feature { Id = 1, Header = "Lorem Ipsum", Icon = "bi bi-card-checklist", Description = "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident" }
             , new Feature { Id = 2,Header="Dolor Sitema",Icon="bi bi-bar-chart", Description="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"},
             new Feature { Id = 3,Header="Sed ut perspiciatis",Icon="bi bi-binoculars", Description="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"}
        };

        public static List<Service> Services = new List<Service>()
        {
            new Service { Id = 1, Header="Lorem Ipsum",Icon="bx bxl-dribbble",Description="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi"},
            new Service { Id = 2, Header="Sed ut perspiciatis",Icon="bx bx-file",Description="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore"},
            new Service { Id = 3, Header="Magni Dolores",Icon="bx bx-tachometer",Description="Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia"},
            new Service { Id = 4, Header="Nemo Enim",Icon="bx bx-world",Description="At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis"},
            new Service { Id = 5, Header="Dele cardo",Icon="bx bx-slideshow",Description="Quis consequatur saepe eligendi voluptatem consequatur dolor consequuntur"},
            new Service { Id = 6, Header="Divera don",Icon="bx bx-arch",Description="Modi nostrum vel laborum. Porro fugit error sit minus sapiente sit aspernatur"}
        };

        
    }
}
